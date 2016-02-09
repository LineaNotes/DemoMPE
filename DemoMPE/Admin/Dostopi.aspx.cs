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

namespace DemoMPE.Admin
{
    public partial class Dostopi : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        // e.q. of QueryString("id") http://localhost/ProductList.aspx?id=1
        public IQueryable<Log> GetLogEntriesQS([QueryString("id")] int? Id/*, [RouteData] string UserName*/)
        {
            var _db = new GasContext();
            IQueryable<Log> query = _db.Logs;

            //TODO: atm it shows logs by id from QueryString, it would make more sense to manually pick user to check his logs or have
            // a date range picker to show all logs for certain time period 
            if (Id.HasValue && Id > 0)
            {
                query = query.Where(l => l.LogId == Id);
            }

            return query;
        }

        public IQueryable<Log> GetLogs()
        {
            GasContext _db = new GasContext();
            IQueryable<Log> query = _db.Logs.Select(row => row);

            return query;
        }
    }
}