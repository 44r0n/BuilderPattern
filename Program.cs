using System;

namespace BuilderPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            var buildToday = new NowDateBuilder();
            BuildToday(buildToday);
            var dateExample = buildToday.GetDateExample();
            System.Console.WriteLine(dateExample.DateString+" "+dateExample.TimeString);
            var buildCustom = new SpecificDateBuilder();
            BuildCustom(buildCustom);
            dateExample = buildCustom.GetDateExample();
            System.Console.WriteLine(dateExample.DateString+" "+dateExample.TimeString);
        }   

        static void BuildToday(Builder builder)
        {
            builder.BuildDate();
            builder.BuildTime();
        } 

        static void BuildCustom(Builder builder)
        {
            builder.BuildDate("14/12/2018");
            builder.BuildTime("10:34");
        }
    }
}
