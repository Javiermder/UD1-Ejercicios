namespace ButtonLibrary
{
    partial class UserControl1
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

        #region Código generado por el Diseñador de componentes

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnPost = new System.Windows.Forms.Button();
            this.lbResult = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnPost
            // 
            this.btnPost.Location = new System.Drawing.Point(20, 18);
            this.btnPost.Name = "btnPost";
            this.btnPost.Size = new System.Drawing.Size(136, 43);
            this.btnPost.TabIndex = 0;
            this.btnPost.Text = "Enviar";
            this.btnPost.UseVisualStyleBackColor = true;
            this.btnPost.Click += new System.EventHandler(this.btnPost_Click);
            this.btnPost.MouseLeave += new System.EventHandler(this.btnPost_MouseLeave);
            this.btnPost.MouseHover += new System.EventHandler(this.btnPost_MouseHover);
            // 
            // lbResult
            // 
            this.lbResult.AutoSize = true;
            this.lbResult.Location = new System.Drawing.Point(17, 64);
            this.lbResult.Name = "lbResult";
            this.lbResult.Size = new System.Drawing.Size(35, 13);
            this.lbResult.TabIndex = 1;
            this.lbResult.Text = "label1";
            this.lbResult.Visible = false;
            this.lbResult.Click += new System.EventHandler(this.lbResult_Click);
            this.lbResult.MouseHover += new System.EventHandler(this.lbResult_MouseHover);
            // 
            // UserControl1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lbResult);
            this.Controls.Add(this.btnPost);
            this.Name = "UserControl1";
            this.Size = new System.Drawing.Size(236, 129);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnPost;
        private System.Windows.Forms.Label lbResult;
    }
}
