using System;
using System.IO;

namespace LibVLCSharp.WinForms.Sample
{
    public class AudioManager
    {
        public string FFMPEGPath => Path.Combine(Environment.CurrentDirectory, "ffmpeg", "ffmpeg.exe");

        public void DeleteTemporaryFolder(string folder)
        {
            var path = Path.Combine(Environment.CurrentDirectory, folder);
            if (Directory.Exists(path))
            {
                Directory.Delete(path,true);
            }
        }

        public string TemporarySaveFolder(string folder)
        {
            var path= Path.Combine(Environment.CurrentDirectory, folder);
            if (!Directory.Exists(path))
            {
                Directory.CreateDirectory(path);
            }
            return path;
        }
    }
}