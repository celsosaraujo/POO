namespace _10_HerancaBranchGIT
{
    internal class Losango : Forma
    {
        public double DiagonalMaior { get; set; }
        public double DiagonalMenor { get; set; }

        public override string getTipo()
        {
            return "Losango";
        }

        public override double getArea()
        {
            return (DiagonalMaior * DiagonalMenor) / 2;
        }
    }
}
