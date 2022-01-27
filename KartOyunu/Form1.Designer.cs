
namespace KartOyunu
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
            this.btnKaristir = new System.Windows.Forms.Button();
            this.btnGoster = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.LBLscore = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnKaristir
            // 
            this.btnKaristir.Location = new System.Drawing.Point(266, 12);
            this.btnKaristir.Name = "btnKaristir";
            this.btnKaristir.Size = new System.Drawing.Size(216, 77);
            this.btnKaristir.TabIndex = 0;
            this.btnKaristir.Text = "Karıştır";
            this.btnKaristir.UseVisualStyleBackColor = true;
            this.btnKaristir.Click += new System.EventHandler(this.btnKaristir_Click);
            // 
            // btnGoster
            // 
            this.btnGoster.Location = new System.Drawing.Point(266, 324);
            this.btnGoster.Name = "btnGoster";
            this.btnGoster.Size = new System.Drawing.Size(216, 77);
            this.btnGoster.TabIndex = 1;
            this.btnGoster.Text = "Göster";
            this.btnGoster.UseVisualStyleBackColor = true;
            this.btnGoster.Click += new System.EventHandler(this.btnGoster_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(539, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "SCORE :";
            // 
            // LBLscore
            // 
            this.LBLscore.AutoSize = true;
            this.LBLscore.Location = new System.Drawing.Point(590, 44);
            this.LBLscore.Name = "LBLscore";
            this.LBLscore.Size = new System.Drawing.Size(0, 13);
            this.LBLscore.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BackgroundImage = global::KartOyunu.Properties.Resources.pngegg;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(793, 413);
            this.Controls.Add(this.LBLscore);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnGoster);
            this.Controls.Add(this.btnKaristir);
            this.DoubleBuffered = true;
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnKaristir;
        private System.Windows.Forms.Button btnGoster;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label LBLscore;
    }
}

