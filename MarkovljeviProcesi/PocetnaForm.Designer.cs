namespace MarkovljeviProcesi
{
    partial class PocetnaForm
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
            this.btnPredvidanjeKoristenjaUsluga = new System.Windows.Forms.Button();
            this.btnPrognoziranjeBrojaKorisnika = new System.Windows.Forms.Button();
            this.lblNaslov = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblNaslov2 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnPredvidanjeKoristenjaUsluga
            // 
            this.btnPredvidanjeKoristenjaUsluga.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnPredvidanjeKoristenjaUsluga.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold);
            this.btnPredvidanjeKoristenjaUsluga.Location = new System.Drawing.Point(76, 151);
            this.btnPredvidanjeKoristenjaUsluga.Name = "btnPredvidanjeKoristenjaUsluga";
            this.btnPredvidanjeKoristenjaUsluga.Size = new System.Drawing.Size(202, 77);
            this.btnPredvidanjeKoristenjaUsluga.TabIndex = 0;
            this.btnPredvidanjeKoristenjaUsluga.Text = "Predviđanje korištenja usluga";
            this.btnPredvidanjeKoristenjaUsluga.UseVisualStyleBackColor = false;
            this.btnPredvidanjeKoristenjaUsluga.Click += new System.EventHandler(this.btnPredvidanjeKoristenjaUsluga_Click);
            // 
            // btnPrognoziranjeBrojaKorisnika
            // 
            this.btnPrognoziranjeBrojaKorisnika.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnPrognoziranjeBrojaKorisnika.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold);
            this.btnPrognoziranjeBrojaKorisnika.Location = new System.Drawing.Point(76, 43);
            this.btnPrognoziranjeBrojaKorisnika.Name = "btnPrognoziranjeBrojaKorisnika";
            this.btnPrognoziranjeBrojaKorisnika.Size = new System.Drawing.Size(202, 77);
            this.btnPrognoziranjeBrojaKorisnika.TabIndex = 1;
            this.btnPrognoziranjeBrojaKorisnika.Text = "Prognoziranje broja korisnika";
            this.btnPrognoziranjeBrojaKorisnika.UseVisualStyleBackColor = false;
            this.btnPrognoziranjeBrojaKorisnika.Click += new System.EventHandler(this.btnPrognoziranjeBrojaKorisnika_Click);
            // 
            // lblNaslov
            // 
            this.lblNaslov.AutoSize = true;
            this.lblNaslov.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.lblNaslov.Location = new System.Drawing.Point(197, 34);
            this.lblNaslov.Name = "lblNaslov";
            this.lblNaslov.Size = new System.Drawing.Size(239, 25);
            this.lblNaslov.TabIndex = 2;
            this.lblNaslov.Text = "Aplikacija za rješavanje";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnPrognoziranjeBrojaKorisnika);
            this.groupBox1.Controls.Add(this.btnPredvidanjeKoristenjaUsluga);
            this.groupBox1.Location = new System.Drawing.Point(114, 128);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(339, 253);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Izbornik mogućnosti";
            // 
            // lblNaslov2
            // 
            this.lblNaslov2.AutoSize = true;
            this.lblNaslov2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.lblNaslov2.Location = new System.Drawing.Point(125, 71);
            this.lblNaslov2.Name = "lblNaslov2";
            this.lblNaslov2.Size = new System.Drawing.Size(393, 25);
            this.lblNaslov2.TabIndex = 4;
            this.lblNaslov2.Text = "problema pomoću Markovljevih procesa";
            // 
            // PocetnaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(588, 451);
            this.Controls.Add(this.lblNaslov2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lblNaslov);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.KeyPreview = true;
            this.Name = "PocetnaForm";
            this.Text = "Izbornik";
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.PocetnaForm_KeyUp);
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnPredvidanjeKoristenjaUsluga;
        private System.Windows.Forms.Button btnPrognoziranjeBrojaKorisnika;
        private System.Windows.Forms.Label lblNaslov;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblNaslov2;
    }
}