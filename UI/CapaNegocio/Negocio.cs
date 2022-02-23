using CapaConexion;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio
{
    class Negocio
    {
        private ConexionSQL conec;

        public ConexionSQL Conec { get => conec; set => conec = value; }

        public void configConex()
        {
            this.Conec = new ConexionSQL();
            this.Conec.NombreTabla = "Usuario";
            this.Conec.NombreBaseDatos = "portafolio";
            this.Conec.CadenaConexion = @"Data Source=DESKTOP-398JQJ0\SQLEXPRESS;Initial Catalog=portafolio ;Integrated Security=True"; ;
        }

        public DataSet Login(string correo, string cont)
        {
            this.configConex();
            this.Conec.CadenaSQL = "SELECT * FROM PROFESIONAL WHERE PROFESIONAL.Correo = '" + correo + "' AND PROFESIONAL.contrasenna = '" + cont + "';";
            this.Conec.EsSelect = true;
            this.Conec.conectar();
            return this.Conec.DbDataSet;
        }
    }
}
