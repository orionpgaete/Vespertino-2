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
        private void CargaGrilla(List<Asistente> asistentes)
        {
            this.grillaAsistente.DataSource = asistentes;
            this.grillaAsistente.DataBind();
        }
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                this.CargaGrilla(this.asistentesDAL.ObtenerAsistentes());
            }
        }

        protected void estadoDDL_SelectedIndexChanged(object sender, EventArgs e)
        {
            string estado = this.estadoDDl.SelectedValue;
            List<Asistente> asistentes = this.asistentesDAL.ObtenerAsistentes(estado);
            this.CargaGrilla(asistentes);
        }
    }
}