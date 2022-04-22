using src.TesteSerializacao.Models;

namespace TesteSerializacao.Models.ValueObjects
{
    public class ListaPrecos
    {
        public ListaPrecos(List<PrecoProduto> listaPreco)
        {
            ListaPreco = listaPreco;
        }

        public List<PrecoProduto> ListaPreco { get; set; }
    }
}