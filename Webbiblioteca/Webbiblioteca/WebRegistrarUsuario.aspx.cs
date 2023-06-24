using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Webbiblioteca
{
    public partial class WebRegistrarUsuario : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if(!IsPostBack== true) { fnt_Cargar_estadoU(); }
        }
        private void fnt_Cargar_estadoU()
        {

            Cls_cargar_estado_usuario objcargarestado = new Cls_cargar_estado_usuario();
            objcargarestado.fnt_Cargar_estadoU();
            cbx_estado_usuario.DataSource = objcargarestado.getEstado();
            cbx_estado_usuario.DataValueField = "PKCodigo";
            cbx_estado_usuario.DataTextField = "Nombres";
            cbx_estado_usuario.DataBind();

        }
        protected void bnt_Registrar_Click(object sender, EventArgs e)
        {
            Cls_Registrar_usuario obj_Registrar = new Cls_Registrar_usuario();
            obj_Registrar.fnt_CrearU(txt_id.Text, txt_nombres.Text, txt_apellidos.Text, txt_Contacto.Text, txt_Direccion.Text
                , txt_Correo.Text, cbx_estado_usuario.SelectedIndex + 1);
        }
        private void fnt_ConsultarU(string id)
        {
            Cls_ConsulatUsuario obj_consultarLibro = new Cls_ConsulatUsuario();
            obj_consultarLibro.fnt_ConsultarL(id);
            txt_nombres.Text = obj_consultarLibro.getNombre();
            txt_apellidos.Text = obj_consultarLibro.getApellido();
            txt_Contacto.Text = obj_consultarLibro.getContacto();
            txt_Direccion.Text = obj_consultarLibro.getDireccion();
            txt_Correo.Text = obj_consultarLibro.getcorreo();
            cbx_estado_usuario.SelectedValue = Convert.ToString(obj_consultarLibro.getEstado());
        }
        protected void Button1_Click(object sender, EventArgs e)
        {
            fnt_ConsultarU(txt_id.Text);
        }

        protected void bnt_actualizar_Click(object sender, EventArgs e)
        {
            Cls_actualizarUsuario obj_actualizar = new Cls_actualizarUsuario();
            obj_actualizar.fnt_ActualizarU(txt_id.Text, txt_nombres.Text, txt_apellidos.Text, txt_Contacto.Text,
            txt_Direccion.Text, txt_Correo.Text, Convert.ToInt16(cbx_estado_usuario.SelectedValue));
        }
    }
}
    

   