namespace VoeAirlinesSenai.Entities;

public class Piloto
{
    public Piloto(string matricula, string nome)
    {
        this.nome = nome;
        this.matricula = matricula;
    }
    public int ID { get; set; }
    public string nome { get; set; }
    public string matricula { get; set; }
    public ICollection<Manuntecao> Manuntecoes { get; set; } = null!;
    public ICollection<Voo> Voos { get; set; } = null!;
}