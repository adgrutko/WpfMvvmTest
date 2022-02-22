namespace WpfMvvmTest.Core.Helpers
{
    public class ColorPair
    {
        public Color First { get; set; }
        public Color Second { get; set; }

        public ColorPair(Color first, Color second)
        {
            First = first;
            Second = second;
        }
    }
}
