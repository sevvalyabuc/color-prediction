namespace renkTahmin
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Text = "Form1";
            this.panel1 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.lblPuan = new System.Windows.Forms.Label();
            this.lblKalanHak = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pnlHedefRenk = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.pnlSecilenRenk = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnYeniOyun = new System.Windows.Forms.Button();
            this.btnTahminEt = new System.Windows.Forms.Button();
            this.lblB = new System.Windows.Forms.Label();
            this.trackBarB = new System.Windows.Forms.TrackBar();
            this.lblG = new System.Windows.Forms.Label();
            this.trackBarG = new System.Windows.Forms.TrackBar();
            this.lblR = new System.Windows.Forms.Label();
            this.trackBarR = new System.Windows.Forms.TrackBar();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarR)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarG)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarB)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(52)))), ((int)(((byte)(54)))));
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.lblPuan);
            this.panel1.Controls.Add(this.lblKalanHak);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(684, 100);
            this.panel1.TabIndex = 0;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.Color.Silver;
            this.label4.Location = new System.Drawing.Point(12, 71);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(301, 15);
            this.label4.TabIndex = 3;
            this.label4.Text = "RGB değerlerini ayarlayıp hedef rengi bulmaya çalışmalısın";
            // 
            // lblPuan
            // 
            this.lblPuan.AutoSize = true;
            this.lblPuan.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblPuan.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(234)))), ((int)(((byte)(167)))));
            this.lblPuan.Location = new System.Drawing.Point(576, 71);
            this.lblPuan.Name = "lblPuan";
            this.lblPuan.Size = new System.Drawing.Size(65, 21);
            this.lblPuan.TabIndex = 2;
            this.lblPuan.Text = "Puan: 0";
            // 
            // lblKalanHak
            // 
            this.lblKalanHak.AutoSize = true;
            this.lblKalanHak.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblKalanHak.ForeColor = System.Drawing.Color.White;
            this.lblKalanHak.Location = new System.Drawing.Point(576, 34);
            this.lblKalanHak.Name = "lblKalanHak";
            this.lblKalanHak.Size = new System.Drawing.Size(96, 21);
            this.lblKalanHak.TabIndex = 1;
            this.lblKalanHak.Text = "Kalan Hak: ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(184)))), ((int)(((byte)(148)))));
            this.label1.Location = new System.Drawing.Point(3, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(326, 40);
            this.label1.TabIndex = 0;
            this.label1.Text = "SÜPER RENK TAHMİNİ";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(59)))), ((int)(((byte)(72)))));
            this.panel2.Controls.Add(this.pnlHedefRenk);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.pnlSecilenRenk);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 100);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(684, 149);
            this.panel2.TabIndex = 1;
            // 
            // pnlHedefRenk
            // 
            this.pnlHedefRenk.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlHedefRenk.Location = new System.Drawing.Point(487, 58);
            this.pnlHedefRenk.Name = "pnlHedefRenk";
            this.pnlHedefRenk.Size = new System.Drawing.Size(95, 75);
            this.pnlHedefRenk.TabIndex = 3;
            this.pnlHedefRenk.Visible = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(196)))), ((int)(((byte)(15)))));
            this.label3.Location = new System.Drawing.Point(487, 32);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(95, 21);
            this.label3.TabIndex = 2;
            this.label3.Text = "Hedef Renk";
            // 
            // pnlSecilenRenk
            // 
            this.pnlSecilenRenk.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlSecilenRenk.Location = new System.Drawing.Point(94, 58);
            this.pnlSecilenRenk.Name = "pnlSecilenRenk";
            this.pnlSecilenRenk.Size = new System.Drawing.Size(95, 75);
            this.pnlSecilenRenk.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(196)))), ((int)(((byte)(15)))));
            this.label2.Location = new System.Drawing.Point(94, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(104, 21);
            this.label2.TabIndex = 0;
            this.label2.Text = "Seçilen Renk";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(47)))), ((int)(((byte)(62)))));
            this.panel3.Controls.Add(this.btnYeniOyun);
            this.panel3.Controls.Add(this.btnTahminEt);
            this.panel3.Controls.Add(this.lblB);
            this.panel3.Controls.Add(this.trackBarB);
            this.panel3.Controls.Add(this.lblG);
            this.panel3.Controls.Add(this.trackBarG);
            this.panel3.Controls.Add(this.lblR);
            this.panel3.Controls.Add(this.trackBarR);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(0, 249);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(684, 242);
            this.panel3.TabIndex = 2;
            // 
            // btnYeniOyun
            // 
            this.btnYeniOyun.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(60)))), ((int)(((byte)(117)))));
            this.btnYeniOyun.FlatAppearance.BorderSize = 0;
            this.btnYeniOyun.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnYeniOyun.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnYeniOyun.ForeColor = System.Drawing.Color.White;
            this.btnYeniOyun.Location = new System.Drawing.Point(418, 188);
            this.btnYeniOyun.Name = "btnYeniOyun";
            this.btnYeniOyun.Size = new System.Drawing.Size(129, 42);
            this.btnYeniOyun.TabIndex = 7;
            this.btnYeniOyun.Text = "Yeni Oyun";
            this.btnYeniOyun.UseVisualStyleBackColor = false;
            this.btnYeniOyun.Click += new System.EventHandler(this.btnYeniOyun_Click);
            // 
            // btnTahminEt
            // 
            this.btnTahminEt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(184)))), ((int)(((byte)(148)))));
            this.btnTahminEt.FlatAppearance.BorderSize = 0;
            this.btnTahminEt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTahminEt.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnTahminEt.ForeColor = System.Drawing.Color.White;
            this.btnTahminEt.Location = new System.Drawing.Point(246, 188);
            this.btnTahminEt.Name = "btnTahminEt";
            this.btnTahminEt.Size = new System.Drawing.Size(155, 42);
            this.btnTahminEt.TabIndex = 6;
            this.btnTahminEt.Text = "TAHMİN ET!";
            this.btnTahminEt.UseVisualStyleBackColor = false;
            this.btnTahminEt.Click += new System.EventHandler(this.btnTahminEt_Click);
            // 
            // lblB
            // 
            this.lblB.AutoSize = true;
            this.lblB.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblB.ForeColor = System.Drawing.Color.LightSkyBlue;
            this.lblB.Location = new System.Drawing.Point(36, 140);
            this.lblB.Name = "lblB";
            this.lblB.Size = new System.Drawing.Size(38, 21);
            this.lblB.TabIndex = 5;
            this.lblB.Text = "B: 0";
            // 
            // trackBarB
            // 
            this.trackBarB.Location = new System.Drawing.Point(94, 140);
            this.trackBarB.Maximum = 255;
            this.trackBarB.Name = "trackBarB";
            this.trackBarB.Size = new System.Drawing.Size(488, 45);
            this.trackBarB.TabIndex = 4;
            this.trackBarB.Scroll += new System.EventHandler(this.trackBarB_Scroll);
            // 
            // lblG
            // 
            this.lblG.AutoSize = true;
            this.lblG.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblG.ForeColor = System.Drawing.Color.LightGreen;
            this.lblG.Location = new System.Drawing.Point(36, 89);
            this.lblG.Name = "lblG";
            this.lblG.Size = new System.Drawing.Size(38, 21);
            this.lblG.TabIndex = 3;
            this.lblG.Text = "G: 0";
            // 
            // trackBarG
            // 
            this.trackBarG.Location = new System.Drawing.Point(94, 89);
            this.trackBarG.Maximum = 255;
            this.trackBarG.Name = "trackBarG";
            this.trackBarG.Size = new System.Drawing.Size(488, 45);
            this.trackBarG.TabIndex = 2;
            this.trackBarG.Scroll += new System.EventHandler(this.trackBarG_Scroll);
            // 
            // lblR
            // 
            this.lblR.AutoSize = true;
            this.lblR.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblR.ForeColor = System.Drawing.Color.IndianRed;
            this.lblR.Location = new System.Drawing.Point(36, 38);
            this.lblR.Name = "lblR";
            this.lblR.Size = new System.Drawing.Size(38, 21);
            this.lblR.TabIndex = 1;
            this.lblR.Text = "R: 0";
            // 
            // trackBarR
            // 
            this.trackBarR.Location = new System.Drawing.Point(94, 38);
            this.trackBarR.Maximum = 255;
            this.trackBarR.Name = "trackBarR";
            this.trackBarR.Size = new System.Drawing.Size(488, 45);
            this.trackBarR.TabIndex = 0;
            this.trackBarR.Scroll += new System.EventHandler(this.trackBarR_Scroll);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(684, 491);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarR)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarG)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarB)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panel1;
        private Label lblPuan;
        private Label lblKalanHak;
        private Label label1;
        private Panel panel2;
        private Panel pnlHedefRenk;
        private Label label3;
        private Panel pnlSecilenRenk;
        private Label label2;
        private Panel panel3;
        private Button btnYeniOyun;
        private Button btnTahminEt;
        private Label lblB;
        private TrackBar trackBarB;
        private Label lblG;
        private TrackBar trackBarG;
        private Label lblR;
        private TrackBar trackBarR;
        private Label label4;
    }
}
