using StarCapModel;
using StarCapModel.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace StarCapWeb
{
    public partial class VerClientes : System.Web.UI.Page
    {
        private IClientesDAL clientesDAL = new ClientesDALObjetos();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                List<Cliente> cliente = clientesDAL.Obtener();
                this.grillaCliente.DataSource = cliente;
                this.grillaCliente.DataBind();
            }
        }

        protected void grillaCliente_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            if(e.CommandName == "eliminar")
            {

                string rut = Convert.ToString(e.CommandArgument);
                clientesDAL.Eliminar(rut);
            }
        }
    }
}