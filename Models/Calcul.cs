namespace Calculomath.Models
{
    public partial class Calcul
    {
        // "A" ==> Addition, "S" ==> Soustraction, "M" ==> Multiplication, "D" ==> Division
        public string TypeDeCalcul { get; set; } = string.Empty;

        public int PremierNombre { get; set; } = 0;

        public int DernierNombre { get; set; } = 0;

        public bool Correct { get; set; } = false;

        public double DureeEnMillisecondes { get; set; } = 0;
    }
}
