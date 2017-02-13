using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace RaulLorca.MarquesAtletiques.Model
{
    public class Athlete : Entity<int>
    {
        [Required]
        [Display(Name = "Any de naixement")]
        public int BirthYear { get; set; }

        [Required]
        [Display(Name = "Sexe")]
        public Genre Genre { get; set; }

        [Required]
        [Display(Name = "Nom")]
        public string Name { get; set; }

        public virtual ICollection<MarkAthlete> MarkAthletes { get; set; }

    }
}
