using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Http;

public class MeuMiddleware
{
    //Request Delegate
    private readonly RequestDelegate _next;

    public MeuMiddleware(RequestDelegate next)
    {
        _next = next;
    }

    //Metodo que é dedicada a logica do seu middleware
    public async Task InvokeAsync(HttpContext context)
    {
        System.Console.WriteLine("\n\r ---- Antes ----\n\r");
        //Passa o request proximo middleware
        await _next(context);

        //Quando acabar a cadeia de middleware ele é chamado novamente
        System.Console.WriteLine("\n\r ---- Depois ----\n\r");
    }
}

//Extension method para chamar o middleware direto no app;
public static class MeuMiddlewareExtension
{
    public static IApplicationBuilder UseMeuMiddleware(this IApplicationBuilder builder)
    {
        return builder.UseMiddleware<MeuMiddleware>();
    }
}