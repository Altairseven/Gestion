namespace Gestion
{
    partial class MaskedTB_Ejemplo
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
            this.tb1 = new Gestion.Maskedtextdownnuestro();
            this.tb2 = new Gestion.Maskedtextdownnuestro();
            this.tb3 = new Gestion.Maskedtextdownnuestro();
            this.SuspendLayout();
            // 
            // tb1
            // 
            this.tb1.Location = new System.Drawing.Point(21, 24);
            this.tb1.Name = "tb1";
            this.tb1.Size = new System.Drawing.Size(150, 20);
            this.tb1.TabIndex = 0;
            // 
            // tb2
            // 
            this.tb2.Location = new System.Drawing.Point(21, 74);
            this.tb2.Name = "tb2";
            this.tb2.Size = new System.Drawing.Size(150, 20);
            this.tb2.TabIndex = 1;
            // 
            // tb3
            // 
            this.tb3.Location = new System.Drawing.Point(21, 123);
            this.tb3.Name = "tb3";
            this.tb3.Size = new System.Drawing.Size(150, 20);
            this.tb3.TabIndex = 2;
            // 
            // MaskedTB_Ejemplo
            // 
            this.ClientSize = new System.Drawing.Size(192, 205);
            this.Controls.Add(this.tb3);
            this.Controls.Add(this.tb2);
            this.Controls.Add(this.tb1);
            this.Name = "MaskedTB_Ejemplo";
            this.ResumeLayout(false);

        }


        #endregion

        private Maskedtextdownnuestro tb1;
        private Maskedtextdownnuestro tb2;
        private Maskedtextdownnuestro tb3;
    }
}

