namespace Casa_Empeños
{
    partial class Facturacion
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
            this.lblNomComp = new System.Windows.Forms.Label();
            this.lblApellidoComp = new System.Windows.Forms.Label();
            this.lblIDComp = new System.Windows.Forms.Label();
            this.lblVendedor = new System.Windows.Forms.Label();
            this.txtNomComp = new System.Windows.Forms.TextBox();
            this.txtApeComp = new System.Windows.Forms.TextBox();
            this.txtIDComp = new System.Windows.Forms.TextBox();
            this.txtVendedor = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblNomComp
            // 
            this.lblNomComp.AutoSize = true;
            this.lblNomComp.Location = new System.Drawing.Point(12, 20);
            this.lblNomComp.Name = "lblNomComp";
            this.lblNomComp.Size = new System.Drawing.Size(101, 13);
            this.lblNomComp.TabIndex = 0;
            this.lblNomComp.Text = "Nombre Comprador:";
            // 
            // lblApellidoComp
            // 
            this.lblApellidoComp.AutoSize = true;
            this.lblApellidoComp.Location = new System.Drawing.Point(12, 70);
            this.lblApellidoComp.Name = "lblApellidoComp";
            this.lblApellidoComp.Size = new System.Drawing.Size(101, 13);
            this.lblApellidoComp.TabIndex = 1;
            this.lblApellidoComp.Text = "Apellido Comprador:";
            // 
            // lblIDComp
            // 
            this.lblIDComp.AutoSize = true;
            this.lblIDComp.Location = new System.Drawing.Point(234, 23);
            this.lblIDComp.Name = "lblIDComp";
            this.lblIDComp.Size = new System.Drawing.Size(108, 13);
            this.lblIDComp.TabIndex = 2;
            this.lblIDComp.Text = "Identidad Comprador:";
            // 
            // lblVendedor
            // 
            this.lblVendedor.AutoSize = true;
            this.lblVendedor.Location = new System.Drawing.Point(279, 70);
            this.lblVendedor.Name = "lblVendedor";
            this.lblVendedor.Size = new System.Drawing.Size(56, 13);
            this.lblVendedor.TabIndex = 3;
            this.lblVendedor.Text = "Vendedor:";
            // 
            // txtNomComp
            // 
            this.txtNomComp.Location = new System.Drawing.Point(119, 23);
            this.txtNomComp.Name = "txtNomComp";
            this.txtNomComp.Size = new System.Drawing.Size(100, 20);
            this.txtNomComp.TabIndex = 4;
            // 
            // txtApeComp
            // 
            this.txtApeComp.Location = new System.Drawing.Point(119, 67);
            this.txtApeComp.Name = "txtApeComp";
            this.txtApeComp.Size = new System.Drawing.Size(100, 20);
            this.txtApeComp.TabIndex = 5;
            // 
            // txtIDComp
            // 
            this.txtIDComp.Location = new System.Drawing.Point(348, 20);
            this.txtIDComp.Name = "txtIDComp";
            this.txtIDComp.Size = new System.Drawing.Size(100, 20);
            this.txtIDComp.TabIndex = 6;
            // 
            // txtVendedor
            // 
            this.txtVendedor.Location = new System.Drawing.Point(346, 67);
            this.txtVendedor.Name = "txtVendedor";
            this.txtVendedor.Size = new System.Drawing.Size(100, 20);
            this.txtVendedor.TabIndex = 7;
            // 
            // Facturacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(458, 261);
            this.Controls.Add(this.txtVendedor);
            this.Controls.Add(this.txtIDComp);
            this.Controls.Add(this.txtApeComp);
            this.Controls.Add(this.txtNomComp);
            this.Controls.Add(this.lblVendedor);
            this.Controls.Add(this.lblIDComp);
            this.Controls.Add(this.lblApellidoComp);
            this.Controls.Add(this.lblNomComp);
            this.Name = "Facturacion";
            this.Text = "Facturacion";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNomComp;
        private System.Windows.Forms.Label lblApellidoComp;
        private System.Windows.Forms.Label lblIDComp;
        private System.Windows.Forms.Label lblVendedor;
        private System.Windows.Forms.TextBox txtNomComp;
        private System.Windows.Forms.TextBox txtApeComp;
        private System.Windows.Forms.TextBox txtIDComp;
        private System.Windows.Forms.TextBox txtVendedor;
    }
}