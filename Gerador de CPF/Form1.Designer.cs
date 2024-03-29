namespace Gerador_de_CPF
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
            this.GenerateCpfBtn = new System.Windows.Forms.Button();
            this.CpfValueMasked = new System.Windows.Forms.MaskedTextBox();
            this.SuspendLayout();
            // 
            // GenerateCpfBtn
            // 
            this.GenerateCpfBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GenerateCpfBtn.Location = new System.Drawing.Point(12, 12);
            this.GenerateCpfBtn.Name = "GenerateCpfBtn";
            this.GenerateCpfBtn.Size = new System.Drawing.Size(211, 35);
            this.GenerateCpfBtn.TabIndex = 0;
            this.GenerateCpfBtn.Text = "Gerar CPF";
            this.GenerateCpfBtn.UseVisualStyleBackColor = true;
            this.GenerateCpfBtn.Click += new System.EventHandler(this.GenerateCpfBtn_Click);
            // 
            // CpfValueMasked
            // 
            this.CpfValueMasked.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CpfValueMasked.Location = new System.Drawing.Point(12, 53);
            this.CpfValueMasked.Mask = "000,000,000-00";
            this.CpfValueMasked.Name = "CpfValueMasked";
            this.CpfValueMasked.Size = new System.Drawing.Size(211, 40);
            this.CpfValueMasked.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(235, 105);
            this.Controls.Add(this.CpfValueMasked);
            this.Controls.Add(this.GenerateCpfBtn);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Gerador";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.MaskedTextBox CpfValueMasked;

        private System.Windows.Forms.Button GenerateCpfBtn;

        #endregion
    }
}