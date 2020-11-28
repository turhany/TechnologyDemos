using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace _12_MVC_EF_CodeFirst.Models
{
    [Table("Kisiler")]
    public class Kisiler
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { get; set; }
        [StringLength(20),Required]
        public string Ad { get; set; }
        [StringLength(20),Required]
        public string Soyad { get; set; }
        [Required]
        public int Yas { get; set; }

        public virtual List<Adresler> Adresler { get; set; }
    }
}