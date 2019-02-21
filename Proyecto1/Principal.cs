﻿using Proyecto1.Clases;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto1
{
    public partial class Principal : Form
    {
        public Principal()
        {
            GetForm = new Form();
            GetForm = MdiParent;
            InitializeComponent();
        }

        public static Veloz veloz22;
        public string nombre;
        public string contrasenia;
        public static Form GetForm;
        

       

        private void usuarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Usuarios.BuscarUsuario user = new Usuarios.BuscarUsuario();
            user.MdiParent = this;
            user.Show();
        }

        private void Principal_Load(object sender, EventArgs e)
        {
            this.Location = Screen.PrimaryScreen.WorkingArea.Location;
            this.Size = Screen.PrimaryScreen.WorkingArea.Size;
        }

        private void clientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Clientes.BuscarClientes fr = new Clientes.BuscarClientes();
            fr.MdiParent = this;
            fr.Show();
        }

        private void proveedoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //var pro = new Proveedores.BuscarProveedores();
            //pro.MdiParent = this;
            //pro.Show();
        }

        private void productosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var productos = new Productos.BuscarProductos();
            productos.MdiParent = this;
            productos.Show();
        }

        private void facturasToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
        }

        
        
        private void Principal_Shown(object sender, EventArgs e)
        {
            Login fr = new Login();
            fr.ShowDialog();

            if (veloz22 != null)
            {
                nombre = veloz22.Nombre;
                contrasenia = veloz22.Contrasenia;
            }
            else
            {
                Application.Exit();
            }
                
            
        }

        private void crearToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Modulos.FrmCrearModulos fr = new Modulos.FrmCrearModulos
            {
                MdiParent = this
            };
            fr.Show();
        }

        private void agregarYModificarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Modulos.AgsinarYModificar fr = new Modulos.AgsinarYModificar
            {
                MdiParent = this
            };
            fr.Show();
        }

        private void seleccionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Proveedores.Proveedores fr = new Proveedores.Proveedores
            {
                MdiParent = this
            };
            fr.Show();

        }

        private void proToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Proveedores.BuscarProveedores fr = new Proveedores.BuscarProveedores
            {
                MdiParent = this
            };

            fr.Show();

        }

        private void listarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Facturas.ListaDeFacturas fa = new Facturas.ListaDeFacturas();
            fa.MdiParent = this;
            fa.Show();
        }

        private void facturasToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Facturas.Crear frcrear = new Facturas.Crear();
            frcrear.MdiParent = this;
            frcrear.Show();
        }

        private void movimientoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Almacen.AlmacenMovimiento fralmacen = new Almacen.AlmacenMovimiento();
            fralmacen.MdiParent = this;
            fralmacen.Show();
        }

        private void mantenimientoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Almacen.Almacen fralmacen = new Almacen.Almacen();
            fralmacen.MdiParent = this;
            fralmacen.Show();
        }
    }
}