using System;
using System.Collections.Generic;
using System.Text;
using SQLite;

namespace Xplora.Model
{
    public class tblUsers
    {
        [PrimaryKey, AutoIncrement]
        public int fldId { get; set; }
        public String fldUsername { get; set; }
        public String fldPwd { get; set; }
        public bool fldFirst { get; set; }
    }
}
