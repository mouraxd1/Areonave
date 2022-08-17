namespace VoeAirlinesSenai.Entities;
//using VoeAirlinesSenai.Entities.Enums;
public class Cancelamento
{
    public Cancelamento(string motivo, DateTime dataHoraNotificacao, int vooId)
    {
        this.motivo = motivo;
        DataHoraNotificacao = dataHoraNotificacao;
        VooId = vooId;
    }

    public int ID { get; set; }
    public string motivo { get; set; }
    public DateTime DataHoraNotificacao { get; set; }
    public int VooId { get; set; }
    public Voo Voo { get; set; } = null!;
}