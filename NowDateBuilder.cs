namespace BuilderPattern
{
    public class NowDateBuilder : Builder
    {
        private bool built = false;
        private DateExample dateExample;
        public override void BuildDate()
        {
            if(!built)
            {
                dateExample = new DateExample(System.DateTime.Now.ToShortDateString(),string.Empty);
                built = true;
            }
            else
            {
                dateExample = new DateExample(System.DateTime.Now.ToShortDateString(),dateExample.TimeString);
            }
        }

        public override void BuildTime()
        {
            if(!built)
            {
                dateExample = new DateExample(string.Empty,System.DateTime.Now.ToShortTimeString());
                built = true;
            }
            else
            {
                dateExample = new DateExample(dateExample.DateString,System.DateTime.Now.ToShortTimeString());
            }
        }

        public DateExample GetDateExample() => dateExample;
    }
}