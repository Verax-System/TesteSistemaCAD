// Define o namespace baseado no nome do seu projeto (com sublinhado)
namespace Teste_Sistema_CAD.Core.Geometry
{
    /// <summary>
    /// Define o contrato base para todas as entidades 
    /// que podem ser desenhadas.
    /// </summary>
    public interface IEntidadeGeometrica
    {
        public Cor Cor { get; set; }
        public TipoDeLinha TipoDeLinha { get; set; }
        public EspessuraLinha Espessura { get; set; }
    }
}