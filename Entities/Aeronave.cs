//Nmaespace e um conjunto de classes
//Names e uma divisao logica
namespace VoeAirlinesSenai.Entities;

//classes  e conjunto de objetos 
//objeto: e uma instancia de uma classe

public class Aeronave{
    public Aeronave(string? frabricante, string? modelo, string? codigo)
    {
        this.frabricante = frabricante;
        this.modelo = modelo;
        Codigo = codigo;
    }

    //propriedades automaticas
    //caracteristicas do objeto
    //automatico: gera get set
    //motodos set atribui
    //motodos get recupera
    //POCO(Plain Old C# Object), em contrapartida no Java e POJO (Plain Old Java Object) - foco e objetoF


    public int Id {

         get; set;
    }

    public string? frabricante{

        get; set;
    }
    public string? modelo{

        get; set;
    }
    public string? Codigo{

        get; set;
    }  

    public ICollection<Manuntecao>  Manuntecoes { get; set;}
}