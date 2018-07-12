using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Text.RegularExpressions;
using System.Web.Script.Serialization;
using System.Windows.Forms;

namespace HostManager
{
    public partial class frmHostFileManager : Form
    {
        // private members
        private Color _commentColor = System.Drawing.ColorTranslator.FromHtml("#ECD6F5");
        private string _hostPath = "";
        private string _hostFile = "";
        private string _mapSep = "|";
        private string _ext = ".hm";
        private string _strippedFile = "";
        private string _ipPatrn = @"\b(?:[0-9]{1,3}\.){3}[0-9]{1,3}\b";
        private EditMode _mode = Properties.Settings.Default.DefaultMode;

        #region Form events
        public frmHostFileManager()
        {
            InitializeComponent();
            // get system drive folder (typically C:\)
            string sysFolder = Environment.GetFolderPath(Environment.SpecialFolder.System);
            _hostPath = Path.Combine(sysFolder, @"drivers\etc\hosts");  // build path to hosts file
            // set even width for listView columns
            int width = (lvMappings.Width - 10) / lvMappings.Columns.Count;
            foreach (ColumnHeader col in lvMappings.Columns)
            {
                col.Width = width;
            }
        }
        // when form loads, set default panel states and load Host file into edit - no need to browse as Host is always same on system drive
        private void frmHostFileManager_Load(object sender, EventArgs e)
        {
            loadHostFile(_mode);
            togglePanels(_mode);
        }
        #endregion
        #region Helper methods
        /// <summary>
        /// Reads the system Host file into edit based on specified mode
        /// </summary>
        private void loadHostFile(EditMode mode)
        {
            if (File.Exists(_hostPath))
            {
                _mode = mode;
                _hostFile = File.ReadAllText(_hostPath);
                _strippedFile = stripMappings(_hostFile);
                if (mode == EditMode.List)
                {
                    addHostsToList(_hostFile);
                }
                else { txtHostText.Text = _hostFile; }
            }
            else
            {
                DialogResult retryCancel = MessageBox.Show("Unable to locate host file on machine. Please check your permissions and try again.", "No file found", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
                if (retryCancel == DialogResult.Retry)
                {
                    loadHostFile(mode);
                }
                else
                {   // do nothing for now
                }
            }
        }
        /// <summary>
        /// Parses Host mappings from specified string and adds to ListView for editing 
        /// </summary>
        private void addHostsToList(string hostStr)
        {
            addHostsToList(getHostListFromStr(hostStr));
        }
        /// <summary>
        /// Adds specified List of HostMapping objects to ListView for editing
        /// </summary>
        private void addHostsToList(List<HostMapping> hostMaps)
        {
            List<ListViewItem> items = new List<ListViewItem>();
            foreach (var hm in hostMaps)
            {
                ListViewItem item = new ListViewItem(new string[] { hm.IP, hm.URL, hm.Comment });
                if (hm.IsCommented)
                {
                    commentItem(item);
                }
                items.Add(item);
            }
            if (items.Count() > 0)
            {
                lvMappings.Items.Clear();
                lvMappings.Items.AddRange(items.ToArray());
            }
        }
        private void commentItem(ListViewItem item)
        {
            item.BackColor = _commentColor;
            item.ForeColor = Color.LightSlateGray;
            item.ToolTipText = "Item commented out";
        }
        // set properties to indicate commented line
        private void commentItem(IEnumerable<ListViewItem> items)
        {
            foreach (var item in items)
            {
                commentItem(item);
            }
        }
        private void uncommentItem(ListViewItem item)
        {
            item.BackColor = Color.Empty;
            item.ForeColor = lvMappings.ForeColor;
            item.ToolTipText = "";
        }
        // remove properties indicating commented line
        private void uncommentItem(IEnumerable<ListViewItem> items)
        {
            foreach (var item in items)
            {
                uncommentItem(item);
            }
        }
        /// <summary>
        /// Adds a single new mapping to list of mappings at specified location if an IP and URL are specified.
        /// Specify index greater than -1 to replace an existing item
        /// </summary>
        private void addSingleHost(string ip, string url, string comment = "", ListViewItem item = null)
        {
            if (!string.IsNullOrWhiteSpace(ip) && !string.IsNullOrWhiteSpace(url))
            {
                if (!string.IsNullOrWhiteSpace(comment))
                {
                    comment = (comment.StartsWith("#") ? comment : "#" + comment);
                }
                if (item ==null)
                {
                    lvMappings.Items.Add(new ListViewItem(new string[] { ip, url, comment }));
                }
                else
                {
                    item.SubItems[0].Text = ip;
                    item.SubItems[1].Text = url;
                    item.SubItems[2].Text = comment;
                }
            }
        }
        /// <summary>
        /// Removes specified items from ListView
        /// </summary>
        private void removeHost()
        {
            foreach (ListViewItem item in lvMappings.SelectedItems)
            {
                lvMappings.Items.Remove(item);
            }
        }
        /// <summary>
        /// Get host mappings from supplied string. Removes full line comments and return a list of HostMapping
        /// objects with IP, URL, and Comment. Used to get mappings for list from host file or text entry.
        /// </summary>
        private List<HostMapping> getHostListFromStr(string hostStr)
        {
            List<HostMapping> items = new List<HostMapping>();
            if (!string.IsNullOrWhiteSpace(hostStr))
            {
                hostStr = stripComments(hostStr);
                var mappings = hostStr.Split(new string[] { _mapSep }, StringSplitOptions.RemoveEmptyEntries);
                foreach (string map in mappings)
                {
                    string[] mapPair = map.Split(' ');
                    if (mapPair.Length > 1)
                    {
                        string comment = "";
                        if (mapPair.Length > 2)
                        {
                            comment = String.Join(" ", mapPair.Skip(2));
                        }
                        HostMapping hMap = new HostMapping();

                        hMap.IP = mapPair[0].TrimStart('#');
                        hMap.URL = mapPair[1];
                        hMap.Comment = comment;
                        hMap.IsCommented = mapPair[0].StartsWith("#");
                        items.Add(hMap);
                    }
                }
            }
            return items;
        }
        /// <summary>
        /// Strips out all typical Hosts file whole line comments from string - Comments after a mapping are preserved.
        /// </summary>
        private string stripComments(string text)
        {
            string cleaned = Regex.Replace(text, @"^\#(?!"+_ipPatrn+").*$", "", RegexOptions.Multiline);    // remove comments
            cleaned = Regex.Replace(cleaned, @"^\r\n|^\n", "", RegexOptions.Multiline);    // remove empty lines
            cleaned = Regex.Replace(cleaned, @"\r\n", _mapSep, RegexOptions.Multiline);     // remove line breaks between mappings and separate with #
            cleaned = Regex.Replace(cleaned, @"\s+", " ", RegexOptions.Multiline);     // convert multiple spaces to one
            return cleaned;
        }
        /// <summary>
        /// Strips out all Hosts mappings and collapses whole line comments from string
        /// </summary>
        private string stripMappings(string text)
        {
            string cleaned = Regex.Replace(text, @"^(?!\#).*?$", "", RegexOptions.Multiline);   // remove non-comment lines (active mappings)
            cleaned = Regex.Replace(cleaned, @"^#" + _ipPatrn + ".*?$", "", RegexOptions.Multiline); // remove commented mappings
            cleaned = Regex.Replace(cleaned, @"\n\n+", "\n", RegexOptions.Multiline);
            return cleaned;
        }
        // Hide/Show proper panels based on mode for List or Text editing
        private void togglePanels(EditMode mode)
        {
            if (mode == EditMode.Text)
            {
                pnlHostsText.Visible = !(pnlHostList.Visible = false);
                txtHostText.Text = getStringForSave();
            }
            else
            {
                pnlHostList.Visible = !(pnlHostsText.Visible = false);
                addHostsToList(txtHostText.Text);
            }
            _mode = mode;  // this helps control various function behavior
        }
        /// <summary>
        /// Adds a new ListViewItem into mapping list from data entered in dialog
        /// </summary>
        private void addNewItem()
        {
            InputDialog input = new InputDialog();
            if (input.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                addSingleHost(input.IP, input.Url, input.Comment);
            }
        }
        /// <summary>
        /// Loads specified item in list into dialog for editing current values
        /// </summary>
        private void editItem(int index)
        {
            if (index >= 0)
            {
                ListViewItem lvi = lvMappings.Items[index];
                InputDialog input = new InputDialog();
                input.Text = "Edit mapping";
                input.IP = lvi.SubItems[0].Text;
                input.Url = lvi.SubItems[1].Text;
                input.Comment = lvi.SubItems[2].Text;
                if (input.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    addSingleHost(input.IP, input.Url, input.Comment, lvi);
                }
            }
        }
        /// <summary>
        /// Serializes the edited Host mappings and writes them to a file
        /// </summary>
        private void exportMappings(string fileName)
        {
            try
            {
                JavaScriptSerializer jss = new JavaScriptSerializer();
                string hostJSON = jss.Serialize(getListFromEdit());
                if (Path.GetExtension(fileName) != _ext) { fileName += _ext; }
                File.WriteAllText(fileName, hostJSON);
                MessageBox.Show("Host Mappings exported");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Could not export mappings. Reason:" + Environment.NewLine+ex.Message, "Error with export", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        /// <summary>
        /// Reads HostMapping data from a saved file and imports the data for editing as List of HostMapping objects
        /// </summary>
        private List<HostMapping> importMappings(string fileName)
        {
            if (Path.GetExtension(fileName) == _ext)
            {
                try
                {
                    if (File.Exists(fileName))
                    {
                        string hostJSON = File.ReadAllText(fileName);
                        JavaScriptSerializer jss = new JavaScriptSerializer();
                        return jss.Deserialize<List<HostMapping>>(hostJSON);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Could not import mappings. Reason:" + Environment.NewLine + ex.Message, "Error with import", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Could not import mappings. Wrong file type.");
            }
            return null;
        }
        /// <summary>
        /// Return a List of HostMapping objects based on current mode
        /// </summary>
        private List<HostMapping> getListFromEdit()
        {
            if (_mode == EditMode.Text) { return getHostListFromStr(txtHostText.Text); }
            else { return getMappingList(); }
        }
        /// <summary>
        /// Takes ListViewItems from lvMappings ListView and returns a List of HostMapping objects.
        /// </summary>
        private List<HostMapping> getMappingList()
        {
            return lvMappings.Items.Cast<ListViewItem>().Select(i => new HostMapping()
            {
                IP = i.SubItems[0].Text,
                URL = i.SubItems[1].Text,
                Comment = i.SubItems[2].Text,
                IsCommented = (i.BackColor == _commentColor)
            }).ToList();
        }
        /// <summary>
        /// Get the text for writing to Host file based on current mode
        /// </summary>
        private string getStringForSave()
        {
            if (_mode == EditMode.Text) { return txtHostText.Text; }
            else { return getHostStrFromList(getMappingList()); }
        }
        /// <summary>
        /// Takes a List of HostMapping objects and builds the host file string from the base Host file,
        /// cleaned up with mappings added after all comments.
        /// </summary>
        private string getHostStrFromList(List<HostMapping> maps)
        {
            StringBuilder sb = new StringBuilder(_strippedFile);
            sb.Append(Environment.NewLine);
            foreach (var map in maps)
            {
                sb.Append(string.Format("{0}{1}\t{2}\t{3}{4}", (map.IsCommented ? "#" : ""), map.IP, map.URL, map.Comment, Environment.NewLine));
            }
            return sb.ToString();
        }
        /// <summary>
        /// Perform a simple check to see if the item is commented based on background color
        /// </summary>
        private bool isItemCommented(ListViewItem item)
        {
            return item.BackColor == _commentColor;
        }
        /// <summary>
        /// Add or edit item based on item or empty below mouse
        /// </summary>
        private void addEditItem(ListViewHitTestInfo lvInfo)
        {
            if (lvInfo.SubItem == null)
            {
                addNewItem();
            }
            else
            {
                editItem(lvInfo.Item.Index);
            }
        }
        /// <summary>
        /// Toggle commands in menu based on item and show context menu
        /// </summary> 
        private void showContextMenu(ListViewHitTestInfo lvInfo, Point location)
        {
            if (lvInfo.SubItem != null)
            {
                mnuCommentItem.Visible = !(mnuUncommentItem.Visible = (lvInfo.Item.BackColor == _commentColor));    // if backcolor is commentcolor, uncomment is visible, comment is not - reverse if false
            }
            else { mnuCommentItem.Visible = (mnuUncommentItem.Visible = false); }
            mnuEditItem.Visible = !(mnuAddItem.Visible = (lvInfo.SubItem == null)); // if null, add is visible, edit is not - reverse if not null
            mnuLineItemMenu.Cursor = Cursors.Hand;
            mnuLineItemMenu.Show(lvMappings, location.X+10,location.Y+10);
        }
        /// <summary>
        /// Write edited Host mapping information to system Hosts file based on mode. If mode is List, preview prompt will show. If mode is text,
        /// a write confirmation will show.
        /// </summary>
        /// <param name="preview">Checks for DialogResult.No, Ignore, and Cancel. In Text mode, use DialogResult.No to avoid write confirmation.</param>
        private void writeToHost(DialogResult preview = DialogResult.No)
        {
            Properties.Settings _settings = Properties.Settings.Default;
            string hostStr = getStringForSave();
            if (_mode == EditMode.List && _settings.PromptPreview)
            {
                MessageBoxForm mb = new MessageBoxForm();
                mb.RememberChoiceEvent += (sender, e) =>
                {
                    if (e.IsChoiceRemembered && (e.FormResult == DialogResult.Yes || e.FormResult == DialogResult.No))
                    {
                        _settings.PromptPreview = (e.FormResult == DialogResult.Yes ? false : true);
                    }
                };
                preview = mb.ShowDialog("Preview changes before setting Host file?", "Preview?", MessageBoxButtons.YesNoCancel, true);
                //preview = MessageBox.Show("Preview changes before setting Host file?", "Preview?", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
            }
            if (preview == DialogResult.Yes)
            {
                togglePanels(EditMode.Text);
            }
            else if (preview == DialogResult.No || preview == DialogResult.Ignore)
            {
                try
                {
                    MessageBoxForm mb = new MessageBoxForm();
                    mb.RememberChoiceEvent += (sender, e) =>
                    {
                        if (e.IsChoiceRemembered)
                        {
                            _settings.ConfirmSave = (e.FormResult == DialogResult.OK ? false : true);
                        }
                    };
                    if ((preview == DialogResult.No || !_settings.ConfirmSave) || mb.ShowDialog("Write mappings to Host file?", "", MessageBoxButtons.OKCancel, true) == DialogResult.OK)
                    {
                        File.WriteAllText(_hostPath, hostStr);
                        MessageBox.Show("Mappings set in Host file.", "Success", MessageBoxButtons.OK);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Unable to set mappings in Host file.\n" + ex.Message, "Error saving", MessageBoxButtons.OK);
                }
            }
            else
            {   // this handles the cancel click - do nothing.
            }
        }
        #endregion
        #region Control events
        // Exit button
        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
        // toggle to List view
        private void lnkEditHostList_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            togglePanels(EditMode.List);
        }
        // toggle to Text view
        private void lnkEditHostText_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            togglePanels(EditMode.Text);
        }
        // Reloads ListView from currently active Hosts file
        private void lnkReloadList_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (MessageBox.Show("This will erase any changes to your list below and load from the system host file.", "Warning: Changes will be lost", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == System.Windows.Forms.DialogResult.OK)
            {
                loadHostFile(EditMode.List);
            }
        }
        // Reloads Text area from currently active Hosts file
        private void lnkReloadTest_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (MessageBox.Show("This will erase any changes you have made below and will reload from the system host file.", "Warning: Changes will be lost", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == System.Windows.Forms.DialogResult.OK)
            {
                loadHostFile(EditMode.Text);
            }
        }
        // Button trigger to add new mapping
        private void pbListAdd_Click(object sender, EventArgs e)
        {
            addNewItem();
        }
        // Button trigger to delete selected items from list
        private void pbListDel_Click(object sender, EventArgs e)
        {
            if (lvMappings.SelectedItems.Count > 0)
            {
                if (MessageBox.Show("Remove selected mappings from list?", "Remove items", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == System.Windows.Forms.DialogResult.OK)
                {
                    removeHost();
                }
            }
        }
        // Button trigger to start export process - prompts user for save location
        private void btnExport_Click(object sender, EventArgs e)
        {
            saveFileDialog1.Filter = "Host Mapping Files | *" + _ext;
            saveFileDialog1.Title = "Export mappings to file";
            saveFileDialog1.FileName = "myHosts.hm";
            saveFileDialog1.InitialDirectory = Properties.Settings.Default.ExportLocation;
            if (saveFileDialog1.ShowDialog(this) == DialogResult.OK)
            {
                string filePath = saveFileDialog1.FileName;
                Properties.Settings.Default.ExportLocation = filePath;
                Properties.Settings.Default.Save();
                exportMappings(filePath);
            }
        }
        // Button trigger to save mappings to system Hosts file
        private void btnSave_Click(object sender, EventArgs e)
        {
            if (_mode == EditMode.Text)
            {
                writeToHost(DialogResult.Ignore);
            }
            else { writeToHost(); }
        }
        // simple method to show settings dialog
        private void btnSettings_Click(object sender, EventArgs e)
        {
            (new Settings()).ShowDialog();
        }
        // show tooltip to show commented items
        private void lvMappings_ItemMouseHover(object sender, ListViewItemMouseHoverEventArgs e)
        {
            Point pt = ((ListView)sender).PointToClient(Cursor.Position);
            if (e.Item != null)
            {
                if (isItemCommented(e.Item) && !string.IsNullOrWhiteSpace(e.Item.ToolTipText))
                {
                    toolTip1.UseFading = true;
                    toolTip1.Show(e.Item.ToolTipText, e.Item.ListView, pt.X + 10, pt.Y + 10, 1000);
                }
            }
        }
        // call comment function for all selected items
        private void mnuCommentItem_Click(object sender, EventArgs e)
        {
            commentItem(lvMappings.SelectedItems.Cast<ListViewItem>());
        }
        // call uncomment function for all selected items
        private void mnuUncommentItem_Click(object sender, EventArgs e)
        {
            uncommentItem(lvMappings.SelectedItems.Cast<ListViewItem>());
        }
        // add item - empty area
        private void mnuAddItem_Click(object sender, EventArgs e)
        {
            addNewItem();
        }
        // edit item - only first item can be edited
        private void mnuEditItem_Click(object sender, EventArgs e)
        {
            editItem(lvMappings.SelectedIndices[0]);
        }
        // Button trigger to start import process - prompts for save HostMappings(HM) file
        private void btnImport_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "Host Mapping Files | *" + _ext;
            openFileDialog1.Title = "Import mappings";
            openFileDialog1.FileName = "";
            openFileDialog1.InitialDirectory = Properties.Settings.Default.ExportLocation;
            if (openFileDialog1.ShowDialog(this) == DialogResult.OK)
            {
                string filePath = openFileDialog1.FileName;
                Properties.Settings.Default.ExportLocation = filePath;
                Properties.Settings.Default.Save();
                List<HostMapping> maps = importMappings(filePath);
                // text mode requires the list to be converted to the host str
                if (_mode == EditMode.Text) { txtHostText.Text = getHostStrFromList(maps); }
                else { addHostsToList(maps); }
            }
        }
        // Allow Ctl+A Select All shortcut in multi-line textbox
        private void txtHostText_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control && (e.KeyCode == Keys.A))
            {
                ((TextBox)sender).SelectAll();
                e.SuppressKeyPress = true;
                e.Handled = true;
            }
        }
        // Check for double-click in ListView - handles On item or not
        private void lvMappings_MouseDown(object sender, MouseEventArgs e)
        {
            if ((e.Button == MouseButtons.Left && e.Clicks == 2) || e.Button == MouseButtons.Right)
            {
                // Handle double-click on ListView for Add or Edit items
                ListViewHitTestInfo lvInfo = ((ListView)sender).HitTest(e.Location);
                if (e.Button == MouseButtons.Left)
                {
                    addEditItem(lvInfo);
                }
                else if (e.Button == MouseButtons.Right)
                {
                    showContextMenu(lvInfo, e.Location);
                }
            }
        }
        #endregion

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBoxForm mb = new MessageBoxForm();
            mb.ShowDialog("This is a simple test"/* to see what happens."*/, "This is a test", MessageBoxButtons.OK);
        }

    }
    // Class for serializing mapping data
    public class HostMapping
    {
        public string IP { get; set; }
        public string URL { get; set; }
        public string Comment { get; set; }
        public bool IsCommented { get; set; }
    }
}
