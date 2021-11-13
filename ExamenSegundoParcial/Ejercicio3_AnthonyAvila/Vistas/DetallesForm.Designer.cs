
namespace Ejercicio3_AnthonyAvila.Vistas
{
    partial class DetallesForm
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
            this.DGVDetalles = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.SalirBTN = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DGVDetalles)).BeginInit();
            this.SuspendLayout();
            // 
            // DGVDetalles
            // 
            this.DGVDetalles.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVDetalles.Location = new System.Drawing.Point(12, 101);
            this.DGVDetalles.Name = "DGVDetalles";
            this.DGVDetalles.RowHeadersWidth = 51;
            this.DGVDetalles.RowTemplate.Height = 24;
            this.DGVDetalles.Size = new System.Drawing.Size(1308, 556);
            this.DGVDetalles.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(432, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(402, 51);
            this.label1.TabIndex = 1;
            this.label1.Text = "Tickets en proceso";
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
            // DetallesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(1332, 669);
            this.Controls.Add(this.SalirBTN);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.DGVDetalles);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "DetallesForm";
            this.Text = "Detalle";
            this.Load += new System.EventHandler(this.DetallesForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DGVDetalles)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.Button SalirBTN;
        public System.Windows.Forms.DataGridView DGVDetalles;
    }
}