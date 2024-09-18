using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace Ejemplo_4
{
    internal class Cliente
    {
        private string nombre;
        public string Nombre
        {
            get { return nombre; }
            set {
                if (string.IsNullOrWhiteSpace(value))
                    throw new ArgumentNullException(nameof(Nombre), "El nombre no puede estar vacio.");
                nombre = value; 
            }
        }

        private int edad;
        public int Edad
        {
            get { return edad; }
            set { 
                if (value < 0) 
                    throw new ArgumentOutOfRangeException(nameof(Edad), "La edad no puede ser negativa"); 
                edad = value; 
            }
        }

        private List<string> correos;
        public List<string> Correos
        {
            get { return correos; }
            set { 
                if (value == null || value.Count == 0) 
                    throw new ArgumentNullException(nameof(Correos),"La lista de correos no puede estar vacia."); 
            foreach (var correo in value)
            {
                if (!esCorreoValido(correo))
                    throw new FormatException($"El correo {correo} no es válido.");
            }
            correos = value;
            }
        }

        private string tipopago;
        public string tipoPago
        {
            get { return tipopago; }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                    throw new ArgumentNullException(nameof(tipoPago), "El tipo de pago no puede estar vacío.");

                if (value.ToLower() != "contado" && value.ToLower() != "credito") 
                    throw new ArgumentException("El pago debe realizarse al credito o al contado.");
                if (value.ToLower() == "credito" && Edad < 18) 
                    throw new InvalidOperationException("El cliente debe tener al menos 18 años para realizar un pago al credito");

                tipopago = value;
            }
        }

        public static bool esCorreoValido(string correo)
        {
            string patron = @"^[^@\s]+@[^@\s]+\.[^@\s]+$";
            return Regex.IsMatch(correo, patron);
        }
    }
}
