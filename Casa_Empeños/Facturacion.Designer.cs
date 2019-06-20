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
            this.lblApeComp = new System.Windows.Forms.Label();
            this.lblIDComp = new System.Windows.Forms.Label();
            this.lblVendedor = new System.Windows.Forms.Label();
            this.txtNomComp = new System.Windows.Forms.TextBox();
            this.txtApeComp = new System.Windows.Forms.TextBox();
            this.txtIdComp = new System.Windows.Forms.TextBox();
            this.txtVendedor = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblNomComp
            // 
            this.lblNomComp.AutoSize = true;
            this.lblNomComp.Location = new System.Drawing.Point(12, 25);
            this.lblNomComp.Name = "lblNomComp";
            this.lblNomComp.Size = new System.Drawing.Size(101, 13);
            this.lblNomComp.TabIndex = 0;
            this.lblNomComp.Text = "Nombre Comprador:";
            // 
            // lblApeComp
            // 
            this.lblApeComp.AutoSize = true;
            this.lblApeComp.Location = new System.Drawing.Point(12, 69);
            this.lblApeComp.Name = "lblApeComp";
            this.lblApeComp.Size = new System.Drawing.Size(101, 13);
            this.lblApeComp.TabIndex = 1;
            this.lblApeComp.Text = "Apellido Comprador:";
            // 
            // lblIDComp
            // 
            this.lblIDComp.AutoSize = true;
            this.lblIDComp.Location = new System.Drawing.Point(248, 22);
            this.lblIDComp.Name = "lblIDComp";
            this.lblIDComp.Size = new System.Drawing.Size(108, 13);
            this.lblIDComp.TabIndex = 2;
            this.lblIDComp.Text = "Identidad Comprador:";
            // 
            // lblVendedor
            // 
            this.lblVendedor.AutoSize = true;
            this.lblVendedor.Location = new System.Drawing.Point(268, 69);
            this.lblVendedor.Name = "lblVendedor";
            this.lblVendedor.Size = new System.Drawing.Size(56, 13);
            this.lblVendedor.TabIndex = 3;
            this.lblVendedor.Text = "Vendedor:";
            // 
            // txtNomComp
            // 
            this.txtNomComp.Location = new System.Drawing.Point(128, 19);
            this.txtNomComp.Name = "txtNomComp";
            this.txtNomComp.Size = new System.Drawing.Size(100, 20);
            this.txtNomComp.TabIndex = 4;
            // 
            // txtApeComp
            // 
            this.txtApeComp.Location = new System.Drawing.Point(128, 66);
            this.txtApeComp.Name = "txtApeComp";
            this.txtApeComp.Size = new System.Drawing.Size(100, 20);
            this.txtApeComp.TabIndex = 5;
            // 
            // txtIdComp
            // 
            this.txtIdComp.Location = new System.Drawing.Point(362, 22);
            this.txtIdComp.Name = "txtIdComp";
            this.txtIdComp.Size = new System.Drawing.Size(100, 20);
            this.txtIdComp.TabIndex = 6;
            // 
            // txtVendedor
            // 
            this.txtVendedor.Location = new System.Drawing.Point(362, 62);
            this.txtVendedor.Name = "txtVendedor";
            this.txtVendedor.Size = new System.Drawing.Size(100, 20);
            this.txtVendedor.TabIndex = 7;
            // 
            // Facturacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(494, 261);
            this.Controls.Add(this.txtVendedor);
            this.Controls.Add(this.txtIdComp);
            this.Controls.Add(this.txtApeComp);
            this.Controls.Add(this.txtNomComp);
            this.Controls.Add(this.lblVendedor);
            this.Controls.Add(this.lblIDComp);
            this.Controls.Add(this.lblApeComp);
            this.Controls.Add(this.lblNomComp);
            this.Name = "Facturacion";
            this.Text = "Facturacion";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNomComp;
        private System.Windows.Forms.Label lblApeComp;
        private System.Windows.Forms.Label lblIDComp;
        private System.Windows.Forms.Label lblVendedor;
        private System.Windows.Forms.TextBox txtNomComp;
        private System.Windows.Forms.TextBox txtApeComp;
        private System.Windows.Forms.TextBox txtIdComp;
        private System.Windows.Forms.TextBox txtVendedor;
    }
}