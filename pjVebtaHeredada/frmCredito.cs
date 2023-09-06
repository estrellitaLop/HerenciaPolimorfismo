using Modelo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pjVebtaHeredada
{
    public partial class frmCredito : Form
    {
        static int[] letras = { 3, 6, 9, 12 };
        static string[] productos = { "LAVADORA", "REFRIGERADORA","LICUADORA", "EXTRACTORA",
        "RADIOGRABADORA","DVD", "BLUERAY"};
        //Variable
        double tSubtotal = 0;
        public frmCredito()
        {
            InitializeComponent();
        }

        private void frmCredito_Load(object sender, EventArgs e)
        {
            cboLetras.DataSource = letras;
            cboProducto.DataSource = productos;
            MostrarFecha();
            MostrarHora();
            lblMonto.Text = "0.00";
        }

        private void MostrarHora()
        {
            lblHora.Text = DateTime.Now.ToShortTimeString();
        }

        private void MostrarFecha()
        {
            lblFecha.Text = DateTime.Now.ToShortDateString();
        }

        private void btnAdquirir_Click(object sender, EventArgs e)
        {
            //Obejeto de la clase Contado
            Credito objCr = new Credito();

            //Datos del cliente
            objCr.Cliente = txtCliente.Text;
            objCr.RUC = txtRUC.Text;
            objCr.Fecha = DateTime.Parse(lblFecha.Text);
            objCr.Hora = DateTime.Parse(lblHora.Text);

            //Datos del prodtucto
            objCr.Producto = cboProducto.Text;
            objCr.Cantidad = int.Parse(txtCantidad.Text);

            //Impromeiendo lista

            ListViewItem fila = new ListViewItem(objCr.GetX().ToString());
            fila.SubItems.Add(objCr.Producto);
            fila.SubItems.Add(txtCantidad.ToString());
            fila.SubItems.Add(objCr.AsignaPrecio().ToString("C"));
            fila.SubItems.Add(objCr.CalculadoraSubtotal().ToString());
            lvDetalle.Items.Add(fila);
            
            tSubtotal += objCr.CalculadoraSubtotal();
            lblMonto.Text=tSubtotal.ToString("0.00");

        }

        private void btnResumen_Click(object sender, EventArgs e)
        {
            int letras = int.Parse(cboLetras.Text);
            switch (letras)
            {
                case 3: Montoletras(3); break;
                case 6:Montoletras(6); break;
                case 9: Montoletras(9); break;
                case 12 : Montoletras(12); break;
            }
        }

        private void Montoletras(int le)
        {
            double MontoMensual = double.Parse(lblMonto.Text) / le;
            lvResumen.Items.Clear();    
            for( int i =1; i <= le; i++)
            {
                ListViewItem fila = new ListViewItem(i.ToString());
                fila.SubItems.Add(i.ToString());
                lvResumen.Items.Add(fila);  
            }
        }
    }
}
