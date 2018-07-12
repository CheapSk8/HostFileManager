using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HostManager
{
    public partial class InputDialog : Form
    {
        public string Comment { get; set; }
        public string IP { get; set; }
        public string Url { get; set; }
        public string Message { get; set; }
        public InputDialog()
        {
            InitializeComponent();
        }

        private void InputDialog_Load(object sender, EventArgs e)
        {
            lblInputInstructions.Text = Message ?? "Enter the IP and URL for the new host map";  // default message
            ipAddress.Text = IP;
            txtUrl.Text = Url;
            txtComments.Text = Comment;
        }
        
        public DialogResult ShowDialog(string message)
        {
            this.Message = message;
            return base.ShowDialog();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            IP = ipAddress.Text;
            Url = txtUrl.Text.Trim();
            Comment = txtComments.Text.Trim();
        }
    }
}
