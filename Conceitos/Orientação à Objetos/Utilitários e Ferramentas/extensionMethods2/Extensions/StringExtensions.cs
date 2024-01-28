namespace System
{
    internal static class StringExtensions
    {
        public static string Cut(this string thisOBJ, int contador)
        {
            if(thisOBJ.Length <= contador)
            {
                return thisOBJ;
            }
            else
            {
                return thisOBJ.Substring(0, contador) + "...";
            }
        }
    }
}
