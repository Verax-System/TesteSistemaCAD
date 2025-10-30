public class DefinicaoDeBloco
{
    public string Nome { get; set; }
    public Ponto2D PontoBase { get; set; }
    public List<IEntidadeGeometrica> Entidades { get; private set; } = new List<IEntidadeGeometrica>();
}