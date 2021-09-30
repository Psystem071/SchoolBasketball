namespace SchoolBasketball_WebAPI.Data

public class DataContext : DbContext
{
  public DataContext(DbContextOptions<DataContext> options) : base (options) { }
        public DbSet<tecnicos> Tecnico { get; set; }
        public DbSet<times> Times { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<Tecnico>()
                .HasKey(AD => new { AD.TecnicoId, AD.TimeId });

            builder.Entity<Tecnico>()
                .HasData(new List<Professor>(){
                    new Tecnico(1, "Billy Donovan"),
                    new Tecnico(2, "Frank Vogel"),
                    new Tecnico(3, "Ime Udoka"),
                    new Tecnico(4, "Erik Spoelstra"),
                    new Tecnico(5, "Steve Kerr"),
                    new Tecnico(6, "Monty Williams"),
                    new Tecnico(7, "Stephen Silas"),
                });

            builder.Entity<Regiao>()
                .HasData(new List<Regiao>{
                    new Regiao(1, "Rockville Centre, Nova York, EUA", 1),
                    new Regiao(2, "Wildwood Crest, Nova Jersey, EUA", 2),
                    new Regiao(3, "Portland, Oregon, EUA", 3),
                    new Regiao(3, "Portland, Oregon, EUA", 3),
                    new Regiao(4, "Evanston, Illinois, EUA", 4),
                    new Regiao(5, "Beirute, Líbano", 5)
                    new Regiao(5, "Fredericksburg, Virgínia, EUA", 6),
                    new Regiao(5, "Boston, Massachusetts, EUA", 6)
                });

            builder.Entity<Times>()
                .HasData(new List<Times>(){
                    new nome(1, "Chicago Bull"),
                    new nome(2, "Los Angeles Lakers"),
                    new nome(3, "Boston Celtics"),
                    new nome(4, "Miami Heat"),
                    new nome(5, "Golden State Warriors"),
                    new nome(6, "Phoenix Suns"),
                    new nome(7, "Houston Rockets")
                });

            builder.Entity<AlunoDisciplina>()
                .HasData(new List<AlunoDisciplina>() {
                    new TecnicoTime() {Timeid = 1, TecnicoId = 1 },
                    new TecnicoTime() {Timeid = 2, TecnicoId = 2 },
                    new TecnicoTime() {Timeid = 3, TecnicoId = 3 },
                    new TecnicoTime() {Timeid = 4, TecnicoId = 4 },
                    new TecnicoTime() {Timeid = 5, TecnicoId = 5 },
                    new TecnicoTime() {Timeid = 6, TecnicoId = 6 },
                    new TecnicoTime() {Timeid = 7, TecnicoId = 7 },

                });
        }
    }
}
}
