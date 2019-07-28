namespace SwitchExtractorTool
{
    partial class Extract
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Extract));
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.Input = new System.Windows.Forms.Button();
            this.Out = new System.Windows.Forms.TextBox();
            this.FileName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tkey = new System.Windows.Forms.TextBox();
            this.ExtractB = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(197, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Result";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(191, 177);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(137, 29);
            this.button1.TabIndex = 1;
            this.button1.Text = "Choose Out Directory";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // Input
            // 
            this.Input.Location = new System.Drawing.Point(191, 87);
            this.Input.Name = "Input";
            this.Input.Size = new System.Drawing.Size(137, 29);
            this.Input.TabIndex = 2;
            this.Input.Text = "Choose Input File";
            this.Input.UseVisualStyleBackColor = true;
            this.Input.Click += new System.EventHandler(this.Button2_Click);
            // 
            // Out
            // 
            this.Out.Location = new System.Drawing.Point(64, 151);
            this.Out.Name = "Out";
            this.Out.Size = new System.Drawing.Size(391, 20);
            this.Out.TabIndex = 3;
            // 
            // FileName
            // 
            this.FileName.Location = new System.Drawing.Point(64, 61);
            this.FileName.Name = "FileName";
            this.FileName.Size = new System.Drawing.Size(391, 20);
            this.FileName.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(233, 221);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 18);
            this.label2.TabIndex = 5;
            this.label2.Text = "TitleKey";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label2.Visible = false;
            // 
            // tkey
            // 
            this.tkey.Location = new System.Drawing.Point(64, 251);
            this.tkey.Name = "tkey";
            this.tkey.Size = new System.Drawing.Size(391, 20);
            this.tkey.TabIndex = 6;
            this.tkey.Visible = false;
            // 
            // ExtractB
            // 
            this.ExtractB.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ExtractB.Location = new System.Drawing.Point(182, 287);
            this.ExtractB.Name = "ExtractB";
            this.ExtractB.Size = new System.Drawing.Size(167, 49);
            this.ExtractB.TabIndex = 7;
            this.ExtractB.Text = "Extract!";
            this.ExtractB.UseVisualStyleBackColor = true;
            this.ExtractB.Click += new System.EventHandler(this.ExtractB_Click);
            // 
            // Extract
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(529, 367);
            this.Controls.Add(this.ExtractB);
            this.Controls.Add(this.tkey);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.FileName);
            this.Controls.Add(this.Out);
            this.Controls.Add(this.Input);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Extract";
            this.Text = "Extracting";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button Input;
        private System.Windows.Forms.TextBox Out;
        private System.Windows.Forms.TextBox FileName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tkey;
        private System.Windows.Forms.Button ExtractB;
    }
}