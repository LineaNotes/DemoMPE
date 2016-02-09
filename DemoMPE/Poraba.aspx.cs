using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using DemoMPE.Models;
using DemoMPE.Logic;
using System.Web.ModelBinding;
using System.Web.Routing;

namespace DemoMPE
{
    public partial class Poraba : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        public IQueryable<Gas> GetGases()
        {
            GasContext _db = new GasContext();
            IQueryable<Gas> query = _db.Gases.Select(row => row);

            return query;
        }
    }
}