namespace pjVebtaHeredada
{
    partial class frmCredito
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
            this.btnAdquirir = new System.Windows.Forms.Button();
            this.lblMonto = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.lblFecha = new System.Windows.Forms.Label();
            this.lblHora = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtCantidad = new System.Windows.Forms.TextBox();
            this.cboProducto = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.cboLe = new System.Windows.Forms.GroupBox();
            this.txtRUC = new System.Windows.Forms.TextBox();
            this.txtCliente = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.lvResumen = new System.Windows.Forms.ListView();
            this.btnResumen = new System.Windows.Forms.Button();
            this.cboLetras = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.lvDetalle = new System.Windows.Forms.ListView();
            this.columnHeader1 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader2 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader3 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader4 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader5 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader6 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader7 = new System.Windows.Forms.ColumnHeader();
            this.groupBox2.SuspendLayout();
            this.cboLe.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnAdquirir
            // 
            this.btnAdquirir.Location = new System.Drawing.Point(489, 240);
            this.btnAdquirir.Name = "btnAdquirir";
            this.btnAdquirir.Size = new System.Drawing.Size(75, 23);
            this.btnAdquirir.TabIndex = 23;
            this.btnAdquirir.Text = "ADQUIRIR";
            this.btnAdquirir.UseVisualStyleBackColor = true;
            this.btnAdquirir.Click += new System.EventHandler(this.btnAdquirir_Click);
            // 
            // lblMonto
            // 
            this.lblMonto.AutoSize = true;
            this.lblMonto.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblMonto.Location = new System.Drawing.Point(538, 502);
            this.lblMonto.Name = "lblMonto";
            this.lblMonto.Size = new System.Drawing.Size(66, 21);
            this.lblMonto.TabIndex = 26;
            this.lblMonto.Text = "label12";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label11.Location = new System.Drawing.Point(500, 466);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(154, 21);
            this.label11.TabIndex = 25;
            this.label11.Text = "MONTO A PAGAR $";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(15, 416);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(60, 15);
            this.label10.TabIndex = 24;
            this.label10.Text = "RESUMEN";
            // 
            // lblFecha
            // 
            this.lblFecha.AutoSize = true;
            this.lblFecha.Location = new System.Drawing.Point(478, 116);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(38, 15);
            this.lblFecha.TabIndex = 19;
            this.lblFecha.Text = "label5";
            // 
            // lblHora
            // 
            this.lblHora.AutoSize = true;
            this.lblHora.Location = new System.Drawing.Point(594, 116);
            this.lblHora.Name = "lblHora";
            this.lblHora.Size = new System.Drawing.Size(38, 15);
            this.lblHora.TabIndex = 21;
            this.lblHora.Text = "label7";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtCantidad);
            this.groupBox2.Controls.Add(this.cboProducto);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Location = new System.Drawing.Point(12, 190);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(410, 97);
            this.groupBox2.TabIndex = 17;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "DATOS DE LA VENTA";
            // 
            // txtCantidad
            // 
            this.txtCantidad.Location = new System.Drawing.Point(224, 50);
            this.txtCantidad.Name = "txtCantidad";
            this.txtCantidad.Size = new System.Drawing.Size(100, 23);
            this.txtCantidad.TabIndex = 9;
            // 
            // cboProducto
            // 
            this.cboProducto.FormattingEnabled = true;
            this.cboProducto.Location = new System.Drawing.Point(18, 50);
            this.cboProducto.Name = "cboProducto";
            this.cboProducto.Size = new System.Drawing.Size(158, 23);
            this.cboProducto.TabIndex = 8;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(224, 32);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(132, 15);
            this.label9.TabIndex = 7;
            this.label9.Text = "CANTIDAD SOLICITADA";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(18, 32);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(158, 15);
            this.label8.TabIndex = 6;
            this.label8.Text = "SELECCIONE UN PRODUCTO";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(594, 74);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(40, 15);
            this.label6.TabIndex = 20;
            this.label6.Text = "HORA";
            // 
            // cboLe
            // 
            this.cboLe.Controls.Add(this.txtRUC);
            this.cboLe.Controls.Add(this.txtCliente);
            this.cboLe.Controls.Add(this.label3);
            this.cboLe.Controls.Add(this.label2);
            this.cboLe.Location = new System.Drawing.Point(12, 46);
            this.cboLe.Name = "cboLe";
            this.cboLe.Size = new System.Drawing.Size(410, 118);
            this.cboLe.TabIndex = 16;
            this.cboLe.TabStop = false;
            this.cboLe.Text = "DATOS DEL CLIENTE";
            // 
            // txtRUC
            // 
            this.txtRUC.Location = new System.Drawing.Point(224, 62);
            this.txtRUC.Name = "txtRUC";
            this.txtRUC.Size = new System.Drawing.Size(100, 23);
            this.txtRUC.TabIndex = 4;
            // 
            // txtCliente
            // 
            this.txtCliente.Location = new System.Drawing.Point(18, 62);
            this.txtCliente.Name = "txtCliente";
            this.txtCliente.Size = new System.Drawing.Size(158, 23);
            this.txtCliente.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(224, 28);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(30, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "RUC";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(149, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "CLIENTE O RAZON SOCIAL";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(203, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(262, 20);
            this.label1.TabIndex = 15;
            this.label1.Text = "VENTA DE PRODUCTOS AL CREDITO";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(472, 74);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 15);
            this.label4.TabIndex = 18;
            this.label4.Text = "FECHA";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.lvResumen);
            this.groupBox3.Controls.Add(this.btnResumen);
            this.groupBox3.Controls.Add(this.cboLetras);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Location = new System.Drawing.Point(15, 434);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(488, 160);
            this.groupBox3.TabIndex = 27;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "OPCIONES DE CREDITO";
            // 
            // lvResumen
            // 
            this.lvResumen.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader6,
            this.columnHeader7});
            this.lvResumen.GridLines = true;
            this.lvResumen.Location = new System.Drawing.Point(182, 22);
            this.lvResumen.Name = "lvResumen";
            this.lvResumen.Size = new System.Drawing.Size(300, 111);
            this.lvResumen.TabIndex = 25;
            this.lvResumen.UseCompatibleStateImageBehavior = false;
            this.lvResumen.View = System.Windows.Forms.View.Details;
            // 
            // btnResumen
            // 
            this.btnResumen.Location = new System.Drawing.Point(18, 79);
            this.btnResumen.Name = "btnResumen";
            this.btnResumen.Size = new System.Drawing.Size(146, 23);
            this.btnResumen.TabIndex = 24;
            this.btnResumen.Text = "MOSTRAR RESUMEN";
            this.btnResumen.UseVisualStyleBackColor = true;
            this.btnResumen.Click += new System.EventHandler(this.btnResumen_Click);
            // 
            // cboLetras
            // 
            this.cboLetras.FormattingEnabled = true;
            this.cboLetras.Location = new System.Drawing.Point(18, 50);
            this.cboLetras.Name = "cboLetras";
            this.cboLetras.Size = new System.Drawing.Size(158, 23);
            this.cboLetras.TabIndex = 8;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(18, 32);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(116, 15);
            this.label7.TabIndex = 6;
            this.label7.Text = "SELECCIONE LETRAS";
            // 
            // lvDetalle
            // 
            this.lvDetalle.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5});
            this.lvDetalle.GridLines = true;
            this.lvDetalle.Location = new System.Drawing.Point(12, 293);
            this.lvDetalle.Name = "lvDetalle";
            this.lvDetalle.Size = new System.Drawing.Size(631, 120);
            this.lvDetalle.TabIndex = 28;
            this.lvDetalle.UseCompatibleStateImageBehavior = false;
            this.lvDetalle.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "ITEM";
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "DESCRIPCION DEL PRODUCTO";
            this.columnHeader2.Width = 240;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "CANTIDAD";
            this.columnHeader3.Width = 120;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "PRECIO";
            this.columnHeader4.Width = 120;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "SUBTOTAL";
            this.columnHeader5.Width = 120;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "No.Letras";
            this.columnHeader6.Width = 120;
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "Montos";
            this.columnHeader7.Width = 180;
            // 
            // frmCredito
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.OldLace;
            this.ClientSize = new System.Drawing.Size(657, 607);
            this.Controls.Add(this.lvDetalle);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.btnAdquirir);
            this.Controls.Add(this.lblMonto);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.lblFecha);
            this.Controls.Add(this.lblHora);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.cboLe);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label4);
            this.Name = "frmCredito";
            this.Text = "frmCredito";
            this.Load += new System.EventHandler(this.frmCredito_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.cboLe.ResumeLayout(false);
            this.cboLe.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btnAdquirir;
        private Label lblMonto;
        private Label label11;
        private Label label10;
        private Label lblFecha;
        private Label lblHora;
        private GroupBox groupBox2;
        private TextBox txtCantidad;
        private ComboBox cboProducto;
        private Label label9;
        private Label label8;
        private Label label6;
        private GroupBox cboLe;
        private TextBox txtRUC;
        private TextBox txtCliente;
        private Label label3;
        private Label label2;
        private Label label1;
        private Label label4;
        private GroupBox groupBox3;
        private ListView lvResumen;
        private Button btnResumen;
        private ComboBox cboLetras;
        private Label label7;
        private ColumnHeader columnHeader6;
        private ColumnHeader columnHeader7;
        private ListView lvDetalle;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private ColumnHeader columnHeader3;
        private ColumnHeader columnHeader4;
        private ColumnHeader columnHeader5;
    }
}