using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RaulLorca.MarquesAtletiques.Model
{
    public class Mark : Entity<int>
    {
        [Display(Name = "Comentaris")]
        public string Comments { get; set; }

        [Display(Name = "Data")]
        public DateTime Date { get; set; }

        [Display(Name = "Comprobant")]
        public string Receipt { get; set; }

        [Required]
        [Display(Name = "Ciutat")]
        public string Town { get; set; }

        [Required]
        [Display(Name ="Pista")]
        public Track Track { get; set; }

        [Display(Name="Prova")]
        public int TrialId { get; set; }

        [Required]
        [Display(Name = "Marca")]
        public decimal Value { get; set; }

        public virtual ICollection<MarkAthlete> MarkAthletes { get; set; }

        [ForeignKey("TrialId")]
        public virtual Trial Trial { get; set; }

    }
}
