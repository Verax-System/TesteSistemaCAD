// Define o namespace baseado no nome do seu projeto (com sublinhado)
namespace Teste_Sistema_CAD.Core.Geometry
{
    /// <summary>
    /// Define o contrato base para todas as entidades 
    /// que podem ser desenhadas.
    /// </summary>
    public interface IEntidadeGeometrica
    {
        // Por enquanto, é só um contrato vazio.
        // No futuro, podemos adicionar:
        // void Desenhar(ContextoDeRenderizacao ctx);
        // BoundingBox GetBoundingBox();
    }
}