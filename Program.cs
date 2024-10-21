using Exceções_e_Coleções_em_C_.Models;
using Exemploexplorando.Models;
using nuget__Serializar_e_atributos_no_C_.Models;
using System.Globalization;
using System.Reflection;
using System.Reflection.Metadata;
using Tuplas_operador_ternario_e_desconstrução_de_um_objeto_com_C_.Models;
using Newtonsoft.Json;

//capitulo 5 etapa 5 Nuget serialização e atributos em C# 


//DESEREALIZAÇÃO: 

string conteudoArquivo = File.ReadAllText("Arquivos/vendas.json");// Aqui ele leu o json 

List<Venda> listaVenda = JsonConvert.DeserializeObject<List<Venda>>(conteudoArquivo);// o deserialize voltou o arquivo em Json em objeto de volta em forma de lista, pasando o conteudo do arquivo

foreach (Venda venda in listaVenda)
{
    Console.WriteLine($"Id: {venda.Id}, Produto: {venda.Produto}, " +
                        $"Preço: {venda.Preco}, Data: {venda.DataVenda.ToString("dd/MM/yyyy HH:mm")}");
}




// SERIALIZAÇÃO: 

// DateTime dataAtual = DateTime.Now;

// List<Venda> listaVendas = new List<Venda>();

// Venda v1 = new Venda(1, "Material de Escritorio", 25.00M, dataAtual);
// Venda v2 = new Venda(2, "Licença de Software", 110.00M, dataAtual);

// listaVendas.Add(v1);
// listaVendas.Add(v2);

// string serializado = JsonConvert.SerializeObject(listaVendas, Formatting.Indented);

// File.WriteAllText("Arquivos/vendas.json", serializado);//vc escreveu um arquivo com base no serializado emitido pelo terminal

// Console.WriteLine(serializado);






//Capitulo 4 etapa 4 Tuplas, operador ternario e desconstrução com C# 


//   int numero = 15;
//   bool ehPar = false;

// // If ternario: 
// ehPar = numero % 2 == 0;//atravez dessa variavel é posssivel identificar se ele é par ou impar 

// Console.WriteLine($"O numero {numero} é Par" + (ehPar ? "par" : "impar"));//aqui ele é escrito e ele faz dessa forma o if ternario, sempre um caso de if e else 
// //retonar dois resultados baseado em uma condição, 

//If não ternario: 
//  int numero = 15;
//  if (numero % 2 == 0 )
//  {
//     Console.WriteLine($"O numero {numero} é par");
//  }
//  else
//  {
//     Console.WriteLine($"O numero {numero} é impar");
//  }




//funcionamento do desconstrutor:
// Pessoa p1 = new Pessoa("Leonardo", "Andrade");

// (string nome, string sobrenome) = p1;

// Console.WriteLine($"{nome} {sobrenome}");



//funcionamento do meu metodo de tupla fazendo a leitura do meu arquivo Txt: 

// LeituraArquivo arquivo= new LeituraArquivo();

// var (sucesso, linhasArquivo, _) = arquivo.LerArquivo("Arquivos/arquivoLeitura.txt");//realizar o descarte apenas das info que não estão sendo usadas.

// if (sucesso)
// {
//     //Console.WriteLine("Quantidade de linhas do arquivo: " + quantidadeLinhas);
//     foreach(string linhas in linhasArquivo)
//     {
//         Console.WriteLine(linhas);
//     }
// }
// else
// {
//     Console.WriteLine("Não foi possivel ler o arquivo: ");
// }







// (int Id, string nome, string sobrenome, decimal Altura) tupla = (1, "Leonardo", "Andrade", 1.80M);//dessa maneira pode se nomear os dados 

// //outras formas de usar o Tuple: porém você não vai conseguir nomear os dados que vc está usando. 
// // ValueTuple<int, string, string, decimal> outroExemploTupla = (1, "Leonardo", "Andrade", 1.80M);
// // var outroExemploTuplaCreate = Tuple.Create(1, "Leonardo", "Andrade", 1.80M);



// Console.WriteLine($"Id: {tupla.Id}");
// Console.WriteLine($"nome: {tupla.nome}");
// Console.WriteLine($"Sobrenome: {tupla.sobrenome}");
// Console.WriteLine($"Altura: {tupla.Altura}");






















//Capitulo 3 Etapa 3 Execeções e coleções com C#

//metodo Dictionary: 

// Dictionary<string, string> estados = new Dictionary<string, string>();//primeiro elemento é a chave e o segundo é considerado o valor.

// estados.Add("SP", "São Paulo");
// estados.Add("BA", "Bahia");
// estados.Add("MG", "Minas Gerais");

// Console.WriteLine(estados["MG"]);


// foreach(var item in estados)
// {
//     Console.WriteLine($"Chave: {item.Key}, Valor: {item.Value}");
// }


// Console.WriteLine("-------------");

// estados.Remove("BA");
// estados["SP"] = "São paulo - valor alterado";

// foreach(var item in estados)
// {
//     Console.WriteLine($"Chave: {item.Key}, Valor: {item.Value}");
// }

// string chave = "BA";
// Console.WriteLine($"verificando o elemento: {chave}");

// if (estados.ContainsKey (chave))
// {
//     Console.WriteLine($"Valor existente: {chave}");
// }
// else
// {
//     Console.WriteLine($"Valor não existe. É seguro adicionar a chave: {chave}");
// }








//Metodo de Pilha 
// Stack<int> pilha = new Stack<int>();

// pilha.Push(4);
// pilha.Push(6);
// pilha.Push(8);
// pilha.Push(10);

// foreach(int item in pilha)
// {
//     Console.WriteLine(item);
// }

// Console.WriteLine($"Removendo o elemento do topo {pilha.Pop()}");//metodo remove e retorna o objeto ao topo da fila. 
// pilha.Push(20);

// foreach(int item in pilha)
// {
//     Console.WriteLine(item);
// }













//Fila na pratica 

// Queue<int> fila = new Queue<int>();

// fila.Enqueue(2);
// fila.Enqueue(4);
// fila.Enqueue(6);
// fila.Enqueue(8);

// foreach(int item in fila)//comando para imprimir a fila.
// {
//     Console.WriteLine(item);
// }

// Console.WriteLine($"Removendo o elemento: {fila.Dequeue()}");//sempre remove o primeiro elemento, pois segue a regra da fila
// fila.Enqueue(10);

// foreach(int item in fila)
// {
//     Console.WriteLine(item);
// }





//Usando o throw com ExemploExcecao
//new ExemploExcecao().Metodo1();


// string [] linhasExemplos = File.ReadAllLines("Arquivos/arquivoLeitura.txt");
// Console.WriteLine("Chegou até aqui");



//Usando o Try
// try
// {
//     string [] linhas = File.ReadAllLines("Arquivos/darquivoLeitura.txt");//cuidar com o noe corretor do arquivo para que ele não se perca

//     foreach(string linha in linhas)
//     {
//         Console.WriteLine(linha);
//     }

// } 
// catch(FileNotFoundException ex)
// {
//     Console.WriteLine($"Ocorreu um erro na leitura do arquivo. Arquivo não encontrado. {ex.Message}");
// }
//  catch (DirectoryNotFoundException ex)
// {
//     Console.WriteLine($"Ocorreu um erro na leitura do arquivo. Caminho da pasta não encontrado. {ex.Message}");
// }
//  catch(Exception ex)
// {
//     Console.WriteLine($"Ocorreu uma exceção genérica. {ex.Message}");
// }
// finally // serve para que ele execute o codigo finaly sempre, independente do erro ou não, sempre é executado. 
// {
// Console.WriteLine("Chegou até aqui");
//  }


//Capitulo 2 Etapa 2
// // Metodo de Datetime com Tryparse e validação do retorno do tryparse
// string dataString = "2024-10-15 21:00";

// bool sucesso = DateTime.TryParseExact(dataString, "yyyy-MM-dd HH:mm", CultureInfo.InvariantCulture, DateTimeStyles.None, out DateTime data );//tryparse, vai tentar converter essa represetnação de data, para um tipo date time uma data valida com a qual ele consiga trabalhar.

// if (sucesso)
// {
//     Console.WriteLine($"Conversão com sucesso!  Data: {data}");
// }

// else
// {
//     Console.WriteLine($"{dataString} não é uma data válida");
// }


//Fomatação de data e de hora com tipo DateTime
//DateTime data = DateTime.Parse(dataString);
//Console.WriteLine(data);

//Console.WriteLine(data.ToLongTimeString());//para expor só a hora
//Console.WriteLine(data.ToShortDateString());//para apresentar somente a data
//Console.WriteLine(data.ToString("dd/MM/yyyy HH:mm"));//se colocar ele em minusculo ele represente os minutos, então cuidado com os maiculos e minusculos



// //Formatação de cultura dentro do codigo, alteração e localização e cultura do codigo
// CultureInfo.DefaultThreadCurrentCulture = new CultureInfo("pt-BR");//alterando a formatação de acordo com a cultura do sistema inserido Dolar("en-US")

// decimal valorMonetario = 1582.40M;

// Console.WriteLine(valorMonetario.ToString("C8"));// C currence e o numero, quantidade de casa decimal. pode ser substituido por N também.
// //Console.WriteLine(valorMonetario.ToString("C", CultureInfo.CreateSpecificCulture("en-US")));//outra maneira de realizar a alteração da cultura
// //Console.WriteLine($"{valorMonetario:C}");//quando temos a interpolação e colocamos: significa que eu quero formatar ela o C significa corrence(Moeda), 


// //representando porcentagem: 
// double porcentagem = .3421;

// Console.WriteLine(porcentagem.ToString("P"));//usado o metodo de double pode se representar porcentagens no meu terminal

// int numero = 123456;
// Console.WriteLine(numero.ToString("##-##-##"));//nesse metodo pode se apresentar difernetes tipos de formatos das representações,meotdo personalizado que pode ser usado.



//Parte de manipulação de valores.:

// int numero1 = 10; // mesmo sendo do tipo inteiro por conta do + no meu resultado (concatenação) ele sempre vai ser lido como uma string
// string numero2 = "20";

// string resultado = numero1 + numero2;

// Console.WriteLine(resultado);



// Pessoa p1 =new Pessoa(nome: "Leonardo", sobrenome: "Pereira de Andrade");
// // p1.Nome = "leonardo";
// // p1.Sobrenome = "pereira de andrade";

// Pessoa p2 = new Pessoa(nome: "Eduardo",sobrenome: "Neves Queiroz"); //está susbistuindo usando um construtor e para os parametros, porém justificar sempre.
// // p2.Nome = "Eduardo";
// // p2.Sobrenome = "Neves Queiroz";

// Curso cursoDeIngles = new Curso();
// cursoDeIngles.Nome = "Ingles";
// cursoDeIngles.Alunos = new List<Pessoa>();

// cursoDeIngles.AdicionarAluno(p1);
// cursoDeIngles.AdicionarAluno(p2);
// cursoDeIngles.ListarAlunos();



// Pessoa p1 = new Pessoa();   //Nesse caso estamos estanciando uma variavel e salvando ela de forma que assuma o lugar de P1
// p1.Nome= "leonardo";
// p1.Sobrenome = "pereira de andrade";
// p1.Idade = 24;  //colocou valor de igual está atribuindo um SET 
// p1.Apresentar();    //não inseriu o valor de = então estão atribuindo o GET

// //quando fazemos isso com P1 significa que estamos atriubuindo ao meu p1 um valor de propriedade como idade ou nome



