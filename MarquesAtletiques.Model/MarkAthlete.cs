using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RaulLorca.MarquesAtletiques.Model
{
    public class MarkAthlete : BaseEntity
    {
        [Key, Column(Order = 0)]
        public int MarkId { get; set; }

        [Key, Column(Order = 1)]
        public int AthleteId { get; set; }

        [Key, Column(Order = 2)]
        public int Position { get; set; }

        public virtual Mark Mark { get; set; }
        public virtual Athlete Athlete { get; set; }

    }
}
