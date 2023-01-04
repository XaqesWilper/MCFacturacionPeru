using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Configuration;
using CapaEntidad;

using System.Data.SqlClient;
using System.Data;

namespace CapaDatos
{
    public class cd_tm_Cliente
    {

        SqlConnection cn = new SqlConnection(ConfigurationManager.ConnectionStrings["SqlConexion"].ConnectionString); 

        public DataTable cd_ListarCliente()
        {
            SqlCommand cmd = new SqlCommand("spu_sel_tm_Cliente", cn);
            cmd.CommandType = CommandType.StoredProcedure;
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }

        public void cd_RegistraNuevoCliente(ce_tm_Cliente objEnt_Cliente)
        {

            SqlCommand cmd = new SqlCommand("spu_ins_tm_Cliente", cn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@ds_tmc_Cliente", objEnt_Cliente.ds_tmc_Cliente);
            cmd.Parameters.AddWithValue("@tmc_ruc", objEnt_Cliente.tmc_ruc);
            cmd.Parameters.AddWithValue("@tmc_Direccion", objEnt_Cliente.tmc_Direccion);
            cmd.Parameters.AddWithValue("@tmc_FechaRegistro", objEnt_Cliente.tmc_FechaRegistro);

            if (cn.State == ConnectionState.Open) cn.Close();
            cn.Open();
            cmd.ExecuteNonQuery();
            cn.Close();
        }

        public void cd_ModificarCliente(ce_tm_Cliente objEnt_Cliente)
        {

            SqlCommand cmd = new SqlCommand("spu_upd_tm_Cliente", cn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@id_tmc_Cliente", objEnt_Cliente.id_tmc_Cliente);
            cmd.Parameters.AddWithValue("@ds_tmc_Cliente", objEnt_Cliente.ds_tmc_Cliente);
            cmd.Parameters.AddWithValue("@tmc_ruc", objEnt_Cliente.tmc_ruc);
            cmd.Parameters.AddWithValue("@tmc_Direccion", objEnt_Cliente.tmc_Direccion);
            cmd.Parameters.AddWithValue("@tmc_FechaRegistro", objEnt_Cliente.tmc_FechaRegistro);


            if (cn.State == ConnectionState.Open) cn.Close();
            cn.Open();
            cmd.ExecuteNonQuery();
            cn.Close();
        }


        public void cd_EliminarCliente(int CodCliente)
        {
            SqlCommand cmd = new SqlCommand("spu_del_tm_Cliente", cn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@id_tmc_Cliente", CodCliente);
            if (cn.State == ConnectionState.Open) cn.Close();
            cn.Open();
            cmd.ExecuteNonQuery();
            cn.Close();

        }

    }
}
