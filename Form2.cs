using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp53
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
          
            Point point1 = new Point(150, 13); // Üst nokta (1.5, 0) -> (150, 13)
            Point point2 = new Point(120, 200); // Sol alt nokta (0, 13) -> (120, 200)
            Point point3 = new Point(180, 200); // Sağ alt nokta (3, 13) -> (180, 200)

            // Üçgeni çiz
            e.Graphics.DrawPolygon(Pens.Black, new Point[] { point1, point2, point3 });
        }

        private void button1_Click(object sender, EventArgs e)
        {
            panel1.Invalidate();


        }
    }
}
