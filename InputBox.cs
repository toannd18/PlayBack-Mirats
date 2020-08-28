using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibVLCSharp.WinForms.Sample
{
    class InputBox
    {
        public static DialogResult Show(string title, string promptText, ref DateTime value)
        {
            Form form = new Form();
            Label label = new Label();
            DateTimePicker dateTimePiker = new DateTimePicker();
            Button buttonOk = new Button();
            Button buttonCancel = new Button();
            dateTimePiker.Format = DateTimePickerFormat.Custom;
            dateTimePiker.CustomFormat = "dd-MM-yyyy HH:mm:ss";
            dateTimePiker.ShowUpDown = true;
            form.Text = title;
            label.Text = promptText;
            dateTimePiker.Value = value;
            buttonOk.Text = "OK";
            buttonCancel.Text = "Cancel";
            buttonOk.DialogResult = DialogResult.OK;
            buttonCancel.DialogResult = DialogResult.Cancel;
            label.SetBounds(9, 20, 372, 13);
            dateTimePiker.SetBounds(12, 36, 372, 20);
            buttonOk.SetBounds(228, 72, 75, 23);
            buttonCancel.SetBounds(309, 72, 75, 23);
            label.AutoSize = true;
            dateTimePiker.Anchor = dateTimePiker.Anchor | AnchorStyles.Right;
            buttonOk.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            buttonCancel.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            form.ClientSize = new Size(396, 107);
            form.Controls.AddRange(new Control[] { label, dateTimePiker, buttonOk, buttonCancel });
            form.ClientSize = new Size(Math.Max(300, label.Right + 10), form.ClientSize.Height);
            form.FormBorderStyle = FormBorderStyle.FixedDialog;
            form.StartPosition = FormStartPosition.CenterScreen;
            form.MinimizeBox = false;
            form.MaximizeBox = false;
            form.AcceptButton = buttonOk;
            form.CancelButton = buttonCancel;
            DialogResult dialogResult = form.ShowDialog();
            value = dateTimePiker.Value;
            return dialogResult;

        }
       
    }
}
