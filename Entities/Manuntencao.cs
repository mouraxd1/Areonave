namespace VoeAirlinesSenai.Entities;
using VoeAirlinesSenai.Entities.Enums;

public class Manuntecao{
    public Manuntecao(DateTime dataHora, TipoManuntencao tipo, int aeronaveId, string? observacoes = null)
    {
        DataHora = dataHora;
        Observacoes = observacoes;
        Tipo = tipo;
        AeronaveId = aeronaveId;
    }

    public int Id{get; set;}

public  DateTime DataHora {get; set;}

public string? Observacoes {get; set;}

public TipoManuntencao Tipo {get; set;}

public int AeronaveId{get; set;}

public Aeronave Aeronave { get; set; } = null!;
}