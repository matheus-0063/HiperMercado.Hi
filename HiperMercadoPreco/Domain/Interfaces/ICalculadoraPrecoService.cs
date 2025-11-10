using HiperMercadoPreco.Domain.Entities;

namespace HiperMercadoPreco.Domain.Interfaces;

public interface ICalculadoraPrecoService
{
    double CalcularPreco(Item item);
}