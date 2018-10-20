using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace DPF
{
    public partial class FormN : Form
    {
        public FormN()
        {
            InitializeComponent();
            textBox1.Text = N.ToString();
        }

        public delegate void MethodContainer();
        public event MethodContainer onCount;

        public int N { get; private set; }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.TextLength != 0)
            {
                N = Convert.ToInt32(textBox1.Text);
                onCount();
                this.Visible = false;
            }
            else MessageBox.Show("ENTER N");         
        }

        private void textBox1_MouseDown(object sender, MouseEventArgs e)
        {
            textBox1.Text = "";
        }
    }
}
