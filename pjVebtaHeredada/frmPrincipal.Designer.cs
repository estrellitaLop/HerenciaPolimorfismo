namespace pjVebtaHeredada
{
    partial class frmPrincipal
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
            this.btnCredito = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnContado = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnCredito
            // 
            this.btnCredito.Location = new System.Drawing.Point(45, 117);
            this.btnCredito.Name = "btnCredito";
            this.btnCredito.Size = new System.Drawing.Size(145, 23);
            this.btnCredito.TabIndex = 0;
            this.btnCredito.Text = "VENTA AL CREDITO";
            this.btnCredito.UseVisualStyleBackColor = true;
            this.btnCredito.Click += new System.EventHandler(this.btnCredito_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(139, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(186, 21);
            this.label1.TabIndex = 1;
            this.label1.Text = "VENTA DE PRODUCTOS";
            // 
            // btnContado
            // 
            this.btnContado.Location = new System.Drawing.Point(259, 117);
            this.btnContado.Name = "btnContado";
            this.btnContado.Size = new System.Drawing.Size(145, 23);
            this.btnContado.TabIndex = 2;
            this.btnContado.Text = "VENTA AL CONTADO";
            this.btnContado.UseVisualStyleBackColor = true;
            this.btnContado.Click += new System.EventHandler(this.btnContado_Click);
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(442, 256);
            this.Controls.Add(this.btnContado);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnCredito);
            this.Name = "frmPrincipal";
            this.Text = "Formulario Principal";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btnCredito;
        private Label label1;
        private Button btnContado;
    }
}