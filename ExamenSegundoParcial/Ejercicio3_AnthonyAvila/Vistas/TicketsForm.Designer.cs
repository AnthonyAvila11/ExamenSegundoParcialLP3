
namespace Ejercicio3_AnthonyAvila.Vistas
{
    partial class TicketsForm
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.TicketBtn = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.DescripcionTBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.ModeloTBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.TipoServicioTBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.IdClienteTBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SalirBTN = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.TicketBtn);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.DescripcionTBox);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.ModeloTBox);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.TipoServicioTBox);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.IdClienteTBox);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(35, 112);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1391, 477);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // TicketBtn
            // 
            this.TicketBtn.Location = new System.Drawing.Point(405, 373);
            this.TicketBtn.Name = "TicketBtn";
            this.TicketBtn.Size = new System.Drawing.Size(405, 65);
            this.TicketBtn.TabIndex = 9;
            this.TicketBtn.Text = "Enviar Ticket";
            this.TicketBtn.UseVisualStyleBackColor = true;
            this.TicketBtn.Click += new System.EventHandler(this.TicketBtn_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(627, 308);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(495, 20);
            this.label5.TabIndex = 8;
            this.label5.Text = "(Describa cual es que problema que presenta su aparato)";
            // 
            // DescripcionTBox
            // 
            this.DescripcionTBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DescripcionTBox.Location = new System.Drawing.Point(522, 252);
            this.DescripcionTBox.Name = "DescripcionTBox";
            this.DescripcionTBox.Size = new System.Drawing.Size(698, 30);
            this.DescripcionTBox.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(173, 255);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(321, 29);
            this.label4.TabIndex = 6;
            this.label4.Text = "Descripcion del problema:";
            // 
            // ModeloTBox
            // 
            this.ModeloTBox.Location = new System.Drawing.Point(522, 192);
            this.ModeloTBox.Name = "ModeloTBox";
            this.ModeloTBox.Size = new System.Drawing.Size(698, 34);
            this.ModeloTBox.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(386, 197);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(108, 29);
            this.label3.TabIndex = 4;
            this.label3.Text = "Modelo:";
            // 
            // TipoServicioTBox
            // 
            this.TipoServicioTBox.Location = new System.Drawing.Point(522, 132);
            this.TipoServicioTBox.Name = "TipoServicioTBox";
            this.TipoServicioTBox.Size = new System.Drawing.Size(698, 34);
            this.TipoServicioTBox.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(281, 137);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(213, 29);
            this.label2.TabIndex = 2;
            this.label2.Text = "Tipo de Servicio:";
            // 
            // IdClienteTBox
            // 
            this.IdClienteTBox.Location = new System.Drawing.Point(522, 73);
            this.IdClienteTBox.Name = "IdClienteTBox";
            this.IdClienteTBox.Size = new System.Drawing.Size(698, 34);
            this.IdClienteTBox.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(295, 78);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(199, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre cliente:";
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
            this.SalirBTN.TabIndex = 7;
            this.SalirBTN.UseVisualStyleBackColor = false;
            this.SalirBTN.Click += new System.EventHandler(this.SalirBTN_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Ejercicio3_AnthonyAvila.Properties.Resources.tickets;
            this.pictureBox1.Location = new System.Drawing.Point(666, 11);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(130, 112);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // TicketsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(15F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(1458, 627);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.SalirBTN);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.Name = "TicketsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tickets";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        public System.Windows.Forms.Button SalirBTN;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.PictureBox pictureBox1;
        public System.Windows.Forms.TextBox DescripcionTBox;
        public System.Windows.Forms.Button TicketBtn;
        public System.Windows.Forms.TextBox ModeloTBox;
        public System.Windows.Forms.TextBox TipoServicioTBox;
        public System.Windows.Forms.TextBox IdClienteTBox;
    }
}