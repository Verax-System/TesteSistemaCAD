public class Polilinha : IEntidadeGeometrica
{
    public List<Ponto2D> Vertices { get; private set; }
    public bool EhFechada { get; set; }

    public Polilinha(List<Ponto2D> vertices, bool ehFechada = false)
    {
        Vertices = vertices ?? new List<Ponto2D>();
        EhFechada = ehFechada;
    }
}

//É uma sequência de segmentos de linha conectados