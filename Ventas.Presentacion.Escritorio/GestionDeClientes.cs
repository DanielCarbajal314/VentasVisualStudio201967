using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Ventas.Servicios.ImplementacionConSQL;
using Ventas.Servicios.Interfacez;
using Ventas.Servicios.Interfacez.Peticiones;

namespace Ventas.Presentacion.Escritorio
{
    public partial class GestionDeClientes : Form
    {
        IGestorDeClientes _gestorDeCliente;

        public GestionDeClientes()
        {
            this._gestorDeCliente = new GestorDeClientes();
            InitializeComponent();
        }

        private void GestionDeClientes_Load(object sender, EventArgs e)
        {
            this.ActualizarTabla();
        }

        private void ActualizarTabla()
        {
            TablaDeClientes.DataSource = null;
            TablaDeClientes.DataSource = this._gestorDeCliente.ListarTodosLosClientes().ToList();
            TablaDeClientes.Update();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.registrarCliente();
            this.resetearFormulario();
            this.ActualizarTabla();
        }

        private void resetearFormulario()
        {
            this.Nombre.Text = "";
            this.Direccion.Text = "";
            this.Ubigeo.Text = "";
            this.Sexo.SelectedIndex = 0;
            this.FechaDeNacimiento.Value = DateTime.Now;
            this.DNI.Text = "";
            this.Correo.Text = "";
            this.Celular.Text = "";
        }

        private void registrarCliente()
        {
            this._gestorDeCliente.RegistrarNuevoCliente(new NuevoCliente()
            {
                NombreCompleto = this.Nombre.Text,
                Direccion = this.Direccion.Text,
                UBIGEO = this.Ubigeo.Text,
                Sexo = this.Sexo.SelectedItem.ToString(),
                FechaNacimiento = this.FechaDeNacimiento.Value,
                DNI = this.DNI.Text,
                Correo = this.Correo.Text,
                Celular = this.Celular.Text
            });
        }
    }
}
