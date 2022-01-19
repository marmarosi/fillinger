using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Fillinger.Models
{
    [Table("Kapcsolatok")]
    public class Kapcsolat
    {
        public int EmberId { get; set; }

        public virtual Ember Ember { get; set; }

        public int? ApjaId { get; set; }

        public virtual Ember Apja { get; set; }

        public int? AnyjaId { get; set; }

        public virtual Ember Anyja { get; set; }
    }
}
