namespace C____Hesap_Makinesi_Form_Uygulaması_2
{
    public partial class Form1 : Form
    {
        public int islem;


        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            label3.Text = "Yapılacak İşlem: Toplama";
            islem = 1;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            label3.Text = "Yapılacak İşlem: Çıkarma";
            islem = 2;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            label3.Text = "Yapılacak İşlem: Çarpma";
            islem = 3;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            label3.Text = "Yapılacak İşlem: Bölme";
            islem = 4;
        }
        private void button1_Click_1(object sender, EventArgs e)
        {
            double sayi1 = Convert.ToDouble(textBox1.Text);
            double sayi2 = Convert.ToDouble(textBox2.Text);
            double sonuc = 0;
            if (islem == 1)
            {
                sonuc = sayi1 + sayi2;
            }
            else if (islem == 2)
            {
                sonuc = sayi1 - sayi2;
            }
            else if (islem == 3)
            {
                sonuc = sayi1 * sayi2;
            }
            else if ((islem == 4))
            {
                sonuc = sayi1 / sayi2;
            }
            label5.Text = Convert.ToString(sonuc);
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            {
                e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
            }
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            {
                e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
            }
        }
    }
}
