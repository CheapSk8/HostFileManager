using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace HostManager
{
    public partial class MessageBoxForm : Form
    {
        public delegate void RememberChoiceHandler(object sender, RememberChoiceEventArgs e);
        public event RememberChoiceHandler RememberChoiceEvent;

        public string Title { get; set; }
        public string Message { get; set; }
        public MessageBoxButtons Buttons { get; set; }
        public bool EnableRemember { get; set; }
        //public bool RememberChoice { get; private set; }

        public MessageBoxForm()
        {
            InitializeComponent();
            Title = "";
            Message = "";
            Buttons = MessageBoxButtons.OK;
            EnableRemember = true;
        }

        private void MessageBoxForm_Load(object sender, EventArgs e)
        {
            this.Text = Title;
            lblMessage.Text = Message;
            pnlRemember.Visible = EnableRemember;
            setButtons();
        }
        // lblMessage.MaximumSize = new Size(this.ClientSize.Width - 10, lblMessage.MaximumSize.Height);
        private void MessageBoxForm_Resize(object sender, EventArgs e)
        {
            lblMessage.MaximumSize = new Size(this.ClientSize.Width - 5, lblMessage.MaximumSize.Height);
        }

        //private void chkRemember_CheckedChanged(object sender, EventArgs e)
        //{
        //    RememberChoice = chkRemember.Checked;
        //}

        private void setButtons()
        {
            Utilities.GetAllControls<FlowLayoutPanel>(flowLayoutPanel1).ForEach(flp => flp.Visible = false);
            switch (Buttons)
            {
                case MessageBoxButtons.YesNoCancel:
                case MessageBoxButtons.YesNo:
                    flpYesNoCancel.Visible = true;
                    if (Buttons == MessageBoxButtons.YesNo) { btnYNCCancel.Visible = false; }
                    break;
                case MessageBoxButtons.AbortRetryIgnore:
                    flpAbortRetryIgnore.Visible = true;
                    break;
                case MessageBoxButtons.RetryCancel:
                    flpRetryCancel.Visible = true;
                    break;
                case MessageBoxButtons.OKCancel:
                case MessageBoxButtons.OK:
                default:
                    flpOkayCancel.Visible = true;
                    if (Buttons == MessageBoxButtons.OK) { btnOCCancel.Visible = false; }
                    break;
            }
        }

        private void MessageBoxForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            RememberChoiceEventArgs args = new RememberChoiceEventArgs(chkRemember.Checked, this.DialogResult);
            if (RememberChoiceEvent != null)
            {
                RememberChoiceEvent(this, args);
            }
        }

        #region Show functions and overrides
        // the show() function should only allow form loaded as dialog
        public new DialogResult Show()
        {
            return this.ShowDialog();
        }
        public DialogResult Show(string message, string title = "")
        {
            return this.ShowDialog(message, title);
        }
        public DialogResult Show(string message, string title, MessageBoxButtons buttons, bool enableRemember = false)
        {
            return this.ShowDialog(message, title, buttons, enableRemember);
        }
        public DialogResult ShowDialog(string message, string title = "")
        {
            Message = message;
            Title = title;
            return base.ShowDialog();
        }
        public DialogResult ShowDialog(string message, string title, MessageBoxButtons buttons, bool enableRemember = false)
        {
            Message = message;
            Title = title;
            Buttons = buttons;
            EnableRemember = enableRemember;
            return base.ShowDialog();
        }
        #endregion
    }
    public class RememberChoiceEventArgs : System.EventArgs
    {
        public bool IsChoiceRemembered { get; set; }
        public DialogResult FormResult { get; set; }
        public RememberChoiceEventArgs(bool rememberChoice, DialogResult formResult)
        {
            IsChoiceRemembered = rememberChoice;
            FormResult = formResult;
        }
    }
}
