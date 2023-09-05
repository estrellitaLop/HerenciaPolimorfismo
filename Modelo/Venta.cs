namespace Modelo
{
    public class Venta
    {
        //Atributos

        public string Cliente { get; set; }
        public string RUC { get; set; }
        public DateTime Fecha { get; set; }
        public DateTime Hora { get; set; }
        public string Producto { get; set; }
        public int Cantidad { get; set; }

        //Metodos de la clase venta
        public double AsignaPrecio()
        {
            switch (Producto)
            {
                case "LAVADORA":return 1500;
                case "REFRIGERADORA": return 3500;
                case "LICUADORA": return 500;
                case "EXTRACTORA": return 150;
                case "RADIOGRABADORA": return 750;
                case "DVD": return 100;
                case "BLUERAY": return 250;

            }
            return 0;
        }

           //Metodo que calcula el subtotal
        public double CalculadoraSubtotal()
        {
            return AsignaPrecio() * Cantidad;

        }
    }
}