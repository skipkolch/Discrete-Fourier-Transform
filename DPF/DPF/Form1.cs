using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace DPF
{
    public partial class Form1 : Form
    {
        private double h;
        private double[] F;

        private double[] ReFm;
        private double[] ImFm;

        private double[] spectr;

        private double[] Revers_ReF;
        private double[] Revers_ImF;

        private double[] Gfucn;
        private double[] ReG;
        private double[] ImG;

        private double[] H;
        private double[] ReH;
        private double[] ImH;

        private Random rand;
        private FormGrafic next;
        private FormN Numbers;

        private int N;


        public Form1()
        {
            InitializeComponent();
            rand = new Random();
            next = new FormGrafic();
        }

        private double[] InitRandomFunc(int Size, string strArr)
        {
            progressBar1.Maximum = Size;
            progressBar1.Value = 0;

            for (int i = 0; i < Size; i++)
            {
                if(dataGridView1.Rows.Count < Size)
                    dataGridView1.Rows.Add();

                dataGridView1.Rows[i].Cells[strArr].Value = rand.Next(-100,100);
                progressBar1.Value++;
            }

            return dataToArray(strArr);
        }

        private double[] dataToArray(string NameColomn)
        {
            int Size = dataGridView1.Rows.Count;
            double[] array = new double[Size];

            for (int i = 0; i < Size; i++)
                array[i] = Convert.ToDouble(dataGridView1.Rows[i].Cells[NameColomn].Value);

            return array;
        }

        private double[] InitReFm(double[] Fk , string str)
        {
            double sum;
            int size = Fk.Length;           
            double[] localReF = new double[size];

            progressBar1.Maximum = size;
            progressBar1.Value = 0;

            for (int i = 0; i < size; i++)
            {
                sum = 0;

                for (int j = 0; j < size; j++)
                    sum += Fk[j] * Math.Cos(h * i * j);

                localReF[i] = sum / Math.Sqrt(size);

            switch (str)
                {
                    case "ReF": { dataGridView1.Rows[i].Cells["ReF"].Value = localReF[i]; break; }
                    case "LeftRe": { dataGridView1.Rows[i].Cells["LeftRe"].Value = localReF[i]; break; }
                    default: break;
                }

                progressBar1.Value++;
            }

            return localReF;
        }

        private double[] InitImFm(double[] Fk, string str)
        {
            double sum;
            int size = Fk.Length;
            double[] localImF = new double[size];

            progressBar1.Maximum = size;
            progressBar1.Value = 0;

            for (int i = 0; i < size; i++)
            {
                sum = 0;

                for (int j = 0; j < size; j++)
                    sum += Fk[j] * Math.Sin(h * i * j);

                localImF[i] = -sum / Math.Sqrt(size);


                switch (str)
                {
                    case "ImF": { dataGridView1.Rows[i].Cells["ImF"].Value = localImF[i]; break; }
                    case "LeftIm": { dataGridView1.Rows[i].Cells["LeftIm"].Value = localImF[i]; break; }
                    default: break;
                }

                progressBar1.Value++;
            }

            return localImF;
        }


        private void ClearData()
        {
            F = null;
            ImFm = null;
            ReFm = null;

            Revers_ReF = null;
            Revers_ImF = null;
            spectr = null;

            next.ClearChart();
            dataGridView1.Rows.Clear();
        }


        private void allToolStripMenuItem_Click(object sender, EventArgs e)
        {
            progressBar1.Value = 0;
            ClearData();
        }

        private void functionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dataGridView1.Rows[0].Cells["Func"].Value == null)
            {
                if (N != 0)
                {
                    F = InitRandomFunc(N, "Func");
                    Gfucn = InitRandomFunc(N, "G");
                }
                else MessageBox.Show("Enter N");

            }
            else MessageBox.Show("Clear old value");
        }


        private void graficToolStripMenuItem_Click(object sender, EventArgs e)
        {
            next = new FormGrafic();

            if(F != null)
              next.InitGraph(F, "Function");

            if(ReFm != null)
                next.InitGraph(ReFm, "Furie");

            if(spectr != null)
                next.InitGraph(spectr, "Spectr");

            if(Revers_ReF != null)
                next.InitGraph(Revers_ReF, "Alpha");

            next.Show();     
        }

        private void directToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dataGridView1.Rows[0].Cells["Func"].Value != null)
            {
                F = dataToArray("Func");
                N = F.Length;
                h = 2 * Math.PI / N;
                ReFm = InitReFm(F, "ReF");
                ImFm = InitImFm(F, "ImF");
            }
        }

        private void functionToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            ClearCells("Func");           
        }

        private void nToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Numbers == null)
            {
                Numbers = new FormN();
                Numbers.onCount += InitN;
                Numbers.Show();
            }
            else Numbers.Visible = true;
        }

        private void InitN()
        {
            N = Numbers.N;
        }

        private void reFmToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ClearCells("ImF");
        }

        private void imFmToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ClearCells("ReF");
        }

        private void ClearCells(string str)
        {
            switch (str)
            {
                case "ImF":  { ImFm = null; break; }
                case "ReF":  { ReFm = null; break; }
                case "Func": { F = null;    break; }
                case "Spectr": { spectr = null; break; }
            }           

            int Count = dataGridView1.Rows.Count;

            progressBar1.Value = 0;
            progressBar1.Maximum = Count;

            for (int i = 0; i < Count; i++)
            {
                dataGridView1.Rows[i].Cells[str].Value = null;
                progressBar1.Value++;
            }
        }

        private void reverseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (ReFm.Length != 0 || ImFm.Length != 0)
            {
                Revers_ReF = InitRevers_RE(ReFm, ImFm);
                Revers_ImF = InitRevers_IM(ReFm, ImFm);
            }
            else MessageBox.Show("Calculate Direct Furie");
        }

        private double[] InitRevers_RE(double[] Re, double[] Im)
        {
            double[] localArray = new double[N];

            double sum;

            progressBar1.Maximum = N;
            progressBar1.Value = 0;

            for(int i = 0; i < N; i++)
            {
                sum = 0;

                for(int j = 0; j < N; j++)                
                    sum += Re[j] * Math.Cos(h * i * j) - Im[j] * Math.Sin(h * i * j);

                localArray[i] = sum / Math.Sqrt(N);

                dataGridView1.Rows[i].Cells["ReverseRe"].Value = localArray[i];

                progressBar1.Value++;
            }

            return localArray;
        }

        private double[] InitRevers_IM(double[] Re, double[] Im)
        {
            double[] localArray = new double[N];

            double sum;

            progressBar1.Maximum = N;
            progressBar1.Value = 0;

            for (int i = 0; i < N; i++)
            {
                sum = 0;

                for (int j = 0; j < N; j++)
                    sum += Re[j] * Math.Cos(h * i * j) + Im[j] * Math.Sin(h * i * j);

                localArray[i] = sum / Math.Sqrt(N);

                dataGridView1.Rows[i].Cells["ReverseIm"].Value = localArray[i];

                progressBar1.Value++;
            }

            return localArray;
        }


        private void spectrToolStripMenuItem_Click(object sender, EventArgs e)
        {
            progressBar1.Value = 0;
            progressBar1.Maximum = N;

            if (spectr == null)
            {
                spectr = new double[N];


                for (int i = 0; i < N; i++)
                {
                    spectr[i] = Math.Sqrt( Math.Pow(ReFm[i], 2) + Math.Pow(ImFm[i], 2));
                    dataGridView1.Rows[i].Cells["Spectr"].Value = spectr[i];

                    progressBar1.Value++;
                }
            }
            else
                MessageBox.Show("Clear old values.");
        }

        private void spectrToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            ClearCells("Spectr");
        }

        private void inputToolStripMenuItem_Click(object sender, EventArgs e)
        {
            progressBar1.Value = 0;

            Stream mystr = null;

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                if ((mystr = openFileDialog1.OpenFile()) != null)
                {
                    StreamReader myread = new StreamReader(mystr);
                    int num = 0;
                    try//Блок try содержит защищенный код, который может вызвать исключение. 
                       //Этот блок выполняется, пока не возникнет исключение или пока он не будет успешно завершен.
                    {
                        string[] str = myread.ReadToEnd().Split('\n'); // создаем массив из строки, который будет 
                                                                       // загружать из файла с символом разделителем ('\n')
                        num = str.Count();

                        int N = 200;
                        progressBar1.Maximum = N;

                        dataGridView1.RowCount = N;

                        for (int i = 0; i < N; i++)
                        {
                            if (i == N)
                                return;
                            dataGridView1.Rows[i].Cells["Func"].Value = str[i];

                            progressBar1.Value++;
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                    finally
                    {
                        mystr.Close();
                        myread.Close();
                    }
                }
            }

        }

        private void parsevalEqualityToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (F != null && ReFm != null && ImFm != null)
            {
                double sumF = 0;
                double sumFm = 0;

                string strResult;

                progressBar1.Maximum = N;
                progressBar1.Value = 0;

                for (int i = 0; i < N; i++)
                {
                    sumF += Math.Pow(Math.Abs(F[i]), 2);
                    sumFm += Math.Pow(ReFm[i], 2) + Math.Pow(ImFm[i], 2);

                    progressBar1.Value++;
                }

                strResult = " Abs(F)^2 =" + sumF + "\n (ReF)^2 + (ImF)^2 =" + sumFm + "\n";
                strResult += (Convert.ToInt32(sumF) == Convert.ToInt32(sumFm) ? true : false);

                MessageBox.Show(strResult);
            }
            else MessageBox.Show("Use calculate Methods");
        }


        private void convolutionToolStripMenuItem_Click(object sender, EventArgs e)
        {           
            if (Gfucn != null && F != null)
            {
                for(int i = 0; i < dataGridView1.ColumnCount; i++)    
                    dataGridView1.Columns[i].Visible = true;

                H = InitH();
                ReH = InitReFm(H, "LeftRe");
                ImH = InitImFm(H, "LeftIm");

                ReG = InitReFm(Gfucn, "");
                ImG = InitImFm(Gfucn, "");

                if (propertiesConvolution(H, F, Gfucn))
                    MessageBox.Show("Свойство выполнено");
                else MessageBox.Show("Свойство невыполнено");
            }
            else
                MessageBox.Show("Enter Functions.");
        }


        private double[] InitH()
        {
            int k;
            double sum;

            double[] local = new double[N];

            for (int i = 0; i < N; i++)
            {
                sum = 0;

                for(int j = 0; j < N; j++)
                {
                    k = i - j;

                    if (k < 0)
                        k += N;

                    sum += F[k] * Gfucn[j];

                }

                local[i] = sum;
            }

            return local;
        }

        private bool propertiesConvolution(double[] H, double[] F, double[]G)
        {
            double Right = 0;
            for(int i = 0; i < N; i++)
            {
                Right = (ReFm[i]*ReG[i] - ImFm[i]*ImG[i]) * Math.Sqrt(N);
                dataGridView1.Rows[i].Cells["RightRe"].Value = Right;
                if (Convert.ToInt64(ReH[i]) != Convert.ToInt64(Right))
                {
                    return false;
                }
                

                Right = (ReFm[i] * ImG[i] + ImFm[i] * ReG[i]) * Math.Sqrt(N);
                dataGridView1.Rows[i].Cells["RightIm"].Value = Right;
                if (Convert.ToInt64(ImH[i]) != Convert.ToInt64(Right))
                {                 
                    return false;
                }
            }
            return true;
        }

        private void alphaRitmToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Alpha_ritm();
        }

        private void Alpha_ritm()
        {
            for(int i = 0; i < N; i++)
            {
                if (i >= 8 && i <= 14)
                    continue;
                else
                {
                    dataGridView1.Rows[i].Cells["ReF"].Value = 0;
                    dataGridView1.Rows[i].Cells["ImF"].Value = 0;
                }
            }

            ReFm = dataToArray("ReF");
            ImFm = dataToArray("ImF");
        }

    }
}
