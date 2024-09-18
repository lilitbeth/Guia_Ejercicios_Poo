using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace Ejercicio1_G_E
{
    public class Password
    {
        private int longitud;
        private string password;

        public Password()
        {
            this.longitud = 8;
            this.password = "12345678";
        }
        //metodo es fuerte 
        public bool esFuerte()
        {
            int mayusculas = 0, minusculas = 0, numeros = 0;
            foreach (char c in password)
            {
                if (char.IsUpper(c)) { mayusculas++; }
                else if (char.IsLower(c)) { minusculas++; }
                else if (char.IsDigit(c)) { numeros++; }
            }
            return (mayusculas >= 2 && minusculas >= 1 && numeros >= 5);
        }
        //metodo
        private Random random = new Random();

        public string generarPassword()
        {
            var letras = Enumerable.Range('a', 'z' - 'a' + 1)
        .Select(x => (char)x)
        .OrderBy(x => random.Next())
        .Take(3)
        .ToArray();

            var digitos = Enumerable.Range(0, 10)
                .OrderBy(x => random.Next())
                .Take(5)
                .ToArray();

            // Combinar letras y números de manera que siempre haya 3 letras y 5 dígitos
            var passwordList = new char[8];
            Array.Copy(letras, 0, passwordList, 0, 3);
            Array.Copy(digitos, 0, passwordList, 3, 5);

            // Mezclar la lista 
            passwordList = passwordList.OrderBy(x => random.Next()).ToArray();

            // Convertir la lista en una cadena
            var password = new string(passwordList);

            return password;
        }
    
        //get y set
        public int Longitud
        {
            get { return longitud; }
            set { longitud = value; }
        }

        public string Contra
        {
            get { return password; }
        }
    }
}
