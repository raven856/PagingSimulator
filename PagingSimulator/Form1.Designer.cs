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
            this.label2 = new System.Windows.Forms.Label();
            this.btnFIFO = new System.Windows.Forms.Button();
            this.btnNext = new System.Windows.Forms.Button();
            this.cmbFrames = new System.Windows.Forms.ComboBox();
            this.btnLFU = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(754, 17);
            this.label2.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 25);
            this.label2.TabIndex = 2;
            // 
            // btnFIFO
            // 
            this.btnFIFO.Location = new System.Drawing.Point(504, 671);
            this.btnFIFO.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.btnFIFO.Name = "btnFIFO";
            this.btnFIFO.Size = new System.Drawing.Size(150, 44);
            this.btnFIFO.TabIndex = 3;
            this.btnFIFO.Text = "New FIFO";
            this.btnFIFO.UseVisualStyleBackColor = true;
            this.btnFIFO.Click += new System.EventHandler(this.btnFIFO_Click);
            // 
            // btnNext
            // 
            this.btnNext.Location = new System.Drawing.Point(680, 730);
            this.btnNext.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(150, 44);
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
            this.cmbFrames.Location = new System.Drawing.Point(708, 674);
            this.cmbFrames.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.cmbFrames.Name = "cmbFrames";
            this.cmbFrames.Size = new System.Drawing.Size(84, 33);
            this.cmbFrames.TabIndex = 5;
            // 
            // btnLFU
            // 
            this.btnLFU.Location = new System.Drawing.Point(856, 674);
            this.btnLFU.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.btnLFU.Name = "btnLFU";
            this.btnLFU.Size = new System.Drawing.Size(150, 44);
            this.btnLFU.TabIndex = 6;
            this.btnLFU.Text = "New LFU";
            this.btnLFU.UseVisualStyleBackColor = true;
            this.btnLFU.Click += new System.EventHandler(this.btnLFU_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1612, 852);
            this.Controls.Add(this.btnLFU);
            this.Controls.Add(this.cmbFrames);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.btnFIFO);
            this.Controls.Add(this.label2);
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Shown += new System.EventHandler(this.OnLoad);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnFIFO;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.ComboBox cmbFrames;
        private System.Windows.Forms.Button btnLFU;
    }
}

