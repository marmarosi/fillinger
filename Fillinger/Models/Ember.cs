using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Fillinger.Models
{
    [Table("Emberek")]
    public class Ember
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [MaxLength(50)]
        public string Nev { get; set; }

        public Nem Nem { get; set; }

        public DateTime SzuletesiDatum { get; set; }
    }
}
