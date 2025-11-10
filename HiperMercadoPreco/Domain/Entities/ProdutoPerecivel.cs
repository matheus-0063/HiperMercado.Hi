namespace HiperMercadoPreco.Domain.Entities;

public class ProdutoPerecivel : Item
{
    public bool Refrigera { get; set; }
    public double Volume { get; set; }

    public ProdutoPerecivel(string nome, double custo, DateTime validade, bool refrigera, double volume)
        : base(nome, custo, validade)
    {
        Refrigera = refrigera;
        Volume = volume;
    }

    public override double CalcularCustoTotal()
    {
        double custoTotal = Custo;

        custoTotal += Volume * 0.5;
        if (Refrigera)
            custoTotal += 2.0;

        var diasRestantes = (DataValidade - DateTime.Now).Days;
        if (diasRestantes < 5)
            custoTotal += 1.5;

        return custoTotal;
    }
}