namespace Gestion
{
    partial class Main
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
            this.TLYP = new System.Windows.Forms.TableLayoutPanel();
            this.SuspendLayout();
            // 
            // TLYP
            // 
            this.TLYP.BackColor = System.Drawing.SystemColors.Control;
            this.TLYP.ColumnCount = 1;
            this.TLYP.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.TLYP.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.TLYP.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.TLYP.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.TLYP.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.TLYP.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TLYP.Location = new System.Drawing.Point(0, 0);
            this.TLYP.Name = "TLYP";
            this.TLYP.RowCount = 1;
            this.TLYP.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.TLYP.Size = new System.Drawing.Size(200, 300);
            this.TLYP.TabIndex = 0;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(200, 300);
            this.Controls.Add(this.TLYP);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(216, 280);
            this.Name = "Main";
            this.Text = "Gestion - Formularios";
            this.Load += new System.EventHandler(this.Main_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel TLYP;
    }
}