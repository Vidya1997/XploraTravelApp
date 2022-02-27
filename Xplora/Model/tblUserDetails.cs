using System;
using System.Collections.Generic;
using System.Text;
using SQLite;

namespace Xplora.Model
{
    public class tblUserDetails
    {
        [PrimaryKey, AutoIncrement]
        public int fldId { get; set; }
        public string fldName { get; set; }
        public int fldGender { get; set; }
        public String fldGenderName { get; set; }
        public string fldDob { get; set; }
        public string fldPhone { get; set; }
        public string fldEmail { get; set; }
        public int fldUserId { get; set; }

    }
}
