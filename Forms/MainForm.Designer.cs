namespace Gestion {
    partial class MainForm {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.GB1 = new System.Windows.Forms.GroupBox();
            this.FLP1 = new System.Windows.Forms.FlowLayoutPanel();
            this.GB2 = new System.Windows.Forms.GroupBox();
            this.FLP2 = new System.Windows.Forms.FlowLayoutPanel();
            this.GB3 = new System.Windows.Forms.GroupBox();
            this.FLP3 = new System.Windows.Forms.FlowLayoutPanel();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.toolStripComboBox1 = new System.Windows.Forms.ToolStripComboBox();
            this.conectarAToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.FLPMain = new System.Windows.Forms.FlowLayoutPanel();
            this.GB1.SuspendLayout();
            this.GB2.SuspendLayout();
            this.GB3.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.FLPMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // GB1
            // 
            this.GB1.Controls.Add(this.FLP1);
            this.GB1.Location = new System.Drawing.Point(3, 3);
            this.GB1.Name = "GB1";
            this.GB1.Size = new System.Drawing.Size(212, 397);
            this.GB1.TabIndex = 0;
            this.GB1.TabStop = false;
            this.GB1.Text = "Forms Hechos en Clase";
            // 
            // FLP1
            // 
            this.FLP1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.FLP1.Location = new System.Drawing.Point(3, 16);
            this.FLP1.Name = "FLP1";
            this.FLP1.Size = new System.Drawing.Size(206, 378);
            this.FLP1.TabIndex = 0;
            // 
            // GB2
            // 
            this.GB2.Controls.Add(this.FLP2);
            this.GB2.Location = new System.Drawing.Point(221, 3);
            this.GB2.Name = "GB2";
            this.GB2.Size = new System.Drawing.Size(212, 397);
            this.GB2.TabIndex = 1;
            this.GB2.TabStop = false;
            this.GB2.Text = "Forms Propios";
            // 
            // FLP2
            // 
            this.FLP2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.FLP2.Location = new System.Drawing.Point(3, 16);
            this.FLP2.Name = "FLP2";
            this.FLP2.Size = new System.Drawing.Size(206, 378);
            this.FLP2.TabIndex = 1;
            // 
            // GB3
            // 
            this.GB3.Controls.Add(this.FLP3);
            this.GB3.Location = new System.Drawing.Point(439, 3);
            this.GB3.Name = "GB3";
            this.GB3.Size = new System.Drawing.Size(212, 397);
            this.GB3.TabIndex = 2;
            this.GB3.TabStop = false;
            this.GB3.Text = "Sin Clasificar";
            // 
            // FLP3
            // 
            this.FLP3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.FLP3.Location = new System.Drawing.Point(3, 16);
            this.FLP3.Name = "FLP3";
            this.FLP3.Size = new System.Drawing.Size(206, 378);
            this.FLP3.TabIndex = 1;
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.Transparent;
            this.menuStrip1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripComboBox1,
            this.conectarAToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(661, 27);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // toolStripComboBox1
            // 
            this.toolStripComboBox1.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripComboBox1.FlatStyle = System.Windows.Forms.FlatStyle.Standard;
            this.toolStripComboBox1.Margin = new System.Windows.Forms.Padding(1, 0, 10, 0);
            this.toolStripComboBox1.Name = "toolStripComboBox1";
            this.toolStripComboBox1.Size = new System.Drawing.Size(121, 23);
            this.toolStripComboBox1.SelectedIndexChanged += new System.EventHandler(this.toolStripComboBox1_IndexChanged);
            // 
            // conectarAToolStripMenuItem
            // 
            this.conectarAToolStripMenuItem.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.conectarAToolStripMenuItem.Name = "conectarAToolStripMenuItem";
            this.conectarAToolStripMenuItem.Size = new System.Drawing.Size(81, 23);
            this.conectarAToolStripMenuItem.Text = "Conectar A:";
            this.conectarAToolStripMenuItem.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // FLPMain
            // 
            this.FLPMain.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.FLPMain.BackColor = System.Drawing.Color.Transparent;
            this.FLPMain.Controls.Add(this.GB1);
            this.FLPMain.Controls.Add(this.GB2);
            this.FLPMain.Controls.Add(this.GB3);
            this.FLPMain.Location = new System.Drawing.Point(2, 28);
            this.FLPMain.Name = "FLPMain";
            this.FLPMain.Size = new System.Drawing.Size(657, 400);
            this.FLPMain.TabIndex = 4;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(661, 437);
            this.Controls.Add(this.FLPMain);
            this.Controls.Add(this.menuStrip1);
            this.Name = "MainForm";
            this.Text = "Proyecto Gestion";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.GB1.ResumeLayout(false);
            this.GB2.ResumeLayout(false);
            this.GB3.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.FLPMain.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox GB1;
        private System.Windows.Forms.GroupBox GB2;
        private System.Windows.Forms.GroupBox GB3;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripComboBox toolStripComboBox1;
        private System.Windows.Forms.ToolStripMenuItem conectarAToolStripMenuItem;
        private System.Windows.Forms.FlowLayoutPanel FLP1;
        private System.Windows.Forms.FlowLayoutPanel FLP2;
        private System.Windows.Forms.FlowLayoutPanel FLP3;
        private System.Windows.Forms.FlowLayoutPanel FLPMain;
    }
}