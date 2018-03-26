namespace ConTool
{
    partial class frmMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.tableMain = new System.Windows.Forms.TableLayoutPanel();
            this.txtOriginFileLocation = new System.Windows.Forms.TextBox();
            this.btnRead = new System.Windows.Forms.Button();
            this.txtTargetFileLocation = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.radioDMSbackend = new System.Windows.Forms.RadioButton();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.btnConvert = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.openExcelFile = new System.Windows.Forms.OpenFileDialog();
            this.saveTargetFile = new System.Windows.Forms.SaveFileDialog();
            this.tableMain.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableMain
            // 
            resources.ApplyResources(this.tableMain, "tableMain");
            this.tableMain.Controls.Add(this.txtOriginFileLocation, 0, 0);
            this.tableMain.Controls.Add(this.btnRead, 1, 0);
            this.tableMain.Controls.Add(this.txtTargetFileLocation, 0, 1);
            this.tableMain.Controls.Add(this.button2, 1, 1);
            this.tableMain.Controls.Add(this.radioDMSbackend, 0, 2);
            this.tableMain.Controls.Add(this.flowLayoutPanel1, 1, 2);
            this.tableMain.Name = "tableMain";
            // 
            // txtOriginFileLocation
            // 
            resources.ApplyResources(this.txtOriginFileLocation, "txtOriginFileLocation");
            this.txtOriginFileLocation.Name = "txtOriginFileLocation";
            // 
            // btnRead
            // 
            resources.ApplyResources(this.btnRead, "btnRead");
            this.btnRead.Name = "btnRead";
            this.btnRead.UseVisualStyleBackColor = true;
            this.btnRead.Click += new System.EventHandler(this.btnRead_Click);
            // 
            // txtTargetFileLocation
            // 
            resources.ApplyResources(this.txtTargetFileLocation, "txtTargetFileLocation");
            this.txtTargetFileLocation.Name = "txtTargetFileLocation";
            // 
            // button2
            // 
            resources.ApplyResources(this.button2, "button2");
            this.button2.Name = "button2";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // radioDMSbackend
            // 
            resources.ApplyResources(this.radioDMSbackend, "radioDMSbackend");
            this.radioDMSbackend.Checked = true;
            this.radioDMSbackend.Name = "radioDMSbackend";
            this.radioDMSbackend.TabStop = true;
            this.radioDMSbackend.UseVisualStyleBackColor = true;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.btnConvert);
            this.flowLayoutPanel1.Controls.Add(this.btnCancel);
            resources.ApplyResources(this.flowLayoutPanel1, "flowLayoutPanel1");
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            // 
            // btnConvert
            // 
            resources.ApplyResources(this.btnConvert, "btnConvert");
            this.btnConvert.Name = "btnConvert";
            this.btnConvert.UseVisualStyleBackColor = true;
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            resources.ApplyResources(this.btnCancel, "btnCancel");
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // openExcelFile
            // 
            this.openExcelFile.DefaultExt = "xlsx";
            this.openExcelFile.FileName = "*.xlsx";
            resources.ApplyResources(this.openExcelFile, "openExcelFile");
            // 
            // saveTargetFile
            // 
            this.saveTargetFile.DefaultExt = "xlsx";
            this.saveTargetFile.FileName = "yMKT_upload.xlsx";
            resources.ApplyResources(this.saveTargetFile, "saveTargetFile");
            // 
            // frmMain
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancel;
            this.Controls.Add(this.tableMain);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmMain";
            this.tableMain.ResumeLayout(false);
            this.tableMain.PerformLayout();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableMain;
        private System.Windows.Forms.TextBox txtOriginFileLocation;
        private System.Windows.Forms.Button btnRead;
        private System.Windows.Forms.TextBox txtTargetFileLocation;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.RadioButton radioDMSbackend;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button btnConvert;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.OpenFileDialog openExcelFile;
        private System.Windows.Forms.SaveFileDialog saveTargetFile;
    }
}

