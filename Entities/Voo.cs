namespace VoeAirlinesSenai.Entities;

public class Voo
{
    public Voo(string origem, string destino, DateTime dataHoraPartida, DateTime dataHoraChegada, int aeronaveId, int pilotoId)
    {
        Origem = origem;
        Destino = destino;
        DataHoraPartida = dataHoraPartida;
        DataHoraChegada = dataHoraChegada;
        AeronaveId = aeronaveId;
        PilotoId = pilotoId;
    }

    public int ID{get;set;}
    public string Origem{set;get;}
    public string Destino{set;get;}
    public DateTime DataHoraPartida{get;set;}
    public DateTime DataHoraChegada{get;set;}
    public int AeronaveId{get;set;}
    public int PilotoId{get;set;}
    public Piloto piloto{get;set;} = null!;
    public Aeronave aeronave {get;set;} = null!;
    public Cancelamento? Cancelamento{get;set;} = null!;
}