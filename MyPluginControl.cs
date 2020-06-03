using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using XrmToolBox.Extensibility;
using Microsoft.Xrm.Sdk.Query;
using Microsoft.Xrm.Sdk;
using McTools.Xrm.Connection;
using FiddlerAutoResponder.Model;
using System.IO;

namespace FiddlerAutoResponder
{
    public partial class MyPluginControl : PluginControlBase
    {
        private Settings mySettings;
        private List<string> Paths;
        private List<Model.Rule> Rules;

        public MyPluginControl()
        {
            InitializeComponent();
        }

        private void MyPluginControl_Load(object sender, EventArgs e)
        {
            ShowInfoNotification("This is a notification that can lead to XrmToolBox repository", new Uri("https://github.com/MscrmTools/XrmToolBox"));

            // Loads or creates the settings for the plugin
            if (!SettingsManager.Instance.TryLoad(GetType(), out mySettings))
            {
                mySettings = new Settings();

                LogWarning("Settings not found => a new settings file has been created!");
            }
            else
            {
                LogInfo("Settings found and loaded");
                Paths = mySettings.Paths;
                PathListBox.Items.AddRange(Paths.ToArray());
            }
        }

        private void tsbClose_Click(object sender, EventArgs e)
        {
            mySettings.Paths = Paths;
            SettingsManager.Instance.Save(GetType(), mySettings);
            CloseTool();
        }

     
     

        /// <summary>
        /// This event occurs when the connection has been updated in XrmToolBox
        /// </summary>
        public override void UpdateConnection(IOrganizationService newService, ConnectionDetail detail, string actionName, object parameter)
        {
            base.UpdateConnection(newService, detail, actionName, parameter);

            if (mySettings != null && detail != null)
            {
                mySettings.LastUsedOrganizationWebappUrl = detail.WebApplicationUrl;
            }
        }

        private void PathSelectButton_Click(object sender, EventArgs e)
        {
            PathTextInput.Text = SelectPathDialog();
        }

        private void AddToListButton_Click(object sender, EventArgs e)
        {
            if (Paths == null)
                Paths = new List<string>();
            if (string.IsNullOrEmpty(PathTextInput.Text))
                return;
            if (Paths.Any(p => p == PathTextInput.Text))
                return;

            Paths .Add(PathTextInput.Text);
            PathListBox.Items.Clear();
            PathListBox.Items.AddRange(Paths.ToArray());
            PathTextInput.Text = null;
        }


        private string SelectPathDialog()
        {
            string path = "";
            using (FolderBrowserDialog folderBrowser = new FolderBrowserDialog())
            {
                DialogResult result = folderBrowser.ShowDialog();
                if (result == DialogResult.OK && !string.IsNullOrWhiteSpace(folderBrowser.SelectedPath))
                {
                    path = folderBrowser.SelectedPath;
                }
            }
            return path;
        }

        private void GetFilesButton_Click(object sender, EventArgs e)
        {
            if (Paths == null || Paths.Count() == 0)
                return;
            FiddlerRulesGenerator generator = new FiddlerRulesGenerator(Paths, "");
            this.Rules = generator.GenerateFiddlerRules();
            var bindingList = new BindingList<Model.Rule>(this.Rules);
            var source = new BindingSource(bindingList, null);
            RulesDataGridView.DataSource = source;
        }

        private void SaveButon_Click(object sender, EventArgs e)
        {
            FiddlerRulesGenerator generator = new FiddlerRulesGenerator(Paths, "");
            string fileName = SaveToFileDialog();
            if (string.IsNullOrEmpty(fileName))
                return;
            string xml = generator.SerializeToXML(this.Rules);
            StreamWriter sw = new StreamWriter(fileName);
            sw.Write(xml);
            sw.Close();
        }

        private string SaveToFileDialog()
        {
            string fileName = null;
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.DefaultExt = "farx";
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                fileName = saveFileDialog.FileName;
            }
            return fileName;
        }
    }
}