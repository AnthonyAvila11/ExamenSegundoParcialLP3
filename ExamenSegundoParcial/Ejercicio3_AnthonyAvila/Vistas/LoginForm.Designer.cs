
namespace Ejercicio3_AnthonyAvila
{
    partial class LoginForm
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
            this.UsuarioTBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Contra1TBox = new System.Windows.Forms.TextBox();
            this.SalirBTN = new System.Windows.Forms.Button();
            this.LoginBTN = new System.Windows.Forms.Button();
            this.RegistroBTN = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::Ejercicio3_AnthonyAvila.Properties.Resources.pngwing_com__1_;
            this.pictureBox1.Location = new System.Drawing.Point(37, 50);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(236, 206);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // UsuarioTBox
            // 
            this.UsuarioTBox.Location = new System.Drawing.Point(388, 94);
            this.UsuarioTBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.UsuarioTBox.Name = "UsuarioTBox";
            this.UsuarioTBox.Size = new System.Drawing.Size(307, 22);
            this.UsuarioTBox.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(496, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 25);
            this.label1.TabIndex = 2;
            this.label1.Text = "Usuario:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(475, 144);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(131, 25);
            this.label2.TabIndex = 4;
            this.label2.Text = "Contraseña:";
            // 
            // Contra1TBox
            // 
            this.Contra1TBox.Location = new System.Drawing.Point(388, 188);
            this.Contra1TBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Contra1TBox.Name = "Contra1TBox";
            this.Contra1TBox.PasswordChar = '*';
            this.Contra1TBox.Size = new System.Drawing.Size(307, 22);
            this.Contra1TBox.TabIndex = 3;
            // 
            // SalirBTN
            // 
            this.SalirBTN.BackColor = System.Drawing.Color.Transparent;
            this.SalirBTN.BackgroundImage = global::Ejercicio3_AnthonyAvila.Properties.Resources.salir;
            this.SalirBTN.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.SalirBTN.ForeColor = System.Drawing.Color.Transparent;
            this.SalirBTN.Location = new System.Drawing.Point(12, 327);
            this.SalirBTN.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.SalirBTN.Name = "SalirBTN";
            this.SalirBTN.Size = new System.Drawing.Size(49, 49);
            this.SalirBTN.TabIndex = 5;
            this.SalirBTN.UseVisualStyleBackColor = false;
            this.SalirBTN.Click += new System.EventHandler(this.button1_Click);
            // 
            // LoginBTN
            // 
            this.LoginBTN.BackColor = System.Drawing.Color.Transparent;
            this.LoginBTN.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LoginBTN.Location = new System.Drawing.Point(479, 231);
            this.LoginBTN.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.LoginBTN.Name = "LoginBTN";
            this.LoginBTN.Size = new System.Drawing.Size(123, 37);
            this.LoginBTN.TabIndex = 6;
            this.LoginBTN.Text = "Login";
            this.LoginBTN.UseVisualStyleBackColor = false;
            // 
            // RegistroBTN
            // 
            this.RegistroBTN.BackColor = System.Drawing.Color.Transparent;
            this.RegistroBTN.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RegistroBTN.Location = new System.Drawing.Point(589, 327);
            this.RegistroBTN.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.RegistroBTN.Name = "RegistroBTN";
            this.RegistroBTN.Size = new System.Drawing.Size(141, 39);
            this.RegistroBTN.TabIndex = 7;
            this.RegistroBTN.Text = "Registrarse";
            this.RegistroBTN.UseVisualStyleBackColor = false;
            this.RegistroBTN.Click += new System.EventHandler(this.RegistroBTN_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.Image = global::Ejercicio3_AnthonyAvila.Properties.Resources.usuario;
            this.pictureBox2.Location = new System.Drawing.Point(323, 82);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(48, 49);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 8;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox3.Image = global::Ejercicio3_AnthonyAvila.Properties.Resources.contraseña;
            this.pictureBox3.Location = new System.Drawing.Point(323, 171);
            this.pictureBox3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(59, 55);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 9;
            this.pictureBox3.TabStop = false;
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(753, 388);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.RegistroBTN);
            this.Controls.Add(this.LoginBTN);
            this.Controls.Add(this.SalirBTN);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Contra1TBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.UsuarioTBox);
            this.Controls.Add(this.pictureBox1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "LoginForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.Load += new System.EventHandler(this.Login_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.PictureBox pictureBox1;
        public System.Windows.Forms.TextBox UsuarioTBox;
        public System.Windows.Forms.Label label1;
        public System.Windows.Forms.Label label2;
        public System.Windows.Forms.TextBox Contra1TBox;
        public System.Windows.Forms.Button SalirBTN;
        public System.Windows.Forms.Button LoginBTN;
        public System.Windows.Forms.Button RegistroBTN;
        public System.Windows.Forms.PictureBox pictureBox3;
        public System.Windows.Forms.PictureBox pictureBox2;
    }
}

