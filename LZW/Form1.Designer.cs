﻿namespace LZW
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
            this.btnLoad = new System.Windows.Forms.Button();
            this.chkDisplayTokens = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tbPath = new System.Windows.Forms.TextBox();
            this.btnEncode = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.lbIndex = new System.Windows.Forms.ListBox();
            this.btnLoadCompressedFile = new System.Windows.Forms.Button();
            this.btnDecode = new System.Windows.Forms.Button();
            this.tbCompressedPath = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tbTokens = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.chkFreeze = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // btnLoad
            // 
            resources.ApplyResources(this.btnLoad, "btnLoad");
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.UseVisualStyleBackColor = true;
            this.btnLoad.Click += new System.EventHandler(this.btnLoad_Click);
            // 
            // chkDisplayTokens
            // 
            resources.ApplyResources(this.chkDisplayTokens, "chkDisplayTokens");
            this.chkDisplayTokens.Checked = true;
            this.chkDisplayTokens.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkDisplayTokens.Name = "chkDisplayTokens";
            this.chkDisplayTokens.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // tbPath
            // 
            resources.ApplyResources(this.tbPath, "tbPath");
            this.tbPath.Name = "tbPath";
            // 
            // btnEncode
            // 
            resources.ApplyResources(this.btnEncode, "btnEncode");
            this.btnEncode.Name = "btnEncode";
            this.btnEncode.UseVisualStyleBackColor = true;
            this.btnEncode.Click += new System.EventHandler(this.btnEncode_Click);
            // 
            // label3
            // 
            resources.ApplyResources(this.label3, "label3");
            this.label3.Name = "label3";
            // 
            // lbIndex
            // 
            this.lbIndex.FormattingEnabled = true;
            resources.ApplyResources(this.lbIndex, "lbIndex");
            this.lbIndex.Name = "lbIndex";
            // 
            // btnLoadCompressedFile
            // 
            resources.ApplyResources(this.btnLoadCompressedFile, "btnLoadCompressedFile");
            this.btnLoadCompressedFile.Name = "btnLoadCompressedFile";
            this.btnLoadCompressedFile.UseVisualStyleBackColor = true;
            this.btnLoadCompressedFile.Click += new System.EventHandler(this.btnLoadCompressedFile_Click);
            // 
            // btnDecode
            // 
            resources.ApplyResources(this.btnDecode, "btnDecode");
            this.btnDecode.Name = "btnDecode";
            this.btnDecode.UseVisualStyleBackColor = true;
            this.btnDecode.Click += new System.EventHandler(this.btnDecode_Click);
            // 
            // tbCompressedPath
            // 
            resources.ApplyResources(this.tbCompressedPath, "tbCompressedPath");
            this.tbCompressedPath.Name = "tbCompressedPath";
            // 
            // label4
            // 
            resources.ApplyResources(this.label4, "label4");
            this.label4.Name = "label4";
            // 
            // tbTokens
            // 
            resources.ApplyResources(this.tbTokens, "tbTokens");
            this.tbTokens.Name = "tbTokens";
            // 
            // label5
            // 
            resources.ApplyResources(this.label5, "label5");
            this.label5.Name = "label5";
            // 
            // chkFreeze
            // 
            resources.ApplyResources(this.chkFreeze, "chkFreeze");
            this.chkFreeze.Checked = true;
            this.chkFreeze.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkFreeze.Name = "chkFreeze";
            this.chkFreeze.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.Controls.Add(this.chkFreeze);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.tbTokens);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tbCompressedPath);
            this.Controls.Add(this.btnDecode);
            this.Controls.Add(this.btnLoadCompressedFile);
            this.Controls.Add(this.lbIndex);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnEncode);
            this.Controls.Add(this.tbPath);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.chkDisplayTokens);
            this.Controls.Add(this.btnLoad);
            this.Name = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnLoad;
        private System.Windows.Forms.CheckBox chkDisplayTokens;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbPath;
        private System.Windows.Forms.Button btnEncode;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListBox lbIndex;
        private System.Windows.Forms.Button btnLoadCompressedFile;
        private System.Windows.Forms.Button btnDecode;
        private System.Windows.Forms.TextBox tbCompressedPath;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbTokens;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.CheckBox chkFreeze;
    }
}

