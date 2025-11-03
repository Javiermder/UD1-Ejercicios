namespace UD1_EjGimnasio
{
    partial class Principal
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.linkLabel3 = new System.Windows.Forms.LinkLabel();
            this.enlace2 = new System.Windows.Forms.LinkLabel();
            this.enlace1 = new System.Windows.Forms.LinkLabel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::UD1_EjGimnasio.Properties.Resources.gym;
            this.pictureBox1.Location = new System.Drawing.Point(-2, -3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(356, 148);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.label1.Location = new System.Drawing.Point(67, 157);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(277, 31);
            this.label1.TabIndex = 1;
            this.label1.Text = "GIMNASIO OLYMPIA";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.linkLabel3);
            this.panel1.Controls.Add(this.enlace2);
            this.panel1.Controls.Add(this.enlace1);
            this.panel1.Location = new System.Drawing.Point(73, 202);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(281, 100);
            this.panel1.TabIndex = 2;
            // 
            // linkLabel3
            // 
            this.linkLabel3.AutoSize = true;
            this.linkLabel3.Enabled = false;
            this.linkLabel3.Location = new System.Drawing.Point(17, 75);
            this.linkLabel3.Name = "linkLabel3";
            this.linkLabel3.Size = new System.Drawing.Size(126, 13);
            this.linkLabel3.TabIndex = 2;
            this.linkLabel3.TabStop = true;
            this.linkLabel3.Text = "RESERVAR ACTIVIDAD";
            // 
            // enlace2
            // 
            this.enlace2.AutoSize = true;
            this.enlace2.Location = new System.Drawing.Point(17, 40);
            this.enlace2.Name = "enlace2";
            this.enlace2.Size = new System.Drawing.Size(150, 13);
            this.enlace2.TabIndex = 1;
            this.enlace2.TabStop = true;
            this.enlace2.Text = "ACTIVIDADES DEPORTIVAS";
            this.enlace2.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.enlace2Clikao);
            // 
            // enlace1
            // 
            this.enlace1.AutoSize = true;
            this.enlace1.Location = new System.Drawing.Point(14, 14);
            this.enlace1.Name = "enlace1";
            this.enlace1.Size = new System.Drawing.Size(110, 13);
            this.enlace1.TabIndex = 0;
            this.enlace1.TabStop = true;
            this.enlace1.Text = "CLIENTES DEL GYM";
            this.enlace1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.enlaceClick);
            // 
            // Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SandyBrown;
            this.ClientSize = new System.Drawing.Size(349, 299);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Principal";
            this.Text = "GIMNASIO OLIMPIA";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.LinkLabel enlace1;
        private System.Windows.Forms.LinkLabel linkLabel3;
        private System.Windows.Forms.LinkLabel enlace2;
    }
}

