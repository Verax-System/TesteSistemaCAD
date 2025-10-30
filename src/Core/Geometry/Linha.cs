// Estamos usando o Ponto2D, então precisamos "importar" esse namespace
using Teste_Sistema_CAD.Core.Geometry;

namespace Teste_Sistema_CAD.Core.Geometry
{
    /// <summary>
    /// Representa uma entidade de Linha 2D.
    /// Ela implementa a interface base de entidade.
    /// </summary>
    public class Linha : IEntidadeGeometrica
    {
        public Ponto2D Inicio { get; set; }
        public Ponto2D Fim { get; set; }

        public Cor Cor { get; set; } = Cor.PorCamada;
        public TipoDeLinha TipoDeLinha { get; set; } = TipoDeLinha.PorCamada;
        public EspessuraLinha Espessura { get; set; } = EspessuraLinha.PorCamada;
    }

    // Futuramente:
    // public double GetComprimento() { ... }
}
}