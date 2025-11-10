using HiperMercadoPreco.Domain.Entities;
using HiperMercadoPreco.Domain.Interfaces;
using HiperMercadoPreco.Infraestrutura.External;

namespace HiperMercadoPreco.Application.Services;

public class CalculadoraPrecoService : ICalculadoraPrecoService
{
    public double CalcularPreco(Item item)
    {
        var validade = (item.DataValidade - DateTime.Now).Days;
        var custoTotal = item.CalcularCustoTotal();

        return HiperMercadoHi.formulaMagica(custoTotal, validade);
    }
}