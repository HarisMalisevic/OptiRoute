namespace OptiRoute
{
    public class StanicaAbecedmoComparer : IComparer<Stanica>
    {
        public int Compare(Stanica? x, Stanica? y)
        {
            return string.Compare(x?.Naziv, y?.Naziv, StringComparison.Ordinal);
        }
    }
}