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
            this.GB2 = new System.Windows.Forms.GroupBox();
            this.GB3 = new System.Windows.Forms.GroupBox();
            this.GBT1 = new System.Windows.Forms.TableLayoutPanel();
            this.GBT2 = new System.Windows.Forms.TableLayoutPanel();
            this.GBT3 = new System.Windows.Forms.TableLayoutPanel();
            this.GB1.SuspendLayout();
            this.GB2.SuspendLayout();
            this.GB3.SuspendLayout();
            this.SuspendLayout();
            // 
            // GB1
            // 
            this.GB1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.GB1.Controls.Add(this.GBT1);
            this.GB1.Location = new System.Drawing.Point(12, 12);
            this.GB1.Name = "GB1";
            this.GB1.Size = new System.Drawing.Size(212, 442);
            this.GB1.TabIndex = 0;
            this.GB1.TabStop = false;
            this.GB1.Text = "Forms Hechos en Clase";
            // 
            // GB2
            // 
            this.GB2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.GB2.Controls.Add(this.GBT2);
            this.GB2.Location = new System.Drawing.Point(230, 12);
            this.GB2.Name = "GB2";
            this.GB2.Size = new System.Drawing.Size(212, 442);
            this.GB2.TabIndex = 1;
            this.GB2.TabStop = false;
            this.GB2.Text = "Forms Propios";
            // 
            // GB3
            // 
            this.GB3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.GB3.Controls.Add(this.GBT3);
            this.GB3.Location = new System.Drawing.Point(448, 12);
            this.GB3.Name = "GB3";
            this.GB3.Size = new System.Drawing.Size(212, 442);
            this.GB3.TabIndex = 2;
            this.GB3.TabStop = false;
            this.GB3.Text = "Sin Clasificar";
            // 
            // GBT1
            // 
            this.GBT1.BackColor = System.Drawing.Color.Transparent;
            this.GBT1.ColumnCount = 1;
            this.GBT1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.GBT1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.GBT1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GBT1.Location = new System.Drawing.Point(3, 16);
            this.GBT1.Name = "GBT1";
            this.GBT1.RowCount = 1;
            this.GBT1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.GBT1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.GBT1.Size = new System.Drawing.Size(206, 423);
            this.GBT1.TabIndex = 0;
            // 
            // GBT2
            // 
            this.GBT2.BackColor = System.Drawing.Color.Transparent;
            this.GBT2.ColumnCount = 1;
            this.GBT2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.GBT2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.GBT2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GBT2.Location = new System.Drawing.Point(3, 16);
            this.GBT2.Name = "GBT2";
            this.GBT2.RowCount = 1;
            this.GBT2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.GBT2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.GBT2.Size = new System.Drawing.Size(206, 423);
            this.GBT2.TabIndex = 1;
            // 
            // GBT3
            // 
            this.GBT3.BackColor = System.Drawing.Color.Transparent;
            this.GBT3.ColumnCount = 1;
            this.GBT3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.GBT3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GBT3.Location = new System.Drawing.Point(3, 16);
            this.GBT3.Name = "GBT3";
            this.GBT3.RowCount = 1;
            this.GBT3.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.GBT3.Size = new System.Drawing.Size(206, 423);
            this.GBT3.TabIndex = 2;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(670, 457);
            this.Controls.Add(this.GB3);
            this.Controls.Add(this.GB2);
            this.Controls.Add(this.GB1);
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.GB1.ResumeLayout(false);
            this.GB2.ResumeLayout(false);
            this.GB3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox GB1;
        private System.Windows.Forms.GroupBox GB2;
        private System.Windows.Forms.GroupBox GB3;
        private System.Windows.Forms.TableLayoutPanel GBT1;
        private System.Windows.Forms.TableLayoutPanel GBT2;
        private System.Windows.Forms.TableLayoutPanel GBT3;
    }
}