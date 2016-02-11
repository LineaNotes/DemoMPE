using System;
using System.Collections.Generic;
using System.Data.Entity;
namespace DemoMPE.Models
{
    public class AsfaltnaBazaDatabaseInitializer : DropCreateDatabaseIfModelChanges<AsfaltnaBazaContext>
    {
        protected override void Seed(AsfaltnaBazaContext context)
        {
            base.Seed(context);
        }

    }
}