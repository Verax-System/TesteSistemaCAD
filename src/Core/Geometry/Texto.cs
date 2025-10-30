public class Texto : IEntidadeGeometrica
{
    public Ponto2D PontoDeInsercao { get; set; }
    public string Conteudo { get; set; }
    public string NomeEstiloDeTexto { get; set; } // Referencia o EstiloDeTexto.Nome
    public double Rotacao { get; set; } // Em graus
}

//Uma referência ao estilo de texto que define a fonte, tamanho, etc.