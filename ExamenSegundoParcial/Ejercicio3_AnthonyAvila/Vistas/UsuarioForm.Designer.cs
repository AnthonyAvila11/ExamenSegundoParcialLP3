
namespace Ejercicio3_AnthonyAvila
{
    partial class UsuarioForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.NombreTextBox = new System.Windows.Forms.TextBox();
            this.ApellidoTextBox = new System.Windows.Forms.TextBox();
            this.CorreoTextBox = new System.Windows.Forms.TextBox();
            this.IdtextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.SalirBTN = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(111, 148);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(116, 198);
            this.label2.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(117, 29);
            this.label2.TabIndex = 1;
            this.label2.Text = "Apellido:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(130, 259);
            this.label3.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(101, 29);
            this.label3.TabIndex = 2;
            this.label3.Text = "Correo:";
            // 
            // NombreTextBox
            // 
            this.NombreTextBox.Enabled = false;
            this.NombreTextBox.Location = new System.Drawing.Point(253, 148);
            this.NombreTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.NombreTextBox.Name = "NombreTextBox";
            this.NombreTextBox.ReadOnly = true;
            this.NombreTextBox.Size = new System.Drawing.Size(495, 34);
            this.NombreTextBox.TabIndex = 3;
            // 
            // ApellidoTextBox
            // 
            this.ApellidoTextBox.Enabled = false;
            this.ApellidoTextBox.Location = new System.Drawing.Point(253, 203);
            this.ApellidoTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.ApellidoTextBox.Name = "ApellidoTextBox";
            this.ApellidoTextBox.ReadOnly = true;
            this.ApellidoTextBox.Size = new System.Drawing.Size(495, 34);
            this.ApellidoTextBox.TabIndex = 4;
            // 
            // CorreoTextBox
            // 
            this.CorreoTextBox.Enabled = false;
            this.CorreoTextBox.Location = new System.Drawing.Point(253, 259);
            this.CorreoTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.CorreoTextBox.Name = "CorreoTextBox";
            this.CorreoTextBox.ReadOnly = true;
            this.CorreoTextBox.Size = new System.Drawing.Size(495, 34);
            this.CorreoTextBox.TabIndex = 5;
            // 
            // IdtextBox
            // 
            this.IdtextBox.Enabled = false;
            this.IdtextBox.Location = new System.Drawing.Point(253, 87);
            this.IdtextBox.Margin = new System.Windows.Forms.Padding(4);
            this.IdtextBox.Name = "IdtextBox";
            this.IdtextBox.ReadOnly = true;
            this.IdtextBox.Size = new System.Drawing.Size(495, 34);
            this.IdtextBox.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(182, 91);
            this.label4.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 29);
            this.label4.TabIndex = 7;
            this.label4.Text = "ID:";
            // 
            // SalirBTN
            // 
            this.SalirBTN.BackColor = System.Drawing.Color.Transparent;
            this.SalirBTN.BackgroundImage = global::Ejercicio3_AnthonyAvila.Properties.Resources.salir;
            this.SalirBTN.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.SalirBTN.ForeColor = System.Drawing.Color.Transparent;
            this.SalirBTN.Location = new System.Drawing.Point(12, 11);
            this.SalirBTN.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.SalirBTN.Name = "SalirBTN";
            this.SalirBTN.Size = new System.Drawing.Size(49, 49);
            this.SalirBTN.TabIndex = 9;
            this.SalirBTN.UseVisualStyleBackColor = false;
            this.SalirBTN.Click += new System.EventHandler(this.SalirBTN_Click);
            // 
            // UsuarioForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(15F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(911, 401);
            this.Controls.Add(this.SalirBTN);
            this.Controls.Add(this.IdtextBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.CorreoTextBox);
            this.Controls.Add(this.ApellidoTextBox);
            this.Controls.Add(this.NombreTextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "UsuarioForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Usuario";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox NombreTextBox;
        private System.Windows.Forms.TextBox ApellidoTextBox;
        private System.Windows.Forms.TextBox CorreoTextBox;
        private System.Windows.Forms.TextBox IdtextBox;
        private System.Windows.Forms.Label label4;
        public System.Windows.Forms.Button SalirBTN;
    }
}