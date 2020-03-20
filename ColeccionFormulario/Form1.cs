using System;
using System.Collections;
using System.Windows.Forms;
using LibClientes;

namespace ColeccionFormulario
{
    public partial class FormCliente : Form
    {
        private ArrayList clientes;
        private Cliente miCliente;
        private int indice;
        public int Indice {
            get => indice;
            set
            {
                if( value <0  || value >= clientes.Count  )
                {
                    indice = 0;
                }
                else
                {
                    indice = value;
                }
                
            }
                
        }
        public FormCliente()
        {
            InitializeComponent();
            clientes = new ArrayList();
        }

        

        private void BtnAgregar_Click(object sender, EventArgs e)
        {
            miCliente = new Cliente(txtbNombre.Text, byte.Parse(txtbEdad.Text), txtbTelefono.Text, txtbDirección.Text);
            clientes.Add(miCliente);
            MessageBox.Show("Cliente Agregado", "Acción Cliente");
            txtbNombre.Clear();
            txtbEdad.Clear();
            txtbTelefono.Clear();
            txtbDirección.Clear();

        }

        private void BtnSiguiente_Click(object sender, EventArgs e)
        {
            miCliente = (Cliente)clientes[Indice++];
            txtbNombre.Text = miCliente.Nombre;
            txtbTelefono.Text = miCliente.Telefono;
            txtbEdad.Text = miCliente.Edad.ToString();
            txtbDirección.Text = miCliente.Direccion;
        }
    }
}
