using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Figurinhas
{
    public partial class Figurinhas : System.Web.UI.Page
    {
        public void Page_Load(object sender, EventArgs e)
        {
            loadGridView();
        }

        private void loadGridView()
        {

                P1Entities context = new P1Entities();
                List<tb_figurinha> lstFig = context.tb_figurinha.ToList<tb_figurinha>();

                gvDados.DataSource = lstFig;
                gvDados.DataBind();

        }

        public void gvDados_SelectedIndexChanged(object sender, EventArgs e)
        {


        }

    }
}