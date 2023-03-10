using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace waf1
{
    public partial class _Default : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Unnamed1_SelectionChanged(object sender, EventArgs e)
        {
            lMain.Text = $"¡Fecha cambió! {cMain.SelectedDate.ToShortDateString()}";
        }
    }
}