//CNPJ fictício gerado em https://www.4devs.com.br/gerador_de_cnpj
string empresa = "ERICK MAIA DEV ME - CNPJ: 40.418.604/0001-77"; 

string cnpj = empresa.Substring(empresa.IndexOf("CNPJ: ") + 6); 

string cnpjSemPontuacao = 
    cnpj
        .Replace(".", "")
        .Replace("/", "")
        .Replace("-", "");

//dados fictícios
string agenciaEContaCedente = "1850/90475-3"; 
string carteiraNossoNumero = "552/42589637-4"; 
string nossoNumero = carteiraNossoNumero.Substring(4, 8); 
string valorEmTexto = "1.584,98"; 
string valorFormatado = double.Parse(valorEmTexto.Replace(",", "").Replace(".", "")).ToString("00000000000000000"); 

System.Console.WriteLine("Valor: ");
System.Console.WriteLine(valorFormatado);

System.Console.WriteLine("Nosso número: ");
System.Console.WriteLine(nossoNumero);

System.Console.WriteLine("CNPJ: ");
System.Console.WriteLine(cnpj);

System.Console.WriteLine("CNPJ sem pontuação: ");
System.Console.WriteLine(cnpjSemPontuacao);

System.Console.WriteLine("Agência do cedente: ");
System.Console.WriteLine(agenciaEContaCedente.Substring(0, 4));

System.Console.WriteLine("Conta do cedente: ");
System.Console.WriteLine(agenciaEContaCedente.Substring(5, 5));

System.Console.WriteLine("Conta do cedente formatada com zeros à esquerda: ");
System.Console.WriteLine(int.Parse(agenciaEContaCedente.Substring(5, 5)).ToString("0000000"));

System.Console.WriteLine("Dígito verificador da conta do cedente: ");
System.Console.WriteLine(agenciaEContaCedente.Substring(agenciaEContaCedente.IndexOf("-") + 1));

