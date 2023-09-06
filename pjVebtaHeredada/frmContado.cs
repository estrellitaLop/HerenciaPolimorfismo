using Modelo;
using System;
using System.Collections;
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
    public partial class frmContado : Form
    {
        //INICIALIZACION DEL ARREGLO DEL PRODUCTO
        static string[] productos = { "LAVADORA", "REFRIGERADORA","LICUADORA", "EXTRACTORA",
        "RADIOGRABADORA","DVD", "BLUERAY"};
       
        //Variable 
        double tSubtotal = 0;

        public frmContado()
        {
            InitializeComponent();
        }

      
        private void frmContado_Load(object sender, EventArgs e)
        {
            cboProducto.DataSource = productos;
            MostrarFecha();
            MostrarHora();
            lblNeto.Text = "0.00";
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
            Contado objC = new();

            //Datos del cliente
            objC.Cliente = txtCliente.Text;
            objC.RUC=txtRUC.Text;
            objC.Fecha = DateTime.Parse(lblFecha.Text);
            objC.Hora= DateTime.Parse(lblHora.Text);

            //Datos del prodtucto
            objC.Producto = cboProducto.Text;
            objC.Cantidad= int.Parse(txtCantidad.Text); 

            //Impromeiendo lista

            ListViewItem fila = new ListViewItem(objC.GetN().ToString());
            fila.SubItems.Add(objC.Producto);
            fila.SubItems.Add(txtCantidad.ToString());
            fila.SubItems.Add(objC.AsignaPrecio().ToString("C"));
            fila.SubItems.Add(objC.CalculadoraSubtotal().ToString());
            lvDetalle.Items.Add(fila);
            Listado(objC);
        }

        private void Listado(Contado objC)
        {
            tSubtotal += objC.CalculadoraSubtotal();
            lstResumen.Items.Clear();
            lstResumen.Items.Add("**RESUMEN DE VENTA**");
            lstResumen.Items.Add("------------------------------");
            lstResumen.Items.Add($"Cliente :{objC.Cliente}");
            lstResumen.Items.Add($"RUC :{objC.RUC}");
            lstResumen.Items.Add($"Fecha :{objC.Fecha}");
            lstResumen.Items.Add($"Hora :{objC.Hora}");
            lstResumen.Items.Add("------------------------------");
            lstResumen.Items.Add($"Subtotal:{tSubtotal.ToString("C")}");
            double descuento = objC.CalculaDescuento(tSubtotal);
            double neto = objC.CalculaNeto(tSubtotal, descuento);
            lstResumen.Items.Add($"DESCUENTO :{descuento.ToString("C")}");
            lstResumen.Items.Add($"neto :{neto.ToString("C")}");

            lblNeto.Text = neto.ToString("C");

        }
    }
}
