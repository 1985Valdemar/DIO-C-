namespace DIO_C_.Models
{// namespace = organizacao da classe

    //classe pessoa REPRESENTA PESSOA
    public class Pessoa
    {//inicio
        //propriedade Nome & Idade
        //get pegar valor
        //set atribui valor nome = "valdemar" = é o set

        //ATRIBUTOS
        public string Nome { get; set; }
        public int idade { get; set; }

        //metodo ou funcao ou acao  QUE IRA FAZER
        public void Apresentar()
        {   
            Console.WriteLine($"Olá, Meu nome é {Nome}, e tenho {idade} anos");
        }       
         
    }//fim
}