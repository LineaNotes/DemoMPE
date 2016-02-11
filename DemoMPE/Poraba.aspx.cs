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
using System.Data.OleDb;
using DotNet.Highstock.Options;
using DotNet.Highstock.Helpers;
using DotNet.Highstock.Enums;
using DotNet.Highstock.Attributes;
using DotNet.Highstock;
using System.Data.SqlClient;

using JetEntityFrameworkProvider;
using System.Data.Entity.Core.EntityClient;
using System.Data.Entity;
using System.Data.Entity.Core.Objects;
using System.Data.Common;
using System.Data;
using System.IO;
using System.Data.Entity.Migrations;
using System.Data.Entity.Migrations.Infrastructure;

namespace DemoMPE
{
    public partial class Poraba : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string strAccessConn = @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=D:\Faks\Diploma\vs2015\DemoMPE\DemoMPE\App_Data\Asfaltna_baza.mdb";
            string strAccessSelect = "SELECT * FROM gorivo";

            DataSet myDataSet = new DataSet();
            OleDbConnection myAccessConn = null;
            try
            {
                myAccessConn = new OleDbConnection(strAccessConn);
            }
            catch (Exception ex)
            {
                LabelTotalText.Text = $"Error: Failed to create a database connection. \n{ex.Message}";
                return;
            }

            try
            {
                OleDbCommand myAccessCommand = new OleDbCommand(strAccessSelect, myAccessConn);
                OleDbDataAdapter myDataAdapter = new OleDbDataAdapter(myAccessCommand);

                myAccessConn.Open();
                myDataAdapter.Fill(myDataSet, "gorivo");
            }
            catch (Exception ex)
            {
                LabelTotalText.Text = $"Error: Failed to retrieve the required data from the DataBase.\n{ex.Message}";
                return;
            }
            finally
            {
                myAccessConn.Close();
            }

            DataRowCollection dra = myDataSet.Tables["gorivo"].Rows;

            object[,] dataFill = new object[dra.Count, 2];
            for (int j = 0; j < dra.Count; j++)
            {
                dataFill[j, 0] = dra[j][1];
                dataFill[j, 1] = Convert.ToDecimal(dra[j][6]);
            }

            Series serie = new Series { Data = new Data(dataFill) };
            Highstock chart = new Highstock("chart");
            chart.SetSeries(serie);
            chart.SetYAxis(new YAxis { Labels = new YAxisLabels { Formatter = "function() { return Highcharts.numberFormat(this.value, 2) ;}" } });
            chart.SetTooltip(new Tooltip { PointFormat = "Value: {point.y:.2f}" });

            ltrChartGas.Text = chart.ToHtmlString();
        }

        public IQueryable<Gas> GetGases()
        {
            GasContext _db = new GasContext();
            IQueryable<Gas> query = _db.Gases.Select(row => row);

            return query;
        }
    }
}