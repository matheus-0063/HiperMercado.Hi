using HiperMercadoPreco.Domain.Entities.Base;

namespace HiperMercadoPreco.Domain.Entities;

public abstract class Item : Entity
{
    public string Nome { get; set; }
    public double Custo { get; set; }
    public DateTime DataValidade { get; set; }
    
    protected Item() { }

    protected Item(string nome, double custo, DateTime dataValidade)
    {
        Nome = nome;
        Custo = custo;
        DataValidade = dataValidade;
    }
    
    public abstract double CalcularCustoTotal();
}