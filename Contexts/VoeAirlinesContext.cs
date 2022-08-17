using Microsoft.EntityFrameworkCore;
using VoeAirlinesSenai.Entities;

namespace VoeAirlinesSenai.Entities;

public class VoeAirlinesContext : DbContext{

public DbSet<Aeronave> Aeronaves => Set<Aeronave>();
public DbSet<Manuntecao> Manutencoes => Set<Manuntecao>();
public DbSet<Piloto> Pilotos => Set<Piloto>();
public DbSet<Voo> Voos => Set<Voo>();
public DbSet<Cancelamento> Cancelamentos => Set<Cancelamento>();
}