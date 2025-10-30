public class InsercaoDeBloco : IEntidadeGeometrica
{
    public string NomeDoBloco { get; set; } // Referencia DefinicaoDeBloco.Nome
    public Ponto2D PontoDeInsercao { get; set; }
    public double Rotacao { get; set; }
    public double EscalaX { get; set; } = 1.0;
    public double EscalaY { get; set; } = 1.0;

    // Propriedades ByEntity (Cor, etc.)
}