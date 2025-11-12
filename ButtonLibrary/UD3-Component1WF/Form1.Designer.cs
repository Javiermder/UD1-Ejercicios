namespace UD3_Component1WF
{
    partial class Form1
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
            this.userControl11 = new ButtonLibrary.UserControl1();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.chbMessage = new System.Windows.Forms.CheckBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // userControl11
            // 
            this.userControl11.Location = new System.Drawing.Point(49, 19);
            this.userControl11.Name = "userControl11";
            this.userControl11.Size = new System.Drawing.Size(236, 129);
            this.userControl11.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.chbMessage);
            this.groupBox1.Controls.Add(this.userControl11);
            this.groupBox1.Location = new System.Drawing.Point(12, 58);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(549, 256);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Ejemplo componentes";
            // 
            // chbMessage
            // 
            this.chbMessage.AutoSize = true;
            this.chbMessage.Location = new System.Drawing.Point(210, 43);
            this.chbMessage.Name = "chbMessage";
            this.chbMessage.Size = new System.Drawing.Size(106, 17);
            this.chbMessage.TabIndex = 1;
            this.chbMessage.Text = "Cambiar mensaje";
            this.chbMessage.UseVisualStyleBackColor = true;
            this.chbMessage.CheckedChanged += new System.EventHandler(this.chbMessage_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private ButtonLibrary.UserControl1 userControl11;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox chbMessage;
    }
}

