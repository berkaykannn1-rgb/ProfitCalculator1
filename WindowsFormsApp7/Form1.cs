using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp7
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        //Uygulama 4: Bir ana paranın istenilen yıl sonunda daha önceden belirlenlenmiş kar payı oranına kar payı miktarı ve süre sonunda toplam tutar hesaplanacaktır.
        //Vade yıl,Oran yüzde cinsinden girilecektir. Bunu hesaplayan winformunu oluştur ve kodunu yaz.
        private void Form1_Load(object sender, EventArgs e)
        {
            groupBox1.BackColor = Color.Aqua;
        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            int anapara = Convert.ToInt32(textBox1.Text);
            int vade = Convert.ToInt32(textBox2.Text);
            double oran = Convert.ToDouble(textBox3.Text);
            double kar = anapara * oran *vade/ 100;
            textBox4.Text = kar.ToString();
            double toplam = anapara + kar;
            textBox5.Text = toplam.ToString();

        }
    }
}
