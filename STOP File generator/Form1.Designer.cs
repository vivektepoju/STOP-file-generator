namespace STOP_File_generator
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.lblPath = new System.Windows.Forms.Label();
            this.txtFilePath = new System.Windows.Forms.TextBox();
            this.btnGenerateStopFile = new System.Windows.Forms.Button();
            this.rtbStatus = new System.Windows.Forms.RichTextBox();
            this.lblCount = new System.Windows.Forms.Label();
            this.chkDeleteFiles = new System.Windows.Forms.CheckBox();
            this.chkNewFormat = new System.Windows.Forms.CheckBox();
            this.chkRegular = new System.Windows.Forms.CheckBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblPath
            // 
            this.lblPath.AutoSize = true;
            this.lblPath.Location = new System.Drawing.Point(13, 26);
            this.lblPath.Name = "lblPath";
            this.lblPath.Size = new System.Drawing.Size(48, 13);
            this.lblPath.TabIndex = 0;
            this.lblPath.Text = "File Path";
            // 
            // txtFilePath
            // 
            this.txtFilePath.Location = new System.Drawing.Point(67, 23);
            this.txtFilePath.Name = "txtFilePath";
            this.txtFilePath.Size = new System.Drawing.Size(379, 20);
            this.txtFilePath.TabIndex = 1;
            // 
            // btnGenerateStopFile
            // 
            this.btnGenerateStopFile.Location = new System.Drawing.Point(176, 72);
            this.btnGenerateStopFile.Name = "btnGenerateStopFile";
            this.btnGenerateStopFile.Size = new System.Drawing.Size(129, 23);
            this.btnGenerateStopFile.TabIndex = 2;
            this.btnGenerateStopFile.Text = "Generate STOP Files";
            this.btnGenerateStopFile.UseVisualStyleBackColor = true;
            this.btnGenerateStopFile.Click += new System.EventHandler(this.BtnGenerateStopFile_Click);
            // 
            // rtbStatus
            // 
            this.rtbStatus.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rtbStatus.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.rtbStatus.Location = new System.Drawing.Point(34, 118);
            this.rtbStatus.Name = "rtbStatus";
            this.rtbStatus.ReadOnly = true;
            this.rtbStatus.Size = new System.Drawing.Size(412, 149);
            this.rtbStatus.TabIndex = 3;
            this.rtbStatus.Text = "";
            // 
            // lblCount
            // 
            this.lblCount.AutoSize = true;
            this.lblCount.Location = new System.Drawing.Point(373, 94);
            this.lblCount.Name = "lblCount";
            this.lblCount.Size = new System.Drawing.Size(44, 13);
            this.lblCount.TabIndex = 4;
            this.lblCount.Text = "Count 0";
            // 
            // chkDeleteFiles
            // 
            this.chkDeleteFiles.AutoSize = true;
            this.chkDeleteFiles.Location = new System.Drawing.Point(34, 61);
            this.chkDeleteFiles.Name = "chkDeleteFiles";
            this.chkDeleteFiles.Size = new System.Drawing.Size(113, 17);
            this.chkDeleteFiles.TabIndex = 5;
            this.chkDeleteFiles.Text = "Delete STOP Files";
            this.chkDeleteFiles.UseVisualStyleBackColor = true;
            this.chkDeleteFiles.CheckedChanged += new System.EventHandler(this.ChkDeleteFiles_CheckedChanged);
            // 
            // chkNewFormat
            // 
            this.chkNewFormat.AutoSize = true;
            this.chkNewFormat.Checked = true;
            this.chkNewFormat.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkNewFormat.Location = new System.Drawing.Point(348, 57);
            this.chkNewFormat.Name = "chkNewFormat";
            this.chkNewFormat.Size = new System.Drawing.Size(83, 17);
            this.chkNewFormat.TabIndex = 6;
            this.chkNewFormat.Text = "New Format";
            this.chkNewFormat.UseVisualStyleBackColor = true;
            this.chkNewFormat.CheckedChanged += new System.EventHandler(this.ChkNewFormat_CheckedChanged);
            // 
            // chkRegular
            // 
            this.chkRegular.AutoSize = true;
            this.chkRegular.Location = new System.Drawing.Point(348, 74);
            this.chkRegular.Name = "chkRegular";
            this.chkRegular.Size = new System.Drawing.Size(63, 17);
            this.chkRegular.TabIndex = 7;
            this.chkRegular.Text = "Regular";
            this.chkRegular.UseVisualStyleBackColor = true;
            this.chkRegular.CheckedChanged += new System.EventHandler(this.ChkRegular_CheckedChanged);
            // 
            // button1
            // 
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(45, 84);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(59, 18);
            this.button1.TabIndex = 8;
            this.button1.Text = "CDL Path";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(478, 305);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.chkRegular);
            this.Controls.Add(this.chkNewFormat);
            this.Controls.Add(this.chkDeleteFiles);
            this.Controls.Add(this.lblCount);
            this.Controls.Add(this.rtbStatus);
            this.Controls.Add(this.btnGenerateStopFile);
            this.Controls.Add(this.txtFilePath);
            this.Controls.Add(this.lblPath);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Stop File Generator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblPath;
        private System.Windows.Forms.TextBox txtFilePath;
        private System.Windows.Forms.Button btnGenerateStopFile;
        private System.Windows.Forms.RichTextBox rtbStatus;
        private System.Windows.Forms.Label lblCount;
        private System.Windows.Forms.CheckBox chkDeleteFiles;
        private System.Windows.Forms.CheckBox chkNewFormat;
        private System.Windows.Forms.CheckBox chkRegular;
        private System.Windows.Forms.Button button1;
    }
}

