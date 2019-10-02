using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Figurinhas;

namespace Figurinhas
{
    public partial class CadastroFigurinha : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnSalvar_Click(object sender, EventArgs e)
        {

            P1Entities context = new P1Entities();

            tb_figurinha figurinha = new tb_figurinha()
            {
                Descricao = txtDescricao.Text,
                Ano = txtAno.Text
            };

            context.tb_figurinha.Add(figurinha);
            context.SaveChanges();
            SendMessage("Registro Inserido!");
        }

        private void SendMessage(string txt)
        {
            lblMsg.Text = txt;
        }

    }
}