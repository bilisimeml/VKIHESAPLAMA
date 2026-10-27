namespace VKIAPP
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void BtnHesapla_Click(object sender, EventArgs e)
        {
            if (double.TryParse(TxtKilo.Text, out var kilo) && double.TryParse(TxtBoy.Text, out var boy))
            {
                double vki = kilo / (boy * boy);

                if (vki < 18.5)
                {
                    this.BackColor = Color.LightBlue;
                    LblDurum.Text = $"Vücut kitle indeksiniz : {vki:F2}";
                }
                else if (vki >= 18.5 && vki < 24.99)
                {
                    this.BackColor = Color.LightGreen;
                    LblDurum.Text = $"Vücut kitle indeksiniz : {vki:F2}";
                }
                else if (vki >= 25.0 && vki < 29.99)
                {
                    this.BackColor = Color.Yellow;
                    LblDurum.Text = $"Vücut kitle indeksiniz : {vki:F2}";
                }
                else
                {
                    this.BackColor = Color.Red;
                    LblDurum.Text = $"Vücut kitle indeksiniz : {vki:F2}";
                }
            }
            else
            {
                MessageBox.Show("Kilo ve boy boş bırakılmaz", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnSifirla_Click(object sender, EventArgs e)
        {
            this.BackColor = SystemColors.Control;
            TxtKilo.Text = string.Empty;
            TxtBoy.Text = string.Empty;
            LblDurum.Text = "Vücut kitle indeksiniz : 0.0";
        }
    }
}
