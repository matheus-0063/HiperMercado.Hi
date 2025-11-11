using HiperMercadoPreco.Application.Services;
using HiperMercadoPreco.Domain.Entities;
using HiperMercadoPreco.Domain.Interfaces;
using Microsoft.Extensions.DependencyInjection;

public class Program
{
    static void Main()
    {
        var serviceProvider = new ServiceCollection()
            .AddScoped<ICalculadoraPrecoService, CalculadoraPrecoService>()
            .BuildServiceProvider();

        var calculadoraService = serviceProvider.GetRequiredService<ICalculadoraPrecoService>();

        var produto = new ProdutoPerecivel(
            nome: "Leite Integral",
            custo: 5.0,
            validade: DateTime.Now.AddDays(3),
            refrigera: true,
            volume: 2.5
        );

        var preco = calculadoraService.CalcularPreco(produto);
        Console.WriteLine($"Preço final do {produto.Nome}: R$ {preco:F2}");
        
        /*
        public ValidationResult Debitar(double valor)
           {
               var result = new ValidationResult();
           
               if (valor <= 0)
                   result.Errors.Add("O valor do débito deve ser maior que zero.");
           
               if (Saldo < valor)
                   result.Errors.Add("Saldo insuficiente para realizar a operação.");
           
               if (result.Errors.Any())
                   return result;
           
               Saldo -= valor;
               return result;
           }
           
           */
        
    }
}