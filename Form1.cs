using LibVLCSharp.Shared;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibVLCSharp.WinForms.Sample
{
    public partial class Form1 : Form
    {
        public LibVLC _libVLC;
        public MediaPlayer _mp;
        public Media media;
        public string _fileName;
        public List<ModelMediaPlay> listMedia;
        public long _setTime;
        public DateTime timePlayer;
        public AudioService audioService;
        public ToolTip toolTip;
        private readonly AudioManager _audioManager;
        private readonly List<PlayMedia> _lsPlays;
        private float rate;

        public Form1()
        {
            if (!DesignMode)
            {
                Core.Initialize();
            }

            InitializeComponent();
            _libVLC = new LibVLC();
            _mp = new MediaPlayer(_libVLC);
            _setTime = 5000;
            _mp.TimeChanged += Time_Changed;
            _mp.LengthChanged += OnLengthChanged;
            _mp.Stopped += OnStoped;
            _mp.Forward += OnForward;
            _mp.Backward += OnBackward;
            _mp.PositionChanged += OnPositionChanged;
            _mp.Paused += PausableChanged;
            videoView1.MediaPlayer = _mp;
            cbSpeed.SelectedItem = "5";
            cbRate.SelectedIndex = 0;
            rate = (float)cbRate.SelectedIndex + 1;
            audioService = new AudioService();
            _audioManager = new AudioManager();
            _lsPlays = new List<PlayMedia>();
        }

        private void PausableChanged(object sender, EventArgs e)
        {
            if (_mp.CanPause)
            {
                foreach (var i in _lsPlays)
                {
                    i.Player.Pause();
                }
            }
        }

        private void OnPositionChanged(object sender, MediaPlayerPositionChangedEventArgs e)
        {
            trBar.InvokeIfRequired(l => l.Value = (int)_mp.Time / 1000);

        }

        private void OnBackward(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void OnForward(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void OnStoped(object sender, EventArgs e)
        {
            btn_play.InvokeIfRequired(l => l.Text = "Play");
            //var stopList = listMedia.FindAll(x => x.mediaPlayer.IsPlaying).ToList();
            //Parallel.ForEach(_lsPlays, (item) =>
            // {
            //     item.Player.Stop();
            // });
            trBar.InvokeIfRequired(l => l.Value = 0);
            trBar.InvokeIfRequired(l => l.Enabled = false);
        }

        private void OnLengthChanged(object sender, MediaPlayerLengthChangedEventArgs e)
        {
          
            trBar.InvokeIfRequired(l => l.Maximum = (int)e.Length / 1000);
            trBar.InvokeIfRequired(l => l.Enabled = true);
            btn_play.InvokeIfRequired(l => l.Text = "Pause");
        }

        private void Time_Changed(object sender, MediaPlayerTimeChangedEventArgs e)
        {
            var currentime = timePlayer.Add(TimeSpan.FromMilliseconds(e.Time)).ToString(@"hh\:mm\:ss");
          
            lbl_time.InvokeIfRequired(l => l.Text = currentime);

            //Parallel.ForEach(_lsPlays, (item) =>
            //{
            //    if (e.Time - item.Player.Time > 2000 || e.Time - item.Player.Time > -2000)
            //    {
                  
            //        item.Player.Time = e.Time;
            //        item.Player.Play();
                    
            //    }
            //});

            //foreach (var item in _lsPlays)
            //{
            //    Debug.WriteLine(item.Player.Length + "Test");
            //    Debug.WriteLine(item.Player.Media.ParsedStatus + "Test");
            //    if (e.Time - item.Player.Time > 2000)
            //    {
            //        item.Player.Play();
            //        item.Player.Time = e.Time;
            //        Debug.WriteLine(item.Player.Time);
            //    }
            //}

            //PlayAsync(listMedia, currentime);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //await media.Parse(MediaParseOptions.ParseNetwork);
            //var _media = new Media(_libVLC, new Uri("http://commondatastorage.googleapis.com/gtv-videos-bucket/sample/BigBuckBunny.mp4"));
            //_media.AddOption(":no-audio");
            //mp =new MediaPlayer(_libVLC) { Media = new Media(_libVLC, @"D:\Desktop\Downloads\Video\test.mp3", FromType.FromPath) };
            //_mp.Play(_media);
            toolTip = new ToolTip();
            // Set up the delays for the ToolTip.
            toolTip.AutoPopDelay = 5000;
            toolTip.InitialDelay = 1000;
            toolTip.ReshowDelay = 500;
            // Force the ToolTip text to be displayed whether or not the form is active.
            toolTip.ShowAlways = true;

            btn_OpAudio.InvokeIfRequired(l => l.Enabled = _mp.Media is null ? false : true);
        }

        private long GetStartTime(string fileName, DateTime timePlayer)
        {
            var fileLength = fileName.Length;
            if (fileLength != 25)
            {
                return timePlayer.Ticks;
            }
            var timeStart = fileName.Substring(fileLength - 19);
            DateTime getTime;

            bool sucess = DateTime.TryParseExact(timeStart, "yyyy.MM.dd HH.mm.ss", null, DateTimeStyles.None, out getTime);
            if (!sucess)
            {
                return timePlayer.Ticks;
            }
            TimeSpan timeSpan = getTime - timePlayer;
            return (long)timeSpan.TotalMilliseconds;
        }

        private void PlayMedia(List<PlayMedia> plays)
        {
            Parallel.ForEach(plays, (item) =>
            {
                item.Player.SetRate(rate);

                item.Player.Mute = !item.Status;

                item.Player.Play();
                item.Player.Pause();
                Task.Delay(100).Wait();
            });
        }

        private void btn_play_Click(object sender, EventArgs e)
        {
            if (_mp.Media is null) return;
            if (_mp.IsPlaying)
            {
                _mp.Pause();
                btn_play.InvokeIfRequired(l => l.Text = "Play");
                foreach (var i in _lsPlays)
                {
                    i.Player.Pause();
                }
                return;
            }
            if (_mp.CanPause)
            {
                _mp.Play();

                return;
            }

            //for(int i=0;i< cklistbox.CheckedItems.Count; i++)
            //{
            //    string outpath = Path.Combine(Environment.CurrentDirectory, "Audio");
            //    outpath = Path.Combine(outpath, $"{cklistbox.CheckedItems[i]}.mp3");
            //    Debug.WriteLine(outpath);
            //    media.AddSlave(MediaSlaveType.Audio,(uint)i , $"file:///" + outpath);
            //}
            string outpath = Path.Combine(Environment.CurrentDirectory, "video_audio.mp3");
            _mp.AddSlave(MediaSlaveType.Audio, $"file:///" + outpath, false);
            Task.Run(() =>
            {
                //PlayMedia(_lsPlays);
               
                _mp.SetRate(rate);
                Task.Delay(2000).Wait();
                _mp.Play();
            });
        }

        private void btn_bkn_Click(object sender, EventArgs e)
        {
            if (!_mp.IsPlaying) return;
            // btn_bkn.InvokeIfRequired(l => l.Enabled = false);
            _mp.Pause();
            _mp.Time -= _setTime;
            //foreach (var i in _lsPlays)
            //{
            //    i.Player.Stop();
            //}
            Task.Delay(200).Wait();
            _mp.Play();
            //  btn_bkn.InvokeIfRequired(l => l.Enabled = true);
        }

        private void btn_frn_Click(object sender, EventArgs e)
        {
            if (!_mp.IsPlaying) return;
            // btn_frn.InvokeIfRequired(l => l.Enabled = false);
            _mp.Pause();
            _mp.Time += _setTime;
            foreach (var i in _lsPlays)
            {
                i.Player.Stop();
            }
            Task.Delay(200).Wait();
            _mp.Play();
            // btn_frn.InvokeIfRequired(l => l.Enabled = true);
        }

        private void btn_open_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFile = new OpenFileDialog
            {
                InitialDirectory = @"C:/",
                Title = "Browers File",
                CheckFileExists = true,
                CheckPathExists = true,
                DefaultExt = "mkv",
                Filter = "Choose Video File (*.mkv,*.asf)|*.mkv;*.asf",
                FilterIndex = 2,
                RestoreDirectory = true,

                ReadOnlyChecked = true,
                ShowReadOnly = true
            };
            if (openFile.ShowDialog() == DialogResult.OK)
            {
                _fileName = openFile.FileName;
                media = new Media(_libVLC, _fileName, FromType.FromPath);
                //media.AddOption(":no -audio");
                _mp.Media = media;
                string filePathAudio = Path.Combine(Environment.CurrentDirectory, "video_audio.mp3");
                if (File.Exists(filePathAudio))
                {
                    File.Delete(filePathAudio);
                }
                string namePlayer = Path.GetFileNameWithoutExtension(openFile.FileName);
                int lengthName = namePlayer.Length;
                int indexName = namePlayer.LastIndexOf(" ");
                lengthName = lengthName - indexName - 5;
                lengthName = lengthName > 0 ? lengthName : 0;
                namePlayer = namePlayer.Substring(indexName + 1, lengthName);
                string formatString = "yyyy-MM-dd_HH_mm_ss";
                DateTime dateTime;
                if (DateTime.TryParseExact(namePlayer, formatString, null,
                    System.Globalization.DateTimeStyles.None, out dateTime))
                {
                    timePlayer = dateTime;
                }
                else
                {
                    timePlayer = dateTime = DateTime.Now;
                    if (InputBox.Show("Yêu cầu nhập thời gian", "Thời gian:", ref dateTime) == DialogResult.OK)
                    {
                        timePlayer = dateTime;
                    }
                }

                lbl_Name.InvokeIfRequired(l => l.Text = $"Tên: {namePlayer}");
                lbl_Start.InvokeIfRequired(l => l.Text = $"Bắt đầu: {timePlayer.ToString("dd-MM-yyyy HH:mm:ss")}");
                Task.WaitAll(_mp.Media.Parse());
                var lengthFile = _mp.Media.Duration;
                var endPlayer = timePlayer.AddMilliseconds((double)lengthFile);
                lbl_End.InvokeIfRequired(l => l.Text = $"Kết thúc: {endPlayer.ToString("dd-MM-yyyy HH:mm:ss")}");
                lbl_length.InvokeIfRequired(l => l.Text = endPlayer.ToString(@"hh\:mm\:ss"));
                btn_OpAudio.InvokeIfRequired(l => l.Enabled = true);
            }
        }

        private async void btn_OpAudio_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFile = new OpenFileDialog
            {
                InitialDirectory = @"C:/",
                Title = "Browers MP3 File",
                CheckFileExists = true,
                CheckPathExists = true,
                DefaultExt = "mp3",
                Filter = "mp3 file (*.mp3)|*.mp3",
                FilterIndex = 2,
                RestoreDirectory = true,
                Multiselect = true,
                ReadOnlyChecked = true,
                ShowReadOnly = true
            };

            if (openFile.ShowDialog() == DialogResult.OK)
            {
                //listMedia = new List<ModelMediaPlay>();
                //listMedia = openFile.FileNames.Select(x => new ModelMediaPlay
                //{
                //    mediaPlayer = new MediaPlayer(_libVLC) { Media = new Media(_libVLC, x, FromType.FromPath) },
                //    startTime = GetStartTime(Path.GetFileNameWithoutExtension(x), timePlayer)
                //}).ToList();
                List<ModelAudio> listAudio = openFile.FileNames.Select(x => new ModelAudio
                {
                    PathFile = x,
                    StartTime = GetStartTime(Path.GetFileNameWithoutExtension(x), timePlayer)
                }).ToList();
                await  audioService.SetFileAudio(listAudio);
                _audioManager.DeleteTemporaryFolder("Audio");
                List<string> listError = new List<string>();
                List<string> cbListbox = new List<string>();
                foreach (var item in listAudio)
                {
                    string filePath = Path.GetFileNameWithoutExtension(item.PathFile);
                    if (item.StartTime != timePlayer.Ticks)
                    {
                      //  await audioService.ExecuteAsyncAudio(item);
                        cbListbox.Add(filePath);
                    }
                    else
                    {
                        listError.Add(Path.GetFileName(item.PathFile));
                    }
                }

                cklistbox.BeginUpdate();
                cklistbox.Items.Clear();
                cklistbox.Items.AddRange(cbListbox.ToArray());
                cklistbox.EndUpdate();
                //for (int i = 0; i < cklistbox.Items.Count; i++)
                //{
                //    cklistbox.SetItemChecked(i, true);
                //    var playMedia = new PlayMedia();

                //    string outpath = Path.Combine(Environment.CurrentDirectory, "Audio");
                //    outpath = Path.Combine(outpath, $"{cklistbox.Items[i]}.mp3");
                //    var _media = new Media(_libVLC, outpath, FromType.FromPath);

                //    playMedia.Status = cklistbox.GetItemChecked(i);
                //    playMedia.Player = new MediaPlayer(_libVLC) { Media = new Media(_libVLC, outpath, FromType.FromPath) };
                //    Task.WaitAll(playMedia.Player.Media.Parse());
                //    _lsPlays.Add(playMedia);
                //}
                if (listError.Count() > 0)
                {
                    MessageBox.Show(string.Join("\n", listError), "Danh sách lỗi", MessageBoxButtons.OK);
                }
            }
        }

        private void btn_Stop_Click(object sender, EventArgs e)
        {
            if (_mp.IsPlaying)
            {
                _mp.Stop();
            }
            //foreach (var i in _lsPlays)
            //{
            //    i.Player.Stop();
            //}
        }

        private void trBar_Scroll(object sender, EventArgs e)
        {
            toolTip.SetToolTip(trBar, timePlayer.AddSeconds((double)trBar.Value).ToString(@"hh\:mm\:ss"));
            var setTime = (long)(trBar.Value * 1000);
            _mp.Pause();
            //foreach (var i in _lsPlays)
            //{
            //    i.Player.Stop();
            //    i.Player.Time = setTime;
            //}
            _mp.Time = setTime;

            _mp.Play();
        }

        #region code cu

        private void PlayAsync(List<ModelMediaPlay> medias, long currentTime)
        {
            foreach (var i in medias)
            {
                var compareTime = i.startTime - currentTime;
                // System.Diagnostics.Debug.WriteLine("compareTime" + compareTime);
                if (compareTime > 800 & compareTime < 1200 & !i.mediaPlayer.IsPlaying)
                {
                    // System.Diagnostics.Debug.WriteLine("Time:" + currentTime + " starTime " + i.startTime);

                    i.mediaPlayer.Stop();
                    i.mediaPlayer.Play();
                }
            }
        }

        private void SetTimePlay(List<ModelMediaPlay> medias, long getTime)
        {
            foreach (var i in medias)
            {
                var setTime = getTime - i.startTime;
                System.Diagnostics.Debug.WriteLine($"Set Time: {setTime} and Lenght {i.mediaPlayer.Length}");
                if (i.mediaPlayer.IsPlaying & (setTime < 0 || setTime > i.mediaPlayer.Length))
                {
                    System.Diagnostics.Debug.WriteLine("Stop Time:" + setTime);
                    i.mediaPlayer.Stop();
                }
                if (setTime > 0 & (i.mediaPlayer.Length == -1 || setTime < i.mediaPlayer.Length))
                {
                    if (!i.mediaPlayer.IsPlaying)
                    {
                        if (i.mediaPlayer.Time > 0) i.mediaPlayer.Stop();
                        System.Diagnostics.Debug.WriteLine("Start Time:" + i.mediaPlayer.Time);
                        i.mediaPlayer.Play();
                    }
                    i.mediaPlayer.Time = setTime;
                }
            };
        }

        #endregion code cu

        private void cklistbox_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            //for (int i = 0; i < _lsPlays.Count(); i++)
            //{
            //    if (e.Index == i)
            //    {
            //        Debug.WriteLine(e.NewValue.Equals(CheckState.Checked));
            //        _lsPlays[i].Player.Mute = !e.NewValue.Equals(CheckState.Checked);
            //        return;
            //    }
            //}
        }

        private void cbRate_SelectedIndexChanged(object sender, EventArgs e)
        {
            rate = (float)cbRate.SelectedIndex + 1;
            if (_mp.IsPlaying)
            {
                Task.Run(() =>
                {
                    _mp.Pause();
                    _mp.SetRate(rate);
                    //Parallel.ForEach(_lsPlays, (item) =>
                    //{
                    //    item.Player.SetRate(rate);
                    //});
                    Task.Delay(1000).Wait();
                    _mp.Play();
                });
            }
        }

        private void Hook(MediaPlayer media)
        {
            media.LengthChanged += Media_LengthChanged;
        }

        private void Media_LengthChanged(object sender, MediaPlayerLengthChangedEventArgs e)
        {
            throw new NotImplementedException();
        }
    }
}