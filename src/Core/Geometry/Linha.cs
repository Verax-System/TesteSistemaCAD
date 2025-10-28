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

        public Linha(Ponto2D inicio, Ponto2D fim)
        {
            Inicio = inicio;
            Fim = fim;
        }

        // Futuramente:
        // public double GetComprimento() { ... }
    }
}