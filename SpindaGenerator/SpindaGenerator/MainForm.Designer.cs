namespace SpindaGenerator
{
    partial class MainForm
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
            this.radioGen4 = new System.Windows.Forms.RadioButton();
            this.radioGen5 = new System.Windows.Forms.RadioButton();
            this.radioGen6 = new System.Windows.Forms.RadioButton();
            this.buttonGenerate = new System.Windows.Forms.Button();
            this.textOutputPath = new System.Windows.Forms.TextBox();
            this.buttonPickFolder = new System.Windows.Forms.Button();
            this.groupGeneration = new System.Windows.Forms.GroupBox();
            this.groupOutputPath = new System.Windows.Forms.GroupBox();
            this.loadSpinda = new System.Windows.Forms.Button();
            this.labelLoadedSpinda = new System.Windows.Forms.Label();
            this.buttonClearFile = new System.Windows.Forms.Button();
            this.groupGeneration.SuspendLayout();
            this.groupOutputPath.SuspendLayout();
            this.SuspendLayout();
            // 
            // radioGen4
            // 
            this.radioGen4.AutoSize = true;
            this.radioGen4.Checked = true;
            this.radioGen4.Location = new System.Drawing.Point(6, 19);
            this.radioGen4.Name = "radioGen4";
            this.radioGen4.Size = new System.Drawing.Size(90, 17);
            this.radioGen4.TabIndex = 0;
            this.radioGen4.TabStop = true;
            this.radioGen4.Text = "Generation IV";
            this.radioGen4.UseVisualStyleBackColor = true;
            this.radioGen4.CheckedChanged += new System.EventHandler(this.radioGen4_CheckedChanged);
            // 
            // radioGen5
            // 
            this.radioGen5.AutoSize = true;
            this.radioGen5.Location = new System.Drawing.Point(6, 42);
            this.radioGen5.Name = "radioGen5";
            this.radioGen5.Size = new System.Drawing.Size(87, 17);
            this.radioGen5.TabIndex = 1;
            this.radioGen5.Text = "Generation V";
            this.radioGen5.UseVisualStyleBackColor = true;
            this.radioGen5.CheckedChanged += new System.EventHandler(this.radioGen5_CheckedChanged);
            // 
            // radioGen6
            // 
            this.radioGen6.AutoSize = true;
            this.radioGen6.Location = new System.Drawing.Point(6, 65);
            this.radioGen6.Name = "radioGen6";
            this.radioGen6.Size = new System.Drawing.Size(90, 17);
            this.radioGen6.TabIndex = 2;
            this.radioGen6.Text = "Generation VI";
            this.radioGen6.UseVisualStyleBackColor = true;
            this.radioGen6.CheckedChanged += new System.EventHandler(this.radioGen6_CheckedChanged);
            // 
            // buttonGenerate
            // 
            this.buttonGenerate.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonGenerate.Location = new System.Drawing.Point(12, 130);
            this.buttonGenerate.Name = "buttonGenerate";
            this.buttonGenerate.Size = new System.Drawing.Size(321, 51);
            this.buttonGenerate.TabIndex = 5;
            this.buttonGenerate.Text = "Generate";
            this.buttonGenerate.UseVisualStyleBackColor = true;
            this.buttonGenerate.Click += new System.EventHandler(this.buttonGenerate_Click);
            // 
            // textOutputPath
            // 
            this.textOutputPath.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textOutputPath.Location = new System.Drawing.Point(6, 19);
            this.textOutputPath.Name = "textOutputPath";
            this.textOutputPath.Size = new System.Drawing.Size(161, 20);
            this.textOutputPath.TabIndex = 0;
            // 
            // buttonPickFolder
            // 
            this.buttonPickFolder.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonPickFolder.AutoSize = true;
            this.buttonPickFolder.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.buttonPickFolder.Location = new System.Drawing.Point(173, 17);
            this.buttonPickFolder.Name = "buttonPickFolder";
            this.buttonPickFolder.Size = new System.Drawing.Size(26, 23);
            this.buttonPickFolder.TabIndex = 1;
            this.buttonPickFolder.Text = "...";
            this.buttonPickFolder.UseVisualStyleBackColor = true;
            this.buttonPickFolder.Click += new System.EventHandler(this.buttonPickFolder_Click);
            // 
            // groupGeneration
            // 
            this.groupGeneration.Controls.Add(this.radioGen4);
            this.groupGeneration.Controls.Add(this.radioGen5);
            this.groupGeneration.Controls.Add(this.radioGen6);
            this.groupGeneration.Location = new System.Drawing.Point(13, 12);
            this.groupGeneration.Name = "groupGeneration";
            this.groupGeneration.Size = new System.Drawing.Size(109, 93);
            this.groupGeneration.TabIndex = 0;
            this.groupGeneration.TabStop = false;
            this.groupGeneration.Text = "Generation";
            // 
            // groupOutputPath
            // 
            this.groupOutputPath.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupOutputPath.Controls.Add(this.textOutputPath);
            this.groupOutputPath.Controls.Add(this.buttonPickFolder);
            this.groupOutputPath.Location = new System.Drawing.Point(128, 12);
            this.groupOutputPath.Name = "groupOutputPath";
            this.groupOutputPath.Size = new System.Drawing.Size(205, 54);
            this.groupOutputPath.TabIndex = 1;
            this.groupOutputPath.TabStop = false;
            this.groupOutputPath.Text = "Output Path";
            // 
            // loadSpinda
            // 
            this.loadSpinda.AutoSize = true;
            this.loadSpinda.Location = new System.Drawing.Point(128, 72);
            this.loadSpinda.Name = "loadSpinda";
            this.loadSpinda.Size = new System.Drawing.Size(86, 23);
            this.loadSpinda.TabIndex = 2;
            this.loadSpinda.Text = "Load a Spinda";
            this.loadSpinda.UseVisualStyleBackColor = true;
            this.loadSpinda.Click += new System.EventHandler(this.loadSpinda_Click);
            // 
            // labelLoadedSpinda
            // 
            this.labelLoadedSpinda.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelLoadedSpinda.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelLoadedSpinda.Location = new System.Drawing.Point(220, 77);
            this.labelLoadedSpinda.Name = "labelLoadedSpinda";
            this.labelLoadedSpinda.Size = new System.Drawing.Size(113, 47);
            this.labelLoadedSpinda.TabIndex = 3;
            this.labelLoadedSpinda.Text = "LoadedSpinda";
            // 
            // buttonClearFile
            // 
            this.buttonClearFile.Location = new System.Drawing.Point(128, 101);
            this.buttonClearFile.Name = "buttonClearFile";
            this.buttonClearFile.Size = new System.Drawing.Size(86, 23);
            this.buttonClearFile.TabIndex = 4;
            this.buttonClearFile.Text = "Clear File";
            this.buttonClearFile.UseVisualStyleBackColor = true;
            this.buttonClearFile.Click += new System.EventHandler(this.buttonClearFile_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(345, 193);
            this.Controls.Add(this.buttonClearFile);
            this.Controls.Add(this.labelLoadedSpinda);
            this.Controls.Add(this.loadSpinda);
            this.Controls.Add(this.groupOutputPath);
            this.Controls.Add(this.groupGeneration);
            this.Controls.Add(this.buttonGenerate);
            this.Name = "MainForm";
            this.Text = "Spinda Generator";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.groupGeneration.ResumeLayout(false);
            this.groupGeneration.PerformLayout();
            this.groupOutputPath.ResumeLayout(false);
            this.groupOutputPath.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton radioGen4;
        private System.Windows.Forms.RadioButton radioGen5;
        private System.Windows.Forms.RadioButton radioGen6;
        private System.Windows.Forms.Button buttonGenerate;
        private System.Windows.Forms.TextBox textOutputPath;
        private System.Windows.Forms.Button buttonPickFolder;
        private System.Windows.Forms.GroupBox groupGeneration;
        private System.Windows.Forms.GroupBox groupOutputPath;
        private System.Windows.Forms.Button loadSpinda;
        private System.Windows.Forms.Label labelLoadedSpinda;
        private System.Windows.Forms.Button buttonClearFile;
    }
}

