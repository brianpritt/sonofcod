using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace sonOfCod.Models
{
    [Table("Newses")]
    public class News
    {
        [Key]
        public int PostId { get; set; }
        public int PostTitle { get; set; }
        public int PostContent { get; set; }
        public int PosterId { get; set; }
        public virtual ApplicationUser Submitter { get; set;}

        public News() { }
    }
}
