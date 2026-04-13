namespace Calculomath.Models
{
    public partial class DateOnlyCalculList
    {
        public DateOnly DateOfCalcul { get; set; } = new DateOnly();
        public List<Calcul> CalculList { get; set; } = new List<Calcul>();
    }
}
