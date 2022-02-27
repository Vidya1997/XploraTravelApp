using System;
using System.Collections.Generic;
using System.Text;
using SQLite;

namespace Xplora.Model
{
    public class tblStates
    {
        [PrimaryKey,AutoIncrement]
        public int fldID { get; set; }
        public String fldState { get; set; }
    }
}
