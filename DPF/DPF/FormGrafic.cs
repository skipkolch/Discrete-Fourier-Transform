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
    public partial class FormGrafic : Form
    {
        public FormGrafic()
        {
            InitializeComponent();
           
        }

        public void ClearChart()
        {
            try
            {   
                chartFunc.Series[0].Points.Clear();
                chartFunc.Series[1].Points.Clear();
            }
            catch(Exception ex)
            {
                return;
            }
        }

        public void InitGraph(double[] F, string str)
        {
            switch (str)
            { 
                case "Function":
                    {
                        double step = 0;
                        for (int i = 0, size = F.Length; i < size; i++, step += 1)
                            chartFunc.Series[str].Points.AddXY(step, F[i]);
                        break;
                    }

                case "Furie":
                    {
                        double step = 0;
                        for (int i = 0, size = F.Length; i < size; i++, step += 1)
                            chartFurie.Series[str].Points.AddXY(step, F[i]);
                        break;
                    }

                case "Spectr":
                    {
                        double step = 0;
                        for (int i = 0, size = (int) F.Length / 100; i < size; i++, step += 1)
                            chartSpectr.Series[str].Points.AddXY(step, F[i]);
                        break;
                    }

                case "Alpha":
                    {
                        double step = 0;
                        for (int i = 0, size = (int)F.Length; i < size; i++, step += 1)
                            chartFunc.Series[str].Points.AddXY(step, F[i]);
                        break;
                    }

                default: break;

            }
        }

        private void FormGrafic_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Visible = false;
        }

        private void FormGrafic_Resize(object sender, EventArgs e)
        {
            chartFunc.Size = new Size(this.Size.Width,Convert.ToInt32(this.Size.Height / 3.12));
            chartFurie.Size = new Size(this.Size.Width, Convert.ToInt32(this.Size.Height / 3.12));
            chartSpectr.Size = new Size(this.Size.Width, Convert.ToInt32(this.Size.Height / 3.12));

            chartFurie.Location = new Point(0, chartFunc.Size.Height);
        }
    }
}
