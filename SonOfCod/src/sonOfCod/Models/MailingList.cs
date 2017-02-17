using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace sonOfCod.Models
{
    [Table("MailingLists")]
    public class MailingList
    {
        [Key]
        public int CustomerId { get; set; }
        public int CustomerFirstName { get; set; }
        public int CustomerLastName { get; set; }
        public int CustomerEmail { get; set; }

        public MailingList() { }
    }
}
