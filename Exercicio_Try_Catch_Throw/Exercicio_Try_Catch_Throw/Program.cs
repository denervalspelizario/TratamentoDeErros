// See https://aka.ms/new-console-template for more information
Console.WriteLine("## Exercicio Bloco Try Catch e Trhow ##");

try
{
    Console.WriteLine("Acessando o arquivo poesia.txt em https://macoratti.net/dados\n");

    Console.WriteLine("Informe o nome do arquivo");
    string? arquivo = Console.ReadLine();
    
    Console.WriteLine("Informe a url do site");
    string? url = Console.ReadLine();

    Console.WriteLine("\nAguarde...");

    // criando um objeto cliente da instancia HttpClient
    HttpClient client = new HttpClient(); 

    /* variavel resposta que recebe o valor da requisição feita pelo
       metodo GetAsync que vai buscar a url e o texto o Result serve 
       para aguardar a resposta */
    HttpResponseMessage resposta = client.GetAsync(url + "/" + arquivo).Result;

    if(resposta.IsSuccessStatusCode) // se a requisição foi sucess(status 200)
    {
        Console.WriteLine("Acesso ao arquivo feito com sucesso");
        Console.WriteLine("Código de status : " + resposta.StatusCode);
    }
    else
    {                        // transformando o statuscode em int
        throw new HttpRequestException("Erro : " + (int)resposta.StatusCode);
    }
}
// se erro for tipo HttpRequestException e for 404          
catch(HttpRequestException erro) when (erro.Message.Contains("404")) 
{
    Console.WriteLine("Pagina não encontrada");

}
// se erro for tipo HttpRequestException e for 401          
catch (HttpRequestException erro) when (erro.Message.Contains("401"))
{
    Console.WriteLine("Acesso não encontrado");

}
// se erro for tipo HttpRequestException e for 400          
catch (HttpRequestException erro) when (erro.Message.Contains("400"))
{
    Console.WriteLine("Requisição Invalida");

}
// se erro for tipo HttpRequestException e for 500          
catch (HttpRequestException erro) when (erro.Message.Contains("500"))
{
    Console.WriteLine("Erro Interno do servidor");

}
catch (Exception erro) // tratando erro de modo geral caso não seja de nenhum acima
{
    Console.WriteLine("Erro : " + erro.Message);
}
finally // que será executado independente do erro
{
    Console.WriteLine("Processamento concluido");
}




Console.ReadKey();
