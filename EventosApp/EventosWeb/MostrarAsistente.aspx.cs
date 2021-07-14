using EventosModel;
using EventosModel.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace EventosWeb
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        private IAsistentesDAL asistentesDAL = new AsistenteDALDB();

        private void cargaGrilla()
        {
            List<Asistente> asistentes;
            if (this.todosChx.Checked)
            {
                asistentes = this.asistentesDAL.ObtenerAsistentes(); 
            }
            else
            {
                asistentes = this.asistentesDAL.ObtenerAsistentes(this.estadoDDl.SelectedItem.Value);
            }
            this.CargaGrilla(asistentes);

        }
        private void CargaGrilla(List<Asistente> asistentes)
        {
            this.grillaAsistente.DataSource = asistentes;
            this.grillaAsistente.DataBind();
        }
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                this.cargaGrilla();
            }
        }

        protected void estadoDDL_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.cargaGrilla();
        }

        protected void todosChx_CheckedChanged(object sender, EventArgs e)
        {
            this.estadoDDl.Enabled = !this.todosChx.Checked;
            this.cargaGrilla();
        }

        protected void grillaAsistente_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            if(e.CommandName == "eliminar")
            {
                int id = Convert.ToInt32(e.CommandArgument);
                this.asistentesDAL.EliminarAsistente(id);
                this.cargaGrilla();
            }
        }
    }
}