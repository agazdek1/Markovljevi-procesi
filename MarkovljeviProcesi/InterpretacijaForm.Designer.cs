namespace MarkovljeviProcesi
{
    partial class InterpretacijaForm
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
            this.rxtIntepretacija = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // rxtIntepretacija
            // 
            this.rxtIntepretacija.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.rxtIntepretacija.Location = new System.Drawing.Point(12, 12);
            this.rxtIntepretacija.Name = "rxtIntepretacija";
            this.rxtIntepretacija.Size = new System.Drawing.Size(654, 178);
            this.rxtIntepretacija.TabIndex = 0;
            this.rxtIntepretacija.Text = "";
            // 
            // InterpretacijaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(676, 201);
            this.Controls.Add(this.rxtIntepretacija);
            this.Name = "InterpretacijaForm";
            this.Text = "Interpretacija";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox rxtIntepretacija;
    }
}