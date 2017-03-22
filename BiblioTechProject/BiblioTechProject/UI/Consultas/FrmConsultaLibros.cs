﻿using BLL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace BiblioTechProject.UI.Consultas
{
    public partial class FrmConsultaLibros : Form
    {
        private static FrmConsultaLibros formulario = null;

        private FrmConsultaLibros()
        {
            InitializeComponent();
        }

        public static FrmConsultaLibros GetInstance()
        {
            if (formulario == null)
            {
                formulario = new FrmConsultaLibros();
            }
            return formulario;
        }

        private void FrmConsultaLibros_Load(object sender, EventArgs e)
        {
            filtrarTextBox.Enabled = false;
            filtrarComboBox.Text = "Todo";
            estadosComboBox.Text = "Disponible";
        }

        private void Filtrar()
        {
            List<Entidades.Libro> lista = null;
            if (filtrarComboBox.Text == "Id")
            {
                int id = Utilidad.ToInt(filtrarTextBox.Text);
                lista = BLL.LibroBLL.GetList(U => U.LibroId == id);
            }
            else if (filtrarComboBox.Text == "Título")
            {
                lista = BLL.LibroBLL.GetList(U => U.Titulo == filtrarTextBox.Text);
            }
            else if (filtrarComboBox.Text == "Estado")
            {
                lista = BLL.LibroBLL.GetList(U => U.Estado == estadosComboBox.Text);
            }
            else if (filtrarComboBox.Text == "Editorial")
            {
                lista = new List<Entidades.Libro>();
                Entidades.Editorial editorial = BLL.EditorialBLL.Buscar(E => E.Nombre == filtrarTextBox.Text);
                if (editorial != null)
                {
                    lista = BLL.LibroBLL.GetList(L => L.EditorialId == editorial.EditorialId);
                }
            }
            else if (filtrarComboBox.Text == "Autor")
            {
                lista = new List<Entidades.Libro>();
                Entidades.Autor autor = BLL.AutorBLL.Buscar(A => A.Nombre == filtrarTextBox.Text);
                if (autor != null)
                {
                    List<Entidades.AutorLibro> listaRelaciones = AutorLibroBLL.GetList(R => R.AutorId == autor.AutorId);
                    foreach (var relacion in listaRelaciones)
                    {
                        lista.Add(BLL.LibroBLL.Buscar(L => L.LibroId == relacion.LibroId));
                    }
                }
            }
            else
            {
                lista = BLL.LibroBLL.GetList(U => U.LibroId > 0);
            }
            foreach (var libro in lista)
            {
                libro.UltimoUsuarioEnModificar = BLL.UsuarioBLL.Buscar(U => U.UsuarioId == libro.UsuarioId).Nombre;
                libro.NombreEditorial = BLL.EditorialBLL.Buscar(E => E.EditorialId == libro.EditorialId).Nombre;
            }
            autoresDataGridView.DataSource = lista;
            autoresDataGridView.Columns["UsuarioId"].Visible = false;
            autoresDataGridView.Columns["EditorialId"].Visible = false;
        }

        private void filtrarButton_Click(object sender, EventArgs e)
        {
            Filtrar();
        }

        private void filtrarComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (filtrarComboBox.Text == "Estado")
            {
                estadosComboBox.Visible = true;
                filtrarTextBox.Visible = false;
            }
            else
            {
                estadosComboBox.Visible = false;
                filtrarTextBox.Visible = true;
                if (filtrarComboBox.Text == "Todo")
                {
                    filtrarTextBox.Clear();
                    filtrarTextBox.Enabled = false;
                }
                else
                {
                    filtrarTextBox.Enabled = true;
                    filtrarTextBox.Focus();
                }

            }            
        }

        private void filtrarTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (filtrarComboBox.Text == "Id")
            {
                if (Char.IsDigit(e.KeyChar) || Char.IsControl(e.KeyChar))
                {
                    e.Handled = false;
                }
                else
                {
                    e.Handled = true;
                }
            }
            if ((Keys)e.KeyChar == Keys.Enter)
            {
                Filtrar();
            }
        }

        private void FrmConsultaLibros_FormClosed(object sender, FormClosedEventArgs e)
        {
            formulario = null;
        }
    }
}