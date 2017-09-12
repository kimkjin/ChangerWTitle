namespace byC
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
            this.processText = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.statusName = new System.Windows.Forms.Label();
            this.openFile = new System.Windows.Forms.Button();
            this.nomeFile = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // processText
            // 
            this.processText.Enabled = false;
            this.processText.Location = new System.Drawing.Point(16, 29);
            this.processText.Name = "processText";
            this.processText.Size = new System.Drawing.Size(240, 20);
            this.processText.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(16, 98);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(179, 27);
            this.button1.TabIndex = 1;
            this.button1.Text = "Abrir/Renomear";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(201, 75);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Status:";
            // 
            // statusName
            // 
            this.statusName.AutoSize = true;
            this.statusName.Location = new System.Drawing.Point(238, 75);
            this.statusName.Name = "statusName";
            this.statusName.Size = new System.Drawing.Size(0, 13);
            this.statusName.TabIndex = 3;
            // 
            // openFile
            // 
            this.openFile.Location = new System.Drawing.Point(262, 29);
            this.openFile.Name = "openFile";
            this.openFile.Size = new System.Drawing.Size(58, 20);
            this.openFile.TabIndex = 4;
            this.openFile.Text = "Abrir";
            this.openFile.UseVisualStyleBackColor = true;
            this.openFile.Click += new System.EventHandler(this.openFile_Click);
            // 
            // nomeFile
            // 
            this.nomeFile.Location = new System.Drawing.Point(16, 72);
            this.nomeFile.Name = "nomeFile";
            this.nomeFile.Size = new System.Drawing.Size(179, 20);
            this.nomeFile.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Selecionar .exe";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 56);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Nome da Janela";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ClientSize = new System.Drawing.Size(333, 136);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.nomeFile);
            this.Controls.Add(this.openFile);
            this.Controls.Add(this.statusName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.processText);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Opacity = 0.9D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ByCE";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox processText;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label statusName;
        private System.Windows.Forms.Button openFile;
        private System.Windows.Forms.TextBox nomeFile;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}

