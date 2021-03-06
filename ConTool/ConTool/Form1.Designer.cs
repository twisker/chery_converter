﻿namespace ConTool
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.tableMain = new System.Windows.Forms.TableLayoutPanel();
            this.btnChooseMappingSheet = new System.Windows.Forms.Button();
            this.btnChooseErrorLog = new System.Windows.Forms.Button();
            this.txtMappingSheet = new System.Windows.Forms.TextBox();
            this.txtErrorLog = new System.Windows.Forms.TextBox();
            this.txtOriginFileLocation = new System.Windows.Forms.TextBox();
            this.btnRead = new System.Windows.Forms.Button();
            this.txtTargetFileLocation = new System.Windows.Forms.TextBox();
            this.btnTargetFile = new System.Windows.Forms.Button();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.btnConvert = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.flowParameters = new System.Windows.Forms.FlowLayoutPanel();
            this.labelMaxCol = new System.Windows.Forms.Label();
            this.numMaxCol = new System.Windows.Forms.NumericUpDown();
            this.labelMaxRow = new System.Windows.Forms.Label();
            this.numMaxRow = new System.Windows.Forms.NumericUpDown();
            this.lblSeperator = new System.Windows.Forms.Label();
            this.txtSeperator = new System.Windows.Forms.TextBox();
            this.progressConverting = new System.Windows.Forms.ProgressBar();
            this.groupInputFileFormat = new System.Windows.Forms.GroupBox();
            this.radioMan0501 = new System.Windows.Forms.RadioButton();
            this.radioDMSbackend = new System.Windows.Forms.RadioButton();
            this.radioManual = new System.Windows.Forms.RadioButton();
            this.openExcelFile = new System.Windows.Forms.OpenFileDialog();
            this.saveTargetFile = new System.Windows.Forms.SaveFileDialog();
            this.timerProgress = new System.Windows.Forms.Timer(this.components);
            this.tableMain.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.flowParameters.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numMaxCol)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numMaxRow)).BeginInit();
            this.groupInputFileFormat.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableMain
            // 
            resources.ApplyResources(this.tableMain, "tableMain");
            this.tableMain.Controls.Add(this.btnChooseMappingSheet, 1, 3);
            this.tableMain.Controls.Add(this.btnChooseErrorLog, 1, 2);
            this.tableMain.Controls.Add(this.txtMappingSheet, 0, 3);
            this.tableMain.Controls.Add(this.txtErrorLog, 0, 2);
            this.tableMain.Controls.Add(this.txtOriginFileLocation, 0, 0);
            this.tableMain.Controls.Add(this.btnRead, 1, 0);
            this.tableMain.Controls.Add(this.txtTargetFileLocation, 0, 1);
            this.tableMain.Controls.Add(this.btnTargetFile, 1, 1);
            this.tableMain.Controls.Add(this.flowLayoutPanel1, 1, 6);
            this.tableMain.Controls.Add(this.flowParameters, 0, 4);
            this.tableMain.Controls.Add(this.progressConverting, 0, 5);
            this.tableMain.Controls.Add(this.groupInputFileFormat, 0, 6);
            this.tableMain.Name = "tableMain";
            // 
            // btnChooseMappingSheet
            // 
            resources.ApplyResources(this.btnChooseMappingSheet, "btnChooseMappingSheet");
            this.btnChooseMappingSheet.Name = "btnChooseMappingSheet";
            this.btnChooseMappingSheet.UseVisualStyleBackColor = true;
            this.btnChooseMappingSheet.Click += new System.EventHandler(this.btnChooseMappingSheet_Click);
            // 
            // btnChooseErrorLog
            // 
            resources.ApplyResources(this.btnChooseErrorLog, "btnChooseErrorLog");
            this.btnChooseErrorLog.Name = "btnChooseErrorLog";
            this.btnChooseErrorLog.UseVisualStyleBackColor = true;
            this.btnChooseErrorLog.Click += new System.EventHandler(this.btnChooseErrorLog_Click);
            // 
            // txtMappingSheet
            // 
            resources.ApplyResources(this.txtMappingSheet, "txtMappingSheet");
            this.txtMappingSheet.Name = "txtMappingSheet";
            // 
            // txtErrorLog
            // 
            resources.ApplyResources(this.txtErrorLog, "txtErrorLog");
            this.txtErrorLog.Name = "txtErrorLog";
            // 
            // txtOriginFileLocation
            // 
            resources.ApplyResources(this.txtOriginFileLocation, "txtOriginFileLocation");
            this.txtOriginFileLocation.Name = "txtOriginFileLocation";
            this.txtOriginFileLocation.TextChanged += new System.EventHandler(this.FileNames_changed);
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
            this.txtTargetFileLocation.TextChanged += new System.EventHandler(this.FileNames_changed);
            // 
            // btnTargetFile
            // 
            resources.ApplyResources(this.btnTargetFile, "btnTargetFile");
            this.btnTargetFile.Name = "btnTargetFile";
            this.btnTargetFile.UseVisualStyleBackColor = true;
            this.btnTargetFile.Click += new System.EventHandler(this.btnTargetFile_Click);
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
            this.btnConvert.Click += new System.EventHandler(this.btnConvert_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            resources.ApplyResources(this.btnCancel, "btnCancel");
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // flowParameters
            // 
            this.tableMain.SetColumnSpan(this.flowParameters, 2);
            this.flowParameters.Controls.Add(this.labelMaxCol);
            this.flowParameters.Controls.Add(this.numMaxCol);
            this.flowParameters.Controls.Add(this.labelMaxRow);
            this.flowParameters.Controls.Add(this.numMaxRow);
            this.flowParameters.Controls.Add(this.lblSeperator);
            this.flowParameters.Controls.Add(this.txtSeperator);
            resources.ApplyResources(this.flowParameters, "flowParameters");
            this.flowParameters.Name = "flowParameters";
            // 
            // labelMaxCol
            // 
            resources.ApplyResources(this.labelMaxCol, "labelMaxCol");
            this.labelMaxCol.Name = "labelMaxCol";
            // 
            // numMaxCol
            // 
            resources.ApplyResources(this.numMaxCol, "numMaxCol");
            this.numMaxCol.Maximum = new decimal(new int[] {
            300,
            0,
            0,
            0});
            this.numMaxCol.Name = "numMaxCol";
            this.numMaxCol.Value = new decimal(new int[] {
            107,
            0,
            0,
            0});
            // 
            // labelMaxRow
            // 
            resources.ApplyResources(this.labelMaxRow, "labelMaxRow");
            this.labelMaxRow.Name = "labelMaxRow";
            // 
            // numMaxRow
            // 
            resources.ApplyResources(this.numMaxRow, "numMaxRow");
            this.numMaxRow.Maximum = new decimal(new int[] {
            70000,
            0,
            0,
            0});
            this.numMaxRow.Name = "numMaxRow";
            this.numMaxRow.Value = new decimal(new int[] {
            70000,
            0,
            0,
            0});
            // 
            // lblSeperator
            // 
            resources.ApplyResources(this.lblSeperator, "lblSeperator");
            this.lblSeperator.Name = "lblSeperator";
            // 
            // txtSeperator
            // 
            resources.ApplyResources(this.txtSeperator, "txtSeperator");
            this.txtSeperator.Name = "txtSeperator";
            // 
            // progressConverting
            // 
            this.tableMain.SetColumnSpan(this.progressConverting, 2);
            resources.ApplyResources(this.progressConverting, "progressConverting");
            this.progressConverting.Name = "progressConverting";
            // 
            // groupInputFileFormat
            // 
            this.groupInputFileFormat.Controls.Add(this.radioMan0501);
            this.groupInputFileFormat.Controls.Add(this.radioDMSbackend);
            this.groupInputFileFormat.Controls.Add(this.radioManual);
            resources.ApplyResources(this.groupInputFileFormat, "groupInputFileFormat");
            this.groupInputFileFormat.Name = "groupInputFileFormat";
            this.groupInputFileFormat.TabStop = false;
            // 
            // radioMan0501
            // 
            resources.ApplyResources(this.radioMan0501, "radioMan0501");
            this.radioMan0501.Checked = true;
            this.radioMan0501.Name = "radioMan0501";
            this.radioMan0501.TabStop = true;
            this.radioMan0501.UseVisualStyleBackColor = true;
            // 
            // radioDMSbackend
            // 
            resources.ApplyResources(this.radioDMSbackend, "radioDMSbackend");
            this.radioDMSbackend.Name = "radioDMSbackend";
            this.radioDMSbackend.UseVisualStyleBackColor = true;
            // 
            // radioManual
            // 
            resources.ApplyResources(this.radioManual, "radioManual");
            this.radioManual.Name = "radioManual";
            this.radioManual.UseVisualStyleBackColor = true;
            // 
            // openExcelFile
            // 
            this.openExcelFile.DefaultExt = "xlsx";
            this.openExcelFile.FileName = "*.xlsx";
            resources.ApplyResources(this.openExcelFile, "openExcelFile");
            // 
            // saveTargetFile
            // 
            this.saveTargetFile.DefaultExt = "csv";
            this.saveTargetFile.FileName = "yMKT_upload.csv";
            resources.ApplyResources(this.saveTargetFile, "saveTargetFile");
            // 
            // timerProgress
            // 
            this.timerProgress.Tick += new System.EventHandler(this.progress_ticking);
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
            this.flowParameters.ResumeLayout(false);
            this.flowParameters.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numMaxCol)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numMaxRow)).EndInit();
            this.groupInputFileFormat.ResumeLayout(false);
            this.groupInputFileFormat.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableMain;
        private System.Windows.Forms.TextBox txtOriginFileLocation;
        private System.Windows.Forms.Button btnRead;
        private System.Windows.Forms.TextBox txtTargetFileLocation;
        private System.Windows.Forms.Button btnTargetFile;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button btnConvert;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.OpenFileDialog openExcelFile;
        private System.Windows.Forms.SaveFileDialog saveTargetFile;
        private System.Windows.Forms.FlowLayoutPanel flowParameters;
        private System.Windows.Forms.Label labelMaxCol;
        private System.Windows.Forms.NumericUpDown numMaxCol;
        private System.Windows.Forms.Label labelMaxRow;
        private System.Windows.Forms.NumericUpDown numMaxRow;
        private System.Windows.Forms.Label lblSeperator;
        private System.Windows.Forms.TextBox txtSeperator;
        private System.Windows.Forms.ProgressBar progressConverting;
        private System.Windows.Forms.Timer timerProgress;
        private System.Windows.Forms.Button btnChooseMappingSheet;
        private System.Windows.Forms.Button btnChooseErrorLog;
        private System.Windows.Forms.TextBox txtMappingSheet;
        private System.Windows.Forms.TextBox txtErrorLog;
        private System.Windows.Forms.GroupBox groupInputFileFormat;
        private System.Windows.Forms.RadioButton radioDMSbackend;
        private System.Windows.Forms.RadioButton radioManual;
        private System.Windows.Forms.RadioButton radioMan0501;
    }
}

