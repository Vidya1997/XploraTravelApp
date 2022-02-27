using System;
using System.Collections.Generic;
using System.Text;
using SQLite;

namespace Xplora.Model
{
    public class tblReviews
    {
        [PrimaryKey,AutoIncrement]
        public int fldId { get; set; }
        public int fldCustID { get; set; }
        public int fldPlaceID { get; set; }
        public int fldRating { get; set; }
        public string fldReview { get; set; }
    }
}
