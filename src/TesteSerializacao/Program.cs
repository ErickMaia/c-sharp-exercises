using src.TesteSerializacao.Models;
using src.TesteSerializacao.Models.ValueObjects;
using Newtonsoft.Json;
using TesteSerializacao.Models.ValueObjects;

List<PrecoProduto> precos = new List<PrecoProduto>(); 

PrecoProduto preco1 = 
    new PrecoProduto(
        500, 
        new DateRange(
            DateTime.Now.Subtract(TimeSpan.FromDays(3)), 
            DateTime.Now.AddDays(3)
        ));

PrecoProduto preco2 = 
    new PrecoProduto(
        1500, 
        new DateRange(
            DateTime.Now.AddDays(3), 
            DateTime.Now.AddDays(10)
        ));

PrecoProduto preco3 = 
    new PrecoProduto(
        1300, 
        new DateRange(
            DateTime.Now.AddDays(10), 
            DateTime.Now.AddDays(15)
        ));

precos.Add(preco1); 
precos.Add(preco2);
precos.Add(preco3);  

ListaPrecos lista = new ListaPrecos(precos); 

var serializado = JsonConvert.SerializeObject(precos, Formatting.Indented); 

System.Console.WriteLine(serializado);