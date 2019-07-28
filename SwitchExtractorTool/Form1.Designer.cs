namespace SwitchExtractorTool
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
            this.nca = new System.Windows.Forms.Button();
            this.convertXCI = new System.Windows.Forms.Button();
            this.nsp = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // nca
            // 
            this.nca.Location = new System.Drawing.Point(46, 153);
            this.nca.Name = "nca";
            this.nca.Size = new System.Drawing.Size(142, 47);
            this.nca.TabIndex = 5;
            this.nca.Text = "Extract Encrypted NCA (From NSP)";
            this.nca.UseVisualStyleBackColor = true;
            this.nca.Click += new System.EventHandler(this.Nca_Click);
            // 
            // convertXCI
            // 
            this.convertXCI.Location = new System.Drawing.Point(31, 100);
            this.convertXCI.Name = "convertXCI";
            this.convertXCI.Size = new System.Drawing.Size(157, 47);
            this.convertXCI.TabIndex = 6;
            this.convertXCI.Text = "Extract XCI";
            this.convertXCI.UseVisualStyleBackColor = true;
            this.convertXCI.Click += new System.EventHandler(this.ConvertXCI_Click);
            // 
            // nsp
            // 
            this.nsp.Location = new System.Drawing.Point(194, 153);
            this.nsp.Name = "nsp";
            this.nsp.Size = new System.Drawing.Size(142, 47);
            this.nsp.TabIndex = 7;
            this.nsp.Text = "Extract Unencrypted NCA (From XCI)";
            this.nsp.UseVisualStyleBackColor = true;
            this.nsp.Click += new System.EventHandler(this.Nsp_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(364, 31);
            this.label1.TabIndex = 8;
            this.label1.Text = "What do you want to extract?";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(194, 100);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(157, 47);
            this.button1.TabIndex = 9;
            this.button1.Text = "Extract NSP";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click_1);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(389, 270);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.nsp);
            this.Controls.Add(this.convertXCI);
            this.Controls.Add(this.nca);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Switch Game Extractor Tool";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button nca;
        private System.Windows.Forms.Button convertXCI;
        private System.Windows.Forms.Button nsp;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
    }
}

