using Teste_Sistema_CAD.Core.Geometry;

namespace Teste_Sistema_CAD.Core.Geometry
{
    /// <summary>
    /// Representa uma entidade de Círculo 2D.
    /// </summary>
    public class Circulo : IEntidadeGeometrica
    {
        public Ponto2D Centro { get; set; }
        public double Raio { get; set; }

        public Circulo(Ponto2D centro, double raio)
        {
            Centro = centro;
            Raio = raio;
        }
    }
}