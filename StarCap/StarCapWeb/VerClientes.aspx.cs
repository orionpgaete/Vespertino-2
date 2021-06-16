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
                cargarGrilla();
            }
        }

        protected void grillaCliente_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            if (e.CommandName == "eliminar")
            {

                string rut = Convert.ToString(e.CommandArgument);
                clientesDAL.Eliminar(rut);
            }
        }

        private void cargarGrilla()
        {
            List<Cliente> clientes = clientesDAL.Obtener();
            this.grillaCliente.DataSource = clientes;
            this.grillaCliente.DataBind();
        }

        private void cargarGrilla(List<Cliente> filtrada)
        {

            this.grillaCliente.DataSource = filtrada;
            this.grillaCliente.DataBind();
        }


        protected void nivelDb1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.nivelDb1.SelectedItem != null)
            {
                int nivel = Convert.ToInt32(this.nivelDb1.SelectedItem.Value);
                //filtrar por nivel
                List<Cliente> filtrada = clientesDAL.Filtrar(nivel);
                cargarGrilla(filtrada);
            }
        }
    }
}