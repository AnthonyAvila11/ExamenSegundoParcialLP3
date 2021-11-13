
namespace Ejercicio3_AnthonyAvila.Vistas
{
    partial class ServiciosForm
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
            this.CelularesRadioButton = new System.Windows.Forms.RadioButton();
            this.CompuRadioButton = new System.Windows.Forms.RadioButton();
            this.CelularesGBX = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.CelNombreTBox = new System.Windows.Forms.TextBox();
            this.CompuGBX = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.CompuNombreTBox = new System.Windows.Forms.TextBox();
            this.SalirBTN = new System.Windows.Forms.Button();
            this.ProcesoServicioBTN = new System.Windows.Forms.Button();
            this.CelularesGBX.SuspendLayout();
            this.CompuGBX.SuspendLayout();
            this.SuspendLayout();
            // 
            // CelularesRadioButton
            // 
            this.CelularesRadioButton.AutoSize = true;
            this.CelularesRadioButton.Location = new System.Drawing.Point(186, 66);
            this.CelularesRadioButton.Margin = new System.Windows.Forms.Padding(4);
            this.CelularesRadioButton.Name = "CelularesRadioButton";
            this.CelularesRadioButton.Size = new System.Drawing.Size(237, 24);
            this.CelularesRadioButton.TabIndex = 0;
            this.CelularesRadioButton.Text = "Reparacion de Celulares";
            this.CelularesRadioButton.UseVisualStyleBackColor = true;
            this.CelularesRadioButton.CheckedChanged += new System.EventHandler(this.CelularesRadioButton_CheckedChanged);
            // 
            // CompuRadioButton
            // 
            this.CompuRadioButton.AutoSize = true;
            this.CompuRadioButton.Location = new System.Drawing.Point(739, 66);
            this.CompuRadioButton.Margin = new System.Windows.Forms.Padding(4);
            this.CompuRadioButton.Name = "CompuRadioButton";
            this.CompuRadioButton.Size = new System.Drawing.Size(278, 24);
            this.CompuRadioButton.TabIndex = 1;
            this.CompuRadioButton.Text = "Reparacion de Computadoras";
            this.CompuRadioButton.UseVisualStyleBackColor = true;
            this.CompuRadioButton.CheckedChanged += new System.EventHandler(this.CompuRadioButton_CheckedChanged);
            // 
            // CelularesGBX
            // 
            this.CelularesGBX.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.CelularesGBX.Controls.Add(this.label1);
            this.CelularesGBX.Controls.Add(this.CelNombreTBox);
            this.CelularesGBX.Location = new System.Drawing.Point(36, 124);
            this.CelularesGBX.Name = "CelularesGBX";
            this.CelularesGBX.Size = new System.Drawing.Size(561, 268);
            this.CelularesGBX.TabIndex = 2;
            this.CelularesGBX.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(159, 95);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(250, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Que marca es el dispositivo:";
            // 
            // CelNombreTBox
            // 
            this.CelNombreTBox.Location = new System.Drawing.Point(99, 143);
            this.CelNombreTBox.Name = "CelNombreTBox";
            this.CelNombreTBox.Size = new System.Drawing.Size(374, 27);
            this.CelNombreTBox.TabIndex = 0;
            // 
            // CompuGBX
            // 
            this.CompuGBX.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.CompuGBX.Controls.Add(this.label2);
            this.CompuGBX.Controls.Add(this.CompuNombreTBox);
            this.CompuGBX.Location = new System.Drawing.Point(621, 124);
            this.CompuGBX.Name = "CompuGBX";
            this.CompuGBX.Size = new System.Drawing.Size(559, 268);
            this.CompuGBX.TabIndex = 3;
            this.CompuGBX.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(181, 95);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(185, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Que marca es la PC:";
            // 
            // CompuNombreTBox
            // 
            this.CompuNombreTBox.Location = new System.Drawing.Point(109, 143);
            this.CompuNombreTBox.Name = "CompuNombreTBox";
            this.CompuNombreTBox.Size = new System.Drawing.Size(343, 27);
            this.CompuNombreTBox.TabIndex = 1;
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
            this.SalirBTN.TabIndex = 6;
            this.SalirBTN.UseVisualStyleBackColor = false;
            this.SalirBTN.Click += new System.EventHandler(this.SalirBTN_Click);
            // 
            // ProcesoServicioBTN
            // 
            this.ProcesoServicioBTN.Location = new System.Drawing.Point(409, 442);
            this.ProcesoServicioBTN.Name = "ProcesoServicioBTN";
            this.ProcesoServicioBTN.Size = new System.Drawing.Size(414, 56);
            this.ProcesoServicioBTN.TabIndex = 7;
            this.ProcesoServicioBTN.Text = "Procesar pedido de servicio";
            this.ProcesoServicioBTN.UseVisualStyleBackColor = true;
            this.ProcesoServicioBTN.Click += new System.EventHandler(this.ProcesoServicioBTN_Click);
            // 
            // ServiciosForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(1216, 555);
            this.Controls.Add(this.ProcesoServicioBTN);
            this.Controls.Add(this.SalirBTN);
            this.Controls.Add(this.CompuGBX);
            this.Controls.Add(this.CelularesGBX);
            this.Controls.Add(this.CompuRadioButton);
            this.Controls.Add(this.CelularesRadioButton);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "ServiciosForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Servicios";
            this.CelularesGBX.ResumeLayout(false);
            this.CelularesGBX.PerformLayout();
            this.CompuGBX.ResumeLayout(false);
            this.CompuGBX.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.GroupBox CelularesGBX;
        private System.Windows.Forms.GroupBox CompuGBX;
        public System.Windows.Forms.Button SalirBTN;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.Button ProcesoServicioBTN;
        public System.Windows.Forms.TextBox CelNombreTBox;
        public System.Windows.Forms.TextBox CompuNombreTBox;
        public System.Windows.Forms.RadioButton CelularesRadioButton;
        public System.Windows.Forms.RadioButton CompuRadioButton;
    }
}