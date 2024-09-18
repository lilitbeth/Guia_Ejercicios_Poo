using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejemplo_4
{
    internal class Electrodomestico
    {
        private string marca;
        public string Marca
        {
            get { return marca; }
            set {
                if (string.IsNullOrWhiteSpace(value))
                    throw new ArgumentNullException(nameof(Marca), "La marca no puede estar vacia.");
                marca = value; 
            }
        }

        private string modelo;
        public string Modelo
        {
            get { return modelo; }
            set {
                if (string.IsNullOrWhiteSpace(value))
                    throw new ArgumentNullException(nameof(Modelo), "EL modelo no puede estar vacio.");
                modelo = value; 
            }
        }

        private decimal preciocosto;
        public decimal precioCosto
        {
            get { return preciocosto; }
            set { 
                if (value < 0) 
                    throw new ArgumentOutOfRangeException(nameof(precioCosto),"El precio de costo debe de ser mayor que cero."); 
                preciocosto = value; }
        }

        private decimal precioventa;
        public decimal precioVenta
        {
            get { return precioventa; }
            set { 
                if (value < precioCosto * 1.20m) 
                    throw new InvalidOperationException("El precio de venta debe ser al menos un 20% mayor que el precio de costo."); 
                precioventa = value; }
        }

        private DateTime fechacompra;
        public DateTime fechaCompra
        {
            get { return fechacompra; }
            set { if (value.Date != DateTime.Now.Date) 
                    throw new ArgumentOutOfRangeException(nameof(fechaCompra), "La fecha de compra debe ser la fecha actual."); 
                fechacompra = value; }
        }
    }
}
