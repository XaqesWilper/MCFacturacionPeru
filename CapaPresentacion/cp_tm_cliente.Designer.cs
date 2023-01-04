
namespace CapaPresentacion
{
    partial class cp_tm_cliente
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.dg_tm_Cliente = new System.Windows.Forms.DataGridView();
            this.id_tmc_Cliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ds_tmc_Cliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tmc_ruc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tmc_Direccion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btn_nuevo = new System.Windows.Forms.Button();
            this.btn_modificar = new System.Windows.Forms.Button();
            this.btn_eliminar = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.txtNombreCliente = new System.Windows.Forms.TextBox();
            this.txtRucCliente = new System.Windows.Forms.TextBox();
            this.txtDireccionCliente = new System.Windows.Forms.TextBox();
            this.lbl_Cliente = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnGrabarCliente = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dg_tm_Cliente)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(177, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(258, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mantenimiento de Clientes";
            // 
            // dg_tm_Cliente
            // 
            this.dg_tm_Cliente.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dg_tm_Cliente.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id_tmc_Cliente,
            this.ds_tmc_Cliente,
            this.tmc_ruc,
            this.tmc_Direccion});
            this.dg_tm_Cliente.Location = new System.Drawing.Point(12, 96);
            this.dg_tm_Cliente.MultiSelect = false;
            this.dg_tm_Cliente.Name = "dg_tm_Cliente";
            this.dg_tm_Cliente.ReadOnly = true;
            this.dg_tm_Cliente.RowHeadersVisible = false;
            this.dg_tm_Cliente.Size = new System.Drawing.Size(637, 279);
            this.dg_tm_Cliente.TabIndex = 1;
            // 
            // id_tmc_Cliente
            // 
            this.id_tmc_Cliente.DataPropertyName = "id_tmc_Cliente";
            this.id_tmc_Cliente.HeaderText = "Codigo";
            this.id_tmc_Cliente.Name = "id_tmc_Cliente";
            this.id_tmc_Cliente.ReadOnly = true;
            this.id_tmc_Cliente.Width = 60;
            // 
            // ds_tmc_Cliente
            // 
            this.ds_tmc_Cliente.DataPropertyName = "ds_tmc_Cliente";
            this.ds_tmc_Cliente.HeaderText = "Nombre";
            this.ds_tmc_Cliente.Name = "ds_tmc_Cliente";
            this.ds_tmc_Cliente.ReadOnly = true;
            this.ds_tmc_Cliente.Width = 200;
            // 
            // tmc_ruc
            // 
            this.tmc_ruc.DataPropertyName = "tmc_ruc";
            this.tmc_ruc.HeaderText = "RUC";
            this.tmc_ruc.Name = "tmc_ruc";
            this.tmc_ruc.ReadOnly = true;
            // 
            // tmc_Direccion
            // 
            this.tmc_Direccion.DataPropertyName = "tmc_Direccion";
            this.tmc_Direccion.HeaderText = "Dirección";
            this.tmc_Direccion.Name = "tmc_Direccion";
            this.tmc_Direccion.ReadOnly = true;
            this.tmc_Direccion.Width = 270;
            // 
            // btn_nuevo
            // 
            this.btn_nuevo.Location = new System.Drawing.Point(655, 96);
            this.btn_nuevo.Name = "btn_nuevo";
            this.btn_nuevo.Size = new System.Drawing.Size(111, 40);
            this.btn_nuevo.TabIndex = 2;
            this.btn_nuevo.Text = "Nuevo";
            this.btn_nuevo.UseVisualStyleBackColor = true;
            this.btn_nuevo.Click += new System.EventHandler(this.btn_nuevo_Click);
            // 
            // btn_modificar
            // 
            this.btn_modificar.Location = new System.Drawing.Point(655, 154);
            this.btn_modificar.Name = "btn_modificar";
            this.btn_modificar.Size = new System.Drawing.Size(111, 40);
            this.btn_modificar.TabIndex = 3;
            this.btn_modificar.Text = "Modificar";
            this.btn_modificar.UseVisualStyleBackColor = true;
            this.btn_modificar.Click += new System.EventHandler(this.btn_modificar_Click);
            // 
            // btn_eliminar
            // 
            this.btn_eliminar.Location = new System.Drawing.Point(655, 212);
            this.btn_eliminar.Name = "btn_eliminar";
            this.btn_eliminar.Size = new System.Drawing.Size(111, 40);
            this.btn_eliminar.TabIndex = 4;
            this.btn_eliminar.Text = "Eliminar";
            this.btn_eliminar.UseVisualStyleBackColor = true;
            this.btn_eliminar.Click += new System.EventHandler(this.btn_eliminar_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(655, 335);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(110, 40);
            this.btnSalir.TabIndex = 5;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btn_salir_Click);
            // 
            // txtNombreCliente
            // 
            this.txtNombreCliente.Location = new System.Drawing.Point(86, 70);
            this.txtNombreCliente.Name = "txtNombreCliente";
            this.txtNombreCliente.ReadOnly = true;
            this.txtNombreCliente.Size = new System.Drawing.Size(193, 20);
            this.txtNombreCliente.TabIndex = 6;
            // 
            // txtRucCliente
            // 
            this.txtRucCliente.Location = new System.Drawing.Point(285, 70);
            this.txtRucCliente.Name = "txtRucCliente";
            this.txtRucCliente.ReadOnly = true;
            this.txtRucCliente.Size = new System.Drawing.Size(98, 20);
            this.txtRucCliente.TabIndex = 7;
            // 
            // txtDireccionCliente
            // 
            this.txtDireccionCliente.Location = new System.Drawing.Point(389, 70);
            this.txtDireccionCliente.Name = "txtDireccionCliente";
            this.txtDireccionCliente.ReadOnly = true;
            this.txtDireccionCliente.Size = new System.Drawing.Size(260, 20);
            this.txtDireccionCliente.TabIndex = 8;
            // 
            // lbl_Cliente
            // 
            this.lbl_Cliente.AutoSize = true;
            this.lbl_Cliente.Location = new System.Drawing.Point(83, 54);
            this.lbl_Cliente.Name = "lbl_Cliente";
            this.lbl_Cliente.Size = new System.Drawing.Size(96, 13);
            this.lbl_Cliente.TabIndex = 9;
            this.lbl_Cliente.Text = "Nombre del Cliente";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(389, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(104, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Direccion del Cliente";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(282, 54);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "RUC Cliente";
            // 
            // btnGrabarCliente
            // 
            this.btnGrabarCliente.Location = new System.Drawing.Point(655, 68);
            this.btnGrabarCliente.Name = "btnGrabarCliente";
            this.btnGrabarCliente.Size = new System.Drawing.Size(110, 21);
            this.btnGrabarCliente.TabIndex = 12;
            this.btnGrabarCliente.Text = "Grabar";
            this.btnGrabarCliente.UseVisualStyleBackColor = true;
            this.btnGrabarCliente.Visible = false;
            this.btnGrabarCliente.Click += new System.EventHandler(this.btnGrabarCliente_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(655, 335);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(110, 40);
            this.btnCancelar.TabIndex = 13;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Visible = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // cp_tm_cliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(772, 389);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnGrabarCliente);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lbl_Cliente);
            this.Controls.Add(this.txtDireccionCliente);
            this.Controls.Add(this.txtRucCliente);
            this.Controls.Add(this.txtNombreCliente);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btn_eliminar);
            this.Controls.Add(this.btn_modificar);
            this.Controls.Add(this.btn_nuevo);
            this.Controls.Add(this.dg_tm_Cliente);
            this.Controls.Add(this.label1);
            this.Name = "cp_tm_cliente";
            this.Text = "Listado de Clientes";
            this.Load += new System.EventHandler(this.cp_tm_cliente_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dg_tm_Cliente)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dg_tm_Cliente;
        private System.Windows.Forms.Button btn_nuevo;
        private System.Windows.Forms.Button btn_modificar;
        private System.Windows.Forms.Button btn_eliminar;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.TextBox txtNombreCliente;
        private System.Windows.Forms.TextBox txtRucCliente;
        private System.Windows.Forms.TextBox txtDireccionCliente;
        private System.Windows.Forms.Label lbl_Cliente;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_tmc_Cliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn ds_tmc_Cliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn tmc_ruc;
        private System.Windows.Forms.DataGridViewTextBoxColumn tmc_Direccion;
        private System.Windows.Forms.Button btnGrabarCliente;
        private System.Windows.Forms.Button btnCancelar;
    }
}