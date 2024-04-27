// See https://aka.ms/new-console-template for more information
Console.WriteLine("## Bloco Try Catch e Finally ##");

try
{
    Console.WriteLine("\nInforme o dividendo");
    int dividendo = Convert.ToInt32(Console.ReadLine()); // recebendo dado

    Console.WriteLine("\nInforme o divisor");
    int divisor = Convert.ToInt32(Console.ReadLine()); // recebendo dado


    int resultado = (dividendo / divisor);

    Console.WriteLine($"\n{dividendo} / {divisor} = {resultado}");

}
catch (Exception excessao) // Execption é a classe onde todas as excessões herdam
{                          // ela é a classe geral que trata todos os erros 

    Console.WriteLine("ocorreu um erro");
    Console.WriteLine(excessao); // chamando a excessão inteira 
    Console.WriteLine(excessao.Message); // chamando apenas o metodo message de excption
    
}

Console.ReadKey();
