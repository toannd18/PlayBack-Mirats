using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibVLCSharp.WinForms.Sample
{
   public static class ControlExtensions
    {
        public static T InvokeIfRequired<T>(this T source, Action<T> action)
           where T : Control
        {
            try
            {
                if (!source.InvokeRequired)
                    action(source);
                else
                    source.Invoke(new Action(() => action(source)));
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.Write("Error on 'InvokeIfRequired': {0}", ex.Message);
            }
            return source;
        }
    }
}
