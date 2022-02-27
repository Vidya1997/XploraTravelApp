using System;
using System.Collections.Generic;
using System.Text;
using SQLite;

namespace Xplora.Model
{
    public class tblPackage
    {
        [PrimaryKey,AutoIncrement]
        public int fldId { get; set; }
        public int fldPlaceId { get; set; }
        public double fldPackageAmount { get; set; }
        public double fldTotalTaxes { get; set; }
        public double fldServiceCharge { get; set; }
        public double fldDiscount { get; set; }
    }
}
