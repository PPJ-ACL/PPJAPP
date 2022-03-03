using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDTO
{
    public class Profesional
    {
        //Atributos Profesional
        private int id;
        private string rut;
        private string nombre;
        private string aPaterno;
        private string aMaterno;
        private string correo;
        private string telefono;
        private string contrasenna;

        //Metodos Get y Set 
        public int Id { get => id; set => id = value; }
        public string Rut { get => rut; set => rut = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public string APaterno { get => aPaterno; set => aPaterno = value; }
        public string AMaterno { get => aMaterno; set => aMaterno = value; }
        public string Correo { get => correo; set => correo = value; }
        public string Telefono { get => telefono; set => telefono = value; }
        public string Contrasenna { get => contrasenna; set => contrasenna = value; }

    }
}
