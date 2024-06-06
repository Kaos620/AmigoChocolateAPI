using ChocoAmigo.Repository.EntityFramework.Configurations;
using ChocoAmigo.Repository.EntityFramework.Configurations.Entities;
using ChocoAmigoAPI.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;


namespace ChocoAmigo.Repository.EntityFramework
{
    public class Contexto : DbContext
    {
        #region - Atributo e construtor

        private readonly DatabaseSettings _databaseSettings;

        //public Contexto(DbContextOptions<Contexto> options, IOptions<DatabaseSettings> databaseSettings)
        public Contexto()
            : base()
        {
            //_databaseSettings = databaseSettings.Value;
            //try
            //{
            //    Database.CanConnect();
            //    Console.WriteLine("Conexão com o banco de dados bem-sucedida.");
            //}
            //catch (Exception ex)
            //{
            //    Console.WriteLine($"Erro ao conectar com o banco de dados: {ex.Message}");
            //}
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //optionsBuilder.UseSqlServer(_databaseSettings.ConnectionString);
            optionsBuilder.UseSqlServer("Data Source=BANDEIRA, 1434;User ID=RA044321;Password=044321;Database=BD044321;TrustServerCertificate=True;");
        }

        #endregion


        #region - Entities

        public DbSet<Grupo> Grupo { get; set; }
        public DbSet<ParticipanteGrupo> ParticipanteGrupo { get; set; }
        public DbSet<Sorteio> Sorteio { get; set; }
        public DbSet<Usuario> Usuario { get; set; }

        #endregion


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new GrupoConfiguration());
            modelBuilder.ApplyConfiguration(new ParticipanteGrupoConfiguration());
            modelBuilder.ApplyConfiguration(new SorteioConfiguration());
            modelBuilder.ApplyConfiguration(new UsuarioConfiguration());

            //base.OnModelCreating(modelBuilder);
        }
    }
}
