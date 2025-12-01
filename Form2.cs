using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp48
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        int[] dizi = new int[30];//groupbox1

        int[] dizi1 = new int[35];//groubbox6


        int[] dizikaynak = new int[25];//groubbox2
        int[] dizikopya = new int[25];//groubbox2
        
        //*****************************************************groubbox1***************************************************************************************************//
        private void button1_Click(object sender, EventArgs e)//kopyala
        {
            foreach (int kopyala in listBox1.Items)
            {
                listBox2.Items.Add(kopyala);
            }
        }

        private void button2_Click(object sender, EventArgs e)//ekle
        {
            Random rastgele = new Random();
            for (int i = 0; i < dizi.Length; i++)
            {
                dizi[i] = rastgele.Next(1, 100);
                listBox1.Items.Add(dizi[i]);
            }

        }







        //***************************************************************groubbox6******************************************************************************************************//

        private void button12_Click(object sender, EventArgs e)//ekle 
        {
            Random rastgele = new Random();
            for (int i = 0; i < dizi1.Length; i++)
            {
                dizi1[i] = rastgele.Next(1, 100);
                listBox11.Items.Add(i + "=>" + dizi1[i]);
            }

        }

        private void button11_Click(object sender, EventArgs e)//kopyala
        {
            foreach (object kopyala in listBox11.Items)
            {
                listBox12.Items.Add(kopyala);
            }
        }

       






//*********************************groubbox2*************************************************************************************//

        private void button5_Click(object sender, EventArgs e)//kopya
        {
            for (int i = 0; i < dizikopya.Length; i++)//3.yol
            {
                dizikopya[i] = dizikaynak[i];
            }
            for (int i = 0; i < dizikopya.Length; i++)
            {
                listBox4.Items.Add(dizikopya[i]);
            }
            
            /* foreach(int kopyala in dizikaynak)//1.yol
                {
                    listBox4.Items.Add(kopyala);
                }
                */

          /*  for (int i = 0; i < dizikopya.Length; i++)//2.yol
            {
                dizikopya[i] = dizikaynak[i];
                listBox4.Items.Add(dizikopya[i]);
            }
          */
        }

        private void button4_Click(object sender, EventArgs e)//ekle
        {
            /* Random rastgele = new Random();//1.yol
             for(int i=0;i<dizikaynak.Length;i++)
             {
                 dizikaynak[i] = rastgele.Next(1, 100);
                 listBox3.Items.Add(dizikaynak[i]);
             }
            */
            Random rastgele = new Random();//2.yol
            for ( int i = 0; i < dizikaynak.Length; i++)
            {
                dizikaynak[i] = rastgele.Next(1, 100);
            }
            for(int i=0;i<dizikaynak.Length;i++)
            {
                listBox3.Items.Add(dizikaynak[i]);
            }
            


        }
        private void button3_Click(object sender, EventArgs e)//önceki sayfa
        {
            Form1 fr1 = new Form1();
            fr1.Show();
            this.Hide();
        }
    }
}
