using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test_CSharp
{
    internal class VideoJuego
    {
        private string nombre;
        private int precio;
        private int edadPermitida;
        private int stock;
        private int categoria;
        private DateTime fechaLanzamiento;
        private string empresa;

        public VideoJuego(string nombre, int precio, int edadPermitida, int stock, int categoria, DateTime fechaLanzamiento, string empresa)
        {
            this.nombre = nombre;
            this.precio = precio;
            this.edadPermitida = edadPermitida;
            this.stock = stock;
            this.categoria = categoria;
            this.fechaLanzamiento = fechaLanzamiento;
            this.empresa = empresa;
        }
        public VideoJuego()
        {
            nombre = "";
            precio = 0;
            edadPermitida = 0;
            stock = 0;
            categoria = 0;
            fechaLanzamiento = DateTime.Today;
            empresa = "";
        }


        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }
        public int Precio
        {
            get { return precio; }
            set { precio = value; }
        }
        public int EdadPermitida
        {
            get { return edadPermitida; }
            set { edadPermitida = value; }
        }
        public int Stock
        {
            get { return stock; }
            set { stock = value; }
        }
        public int Categoria
        {
            get { return categoria; }
            set { categoria = value; }
        }
        public DateTime FechaLanzamiento
        {
            get { return fechaLanzamiento; }
            set { fechaLanzamiento = value; }
        }
        public string Empresa
        {
            get { return empresa; }
            set { empresa = value; }
        }

        public override string ToString()
        {
            if (precio == 0)
            {
                return nombre + " | " + empresa + " | " + "GRATIS";
            }
            return nombre + " | " + empresa + " | " + "$" + precio;
        }
    }
}
