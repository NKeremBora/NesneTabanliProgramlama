
namespace odev
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.mtxtBaslangic = new System.Windows.Forms.MaskedTextBox();
            this.mtxtBitis = new System.Windows.Forms.MaskedTextBox();
            this.lblBaslangic = new System.Windows.Forms.Label();
            this.lblBitis = new System.Windows.Forms.Label();
            this.btnCalistir = new System.Windows.Forms.Button();
            this.gbGirisBIlgileri = new System.Windows.Forms.GroupBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.lvCiftSayi = new System.Windows.Forms.ListView();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.lvTekSayi = new System.Windows.Forms.ListView();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.lvAsalSayi = new System.Windows.Forms.ListView();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.lvMukemmelSayi = new System.Windows.Forms.ListView();
            this.nlHesapMakinesi = new System.Windows.Forms.NotifyIcon(this.components);
            this.gbGirisBIlgileri.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.tabPage4.SuspendLayout();
            this.SuspendLayout();
            // 
            // mtxtBaslangic
            // 
            this.mtxtBaslangic.Location = new System.Drawing.Point(143, 37);
            this.mtxtBaslangic.Name = "mtxtBaslangic";
            this.mtxtBaslangic.Size = new System.Drawing.Size(125, 27);
            this.mtxtBaslangic.TabIndex = 0;
            // 
            // mtxtBitis
            // 
            this.mtxtBitis.Location = new System.Drawing.Point(363, 36);
            this.mtxtBitis.Name = "mtxtBitis";
            this.mtxtBitis.Size = new System.Drawing.Size(125, 27);
            this.mtxtBitis.TabIndex = 1;
            // 
            // lblBaslangic
            // 
            this.lblBaslangic.AutoSize = true;
            this.lblBaslangic.Location = new System.Drawing.Point(45, 44);
            this.lblBaslangic.Name = "lblBaslangic";
            this.lblBaslangic.Size = new System.Drawing.Size(72, 20);
            this.lblBaslangic.TabIndex = 2;
            this.lblBaslangic.Text = "Baslangic";
            // 
            // lblBitis
            // 
            this.lblBitis.AutoSize = true;
            this.lblBitis.Location = new System.Drawing.Point(298, 43);
            this.lblBitis.Name = "lblBitis";
            this.lblBitis.Size = new System.Drawing.Size(37, 20);
            this.lblBitis.TabIndex = 3;
            this.lblBitis.Text = "Bitis";
            // 
            // btnCalistir
            // 
            this.btnCalistir.Location = new System.Drawing.Point(517, 36);
            this.btnCalistir.Name = "btnCalistir";
            this.btnCalistir.Size = new System.Drawing.Size(94, 29);
            this.btnCalistir.TabIndex = 4;
            this.btnCalistir.Text = "Calistir";
            this.btnCalistir.UseVisualStyleBackColor = true;
            this.btnCalistir.Click += new System.EventHandler(this.btnCalistir_Click);
            // 
            // gbGirisBIlgileri
            // 
            this.gbGirisBIlgileri.Controls.Add(this.lblBaslangic);
            this.gbGirisBIlgileri.Controls.Add(this.btnCalistir);
            this.gbGirisBIlgileri.Controls.Add(this.mtxtBaslangic);
            this.gbGirisBIlgileri.Controls.Add(this.mtxtBitis);
            this.gbGirisBIlgileri.Controls.Add(this.lblBitis);
            this.gbGirisBIlgileri.Location = new System.Drawing.Point(30, 31);
            this.gbGirisBIlgileri.Name = "gbGirisBIlgileri";
            this.gbGirisBIlgileri.Size = new System.Drawing.Size(668, 130);
            this.gbGirisBIlgileri.TabIndex = 5;
            this.gbGirisBIlgileri.TabStop = false;
            this.gbGirisBIlgileri.Text = "Giris Bilgileri";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Location = new System.Drawing.Point(30, 207);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(741, 231);
            this.tabControl1.TabIndex = 7;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.lvCiftSayi);
            this.tabPage1.Location = new System.Drawing.Point(4, 29);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(733, 198);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Cift Sayi";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // lvCiftSayi
            // 
            this.lvCiftSayi.HideSelection = false;
            this.lvCiftSayi.Location = new System.Drawing.Point(20, 21);
            this.lvCiftSayi.Name = "lvCiftSayi";
            this.lvCiftSayi.Size = new System.Drawing.Size(694, 171);
            this.lvCiftSayi.TabIndex = 0;
            this.lvCiftSayi.UseCompatibleStateImageBehavior = false;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.lvTekSayi);
            this.tabPage2.Location = new System.Drawing.Point(4, 29);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(733, 198);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Tek Sayi";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // lvTekSayi
            // 
            this.lvTekSayi.HideSelection = false;
            this.lvTekSayi.Location = new System.Drawing.Point(19, 14);
            this.lvTekSayi.Name = "lvTekSayi";
            this.lvTekSayi.Size = new System.Drawing.Size(694, 171);
            this.lvTekSayi.TabIndex = 1;
            this.lvTekSayi.UseCompatibleStateImageBehavior = false;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.lvAsalSayi);
            this.tabPage3.Location = new System.Drawing.Point(4, 29);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(733, 198);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Asal Sayi";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // lvAsalSayi
            // 
            this.lvAsalSayi.HideSelection = false;
            this.lvAsalSayi.Location = new System.Drawing.Point(19, 14);
            this.lvAsalSayi.Name = "lvAsalSayi";
            this.lvAsalSayi.Size = new System.Drawing.Size(694, 171);
            this.lvAsalSayi.TabIndex = 1;
            this.lvAsalSayi.UseCompatibleStateImageBehavior = false;
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.lvMukemmelSayi);
            this.tabPage4.Location = new System.Drawing.Point(4, 29);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Size = new System.Drawing.Size(733, 198);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Mukemmel Sayi";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // lvMukemmelSayi
            // 
            this.lvMukemmelSayi.HideSelection = false;
            this.lvMukemmelSayi.Location = new System.Drawing.Point(19, 14);
            this.lvMukemmelSayi.Name = "lvMukemmelSayi";
            this.lvMukemmelSayi.Size = new System.Drawing.Size(694, 171);
            this.lvMukemmelSayi.TabIndex = 1;
            this.lvMukemmelSayi.UseCompatibleStateImageBehavior = false;
            // 
            // nlHesapMakinesi
            // 
            this.nlHesapMakinesi.Icon = ((System.Drawing.Icon)(resources.GetObject("nlHesapMakinesi.Icon")));
            this.nlHesapMakinesi.Text = "notifyIcon1";
            this.nlHesapMakinesi.Visible = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.gbGirisBIlgileri);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.gbGirisBIlgileri.ResumeLayout(false);
            this.gbGirisBIlgileri.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            this.tabPage4.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.MaskedTextBox mtxtBaslangic;
        private System.Windows.Forms.MaskedTextBox mtxtBitis;
        private System.Windows.Forms.Label lblBaslangic;
        private System.Windows.Forms.Label lblBitis;
        private System.Windows.Forms.Button btnCalistir;
        private System.Windows.Forms.GroupBox gbGirisBIlgileri;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.ListView lvCiftSayi;
        private System.Windows.Forms.ListView lvTekSayi;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.ListView lvAsalSayi;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.ListView lvMukemmelSayi;
        private System.Windows.Forms.NotifyIcon nlHesapMakinesi;
    }
}

