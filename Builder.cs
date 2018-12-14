namespace BuilderPattern
{
    public abstract class Builder
    {
        public virtual void BuildDate(string date) { }
        public virtual void BuildDate() {  }
        public virtual void BuildTime(string time) { }
        public virtual void BuildTime() { }
    }
}