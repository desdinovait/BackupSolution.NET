using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;
using Microsoft.Win32;
using System.Reflection;

namespace BackupSolution.NET
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
            this.Text = Assembly.GetExecutingAssembly().GetName(false).Name.ToString() + " " + Assembly.GetExecutingAssembly().GetName(false).Version.ToString();
        }

        private void buttonSource_Click(object sender, EventArgs e)
        {
            folderBrowserDialog1.ShowNewFolderButton = true;
            folderBrowserDialog1.Description = "Select .NET solution directory to backup";
            folderBrowserDialog1.SelectedPath = textSource.Text;
            folderBrowserDialog1.ShowNewFolderButton = false;
            if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {
                textSource.Text = folderBrowserDialog1.SelectedPath.ToString();
            }
        }

        private void buttonDestination_Click(object sender, EventArgs e)
        {
            folderBrowserDialog1.ShowNewFolderButton = true;
            folderBrowserDialog1.Description = "Select .NET solution destination directory";
            folderBrowserDialog1.SelectedPath = textDestination.Text;
            folderBrowserDialog1.ShowNewFolderButton = true;
            if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {
                textDestination.Text = folderBrowserDialog1.SelectedPath.ToString();
            }
        }

        private void buttonStart_Click(object sender, EventArgs e)
        {
            DateTime savedTime = new DateTime();
            try
            {
                savedTime = DateTime.Parse(textPrefix.Text.Replace('.', '/'));
                if (DateTime.Now.ToShortDateString() != savedTime.ToShortDateString())
                {
                    if (MessageBox.Show("Date set as prefix does not corrispond to today's day. Updating?", "BackupSolution.NET Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                    {
                        textPrefix.Text = DateTime.Now.ToShortDateString().Replace('/', '.');
                    }
                }
            }
            catch
            {
            }

            try
            {
                savedTime = DateTime.Parse(textSuffix.Text.Replace('.', '/'));
                if (DateTime.Now.ToShortDateString() != savedTime.ToShortDateString())
                {
                    if (MessageBox.Show("Date set as suffix does not corrispond to today's day. Updating?", "BackupSolution.NET Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                    {
                        textSuffix.Text = DateTime.Now.ToShortDateString().Replace('/', '.');
                    }
                }          
            }
            catch
            {

            }
         

            if (buttonStart.Text == "Start")
            {
                if (textDestination.Text != string.Empty)
                {
                    string destDir = textDestination.Text;
                    if (checkName.Checked)
                    {
                        string[] currentDir = textSource.Text.Split('\\');
                        if (currentDir.Length >= 1)
                        {
                            destDir = destDir + "\\" + textPrefix.Text + currentDir[currentDir.Length - 1].ToString() + textSuffix.Text;
                        }
                    }

                    bool proceed = true;
                    if (Directory.Exists(destDir))
                    {
                        if (MessageBox.Show("Destination directory exists. Do you want to overwrite destination directory?", "BackupSolution.NET Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                        {
                            proceed = true;
                            Directory.Delete(destDir,true);
                        }
                        else
                        {
                            proceed = false;
                        }
                    }
                    this.Refresh();

                    if (proceed)
                    {
                        buttonStart.Text = "Copying...";
                        buttonStart.ForeColor = Color.Red;
                        this.Enabled = false;
                        this.Refresh();

                        if (FileCopy(textSource.Text, destDir))
                        {
                            MessageBox.Show("Copying source directory to destination completed successfully", "BackupSolution.NET Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("Error during copying source directory to destination.", "BackupSolution.NET Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }

                    buttonStart.Text = "Start";
                    buttonStart.ForeColor = SystemColors.ControlText;
                    this.Enabled = true;
                }
                else
                {
                    MessageBox.Show("Please select a destination directory.", "BackupSolution.NET Warning", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
        }

        private bool FileCopy(string srcdir, string destdir)
        {
            try
            {
                DirectoryInfo dir;
                FileInfo[] files;
                DirectoryInfo[] dirs;
                string tmppath;

                if (!Directory.Exists(destdir))
                {
                    Directory.CreateDirectory(destdir);
                }
                dir = new DirectoryInfo(srcdir);

                //Files
                files = dir.GetFiles();
                foreach (FileInfo file in files)
                {
                    if (file.Extension == ".pdb")
                    {
                        continue;
                    }

                    if (file.FullName.Contains(".vshost.exe"))
                    {
                        continue;
                    }

                    string extensions = textOtherExt.Text.Replace(".",string.Empty);
                    string[] otherFiles = extensions.Split(';', ',');
                    for (int i = 0; i < otherFiles.Length; i++)
                    {
                        if ("." + otherFiles[i].ToLower() == file.Extension.ToLower())
                        {
                            goto jump1;
                        }
                    }

                    tmppath = Path.Combine(destdir, file.Name);
                    file.CopyTo(tmppath, false);

                jump1:
                    int sentinel1 = 0;

                }
                files = null;

                //Directoy
                dirs = dir.GetDirectories();
                foreach (DirectoryInfo subdir in dirs)
                {
                    //Exclusion
                    if ((checkBIN.Checked) && (subdir.Name.ToUpper() == "BIN"))
                    {
                        continue;
                    }
                    if ((checkOBJ.Checked) && (subdir.Name.ToUpper() == "OBJ"))
                    {
                        continue;
                    }

                    bool copyDir = true;
                    string[] others = textOtherDir.Text.Split(';', ',');
                    for (int i = 0; i < others.Length; i++)
                    {
                        string searchDir = others[i].Trim(' ');
                        if (subdir.Name.ToUpper() == searchDir.ToUpper())
                        {
                            copyDir = false;
                            break;
                        }
                    }

                    if (copyDir)
                    {
                        tmppath = Path.Combine(destdir, subdir.Name);
                        if (FileCopy(subdir.FullName, tmppath) == false)
                        {
                            return false;
                        }
                    }
                }

                dirs = null;
                dir = null;

                return true;
            }
            catch
            {
                return false;
            }
        }

        private void textSource_TextChanged(object sender, EventArgs e)
        {
            if (Directory.Exists(textSource.Text))
            {
                buttonStart.Enabled = true;
            }
            else
            {
                buttonStart.Enabled = false;
            }
            RefreshExample();
        }

        private void FormMain_FormClosed(object sender, FormClosedEventArgs e)
        {
            RegistryKey regKey = Registry.LocalMachine.OpenSubKey(@"Software\BackupSolution.NET", true);
            if (regKey == null)
            {
                regKey = Registry.LocalMachine.CreateSubKey(@"Software\BackupSolution.NET");
            }
            regKey.SetValue("SourceDir", textSource.Text, RegistryValueKind.String);
            regKey.SetValue("ExcludeBIN", checkBIN.Checked, RegistryValueKind.DWord);
            regKey.SetValue("ExcludeOBJ", checkOBJ.Checked, RegistryValueKind.DWord);
            regKey.SetValue("ExcludeFiles", checkExclude.Checked, RegistryValueKind.DWord);
            regKey.SetValue("OtherDir", textOtherDir.Text, RegistryValueKind.String);
            regKey.SetValue("OtherExt", textOtherExt.Text, RegistryValueKind.String);
            regKey.SetValue("UseSourceDir", checkName.Checked, RegistryValueKind.DWord);
            regKey.SetValue("Suffix", textSuffix.Text, RegistryValueKind.String);
            regKey.SetValue("Prefix", textPrefix.Text, RegistryValueKind.String);
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            RegistryKey regKey = Registry.LocalMachine.OpenSubKey(@"Software\BackupSolution.NET", true);
            if (regKey != null)
            {
                textSource.Text = (string)regKey.GetValue("SourceDir", string.Empty);
                checkBIN.Checked = Convert.ToBoolean((int)regKey.GetValue("ExcludeBIN", 1));
                checkOBJ.Checked = Convert.ToBoolean((int)regKey.GetValue("ExcludeOBJ", 1));
                checkExclude.Checked = Convert.ToBoolean((int)regKey.GetValue("ExcludeFiles", 0));
                textOtherDir.Text = (string)regKey.GetValue("OtherDir", string.Empty);
                textOtherExt.Text = (string)regKey.GetValue("OtherExt", string.Empty);
                checkName.Checked = Convert.ToBoolean((int)regKey.GetValue("UseSourceDir", 1));
                textSuffix.Text = (string)regKey.GetValue("Suffix", string.Empty);
                textPrefix.Text = (string)regKey.GetValue("Prefix", string.Empty);
            }
            buttonStart.Select();
        }

        private void buttonAbout_Click(object sender, EventArgs e)
        {
            AboutForm about = new AboutForm();
            about.ShowDialog();
        }

        private void checkName_CheckedChanged(object sender, EventArgs e)
        {
            if (checkName.Checked)
            {
                labelSuffix.Enabled = true;
                textSuffix.Enabled = true;
                labelPrefix.Enabled = true;
                textPrefix.Enabled = true;
                buttonPrefixDate.Enabled = true;
                buttonSuffixDate.Enabled = true;
                labelEx.Enabled = true;
                labelExample.Enabled = true;
            }
            else
            {
                labelSuffix.Enabled = false;
                textSuffix.Enabled = false;
                labelPrefix.Enabled = false;
                textPrefix.Enabled = false;
                buttonPrefixDate.Enabled = false;
                buttonSuffixDate.Enabled = false;
                labelEx.Enabled = false;
                labelExample.Enabled = false;
            }
        }

        private void buttonPrefixDate_Click(object sender, EventArgs e)
        {
            textPrefix.Text = DateTime.Today.ToShortDateString().Replace('/', '.');
        }

        private void buttonSuffixDate_Click(object sender, EventArgs e)
        {
            textSuffix.Text = DateTime.Today.ToShortDateString().Replace('/', '.');
        }

        private void textPrefix_TextChanged(object sender, EventArgs e)
        {
            RefreshExample();
        }

        private void textSuffix_TextChanged(object sender, EventArgs e)
        {
            RefreshExample();
        }

        private void RefreshExample()
        {
            string[] currentDirArray = textSource.Text.Split('\\');
            string currentDir = string.Empty;
            if (currentDirArray.Length >= 1)
            {
                currentDir = currentDirArray[currentDirArray.Length - 1].ToString();
            }
            labelExample.Text = textPrefix.Text + currentDir + textSuffix.Text;
        }

        private void checkBIN_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBIN.Checked)
            {
                checkExclude.Enabled = false;
            }
            else
            {
                checkExclude.Enabled = true;
            }
        }
    }
}