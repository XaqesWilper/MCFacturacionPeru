using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using CapaNegocio;
using CapaEntidad;


namespace CapaPresentacion
{
    public partial class cp_tm_cliente : Form
    {
        public cp_tm_cliente()
        {
            InitializeComponent();
        }

        private void cp_tm_cliente_Load(object sender, EventArgs e)
        {
            Lista_tm_Cliente();
        }

        cn_tm_Cliente objNeg_Cliente = new cn_tm_Cliente();
        ce_tm_Cliente objEnt_Cliente = new ce_tm_Cliente();

        public int EstadoMantenimiento = 0;
        public int idModificarCliente = 0;
        public int dgRowIndex = 0;

        //--------------------------------------------------------------------------------------------------
        void Lista_tm_Cliente()
        {

            DataTable dt = objNeg_Cliente.cn_ListarCliente();
            dg_tm_Cliente.DataSource = dt;

        }


        //--------------------------------------------------------------------------------------------------
        private void btn_nuevo_Click(object sender, EventArgs e)
        {
            txtNombreCliente.ReadOnly = false;
            txtRucCliente.ReadOnly = false;
            txtDireccionCliente.ReadOnly = false;

            txtNombreCliente.Text = "";
            txtRucCliente.Text = "";
            txtDireccionCliente.Text = "";

            btnGrabarCliente.Visible = true;
            btnCancelar.Visible = true;
            btnSalir.Visible = false;

            btn_eliminar.Enabled = false;
            btn_nuevo.Enabled = false;
            btn_modificar.Enabled = false;

            EstadoMantenimiento = 1;

        }

        //--------------------------------------------------------------------------------------------------
        private void btnGrabarCliente_Click(object sender, EventArgs e)
        {
            if (EstadoMantenimiento == 1)
            {
                RegistraNuevoCliente();
                EstadoMantenimiento = 0;
            }
            else
            {
                ModificarCliente(idModificarCliente);
                EstadoMantenimiento = 0;
                dgRowIndex = 0;
                idModificarCliente = 0;
            }
            Lista_tm_Cliente();
            btnCancelar_Click(sender, e);
        }

        //--------------------------------------------------------------------------------------------------
        void RegistraNuevoCliente() 
        {
            objEnt_Cliente.tmc_Direccion = txtDireccionCliente.Text;
            objEnt_Cliente.ds_tmc_Cliente = txtNombreCliente.Text;
            objEnt_Cliente.tmc_ruc = txtRucCliente.Text;
            objEnt_Cliente.tmc_FechaRegistro = DateTime.Now;

            objNeg_Cliente.cn_RegistraNuevoCliente(objEnt_Cliente);

            MessageBox.Show("Se registro los datos del Cliente");

        }

        //--------------------------------------------------------------------------------------------------
        private void btn_modificar_Click(object sender, EventArgs e)
        {
            btn_nuevo_Click(sender, e);

            btn_eliminar.Enabled = false;
            btn_nuevo.Enabled = false;
            btn_modificar.Enabled = false;

            dgRowIndex = dg_tm_Cliente.CurrentRow.Index;
            idModificarCliente = (int)dg_tm_Cliente.Rows[dgRowIndex].Cells["id_tmc_Cliente"].Value;

            txtNombreCliente.Text = (string)dg_tm_Cliente.Rows[dgRowIndex].Cells["ds_tmc_Cliente"].Value;
            txtRucCliente.Text = (string)dg_tm_Cliente.Rows[dgRowIndex].Cells["tmc_ruc"].Value;
            txtDireccionCliente.Text = (string)dg_tm_Cliente.Rows[dgRowIndex].Cells["tmc_direccion"].Value;
            EstadoMantenimiento = 2;
        }

        private void ModificarCliente(int idModificarCliente)
        {

            objEnt_Cliente.id_tmc_Cliente = idModificarCliente;
            objEnt_Cliente.ds_tmc_Cliente = txtNombreCliente.Text;
            objEnt_Cliente.tmc_ruc = txtRucCliente.Text;
            objEnt_Cliente.tmc_Direccion = txtDireccionCliente.Text;
            objEnt_Cliente.tmc_FechaRegistro = DateTime.Now;

            objNeg_Cliente.cn_ModificarCliente(objEnt_Cliente);

            MessageBox.Show("Se Modifico el registro del Cliente");
        }

        //--------------------------------------------------------------------------------------------------
        private void btn_eliminar_Click(object sender, EventArgs e)
        {

            EliminarCliente();
            Lista_tm_Cliente();
            btnCancelar_Click(sender, e);

            // MessageBox.Show("Se Selecciono para Eliminar");
        }
        private void EliminarCliente()
        {
            int dgRowIndex = dg_tm_Cliente.CurrentRow.Index;
            int idEliminarCliente = (int)dg_tm_Cliente.Rows[dgRowIndex].Cells["id_tmc_Cliente"].Value;

            objNeg_Cliente.cn_EliminarCliente(idEliminarCliente);

            MessageBox.Show("Se elimino el registro del Cliente");
        }

        //--------------------------------------------------------------------------------------------------
        private void btnCancelar_Click(object sender, EventArgs e)
        {

            txtNombreCliente.ReadOnly = true;
            txtRucCliente.ReadOnly = true;
            txtDireccionCliente.ReadOnly = true;

            txtNombreCliente.Text = "";
            txtRucCliente.Text = "";
            txtDireccionCliente.Text = "";

            btnGrabarCliente.Visible = false;
            btnCancelar.Visible = false;
            btnSalir.Visible = true;

            // Habilita los botones del Mantenimiento
            btn_eliminar.Enabled = true;
            btn_nuevo.Enabled = true;
            btn_modificar.Enabled = true;

            EstadoMantenimiento = 0;
            dgRowIndex = 0;



        }

        //--------------------------------------------------------------------------------------------------
        private void btn_salir_Click(object sender, EventArgs e)
        {
            this.Close();
        }


    }
}
