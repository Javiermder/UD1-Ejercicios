namespace UD1_Ejemplo2WF
{
    partial class Componentes
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.rbWindows = new System.Windows.Forms.RadioButton();
            this.rbLinux = new System.Windows.Forms.RadioButton();
            this.rbMac = new System.Windows.Forms.RadioButton();
            this.chkbWeb = new System.Windows.Forms.CheckBox();
            this.chkbMovile = new System.Windows.Forms.CheckBox();
            this.chkbIa = new System.Windows.Forms.CheckBox();
            this.nudHour = new System.Windows.Forms.NumericUpDown();
            this.btnReport = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.nudHour)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(153, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Elige tu sistema operativo";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(13, 118);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(125, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Elige tu especialidad";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 271);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(188, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Horas que dedicas al ordenador";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // rbWindows
            // 
            this.rbWindows.AutoSize = true;
            this.rbWindows.Location = new System.Drawing.Point(16, 39);
            this.rbWindows.Name = "rbWindows";
            this.rbWindows.Size = new System.Drawing.Size(69, 17);
            this.rbWindows.TabIndex = 3;
            this.rbWindows.TabStop = true;
            this.rbWindows.Text = "Windows";
            this.rbWindows.UseVisualStyleBackColor = true;
            // 
            // rbLinux
            // 
            this.rbLinux.AutoSize = true;
            this.rbLinux.Location = new System.Drawing.Point(16, 61);
            this.rbLinux.Name = "rbLinux";
            this.rbLinux.Size = new System.Drawing.Size(50, 17);
            this.rbLinux.TabIndex = 4;
            this.rbLinux.TabStop = true;
            this.rbLinux.Text = "Linux";
            this.rbLinux.UseVisualStyleBackColor = true;
            // 
            // rbMac
            // 
            this.rbMac.AutoSize = true;
            this.rbMac.Location = new System.Drawing.Point(16, 84);
            this.rbMac.Name = "rbMac";
            this.rbMac.Size = new System.Drawing.Size(61, 17);
            this.rbMac.TabIndex = 5;
            this.rbMac.TabStop = true;
            this.rbMac.Text = "MacOS";
            this.rbMac.UseVisualStyleBackColor = true;
            // 
            // chkbWeb
            // 
            this.chkbWeb.AutoSize = true;
            this.chkbWeb.Location = new System.Drawing.Point(12, 145);
            this.chkbWeb.Name = "chkbWeb";
            this.chkbWeb.Size = new System.Drawing.Size(114, 17);
            this.chkbWeb.TabIndex = 6;
            this.chkbWeb.Text = "Programación web";
            this.chkbWeb.UseVisualStyleBackColor = true;
            // 
            // chkbMovile
            // 
            this.chkbMovile.AutoSize = true;
            this.chkbMovile.Location = new System.Drawing.Point(12, 185);
            this.chkbMovile.Name = "chkbMovile";
            this.chkbMovile.Size = new System.Drawing.Size(118, 17);
            this.chkbMovile.TabIndex = 7;
            this.chkbMovile.Text = "Programacion movil";
            this.chkbMovile.UseVisualStyleBackColor = true;
            // 
            // chkbIa
            // 
            this.chkbIa.AutoSize = true;
            this.chkbIa.Location = new System.Drawing.Point(12, 220);
            this.chkbIa.Name = "chkbIa";
            this.chkbIa.Size = new System.Drawing.Size(36, 17);
            this.chkbIa.TabIndex = 8;
            this.chkbIa.Text = "IA";
            this.chkbIa.UseVisualStyleBackColor = true;
            // 
            // nudHour
            // 
            this.nudHour.Location = new System.Drawing.Point(16, 302);
            this.nudHour.Name = "nudHour";
            this.nudHour.Size = new System.Drawing.Size(120, 20);
            this.nudHour.TabIndex = 9;
            // 
            // btnReport
            // 
            this.btnReport.Location = new System.Drawing.Point(16, 350);
            this.btnReport.Name = "btnReport";
            this.btnReport.Size = new System.Drawing.Size(122, 23);
            this.btnReport.TabIndex = 10;
            this.btnReport.Text = "Generar  informe";
            this.btnReport.UseVisualStyleBackColor = true;
            this.btnReport.Click += new System.EventHandler(this.btnReport_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(432, 596);
            this.Controls.Add(this.btnReport);
            this.Controls.Add(this.nudHour);
            this.Controls.Add(this.chkbIa);
            this.Controls.Add(this.chkbMovile);
            this.Controls.Add(this.chkbWeb);
            this.Controls.Add(this.rbMac);
            this.Controls.Add(this.rbLinux);
            this.Controls.Add(this.rbWindows);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "Miniencuesta";
            ((System.ComponentModel.ISupportInitialize)(this.nudHour)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RadioButton rbWindows;
        private System.Windows.Forms.RadioButton rbLinux;
        private System.Windows.Forms.RadioButton rbMac;
        private System.Windows.Forms.CheckBox chkbWeb;
        private System.Windows.Forms.CheckBox chkbMovile;
        private System.Windows.Forms.CheckBox chkbIa;
        private System.Windows.Forms.NumericUpDown nudHour;
        private System.Windows.Forms.Button btnReport;
    }
}

