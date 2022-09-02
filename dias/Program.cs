namespace dias;

public class Program
{
    static void Main(string[] args)
    {
        //Fazer um programa para ler um valor inteiro de um a 7 representando um dia da semana(Sendo 1 = domingo, 2 segunda,
        //e assim por diante).
        //Escrever na tela o dia da semana correspondente, conforme exemplos.

        int A;

        Console.WriteLine("Vamos ver qual dia semana é ?");
        Console.WriteLine("Po favor entre com um numero inteiro qualquer");
        Console.Write("Numero inteiro = ");
        A = int.Parse(Console.ReadLine());

        Console.WriteLine();

        try
        {

        if(A == 1)
        {
            Console.WriteLine("Domigo");
        }
        else if(A == 2)
        {
            Console.WriteLine("Segunda - Feira");
        }
        else if(A == 3)
        {
            Console.WriteLine("Treça - Feira");
        }
        else if(A == 4)
        {
            Console.WriteLine("Quarta - Feira");
        }
        else if(A == 5)
        {
            Console.WriteLine("Quinta - feira");
        }
        else if(A == 6)
        {
            Console.WriteLine("Sexta - Feira");
        }
        else if(A == 7)
        {
            Console.WriteLine("Sabado");
        }
        }
        catch(Exception)
        {
           
        }
            Console.WriteLine("Só vale numeros de 1 a 7, se digitar outro numero não poderemos te ajudar");
    }
}