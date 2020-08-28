using LibVLCSharp.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibVLCSharp.WinForms.Sample
{
   public class PlayMedia
    {
        public PlayMedia()
        {
           
            Status = false;
        }
        public MediaPlayer Player { get; set; }
        public bool Status { get; set; }
    }
}
