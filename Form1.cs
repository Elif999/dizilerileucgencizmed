namespace WinFormsApp48
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int[,] kaynak = new int[10, 10];//groubbox1//iki

        int[,] dizi1 = new int[3, 3]//groubbox4//iki
        {
            { 1, 2, 3 },
            { 4, 5, 6 },
            { 7, 8, 9 }
        };//iki boyutlu dizilere deðer atamasý bu þekilde yapýlýr.


        int[,] dizi2 = new int[3, 3];//groupbox2//iki

        int[,] dizi3 = new int[3, 3];//groubbox5//iki

        int[] dizi4 = new int[5]; //groubbox3//tek 

        int[] dizi5 = new int[5] { 13, 14, 15, 16, 17 };//groupbox6 //tek

        //********************************Global Alanda diziler tanýmlandý**************************************//


        //***********************************************************groubbox1*******************************************************//

        private void button1_Click(object sender, EventArgs e)//indexleri lixbox1'e atar
        {

            for (int x = 0; x < 10; x++)
            {
                for (int y = 0; y < 10; y++)
                {
                    listBox1.Items.Add(x + "," + y);
                }
            }

        }

        private void button2_Click(object sender, EventArgs e)//indexleri lixbox2ye kopyalar
        {
            foreach (object kopyala in listBox1.Items)
            {
                listBox2.Items.Add(kopyala);
                /*
var, C# dilinde bir anahtar kelimedir ve deðiþkenlerin türünü otomatik olarak belirlemek için kullanýlýr. 
Yani, var ile tanýmlanan bir deðiþkenin türü, o deðiþkene atanan deðere göre derleyici tarafýndan otomatik olarak belirlenir


"var", C# dilinde bir anahtar kelimedir ve deðiþkenlerin türünü otomatik olarak belirlemek için kullanýlýr. 
Yani, var ile tanýmlanan bir deðiþkenin türü, o deðiþkene atanan deðere göre derleyici tarafýndan otomatik olarak belirlenir .
Ör/                                                                                                                                                                            
var sayi = 10; // Derleyici, 'sayi' deðiþkeninin türünü 'int' olarak belirler.
var metin = "Merhaba"; // Derleyici, 'metin' deðiþkeninin türünü 'string' olarak belirler.           
    */
            }
        }








        //*********************************************************GroubBox4*************************************************************************************************************//

        private void button8_Click(object sender, EventArgs e)
        {
            for (int x = 0; x < 3; x++) // Satýr sayýsý
            {
                for (int y = 0; y < 3; y++) // Sütun sayýsý
                {
                    listBox7.Items.Add(x + "," + y + "=>" + dizi1[x, y]); // Dizinin indekslerini ve deðerlerini listBox1'e ekle
                }
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            foreach (object kopyala in listBox7.Items)
            {
                listBox8.Items.Add(kopyala);
            }
        }







        //********************************************************groupbox2**************************************************************************************************//
        private void button3_Click(object sender, EventArgs e)
        {
            Random random = new Random(); // Rastgele sayý üretici burada tanýmlandý
            // Ýki boyutlu diziyi rastgele sayýlarla doldur
            for (int x = 0; x < 3; x++) // Satýr sayýsý
            {
                for (int y = 0; y < 3; y++) // Sütun sayýsý
                {
                    dizi2[x, y] = random.Next(1, 101); // 1 ile 100 arasýnda rastgele sayý
                    listBox3.Items.Add(dizi2[x, y]); // Dizinin elemanlarýný listBox1'e ekle
                }
            }
        }
        private void button4_Click(object sender, EventArgs e)
        {// Object deðiþkeni içine her türlü tür deðiþkeni yazdýrýp ekleyebilir.
         // lixbox3'ümüzdeki deðerler yani öðeler object türündeyidi çünkü birden fazla deðiþken türü içeriyordu mesela þöyleydi;
         //(0,0=>24) þeklindeydi yani 0 ile 0 arasýndaki virgül string týrnak ile konulmuþ 0 deðerleri ise int türünde
         //veayný zamanda 24 deðeride int türünde sonuç olarak bu öðeler hem string hem de int türünde bir deðer içerdiði
         //için object veri türü kullanmalýyýz.

            foreach (object kopyala in listBox3.Items)
            {
                listBox4.Items.Add(kopyala);
            }
        }







        //***************************************************************groubbox5*************************************************************************************//
        private void button10_Click(object sender, EventArgs e)
        {
            Random random = new Random();
            for (int x = 0; x < 3; x++) // Satýr sayýsý
            {
                for (int y = 0; y < 3; y++) // Sütun sayýsý
                {
                    dizi3[x, y] = random.Next(1, 101); // 1 ile 100 arasýnda rastgele sayý
                    listBox9.Items.Add(x + "," + y + "=>" + dizi3[x, y]);

                }
            }
        }
        private void button9_Click(object sender, EventArgs e)
        {
            foreach (object kopyala in listBox9.Items)
            {
                listBox10.Items.Add(kopyala);
            }
        }











        //************************************groubbox3*******************************************************************//
        private void button6_Click(object sender, EventArgs e)
        {
            int kopyadet = 0;
            for (int i = 0; i < dizi4.Count(); i++)
            {
                listBox5.Items.Add(i);
            }

        }

        private void button5_Click(object sender, EventArgs e)
        {
            foreach (int kopyala in listBox5.Items)
            {
                listBox6.Items.Add(kopyala);
            }
        }








        //**********************************groupbox6**************************************************************************//






        private void button12_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < dizi5.Length; i++)
            {
                listBox11.Items.Add(i + "=>" + dizi5[i]);
            }
        }

        private void button11_Click(object sender, EventArgs e)
        {
            foreach (object kopyala in listBox11.Items)
            {
                listBox12.Items.Add(kopyala);
            }
        }

        private void button13_Click(object sender, EventArgs e)
        {
            Form2 fr2 = new Form2();
            fr2.Show();
            this.Hide();
        }
    }
}

