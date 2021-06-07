using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
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
                listAudio = listAudio.Where(m => m.Status).ToList();
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
                Console.WriteLine(arguments);
                var conversionResult = FFmpeg.Conversions.New().Start(arguments);
                return conversionResult;
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }

            //System.Diagnostics.Debug.WriteLine(arguments);
        }

        public async Task<string> ExecuteAsyncAudio(List<ModelAudio> listAudio)
        {
            _audioManager.TemporarySaveFolder("Audio");
            string outputPath = Path.Combine(Environment.CurrentDirectory, "Audio", $"{DateTime.Now.Ticks}.mp3");
            try
            {
                await Task.Run(() =>
                {
                    string arguments = "-y ";
                    string arguments_1 = "-filter_complex \"";
                    string arguments_2 = null;
                    listAudio = listAudio.Where(m => m.Status).ToList();
                    int lengthList = listAudio.Count;

                    for (int i = 0; i < lengthList; i++)
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
            return outputPath;
        }
    }
}