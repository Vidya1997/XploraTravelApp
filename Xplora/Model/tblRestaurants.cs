using System;
using System.Collections.Generic;
using System.Text;
using SQLite;


namespace Xplora.Model
{
    public class tblRestaurants
    {
        [PrimaryKey, AutoIncrement]
        public int fldID { get; set; }
        public string fldName { get; set; }
        public string fldAddress { get; set; }
        public string fldType { get; set; }
        public int fldDistrictID { get; set; }
    }
}
