using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace RaulLorca.MarquesAtletiques.Model
{
    public class Trial : Entity<int>
    {

        [Required]
        [Display(Name = "Mesura")]
        public Measurement Measurement { get; set; }

        [Required]
        [Display(Name ="Nom de la prova")]
        public string Name { get; set; }


        [Required]
        [Display(Name = "Quantitat d'atletes")]
        public int QuantityAthletes { get; set; }

        public virtual ICollection<Mark> Marks { get; set; }

    }
}
