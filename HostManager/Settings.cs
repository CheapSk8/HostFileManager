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
    [Serializable]
    public enum EditMode
    {
        List,
        Text
    }
    public partial class Settings : Form
    {
        private Properties.Settings _settings = Properties.Settings.Default;
        public Settings()
        {
            InitializeComponent();
            setDropDown();  // set dropdown from enum
        }
        #region Helper methods
        // set values in drop down list
        private void setDropDown()
        {
            ddlEditMode.Items.Clear();
            foreach (var item in Enum.GetNames(typeof(EditMode)))
            {
                ddlEditMode.Items.Add(item);
            }
        }
        // get settings from form and save to global settings
        private void saveSettings()
        {
            MessageBoxForm mb = new MessageBoxForm();
            try
            {
                _settings.PromptPreview = chkPromptPreview.Checked;
                _settings.ConfirmSave = chkPromptTextSave.Checked;
                _settings.DefaultMode = (EditMode)Enum.Parse(typeof(EditMode), ddlEditMode.SelectedItem.ToString());
                _settings.ExportLocation = txtSaveLocation.Text;
                _settings.Save();
                mb.ShowDialog("Settings saved.", "", MessageBoxButtons.OK);
                this.Dispose(); // save is called on exit so close the form when complete
            }
            catch
            {   // we can't do anything if it fails for some reason, but at least let the user know
                mb.Show("Could not save settings. Please try again.", "Settings Error", MessageBoxButtons.OK);
            }
        }
        // load settings from global settings into form elements
        private void loadSettings()
        {
            chkPromptPreview.Checked = _settings.PromptPreview;
            chkPromptTextSave.Checked = _settings.ConfirmSave;
            ddlEditMode.SelectedItem = _settings.DefaultMode.ToString();
            txtSaveLocation.Text = _settings.ExportLocation;
        }
        #endregion
        #region Control Events
        // load settings
        private void Settings_Load(object sender, EventArgs e)
        {
            loadSettings();
        }
        // save settings
        private void tiCheck_Click(object sender, EventArgs e)
        {
            string expLoc = txtSaveLocation.Text.Trim();
            if (System.IO.Directory.Exists(expLoc))
            {
                saveSettings();
            }
            else
            {
                DialogResult createFolder = MessageBox.Show("Caution: Selected folder path does not exist." + Environment.NewLine + "Create folder?", "Create folder?", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
                if (createFolder == DialogResult.Yes)
                {
                    try
                    {
                        System.IO.Directory.CreateDirectory(expLoc);
                        saveSettings();
                    }
                    catch 
                    {
                        MessageBox.Show("Could not create folder at path specified. Please try again.", "Error creating directory", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }
        // cancel button click
        private void tiCancel_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
        // browse button for save location
        private void tiSaveLocation_Click(object sender, EventArgs e)
        {
            folderBrowserDialog1.SelectedPath = _settings.ExportLocation;
            if (folderBrowserDialog1.ShowDialog(this) == DialogResult.OK)
            {
                _settings.ExportLocation = folderBrowserDialog1.SelectedPath;
                txtSaveLocation.Text = _settings.ExportLocation;
            }
        }
        // simple click event so a click on panel makes the cursor focus to "hidden" input
        private void pnlSaveLocation_Click(object sender, EventArgs e)
        {
            txtSaveLocation.Focus();
        }
        #endregion
    }
}
