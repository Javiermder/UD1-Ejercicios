namespace UD01_EjemploComponentesWF
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.btnValidate = new System.Windows.Forms.Button();
            this.txtUser = new System.Windows.Forms.TextBox();
            this.lvUser = new System.Windows.Forms.ListView();
            this.lbUser = new System.Windows.Forms.Label();
            this.lbTimer = new System.Windows.Forms.Label();
            this.errorUser = new System.Windows.Forms.ErrorProvider(this.components);
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorUser)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Usuario";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // btnValidate
            // 
            this.btnValidate.Location = new System.Drawing.Point(16, 41);
            this.btnValidate.Name = "btnValidate";
            this.btnValidate.Size = new System.Drawing.Size(75, 23);
            this.btnValidate.TabIndex = 1;
            this.btnValidate.Text = "VALIDAR";
            this.btnValidate.UseVisualStyleBackColor = true;
            this.btnValidate.Click += new System.EventHandler(this.btnValidate_Click);
            // 
            // txtUser
            // 
            this.txtUser.Location = new System.Drawing.Point(117, 13);
            this.txtUser.Name = "txtUser";
            this.txtUser.Size = new System.Drawing.Size(100, 20);
            this.txtUser.TabIndex = 2;
            // 
            // lvUser
            // 
            this.lvUser.HideSelection = false;
            this.lvUser.Location = new System.Drawing.Point(117, 52);
            this.lvUser.Name = "lvUser";
            this.lvUser.Size = new System.Drawing.Size(121, 97);
            this.lvUser.TabIndex = 3;
            this.lvUser.UseCompatibleStateImageBehavior = false;
            this.lvUser.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            this.lvUser.MouseLeave += new System.EventHandler(this.lvUser_MouseLeave);
            this.lvUser.MouseHover += new System.EventHandler(this.lvUser_MouseHover);
            // 
            // lbUser
            // 
            this.lbUser.AutoSize = true;
            this.lbUser.Location = new System.Drawing.Point(26, 95);
            this.lbUser.Name = "lbUser";
            this.lbUser.Size = new System.Drawing.Size(35, 13);
            this.lbUser.TabIndex = 4;
            this.lbUser.Text = "label2";
            this.lbUser.Visible = false;
            // 
            // lbTimer
            // 
            this.lbTimer.AutoSize = true;
            this.lbTimer.Location = new System.Drawing.Point(29, 123);
            this.lbTimer.Name = "lbTimer";
            this.lbTimer.Size = new System.Drawing.Size(35, 13);
            this.lbTimer.TabIndex = 5;
            this.lbTimer.Text = "label3";
            this.lbTimer.Visible = false;
            // 
            // errorUser
            // 
            this.errorUser.ContainerControl = this;
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(559, 316);
            this.Controls.Add(this.lbTimer);
            this.Controls.Add(this.lbUser);
            this.Controls.Add(this.lvUser);
            this.Controls.Add(this.txtUser);
            this.Controls.Add(this.btnValidate);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Ejemplo componentes";
            ((System.ComponentModel.ISupportInitialize)(this.errorUser)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnValidate;
        private System.Windows.Forms.TextBox txtUser;
        private System.Windows.Forms.ListView lvUser;
        private System.Windows.Forms.Label lbUser;
        private System.Windows.Forms.Label lbTimer;
        private System.Windows.Forms.ErrorProvider errorUser;
        private System.Windows.Forms.Timer timer1;
    }
}

