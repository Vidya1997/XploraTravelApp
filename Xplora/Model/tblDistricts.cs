using SQLite;
using System;
using System.Collections.Generic;
using System.Text;

namespace Xplora.Model
{
    public class tblDistricts
    {
        [PrimaryKey, AutoIncrement]
        public int fldID { get; set; }
        public int fldStateID { get; set; }
        public string fldDistrict { get; set; }
    }
}
