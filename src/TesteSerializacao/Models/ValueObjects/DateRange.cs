namespace src.TesteSerializacao.Models.ValueObjects
{
    public class DateRange
    {

        public DateRange(DateTime from, DateTime to)
        {
            this.From = from;
            this.To = to;

        }
        public DateTime From { get; set; }
        public DateTime To { get; set; }
    }
}