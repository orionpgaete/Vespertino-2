using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace HolaMundoASP
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
    
        }


        protected void BtnSaludar_Click(object sender, EventArgs e)
        {
            //para los asp components, la propiedad para obtner el valor es TEXT
            string nombre = this.nombretxt.Text.Trim();

            //Para los HTML Elements, la propiedad es InnerText
            this.textoH1.InnerText = "Hola " +nombre+ ", pare de faltar a clases";
        }
    }
}