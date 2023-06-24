using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Webbiblioteca
{
    public partial class WebRegistrase : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack == true) { fnt_Cargar_estado(); }
        }
        private void fnt_Cargar_estado()
        {

            Cls_cargar_estado objcargarestado = new Cls_cargar_estado();
            objcargarestado.fnt_Cargar_estado();
            cbx_estado.DataSource = objcargarestado.getEstado();
            cbx_estado.DataValueField = "PKCodigo";
            cbx_estado.DataTextField = "Nombres";
            cbx_estado.DataBind();

        }

        protected void bnt_registrarse_Click(object sender, EventArgs e)
        {
            Cls_Registrar_Libro obj_Registrar = new Cls_Registrar_Libro();
            obj_Registrar.fnt_Crear(txt_isbn.Text, txt_nombre_libro.Text, txt_autor.Text, txt_editorial.Text, Convert.ToInt16(txt_N_paginas.Text)
                , txt_Genero.Text, cl_fecha_p.Text,Convert.ToInt16(cbx_estado.SelectedValue) , Convert.ToInt16(txt_cantidad_ejemplares.Text));

        }
        private void fnt_ConsultarLibro(string isbn)
        {
            Cls_consultaLibro obj_consultarLibro = new Cls_consultaLibro();
            obj_consultarLibro.fnt_ConsultarL(isbn);
            txt_nombre_libro.Text = obj_consultarLibro.getNombre();
            txt_autor.Text = obj_consultarLibro.getAutor();
            txt_editorial.Text = obj_consultarLibro.getEditoreal();
            txt_N_paginas.Text = Convert.ToString(obj_consultarLibro.getPaginas());
            txt_Genero.Text = obj_consultarLibro.getgenero();
            cbx_estado.SelectedValue = Convert.ToString(obj_consultarLibro.getesatdo());
            txt_cantidad_ejemplares.Text = Convert.ToString(obj_consultarLibro.getCantidadEjem());


        }
        protected void Button1_Click(object sender, EventArgs e)
        {
            fnt_ConsultarLibro(txt_isbn.Text);
        }

        protected void bnt_actualizar_Click(object sender, EventArgs e)
        {
            Cls_actualizarlibro obj_actualizar = new Cls_actualizarlibro();
            obj_actualizar.fnt_Actualizar(txt_isbn.Text, txt_nombre_libro.Text, txt_autor.Text, txt_editorial.Text, Convert.ToInt16(txt_N_paginas.Text)
                , txt_Genero.Text, cl_fecha_p.Text, Convert.ToInt16(cbx_estado.SelectedValue), Convert.ToInt16(txt_cantidad_ejemplares.Text));
        }
    }

     
}