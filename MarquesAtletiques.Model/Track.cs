using System.ComponentModel;

namespace RaulLorca.MarquesAtletiques.Model
{
    public enum Track
    {
        [Description("Pista coberta")]
        Indoor, // Pista cubierta

        [Description("Aire Lliure")]
        Outdoor // Aire Libre
    }
}
