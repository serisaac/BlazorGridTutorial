using Microsoft.EntityFrameworkCore;

namespace BlazorGridTutorial.Data
{
    public class ApplicationDbContext : DbContext
    {
        // Esto le dice a EF Core que queremos una tabla llamada "People"
        // que almacenará objetos de tipo "Person".
        public DbSet<Person> People { get; set; }

        // Esto configura la conexión a la base de datos.
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            // Le decimos que use SQLite y que el archivo de la base de datos
            // se llame "people.db" y se guarde en la raíz del proyecto.
            optionsBuilder.UseSqlite("Data Source=people.db");
        }
    }
}
