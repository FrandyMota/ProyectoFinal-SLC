﻿using BLL;
using Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoSistemaLaboratorioClinico
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        public void IniciarSesion()
        {


            RepositorioBase<Usuarios> user = new RepositorioBase<Usuarios>();
            Expression<Func<Usuarios, bool>> Usuario = x => true;



            var TUsuario = UsuariotextBox.Text;
            var Tclave = ClavetextBox.Text;


            var usuario = user.GetList(p => true);

            if (usuario.Count > 0)
            {
                if (usuario.Exists(x => x.Usuario.Equals(TUsuario)))
                {
                    if (usuario.Exists(x => x.Clave.Equals(Eramake.eCryptography.Encrypt(Tclave))))
                    {

                        List<Usuarios> id = user.GetList(U => U.Usuario == UsuariotextBox.Text);
                        Limpiar();
                        MainForm form = new MainForm(id[0].UsuarioId);
                        this.Hide();
                        form.ShowDialog();
                        this.Show();
                    }
                    else
                    {
                        MessageBox.Show("Clave incorrecta");
                        return;
                    }
                }
                else
                {
                    MessageBox.Show("El Usuario no existe");
                    return;

                }
            }
            else
            {


                user.Guardar(new Usuarios()
                {
                    Nombre = "Frandy",
                    Usuario = "admin",
                    Email = "Frandy@gmail.com",
                    Clave = Eramake.eCryptography.Encrypt("admin"),
                    NivelUsuario = "Administrador",

                    Fecha = DateTime.Now
                });
                MessageBox.Show("Se ha creado el siguiente Usuario:" + "\n Usuario: admin" + "\n Clave: admin"
                    );
                return;


            }
        }

        private void Limpiar()
        {
            UsuariotextBox.Text = "";
            ClavetextBox.Text = "";
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Limpiar();
        }

        private void Login_Load(object sender, EventArgs e)
        {
            Limpiar();
        }

        private void loginbutton_Click(object sender, EventArgs e)
        {
            IniciarSesion();
        }
    }
}
