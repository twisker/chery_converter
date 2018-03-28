﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace ConTool
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
            btnConvert.Enabled = false;
        }

        private void btnRead_Click(object sender, EventArgs e)
        {
            Stream stream = null;

            if (openExcelFile.ShowDialog()==DialogResult.OK)
            {
                try
                {
                    stream = openExcelFile.OpenFile();
                    if (stream != null)
                    {
                        txtOriginFileLocation.Text = openExcelFile.FileName;
                        stream.Close();
                        var dirName = Path.GetDirectoryName(openExcelFile.FileName);
                        var origin_fileName = Path.GetFileNameWithoutExtension(openExcelFile.FileName);
                        var fileName = "yMKT_"+ origin_fileName + ".csv";
                        var target = dirName + Path.DirectorySeparatorChar + fileName;
                        var i = 0;
                        while (File.Exists(target))
                        {
                            i++;
                            fileName = "yMKT_" + origin_fileName + "(" + i + ").csv";
                            target = dirName +Path.PathSeparator + fileName;
                        }

                        txtTargetFileLocation.Text = target;
                        saveTargetFile.InitialDirectory = dirName;
                        saveTargetFile.FileName = fileName;
                        
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("错误: 无法读取文件，原因：" + ex.Message);
                }
            }
        }

        private void btnTargetFile_Click(object sender, EventArgs e)
        {
            if (saveTargetFile.ShowDialog() == DialogResult.OK)
            {
                txtTargetFileLocation.Text = saveTargetFile.FileName;
            }
        }

        private void FileNames_changed(object sender, EventArgs e)
        {
            if (txtTargetFileLocation.Text.Length > 0 && txtOriginFileLocation.Text.Length > 0)
            {
                btnConvert.Enabled = true;
            }
            else
            {
                btnConvert.Enabled = false;
            }
        }

        private void btnConvert_Click(object sender, EventArgs e)
        {
            btnConvert.Enabled = false;
            if (txtTargetFileLocation.Text.Length > 0 && txtOriginFileLocation.Text.Length > 0)
            {
                this.Cursor = Cursors.WaitCursor;
                string result = this.Convert();
                if (result.Length == 0)
                {
                    result = "转换成功！";
                }
                txtTargetFileLocation.Text = "";
                txtOriginFileLocation.Text = "";
                this.Cursor = Cursors.Default;
                MessageBox.Show(result);
            }
            else
            {
                MessageBox.Show("请检查输入文件名和输出文件名，有错，谢谢。");
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /// <span class="code-SummaryComment"><summary></span>
        /// Executes a shell command synchronously.
        /// <span class="code-SummaryComment"></summary></span>
        /// <span class="code-SummaryComment"><param name="command">string command</param></span>
        /// <span class="code-SummaryComment"><returns>string, as output of the command.</returns></span>
        private string ExecuteCommandSync(string command)
        {
            try 
            {
                // create the ProcessStartInfo using "cmd" as the program to be run,
                // and "/c " as the parameters.
                // Incidentally, /c tells cmd that we want it to execute the command that follows,
                // and then exit.
                System.Diagnostics.ProcessStartInfo procStartInfo =
                    new System.Diagnostics.ProcessStartInfo("cmd", "/c " + command);

                // The following commands are needed to redirect the standard output.
                // This means that it will be redirected to the Process.StandardOutput StreamReader.
                procStartInfo.RedirectStandardOutput = true;
                procStartInfo.UseShellExecute = false;
                // Do not create the black window.
                procStartInfo.CreateNoWindow = true;
                // Now we create a process, assign its ProcessStartInfo and start it
                System.Diagnostics.Process proc = new System.Diagnostics.Process();
                proc.StartInfo = procStartInfo;
                proc.Start();
                // Get the output into a string
                string result = proc.StandardOutput.ReadToEnd();
                // Display the command output.
                return result;
            }
            catch (Exception objException)
            {
                // Log the exception
                return objException.Message;
            }
        }

        private string Convert()
        {
            string command = "converter";
            command += " " + txtOriginFileLocation.Text;
            command += " --output=" + txtTargetFileLocation.Text;
            command += " --format=" + "1";
            command += " --delimiter=" + txtSeperator.Text;
            command += " --max_col=" + numMaxCol.Value;
            command += " --total=" + numMaxRow.Value;
            return this.ExecuteCommandSync(command);
        }

        private void progress_ticking(object sender, EventArgs e)
        {
            var tar = progressConverting.Value + 15;
            if (tar >= progressConverting.Maximum)
            {
                tar = 0;
            }
            progressConverting.Value = tar;
        }
    }
}
