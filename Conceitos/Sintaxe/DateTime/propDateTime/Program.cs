namespace propDateTime
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //DateTime d = new DateTime(2001, 8, 15, 13, 45, 58, 275);
            //Console.WriteLine(d);
            //Console.WriteLine("1) Date: " + d.Date);
            //Console.WriteLine("2) Day: " + d.Day);
            //Console.WriteLine("3) DayOfWeek: " + d.DayOfWeek);
            //Console.WriteLine("4) DayOfYear: " + d.DayOfYear);
            //Console.WriteLine("5) Hour: " + d.Hour);
            //Console.WriteLine("6) Kind: " + d.Kind);
            //Console.WriteLine("7) Millisecond: " + d.Millisecond);
            //Console.WriteLine("8) Minute: " + d.Minute);
            //Console.WriteLine("9) Month: " + d.Month);
            //Console.WriteLine("10) Second: " + d.Second);
            //Console.WriteLine("11) Ticks: " + d.Ticks);
            //Console.WriteLine("12) TimeOfDay: " + d.TimeOfDay);
            //Console.WriteLine("13) Year: " + d.Year);

            //DateTime e = new DateTime(2001, 8, 15, 13, 45, 58);

            //string s1 = e.ToLongDateString();
            //string s2 = e.ToLongTimeString();
            //string s3 = e.ToShortDateString();
            //string s4 = e.ToShortTimeString();

            //string s5 = e.ToString();

            //string s6 = e.ToString("yyyy-MM-dd HH:mm:ss");
            //string s7 = e.ToString("yyyy-MM-dd HH:mm:ss.fff");

            //Console.WriteLine(s1);
            //Console.WriteLine(s2);
            //Console.WriteLine(s3);
            //Console.WriteLine(s4);
            //Console.WriteLine(s5);
            //Console.WriteLine(s6);
            //Console.WriteLine(s7);

            // Operações

            DateTime f = DateTime.Now;
            DateTime f2 = f.AddHours(2);
            DateTime f3 = f2.AddMinutes(3);
            DateTime f4 = f3.AddDays(7);
            TimeSpan t = f3.Subtract(f);
            Console.WriteLine(f);
            Console.WriteLine(f2);
            Console.WriteLine(f3);
            Console.WriteLine(f4);
            Console.WriteLine(t);
        }
    }
}