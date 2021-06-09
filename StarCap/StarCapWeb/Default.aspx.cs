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
    public partial class Default : System.Web.UI.Page
    {
        private IClientesDAL clientesDAL = new ClientesDALObjetos();
        private IBebidaDAL bebidaDAL = new BebidasDALObjetos();


        //Peticion GET (!PostBack)
        //Peticion POST (PostBack)

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                //aqui cargo la lista del dropdown.
                List<Bebida> bebidas = bebidaDAL.ObtenerBebidas();
                this.bebidaDb1.DataSource = bebidas;
                this.bebidaDb1.DataTextField = "Nombre";
                this.bebidaDb1.DataValueField = "Codigo";
                this.bebidaDb1.DataBind();
            }
        }

        protected void agregarBtn_Click(object sender, EventArgs e)
        {
            //1. Obtener los datos del formulario
            string nombre = this.nombreTxt.Text.Trim();
            string rut = this.rutTxt.Text.Trim();
            string bebidaValor = this.bebidaDb1.SelectedValue;
            string bebidaTexto = this.bebidaDb1.SelectedItem.Text;
            int nivel = Convert.ToInt32(this.nivelRb1.SelectedItem.Value);

            //2. Construir el objeto de tipo Cliente
            Bebida bebida = new Bebida()
            {
                Codigo = bebidaValor,
                Nombre = bebidaTexto
            };
            Cliente cliente = new Cliente()
            {
                Nombre = nombre,
                Rut = rut,
                Nivel = nivel
            };
            //3. Llamar al DAL
            clientesDAL.Agregar(cliente);
            //4. Mostrar mensajes de exito
            this.mensajesLbl.Text = "Cliente Ingresado exitosamente!!!!!";
            Response.Redirect("VerClientes.aspx");
        }
    }
}