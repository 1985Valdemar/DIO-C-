using DIO_C_.Models;//para identificar caminho para pasta classe

Pessoa pessoa1 = new Pessoa();
//pessoa1 variavel para armazenar

pessoa1.Nome = "Valdemar";
pessoa1.idade = 38;
pessoa1.Apresentar(); 

string apresentacao = "Sejam Bem Vindo";

int quantidade = 1;

double altura = 1.80;

decimal preco = 1.90M;

bool condicao = true;

DateTime dataAtual = DateTime.Now;

//adicionar 5 dias
//DateTime datafutura = DateTime.Now.addDays(5);

int a = 2;
int b = 1;
int c = a + b;
int d = a * b;
c = c + 5;
d -= 1;


Console.WriteLine(dataAtual);
Console.WriteLine(c);
Console.WriteLine(d);
//Console.WriteLine(datafutura);
Console.WriteLine(apresentacao);
Console.WriteLine("Valor da variável quantidade: "+ quantidade);
Console.WriteLine("Valor da variável altura: "+ altura + " metros");
Console.WriteLine("Valor da variável preço R$: "+ preco);
Console.WriteLine("Valor da variável condição: "+ condicao);

