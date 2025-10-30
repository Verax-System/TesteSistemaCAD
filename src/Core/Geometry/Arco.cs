public class Arco : IEntidadeGeometrica
{
    public Ponto2D Centro { get; set; }
    public double Raio { get; set; }
    public double AnguloInicial { get; set; } // Em radianos ou graus
    public double AnguloFinal { get; set; }
}

//Para desenhar arcos e círculos parciais