using System;
using System.Collections.Generic;
using System.Data.Entity;

/** Class used to initialize database with some data.
*   Currently uses mock prices. (from 2016.01.01 - 2016.02.04 YYYY/MM/DD)
*   Currently uses mock gases.
*/

namespace DemoMPE.Models
{
    public class GasDatabaseInitializer : DropCreateDatabaseIfModelChanges<GasContext>
    {
        protected override void Seed(GasContext context)
        {
            GetPrices().ForEach(p => context.Prices.Add(p));
            GetGases().ForEach(g => context.Gases.Add(g));
            GetLogs().ForEach(l => context.Logs.Add(l));
            base.Seed(context);
        }

        private static List<GasPrice> GetPrices()
        {

            var prices = new List<GasPrice>();
            var priceInit = 0.4375m;
            for (int i = 0; i < 35; i++)
            {
                priceInit += 0.0050m;

                prices.Add(new GasPrice
                {
                    GasPriceId = i + 1,

                    gasDate = new System.DateTime(2016, i > 31 ? 2 : 1, (i % 31) + 1),

                    gasPrice = priceInit
                });
            }
            return prices;
        }

        private static List<Gas> GetGases()
        {

            var gases = new List<Gas>();
            var zacetnoStanje = 3000;
            var proizvedenaKolicina = 500;

            for (int i = 0; i < 35; i++)
            {
                zacetnoStanje += proizvedenaKolicina;

                gases.Add(new Gas
                {
                    stevilka_vpisa = i + 1,

                    datum = new System.DateTime(2016, i > 31 ? 2 : 1, (i % 31) + 1),

                    ura_zacetnega_vpisa = new System.DateTime(2016, i > 31 ? 2 : 1, (i % 31) + 1),

                    ura_koncnega_vpisa = new System.DateTime(2016, i > 31 ? 2 : 1, (i % 31) + 1),

                    zacetno_stanje = zacetnoStanje,

                    koncno_stanje = zacetnoStanje + proizvedenaKolicina,

                    proizvedena_kolicina = proizvedenaKolicina,

                    zacetno_stanje_cela = zacetnoStanje,

                    zacetno_stanje_cifra = zacetnoStanje,

                    koncno_stanje_cela = zacetnoStanje + proizvedenaKolicina,

                    koncno_stanje_cifra = zacetnoStanje + proizvedenaKolicina,
                });
            }
            return gases;
        }

        private static List<Log> GetLogs()
        {
            var logs = new List<Log>();
            for (int i = 0; i < 35; i++)
            {
                logs.Add(new Log
                {
                    LogId = i + 1,

                    date = new System.DateTime(2016, i > 31 ? 2 : 1, (i % 31) + 1),

                    //UserId = "1"
                });
            }
            return logs;
        }
    }
}