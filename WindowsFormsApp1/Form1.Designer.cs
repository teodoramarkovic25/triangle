namespace WindowsFormsApp1
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.meniToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.podesavanjaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.izadjiIzAplikacijeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cmbTrougao = new System.Windows.Forms.ComboBox();
            this.Trougao = new System.Windows.Forms.Label();
            this.btnIzracunaj = new System.Windows.Forms.Button();
            this.Obim = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblObim = new System.Windows.Forms.Label();
            this.lblPovrsina = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.meniToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(296, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // meniToolStripMenuItem
            // 
            this.meniToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.podesavanjaToolStripMenuItem,
            this.toolStripSeparator1,
            this.izadjiIzAplikacijeToolStripMenuItem});
            this.meniToolStripMenuItem.Name = "meniToolStripMenuItem";
            this.meniToolStripMenuItem.Size = new System.Drawing.Size(46, 20);
            this.meniToolStripMenuItem.Text = "Meni";
            // 
            // podesavanjaToolStripMenuItem
            // 
            this.podesavanjaToolStripMenuItem.Name = "podesavanjaToolStripMenuItem";
            this.podesavanjaToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.podesavanjaToolStripMenuItem.Text = "Podesavanja";
            this.podesavanjaToolStripMenuItem.Click += new System.EventHandler(this.podesavanjaToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(177, 6);
            // 
            // izadjiIzAplikacijeToolStripMenuItem
            // 
            this.izadjiIzAplikacijeToolStripMenuItem.Name = "izadjiIzAplikacijeToolStripMenuItem";
            this.izadjiIzAplikacijeToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.izadjiIzAplikacijeToolStripMenuItem.Text = "Izadji iz aplikacije";
            this.izadjiIzAplikacijeToolStripMenuItem.Click += new System.EventHandler(this.izadjiIzAplikacijeToolStripMenuItem_Click);
            // 
            // cmbTrougao
            // 
            this.cmbTrougao.FormattingEnabled = true;
            this.cmbTrougao.Items.AddRange(new object[] {
            "Obim",
            "Povrsina"});
            this.cmbTrougao.Location = new System.Drawing.Point(16, 63);
            this.cmbTrougao.Name = "cmbTrougao";
            this.cmbTrougao.Size = new System.Drawing.Size(121, 21);
            this.cmbTrougao.TabIndex = 1;
            // 
            // Trougao
            // 
            this.Trougao.AutoSize = true;
            this.Trougao.Location = new System.Drawing.Point(13, 47);
            this.Trougao.Name = "Trougao";
            this.Trougao.Size = new System.Drawing.Size(47, 13);
            this.Trougao.TabIndex = 2;
            this.Trougao.Text = "Trougao";
            // 
            // btnIzracunaj
            // 
            this.btnIzracunaj.Location = new System.Drawing.Point(184, 61);
            this.btnIzracunaj.Name = "btnIzracunaj";
            this.btnIzracunaj.Size = new System.Drawing.Size(75, 23);
            this.btnIzracunaj.TabIndex = 3;
            this.btnIzracunaj.Text = "Izracunaj";
            this.btnIzracunaj.UseVisualStyleBackColor = true;
            this.btnIzracunaj.Click += new System.EventHandler(this.btnIzracunaj_Click);
            // 
            // Obim
            // 
            this.Obim.AutoSize = true;
            this.Obim.Location = new System.Drawing.Point(16, 142);
            this.Obim.Name = "Obim";
            this.Obim.Size = new System.Drawing.Size(31, 13);
            this.Obim.TabIndex = 4;
            this.Obim.Text = "Obim";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 164);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Povrsina";
            // 
            // lblObim
            // 
            this.lblObim.AutoSize = true;
            this.lblObim.Location = new System.Drawing.Point(53, 142);
            this.lblObim.Name = "lblObim";
            this.lblObim.Size = new System.Drawing.Size(28, 13);
            this.lblObim.TabIndex = 6;
            this.lblObim.Text = "0.00";
            // 
            // lblPovrsina
            // 
            this.lblPovrsina.AutoSize = true;
            this.lblPovrsina.Location = new System.Drawing.Point(70, 164);
            this.lblPovrsina.Name = "lblPovrsina";
            this.lblPovrsina.Size = new System.Drawing.Size(28, 13);
            this.lblPovrsina.TabIndex = 7;
            this.lblPovrsina.Text = "0.00";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(296, 202);
            this.Controls.Add(this.lblPovrsina);
            this.Controls.Add(this.lblObim);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Obim);
            this.Controls.Add(this.btnIzracunaj);
            this.Controls.Add(this.Trougao);
            this.Controls.Add(this.cmbTrougao);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem meniToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem podesavanjaToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem izadjiIzAplikacijeToolStripMenuItem;
        private System.Windows.Forms.ComboBox cmbTrougao;
        private System.Windows.Forms.Label Trougao;
        private System.Windows.Forms.Button btnIzracunaj;
        private System.Windows.Forms.Label Obim;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblObim;
        private System.Windows.Forms.Label lblPovrsina;
    }
}

