using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejemplo_4
{
    public partial class Form1 : Form
    {
        List<Electrodomestico> electrodomesticos = new List<Electrodomestico>();
        List<Cliente> clientes = new List<Cliente>();

        public Form1()
        {
            InitializeComponent();
        }

        private void btnElectrodomestico_Click(object sender, EventArgs e)
        {
            try
            {
                Electrodomestico nuevoElectrodomestico = new Electrodomestico();
                nuevoElectrodomestico.Marca = txtmarca.Text;
                nuevoElectrodomestico.Modelo = txtmodelo.Text;
                nuevoElectrodomestico.precioCosto = decimal.Parse(txtpreciocosto.Text);
                nuevoElectrodomestico.precioVenta = decimal.Parse(txtprecioventa.Text);
                nuevoElectrodomestico.fechaCompra = dateTimePicker1.Value;

                if (string.IsNullOrWhiteSpace(txtmarca.Text) || string.IsNullOrWhiteSpace(txtmodelo.Text))
                {
                    MessageBox.Show("La marca y el modelo no pueden estar vacios.");
                }

                if (!decimal.TryParse(txtpreciocosto.Text, out decimal precioCosto) || precioCosto < 0)
                {
                    MessageBox.Show("Ingrese un precio de costo valido.");
                    return;
                }

                if (!decimal.TryParse(txtprecioventa.Text, out decimal precioVenta))
                {
                    MessageBox.Show("Ingrese un precio de venta valido.");
                    return;
                }

                electrodomesticos.Add(nuevoElectrodomestico);
                MessageBox.Show("Electrodomestico agreado existosamente.");
            }
            catch (ArgumentException ex)
            {
                MessageBox.Show(ex.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrio un error inesperado: " + ex.Message);
            }
        }

        private void btnCliente_Click(object sender, EventArgs e)
        {
            try
            {
                Cliente nuevocliente = new Cliente();
                nuevocliente.Nombre = txtnombre.Text;
                nuevocliente.Edad = int.Parse(txtedad.Text);
                string correo = cbcorreos.Text;

                if (string.IsNullOrWhiteSpace(txtnombre.Text))
                {
                    MessageBox.Show("El nombre no puede estar vacío.");
                    return;
                }

                if (!int.TryParse(txtedad.Text, out int edad) || edad < 0)
                {
                    MessageBox.Show("Ingrese una edad válida.");
                    return;
                }

                if (string.IsNullOrWhiteSpace(correo))
                {
                    MessageBox.Show("El correo no puede estar vacío.");
                    return;
                }

                if (!Cliente.esCorreoValido(correo))
                {
                    MessageBox.Show("El correo no es valido.");
                    return;
                }
                if (!cbcorreos.Items.Contains(correo))
                {
                    cbcorreos.Items.Add(correo);
                }

                List<string> correos = cbcorreos.Items.Cast<string>().ToList();
                nuevocliente.Correos = correos;


                if (radioButton1.Checked)
                {
                    nuevocliente.tipoPago = "credito";
                }
                else if (radioButton2.Checked)
                {
                    nuevocliente.tipoPago = "contado";
                }
                else
                {
                    MessageBox.Show("Debe seleccionar un metodo de pago.");
                    return;
                }

                clientes.Add(nuevocliente);
                MessageBox.Show("Cliente agregado exitosamente.");
            }
            catch (FormatException)
            {
                MessageBox.Show("Formato de edad incorrecto.");
            }
            catch (ArgumentException ex) 
            {
                MessageBox.Show(ex.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrio un error inesperado: " + ex.Message);
            }
        }
    }
}
