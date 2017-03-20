namespace PagingSimulator
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
            this.button2 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.btnFIFO = new System.Windows.Forms.Button();
            this.btnNext = new System.Windows.Forms.Button();
            this.cmbFrames = new System.Windows.Forms.ComboBox();
            this.btnLFU = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(576, 408);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 1;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(377, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "label1";
            // 
            // btnFIFO
            // 
            this.btnFIFO.Location = new System.Drawing.Point(252, 344);
            this.btnFIFO.Name = "btnFIFO";
            this.btnFIFO.Size = new System.Drawing.Size(75, 23);
            this.btnFIFO.TabIndex = 3;
            this.btnFIFO.Text = "New FIFO";
            this.btnFIFO.UseVisualStyleBackColor = true;
            this.btnFIFO.Click += new System.EventHandler(this.btnFIFO_Click);
            // 
            // btnNext
            // 
            this.btnNext.Location = new System.Drawing.Point(337, 375);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(75, 23);
            this.btnNext.TabIndex = 4;
            this.btnNext.Text = "Next";
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // cmbFrames
            // 
            this.cmbFrames.FormattingEnabled = true;
            this.cmbFrames.Items.AddRange(new object[] {
            "3",
            "4",
            "5"});
            this.cmbFrames.Location = new System.Drawing.Point(354, 346);
            this.cmbFrames.Name = "cmbFrames";
            this.cmbFrames.Size = new System.Drawing.Size(44, 21);
            this.cmbFrames.TabIndex = 5;
            // 
            // btnLFU
            // 
            this.btnLFU.Location = new System.Drawing.Point(428, 346);
            this.btnLFU.Name = "btnLFU";
            this.btnLFU.Size = new System.Drawing.Size(75, 23);
            this.btnLFU.TabIndex = 6;
            this.btnLFU.Text = "New LFU";
            this.btnLFU.UseVisualStyleBackColor = true;
            this.btnLFU.Click += new System.EventHandler(this.btnLFU_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(806, 443);
            this.Controls.Add(this.btnLFU);
            this.Controls.Add(this.cmbFrames);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.btnFIFO);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Shown += new System.EventHandler(this.OnLoad);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnFIFO;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.ComboBox cmbFrames;
        private System.Windows.Forms.Button btnLFU;
    }
}

