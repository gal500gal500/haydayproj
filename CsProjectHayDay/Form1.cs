using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Mechanics;
namespace CsProjectHayDay
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.MaximizeBox = false;
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            Farmer ori = new Farmer();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("I LOVE MADAR");
        }
    }
}
