namespace Sintaxe_e_tipos_de_dados_em_CSharp.Models
{
//Está relacionada a abstração, no conseito de POO
//Uma abstração é pegar um objeto na vida real e transformar em objeto na computação
//A classe serve como um molde para construir um objeto
//A representação de uma classe é um objeto
    public class Pessoa //Nome de classe sempre em PascalCase
                        //Nome do arquivo obedeça o nome da classe
    {
        
        public string? Nome { get; set; } //Nome de propriedade sempre em PascalCase
        public int Idade { get; set; }
        public string? NomeRepresentanteLegal { get; set; } //Não recomenda-se Abreviações

        public void Apresentar() //Nome de metodo sempre em PascalCase
        {
            System.Console.WriteLine($"Olá, meu nome é {Nome}, e tenho {Idade} anos.");
        }

    }
}