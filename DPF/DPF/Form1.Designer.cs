namespace DPF
{
    partial class Form1
    {
        /// <summary>
        /// Требуется переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Обязательный метод для поддержки конструктора - не изменяйте
        /// содержимое данного метода при помощи редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.nToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.randomToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.functionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.furieToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.directToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reverseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.spectrToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.proprtiesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.parsevalEqualityToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.convolutionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.graficToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.inputToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.outputToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clearToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.functionToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.reFmToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.imFmToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.spectrToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.allToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Func = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Spectr = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.G = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ReF = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ImF = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ReverseRe = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ReverseIm = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LeftRe = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LeftIm = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RightRe = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RightIm = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.panel1 = new System.Windows.Forms.Panel();
            this.alphaRitmToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nToolStripMenuItem,
            this.randomToolStripMenuItem,
            this.furieToolStripMenuItem,
            this.proprtiesToolStripMenuItem,
            this.graficToolStripMenuItem,
            this.fileToolStripMenuItem,
            this.clearToolStripMenuItem,
            this.alphaRitmToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1066, 24);
            this.menuStrip1.TabIndex = 10;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // nToolStripMenuItem
            // 
            this.nToolStripMenuItem.Name = "nToolStripMenuItem";
            this.nToolStripMenuItem.Size = new System.Drawing.Size(28, 20);
            this.nToolStripMenuItem.Text = "N";
            this.nToolStripMenuItem.Click += new System.EventHandler(this.nToolStripMenuItem_Click);
            // 
            // randomToolStripMenuItem
            // 
            this.randomToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.functionToolStripMenuItem});
            this.randomToolStripMenuItem.Name = "randomToolStripMenuItem";
            this.randomToolStripMenuItem.Size = new System.Drawing.Size(64, 20);
            this.randomToolStripMenuItem.Text = "Random";
            // 
            // functionToolStripMenuItem
            // 
            this.functionToolStripMenuItem.Name = "functionToolStripMenuItem";
            this.functionToolStripMenuItem.Size = new System.Drawing.Size(121, 22);
            this.functionToolStripMenuItem.Text = "Function";
            this.functionToolStripMenuItem.Click += new System.EventHandler(this.functionToolStripMenuItem_Click);
            // 
            // furieToolStripMenuItem
            // 
            this.furieToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.directToolStripMenuItem,
            this.reverseToolStripMenuItem,
            this.spectrToolStripMenuItem});
            this.furieToolStripMenuItem.Name = "furieToolStripMenuItem";
            this.furieToolStripMenuItem.Size = new System.Drawing.Size(40, 20);
            this.furieToolStripMenuItem.Text = "DFT";
            // 
            // directToolStripMenuItem
            // 
            this.directToolStripMenuItem.Name = "directToolStripMenuItem";
            this.directToolStripMenuItem.Size = new System.Drawing.Size(114, 22);
            this.directToolStripMenuItem.Text = "Direct";
            this.directToolStripMenuItem.Click += new System.EventHandler(this.directToolStripMenuItem_Click);
            // 
            // reverseToolStripMenuItem
            // 
            this.reverseToolStripMenuItem.Name = "reverseToolStripMenuItem";
            this.reverseToolStripMenuItem.Size = new System.Drawing.Size(114, 22);
            this.reverseToolStripMenuItem.Text = "Reverse";
            this.reverseToolStripMenuItem.Click += new System.EventHandler(this.reverseToolStripMenuItem_Click);
            // 
            // spectrToolStripMenuItem
            // 
            this.spectrToolStripMenuItem.Name = "spectrToolStripMenuItem";
            this.spectrToolStripMenuItem.Size = new System.Drawing.Size(114, 22);
            this.spectrToolStripMenuItem.Text = "Spectr";
            this.spectrToolStripMenuItem.Click += new System.EventHandler(this.spectrToolStripMenuItem_Click);
            // 
            // proprtiesToolStripMenuItem
            // 
            this.proprtiesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.parsevalEqualityToolStripMenuItem,
            this.convolutionToolStripMenuItem});
            this.proprtiesToolStripMenuItem.Name = "proprtiesToolStripMenuItem";
            this.proprtiesToolStripMenuItem.Size = new System.Drawing.Size(66, 20);
            this.proprtiesToolStripMenuItem.Text = "Proprties";
            // 
            // parsevalEqualityToolStripMenuItem
            // 
            this.parsevalEqualityToolStripMenuItem.Name = "parsevalEqualityToolStripMenuItem";
            this.parsevalEqualityToolStripMenuItem.Size = new System.Drawing.Size(162, 22);
            this.parsevalEqualityToolStripMenuItem.Text = "Parseval Equality";
            this.parsevalEqualityToolStripMenuItem.Click += new System.EventHandler(this.parsevalEqualityToolStripMenuItem_Click);
            // 
            // convolutionToolStripMenuItem
            // 
            this.convolutionToolStripMenuItem.Name = "convolutionToolStripMenuItem";
            this.convolutionToolStripMenuItem.Size = new System.Drawing.Size(162, 22);
            this.convolutionToolStripMenuItem.Text = "Convolution";
            this.convolutionToolStripMenuItem.Click += new System.EventHandler(this.convolutionToolStripMenuItem_Click);
            // 
            // graficToolStripMenuItem
            // 
            this.graficToolStripMenuItem.Name = "graficToolStripMenuItem";
            this.graficToolStripMenuItem.Size = new System.Drawing.Size(65, 20);
            this.graficToolStripMenuItem.Text = "Graphics";
            this.graficToolStripMenuItem.Click += new System.EventHandler(this.graficToolStripMenuItem_Click);
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.inputToolStripMenuItem,
            this.outputToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // inputToolStripMenuItem
            // 
            this.inputToolStripMenuItem.Name = "inputToolStripMenuItem";
            this.inputToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.inputToolStripMenuItem.Text = "Open";
            this.inputToolStripMenuItem.Click += new System.EventHandler(this.inputToolStripMenuItem_Click);
            // 
            // outputToolStripMenuItem
            // 
            this.outputToolStripMenuItem.Name = "outputToolStripMenuItem";
            this.outputToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.outputToolStripMenuItem.Text = "Save";
            // 
            // clearToolStripMenuItem
            // 
            this.clearToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.functionToolStripMenuItem1,
            this.reFmToolStripMenuItem,
            this.imFmToolStripMenuItem,
            this.spectrToolStripMenuItem1,
            this.allToolStripMenuItem});
            this.clearToolStripMenuItem.Name = "clearToolStripMenuItem";
            this.clearToolStripMenuItem.Size = new System.Drawing.Size(46, 20);
            this.clearToolStripMenuItem.Text = "Clear";
            // 
            // functionToolStripMenuItem1
            // 
            this.functionToolStripMenuItem1.Name = "functionToolStripMenuItem1";
            this.functionToolStripMenuItem1.Size = new System.Drawing.Size(121, 22);
            this.functionToolStripMenuItem1.Text = "Function";
            this.functionToolStripMenuItem1.Click += new System.EventHandler(this.functionToolStripMenuItem1_Click);
            // 
            // reFmToolStripMenuItem
            // 
            this.reFmToolStripMenuItem.Name = "reFmToolStripMenuItem";
            this.reFmToolStripMenuItem.Size = new System.Drawing.Size(121, 22);
            this.reFmToolStripMenuItem.Text = "ImFm";
            this.reFmToolStripMenuItem.Click += new System.EventHandler(this.reFmToolStripMenuItem_Click);
            // 
            // imFmToolStripMenuItem
            // 
            this.imFmToolStripMenuItem.Name = "imFmToolStripMenuItem";
            this.imFmToolStripMenuItem.Size = new System.Drawing.Size(121, 22);
            this.imFmToolStripMenuItem.Text = "ReFm";
            this.imFmToolStripMenuItem.Click += new System.EventHandler(this.imFmToolStripMenuItem_Click);
            // 
            // spectrToolStripMenuItem1
            // 
            this.spectrToolStripMenuItem1.Name = "spectrToolStripMenuItem1";
            this.spectrToolStripMenuItem1.Size = new System.Drawing.Size(121, 22);
            this.spectrToolStripMenuItem1.Text = "Spectr";
            this.spectrToolStripMenuItem1.Click += new System.EventHandler(this.spectrToolStripMenuItem1_Click);
            // 
            // allToolStripMenuItem
            // 
            this.allToolStripMenuItem.Name = "allToolStripMenuItem";
            this.allToolStripMenuItem.Size = new System.Drawing.Size(121, 22);
            this.allToolStripMenuItem.Text = "All";
            this.allToolStripMenuItem.Click += new System.EventHandler(this.allToolStripMenuItem_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Func,
            this.Spectr,
            this.G,
            this.ReF,
            this.ImF,
            this.ReverseRe,
            this.ReverseIm,
            this.LeftRe,
            this.LeftIm,
            this.RightRe,
            this.RightIm});
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 24);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dataGridView1.Size = new System.Drawing.Size(1066, 488);
            this.dataGridView1.TabIndex = 4;
            // 
            // Func
            // 
            this.Func.HeaderText = "Func";
            this.Func.Name = "Func";
            this.Func.ReadOnly = true;
            // 
            // Spectr
            // 
            this.Spectr.HeaderText = "Spectr";
            this.Spectr.Name = "Spectr";
            this.Spectr.ReadOnly = true;
            // 
            // G
            // 
            this.G.HeaderText = "G";
            this.G.Name = "G";
            this.G.ReadOnly = true;
            this.G.Visible = false;
            // 
            // ReF
            // 
            this.ReF.HeaderText = "ReFm";
            this.ReF.Name = "ReF";
            this.ReF.ReadOnly = true;
            // 
            // ImF
            // 
            this.ImF.HeaderText = "ImFm";
            this.ImF.Name = "ImF";
            this.ImF.ReadOnly = true;
            // 
            // ReverseRe
            // 
            this.ReverseRe.HeaderText = "ReverseRe";
            this.ReverseRe.Name = "ReverseRe";
            this.ReverseRe.ReadOnly = true;
            // 
            // ReverseIm
            // 
            this.ReverseIm.HeaderText = "ReverseIm";
            this.ReverseIm.Name = "ReverseIm";
            this.ReverseIm.ReadOnly = true;
            // 
            // LeftRe
            // 
            this.LeftRe.HeaderText = "LeftRe";
            this.LeftRe.Name = "LeftRe";
            this.LeftRe.ReadOnly = true;
            this.LeftRe.Visible = false;
            // 
            // LeftIm
            // 
            this.LeftIm.HeaderText = "LeftIm";
            this.LeftIm.Name = "LeftIm";
            this.LeftIm.ReadOnly = true;
            this.LeftIm.Visible = false;
            // 
            // RightRe
            // 
            this.RightRe.HeaderText = "RightRe";
            this.RightRe.Name = "RightRe";
            this.RightRe.ReadOnly = true;
            this.RightRe.Visible = false;
            // 
            // RightIm
            // 
            this.RightIm.HeaderText = "RightIm";
            this.RightIm.Name = "RightIm";
            this.RightIm.ReadOnly = true;
            this.RightIm.Visible = false;
            // 
            // progressBar1
            // 
            this.progressBar1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.progressBar1.Location = new System.Drawing.Point(0, 489);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(1066, 23);
            this.progressBar1.Step = 1;
            this.progressBar1.TabIndex = 11;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.progressBar1);
            this.panel1.Controls.Add(this.dataGridView1);
            this.panel1.Controls.Add(this.menuStrip1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1066, 512);
            this.panel1.TabIndex = 1;
            // 
            // alphaRitmToolStripMenuItem
            // 
            this.alphaRitmToolStripMenuItem.Name = "alphaRitmToolStripMenuItem";
            this.alphaRitmToolStripMenuItem.Size = new System.Drawing.Size(75, 20);
            this.alphaRitmToolStripMenuItem.Text = "AlphaRitm";
            this.alphaRitmToolStripMenuItem.Click += new System.EventHandler(this.alphaRitmToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1066, 512);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem nToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem randomToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem functionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem furieToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem directToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reverseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem spectrToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem proprtiesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem parsevalEqualityToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem graficToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem inputToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem outputToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clearToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem functionToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem reFmToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem imFmToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem spectrToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem allToolStripMenuItem;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ToolStripMenuItem convolutionToolStripMenuItem;
        private System.Windows.Forms.DataGridViewTextBoxColumn Func;
        private System.Windows.Forms.DataGridViewTextBoxColumn Spectr;
        private System.Windows.Forms.DataGridViewTextBoxColumn G;
        private System.Windows.Forms.DataGridViewTextBoxColumn ReF;
        private System.Windows.Forms.DataGridViewTextBoxColumn ImF;
        private System.Windows.Forms.DataGridViewTextBoxColumn ReverseRe;
        private System.Windows.Forms.DataGridViewTextBoxColumn ReverseIm;
        private System.Windows.Forms.DataGridViewTextBoxColumn LeftRe;
        private System.Windows.Forms.DataGridViewTextBoxColumn LeftIm;
        private System.Windows.Forms.DataGridViewTextBoxColumn RightRe;
        private System.Windows.Forms.DataGridViewTextBoxColumn RightIm;
        private System.Windows.Forms.ToolStripMenuItem alphaRitmToolStripMenuItem;
    }
}

