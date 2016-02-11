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
using DotNet.Highstock.Options;
using DotNet.Highstock.Helpers;
using DotNet.Highstock.Enums;
using DotNet.Highstock.Attributes;
using DotNet.Highstock;

namespace DemoMPE
{
    public partial class Cena : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            GasContext _db = new GasContext();
            IQueryable<DateTime> gasPricesDate = _db.GasPrices
                .Select(x => x.gasDate);
            var gd = gasPricesDate.ToArray();
            var gds = new string[gd.Length];
            for (int i = 0; i < gd.Length; i++)
            {
                gds[i] = Conversion.getTime(gd[i]).ToString();
            }

            IQueryable<decimal> gasPricesPrice = _db.GasPrices
                .Select(x => x.gasPrice);
            var gp = gasPricesPrice.ToArray();
            var gps = new decimal[gp.Length];
            for (int i = 0; i < gp.Length; i++)
            {
                gps[i] = gp[i];
            }

            object[,] dataFill = new object[gasPricesDate.Count(), 2];
            for (int i = 0; i < gasPricesDate.Count(); i++)
            {
                dataFill[i, 0] = gds[i];
                dataFill[i, 1] = gps[i];
            }

            Series serie = new Series { Data = new Data(dataFill) };
            Highstock chart = new Highstock("chart");
            chart.SetSeries(serie);
            chart.SetYAxis(new YAxis { Labels = new YAxisLabels { Formatter = "function() { return Highcharts.numberFormat(this.value, 2) ;}" } });
            chart.SetTooltip(new Tooltip { PointFormat = "Value: {point.y:.2f}" });

            ltrChartGasPrice.Text = chart.ToHtmlString();
        }

        public IQueryable<GasPrice> GetGasPrices()
        {
            GasContext _db = new GasContext();
            IQueryable<GasPrice> query = _db.GasPrices.Select(row => row);

            return query;
        }
    }
}