﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Proyecto1.Clases.Veloz;

namespace Proyecto1.Clientes
{
    public partial class VerClientes : Form
    {
        public VerClientes()
        {
            InitializeComponent();
        }
        private DataADO.Proyecto1Entities db;
        public bool Buscando;
        public string id;

        private void Clientes_Load(object sender, EventArgs e)
        {
            this.CenterToScreen();
            Llenar();
        }
        private void Llenar()
        {
            var Clientes = db.Clientes
                .Select(x => new
                {
                    x.Id,
                    Cliente = x.Nombre + " " + x.Apellido,
                    x.Edad,
                    x.Celular,
                    x.Correo
                });

            dtgvVer.DataSource = Clientes.OrderBy(x=>x.Id).ToList();
            autosize();
        }
        private void autosize()
        {
            dtgvVer.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dtgvVer.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dtgvVer.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dtgvVer.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dtgvVer.Columns[4].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dtgvVer.Columns[0].Visible = false;

            dtgvVer.MultiSelect = true;
            dtgvVer.AllowUserToOrderColumns = false;
            dtgvVer.AllowUserToDeleteRows = false;
            dtgvVer.BackgroundColor = Color.White;
            dtgvVer.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;

            dtgvVer.Columns[1].ReadOnly = true;
            dtgvVer.Columns[2].ReadOnly = true;
            dtgvVer.Columns[3].ReadOnly = true;
            dtgvVer.Columns[4].ReadOnly = true;
        }

        private void txtbusqueda_TextChanged(object sender, EventArgs e)
        {
            using(db = new DataADO.Proyecto1Entities())
            {
                var clientes = from cl in db.Clientes
                               where cl.Nombre.Contains(txtbusqueda.Text) || cl.Apellido.Contains(txtbusqueda.Text)
                               || cl.Cedula.Contains(txtbusqueda.Text)
                               select new
                               {
                                   cl.Id,
                                   Cliente = cl.Nombre + " " + cl.Apellido,
                                   cl.Edad,
                                   cl.Celular,
                                   cl.Correo

                               };
                dtgvVer.DataSource = clientes.OrderBy(x => x.Id).ToList();
                autosize();

            }
        }

        private void btlseleccionar_Click(object sender, EventArgs e)
        {
            if (Buscando)
            {
                id = dtgvVer.CurrentRow.Cells[0].Value.ToString();
                Close();
            }
        }
    }
}
