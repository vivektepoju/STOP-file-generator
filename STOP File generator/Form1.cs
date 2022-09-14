using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace STOP_File_generator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void BtnGenerateStopFile_Click(object sender, EventArgs e)
        {
            //DirectoryInfo d = new DirectoryInfo(txtFilePath.Text);
            //FileInfo[] Files = d.GetFiles("*.zip");
            int count = 0;

            rtbStatus.Text = "";
            if (txtFilePath.Text != "" && chkDeleteFiles.Checked == false)
            {

                string[] filePaths;
                string stopFileName;
                filePaths = Directory.GetFiles(txtFilePath.Text, "*.zip");

                foreach (var filepath in filePaths)
                {
                    
                    //File.Create(file.Substring(0, filepath.Length - 4) + ".STOP");
                    string[] file = filepath.Split('\\');
                    string filename = file[file.Length - 1];
                    string[] fileSplit = filename.Substring(0, filename.Length - 4).Split('_');
                    //string stopFileName = fileSplit[0] + "_" + fileSplit[1] + "_" + fileSplit[2] + "_" + fileSplit[6] + "_" + fileSplit[8] + ".STOP";
                    if(!chkNewFormat.Checked && !chkRegular.Checked)
                        stopFileName = fileSplit[0] + "_" + fileSplit[1] + "_" + fileSplit[2] + "_SL_" + fileSplit[fileSplit.Length - 1] + ".STOP";
                    else if(chkNewFormat.Checked && !chkRegular.Checked)
                        stopFileName = fileSplit[0] + "_" + fileSplit[1] + "_" + fileSplit[2] + "_" + fileSplit[3] + "_" + fileSplit[fileSplit.Length - 1] + ".STOP";
                    else// if (!chkNewFormat.Checked && chkRegular.Checked)
                        stopFileName = fileSplit[0] + "_" + fileSplit[1] + "_" + fileSplit[2] + "_" + fileSplit[fileSplit.Length - 1] + ".STOP";

                    if (!File.Exists(txtFilePath.Text + "\\" + stopFileName))
                    {
                        File.Create(txtFilePath.Text + "\\" + stopFileName).Close();
                        rtbStatus.AppendText(stopFileName + "\n");
                        count++;
                    }
                    else
                    {
                        rtbStatus.AppendText("Exists: " + stopFileName + "\n");
                    }
                        
                    
                    
                }
            }
            else
            {
                string[] filePaths = Directory.GetFiles(txtFilePath.Text, "*.STOP");
                foreach (var filepath in filePaths)
                {
                    File.Delete(filepath);
                    rtbStatus.AppendText(filepath + "\n");
                    count++;
                }

                
            }
            lblCount.Text = "Count " + count.ToString();
        }

        private void ChkDeleteFiles_CheckedChanged(object sender, EventArgs e)
        {
            if (chkDeleteFiles.Checked == true)
            {
                btnGenerateStopFile.Text = "Delete STOP Files";
            }
            else btnGenerateStopFile.Text = "Generate STOP Files";
        }

        private void ChkNewFormat_CheckedChanged(object sender, EventArgs e)
        {
            if (chkRegular.Checked && chkNewFormat.Checked)
                chkRegular.Checked = false;
        }

        private void ChkRegular_CheckedChanged(object sender, EventArgs e)
        {
            if (chkRegular.Checked && chkNewFormat.Checked)
                chkNewFormat.Checked = false;
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            txtFilePath.Text=@"K:\Kcust\GALAXY\Working\Export\WRST\CDL";
        }
    }
}
