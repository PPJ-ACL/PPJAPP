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
        //Nueva ConexionSQL
        private ConexionSQL conec;
        //Get y Set BD
        public ConexionSQL Conec { get => conec; set => conec = value; }

        public void configConex()
        {
            this.Conec = new ConexionSQL();
            //Nombre Tabla Principal BD
            this.Conec.NombreTabla = "Profesional";
            //Nombre BD SQL Server
            this.Conec.NombreBaseDatos = "SAPJDEV";
            //Cadena Conexion
            this.Conec.CadenaConexion = @"Data Source=MARUCHANBOOK;Initial Catalog=SAPJDEV ;Integrated Security=True"; 
        }

        public DataSet Login(string correo, string cont)
        {
            //Configura Conexion
            this.configConex();
            //Sentencia Select
            this.Conec.CadenaSQL = "SELECT * FROM VistaLogin WHERE VistaLogin.Correo = '" + correo + "' AND VistaLogin.contrasenna = '" + cont + "';";
            //Confirmación de Sentencia Select
            this.Conec.EsSelect = true;
            //Conexion a BD con envio de la cadena
            this.Conec.conectar();
            return this.Conec.DbDataSet;
        }
    }
}
