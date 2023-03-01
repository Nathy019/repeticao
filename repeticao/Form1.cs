using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace repeticao
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ListarFor.Items.Add(1);
            ListarFor.Items.Add(2);
            ListarFor.Items.Add(3);
            ListarFor.Items.Add(4);
            ListarFor.Items.Add(5);
            ListarFor.Items.Add(6);
            ListarFor.Items.Add(7);
            ListarFor.Items.Add(8);
            ListarFor.Items.Add(9);
            ListarFor.Items.Add(10);
        }
    }
}
