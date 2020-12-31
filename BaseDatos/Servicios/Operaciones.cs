using BaseDatos.Modelos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Text;

namespace BaseDatos.Servicios
{
    public class Operaciones : IDisposable
    {
        private SqlConnection con;

        public SqlConnection DBConexion()
        {
            ContextoDB objctxADPRO = new ContextoDB();
            //EJECUTA LAS MIGRACIONES
           

            con = new SqlConnection(objctxADPRO.conexion);
            con.Open();
            return con;
        }


        public DataTable ConsultarSPDT(ConexionDTO obj)
        {
            DataTable ds = new DataTable();
            using (SqlConnection context = DBConexion())
            {
                SqlCommand cmd = new SqlCommand(obj.procedimiento.Trim(), context);
                if (obj.parametros != null)
                {
                    foreach (var item in obj.parametros)
                    {
                        SqlParameter objsp = new SqlParameter();
                        objsp.ParameterName = item.Key;
                        objsp.Value = item.Value;
                       
                        cmd.Parameters.Add(objsp);
                    }
                }
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandTimeout = 200;
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                try
                {
                    da.Fill(ds);

                }
                catch (Exception E)
                {
                    if (context.State != ConnectionState.Closed)
                    {
                        context.Close();
                    }
                    throw new ArgumentException(E.Message + E.Source + E.StackTrace + E.TargetSite + E.HelpLink + E.HelpLink);
                }
                context.Close();
            }
            return ds;
        }


        public int ExecuteNonQuerySP(ConexionDTO obj)
        {
            int result = 0;
            using (SqlConnection context = DBConexion())
            {
                SqlCommand cmd = new SqlCommand(obj.procedimiento, context);
                if (obj.parametros != null)
                {
                    foreach (var item in obj.parametros)
                    {
                        SqlParameter objsp = new SqlParameter(item.Key, item.Value);
                        cmd.Parameters.Add(objsp);
                    }
                }
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandTimeout = 200;
                result = cmd.ExecuteNonQuery();
                return result;
            }
        }


        public void Dispose()
        {
            if (this.con != null && this.con.State != ConnectionState.Closed)
            {
                this.con.Close();
            }
        }
    }
}
