using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Threading.Tasks;
using Xabe.FFmpeg;

namespace LibVLCSharp.WinForms.Sample
{
    public class AudioService
    {
        private readonly AudioManager _audioManager;

        public AudioService()
        {
            _audioManager = new AudioManager();
            
        }

        public Task<IConversionResult> SetFileAudio(List<ModelAudio> listAudio)
        {
            try
            {
                string arguments = "-y ";
                string arguments_1 = "-filter_complex \"";
                string arguments_2 = null;
                var lengthList = listAudio.Count;
                string outputPath = Path.Combine(Environment.CurrentDirectory, "video_audio.mp3");
                for (var i = 0; i < lengthList; i++)
                {
                    arguments = $"{arguments}-i \"{listAudio[i].PathFile}\" ";
                    if (listAudio[i].StartTime < 0)
                    {
                        var timeStart = -listAudio[i].StartTime;
                        arguments_1 = $"{arguments_1}[{i}]atrim=start={timeStart}[a{i}];";
                        arguments_2 = $"{arguments_2}[a{i}]";
                        continue;
                    }
                    arguments_1 = $"{arguments_1}[{i}]adelay={listAudio[i].StartTime}|{listAudio[i].StartTime}[a{i}];";
                    arguments_2 = $"{arguments_2}[a{i}]";
                }
                arguments = $"{arguments}{arguments_1}{arguments_2}amix=inputs={lengthList}[a]\" -map [a] \"{outputPath}\"";
                var conversionResult = FFmpeg.Conversions.New().Start(arguments);
                return conversionResult;
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }

            //System.Diagnostics.Debug.WriteLine(arguments);
        }

        public async Task ExecuteAsyncAudio(ModelAudio model)
        {
            try
            {
                await Task.Run(() =>
                {
                    string inputPath = model.PathFile;
                    string outputConvertedPath = _audioManager.TemporarySaveFolder("Audio");
                    outputConvertedPath = Path.Combine(outputConvertedPath, Path.GetFileName(inputPath));
                    string arguments;
                    if (model.StartTime < 0)
                    {
                        arguments = $"-y -i \"{inputPath}\" -filter_complex \"atrim=start={model.StartTime} [a0]\" -map [a0] \"{outputConvertedPath}\"";
                    }
                    else
                    {
                        arguments = $"-y -i \"{inputPath}\" -filter_complex \"adelay={model.StartTime}|{model.StartTime} [a0]\" -map [a0] \"{outputConvertedPath}\"";
                    }
                    Debug.WriteLine(arguments);
                    var startInfo = new ProcessStartInfo
                    {
                        FileName = _audioManager.FFMPEGPath,
                        Arguments = arguments,
                        CreateNoWindow = true,
                        UseShellExecute = false,
                    };

                    using (var process = new Process { StartInfo = startInfo })
                    {
                        process.Start();
                        process.WaitForExit();
                    }
                });
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }


    }
}