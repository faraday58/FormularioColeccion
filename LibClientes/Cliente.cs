
namespace LibClientes
{
    public class Cliente
    {
        #region  atributos
        private string nombre;
        private byte edad;
        private string telefono;
        private string direccion;        
        #endregion

        #region Propiedad
        public string Nombre { get => nombre; set => nombre = value; }
        public byte Edad { get => edad; set => edad = value; }
        public string Telefono { get => telefono; set => telefono = value; }
        public string Direccion { get => direccion; set => direccion = value; }
        #endregion

        #region Constructor
        public Cliente(string nombre, byte edad, string telefono, string direccion)
        {
            Nombre = nombre;
            Edad = edad;
            Telefono = telefono;
            Direccion = direccion;
        }

        #endregion





    }
}
