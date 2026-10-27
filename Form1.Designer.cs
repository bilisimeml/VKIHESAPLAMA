namespace VKIAPP
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
            label1 = new Label();
            label2 = new Label();
            TxtKilo = new TextBox();
            TxtBoy = new TextBox();
            BtnHesapla = new Button();
            BtnSifirla = new Button();
            LblDurum = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(117, 65);
            label1.Name = "label1";
            label1.Size = new Size(88, 20);
            label1.TabIndex = 0;
            label1.Text = "Kilonuz (kg)";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(117, 117);
            label2.Name = "label2";
            label2.Size = new Size(92, 20);
            label2.TabIndex = 1;
            label2.Text = "Boyunuz (m)";
            // 
            // TxtKilo
            // 
            TxtKilo.Location = new Point(242, 62);
            TxtKilo.Name = "TxtKilo";
            TxtKilo.Size = new Size(206, 27);
            TxtKilo.TabIndex = 2;
            // 
            // TxtBoy
            // 
            TxtBoy.Location = new Point(242, 110);
            TxtBoy.Name = "TxtBoy";
            TxtBoy.Size = new Size(206, 27);
            TxtBoy.TabIndex = 3;
            // 
            // BtnHesapla
            // 
            BtnHesapla.Location = new Point(117, 163);
            BtnHesapla.Name = "BtnHesapla";
            BtnHesapla.Size = new Size(331, 49);
            BtnHesapla.TabIndex = 4;
            BtnHesapla.Text = "VKI HESAPLA";
            BtnHesapla.UseVisualStyleBackColor = true;
            BtnHesapla.Click += BtnHesapla_Click;
            // 
            // BtnSifirla
            // 
            BtnSifirla.Location = new Point(484, 65);
            BtnSifirla.Name = "BtnSifirla";
            BtnSifirla.Size = new Size(94, 72);
            BtnSifirla.TabIndex = 5;
            BtnSifirla.Text = "SIFIRLA";
            BtnSifirla.UseVisualStyleBackColor = true;
            BtnSifirla.Click += BtnSifirla_Click;
            // 
            // LblDurum
            // 
            LblDurum.AutoSize = true;
            LblDurum.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            LblDurum.Location = new Point(165, 241);
            LblDurum.Name = "LblDurum";
            LblDurum.Size = new Size(245, 25);
            LblDurum.TabIndex = 6;
            LblDurum.Text = "Vücut Kitle İndeksiniz : 0.0";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(643, 318);
            Controls.Add(LblDurum);
            Controls.Add(BtnSifirla);
            Controls.Add(BtnHesapla);
            Controls.Add(TxtBoy);
            Controls.Add(TxtKilo);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox TxtKilo;
        private TextBox TxtBoy;
        private Button BtnHesapla;
        private Button BtnSifirla;
        private Label LblDurum;
    }
}
