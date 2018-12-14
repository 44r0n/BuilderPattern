namespace BuilderPattern
{
    public class SpecificDateBuilder : Builder
    {
        private bool built = false;
        private DateExample dateExample;
        public override void BuildDate(string date)
        {
            if(!built)
            {
                dateExample = new DateExample(date,string.Empty);
                built = true;
            }
            else
            {
                dateExample = new DateExample(date,dateExample.TimeString);
            }
        }

        public override void BuildTime(string time)
        {
            if(!built)
            {
                dateExample = new DateExample(string.Empty,time);
                built = true;
            }
            else
            {
                dateExample = new DateExample(dateExample.DateString,time);
            }
        }

        public DateExample GetDateExample() => dateExample;
    }
}