using System;
using System.Collections.Generic;
using System.Text;
using SQLite;

namespace Xplora.Model
{
    public class tblUserPlaces
    {
        [PrimaryKey,AutoIncrement]
        public int fldId { get; set; }
        public int fldCustId { get; set; }
        public int fldPckId { get; set; }
        public string fldtblplace { get; set; }
        public int fldnoofpresons { get; set; }
        public double fldtblPackage { get; set; }
        public double fldGrandTotal { get; set; }
        public string fldDate { get; set; }
        public int fldPlaceId { get; set; }
    }
}
