using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace _12_MVC_EF_CodeFirst.Models
{
    [Table("Adresler")]
    public class Adresler
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { get; set; }
        [StringLength(300)]
        public string AdresTanimi { get; set; }

        public virtual Kisiler Kisi { get; set; }
    }
}