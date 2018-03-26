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

namespace ConTool
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void mainPanel_Paint(object sender, PaintEventArgs e)
        {

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
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("错误: 无法读取文件，原因：" + ex.Message);
                }
            }
        }
    }
}
