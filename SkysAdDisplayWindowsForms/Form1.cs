using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SkysAdDisplayWindowsForms
{
    public partial class Form1 : Form
    {
        private int secondCounter = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            rad1.Text = "Kalle Anka";
            rad2.Text = "Test123";
            rad3.Text = "1234567890123456789012345";
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            secondCounter++;
            if (secondCounter == 20)
            {
                rad1.Text = "Synas här?";
                rad2.Text = "Ring genast";
                rad3.Text = ".NET:s reklambyrå";
                secondCounter = 0;
            }
        }
    }
}
