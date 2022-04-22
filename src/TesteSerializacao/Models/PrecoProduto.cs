using src.TesteSerializacao.Models.ValueObjects;

namespace src.TesteSerializacao.Models
{
    public class PrecoProduto
    {

        public PrecoProduto(double value, DateRange dateRange)
        {
            this.Value = value;
            this.DateRange = dateRange; 

        }
        public double Value { get; set; }
        public DateRange DateRange { get; set; }

    }
}