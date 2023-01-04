using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using CapaDatos;
using CapaEntidad;
using System.Data;


namespace CapaNegocio
{
    public class cn_tm_Cliente
    {

        cd_tm_Cliente obj_Cliente = new cd_tm_Cliente();

        public DataTable cn_ListarCliente()
        {
            return obj_Cliente.cd_ListarCliente();
        }

        public void cn_RegistraNuevoCliente(ce_tm_Cliente objEnt_Cliente)
        {
            obj_Cliente.cd_RegistraNuevoCliente(objEnt_Cliente);
        }

        public void cn_EliminarCliente(int CodigoCliente)
        {
            obj_Cliente.cd_EliminarCliente(CodigoCliente);
        }

        public void cn_ModificarCliente (ce_tm_Cliente objEnt_Cliente)
        {
            obj_Cliente.cd_ModificarCliente(objEnt_Cliente);
        }


    }
}
