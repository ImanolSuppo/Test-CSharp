using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace Test_CSharp
{
    internal class ConexionDB
    {
        private SqlConnection cnn;
        private SqlCommand cmd;

        public ConexionDB()
        {
            cnn = new SqlConnection(@"Data Source=LAPTOP-QCMCF27P\SQLEXPRESS;Initial Catalog=VideoJuegos;Integrated Security=True");
        }

        public DataTable ConsultarDatos(string cadena)
        {
            cnn.Open();
            cmd = new SqlCommand(cadena, cnn);
            DataTable table = new DataTable();
            table.Load(cmd.ExecuteReader());
            cnn.Close();
            return table;
        }
        public int EjecutarDatos(string cadena, VideoJuego vj)
        {
            cnn.Open();
            cmd.CommandText = "SP_INSERT_VIDEOJUEGO";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@nombre", vj.Nombre);
            cmd.Parameters.AddWithValue("@empresa", vj.Empresa);
            cmd.Parameters.AddWithValue("@precio", vj.Precio);
            cmd.Parameters.AddWithValue("@stock", vj.Stock);
            cmd.Parameters.AddWithValue("@categoria", vj.Categoria);
            cmd.Parameters.AddWithValue("@PEGI", vj.EdadPermitida);
            cmd.Parameters.AddWithValue("@fechaLanzamiento", vj.FechaLanzamiento);
            int result = cmd.ExecuteNonQuery();
            cnn.Close();
            return result;
        }
    }
}
/*            cmd = new SqlCommand(cadena, cnn);
*/