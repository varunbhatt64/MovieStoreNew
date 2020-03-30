using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MovieStoreNew.Models
{
    public class MembershipType
    {
        // Entity framework every entity must have a key which will be mapped to the primary key of the table.
        // and the name must be either Id or name of the type + Id .we'll have only few membership types so byte is enough.
        public byte Id { get; set; }
        [Required]
        [StringLength(255)]
        public string Name { get; set; }
        public short SignUpFee { get; set; }
        public byte DurationInMonths { get; set; } // use byte as month is between 1 & 12 only
        public byte DiscountRate { get; set; }

        public static readonly byte Unknown = 0;
        public static readonly byte None = 1;
    }
}