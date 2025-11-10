namespace HiperMercadoPreco.Infraestrutura.External;

public static class HiperMercadoHi
{
    public static double formulaMagica(double custo, int validade)
    {
        return custo + (100 - validade) * 0.5;
    }
}