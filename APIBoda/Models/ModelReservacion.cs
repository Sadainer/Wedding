namespace APIBoda.Models
{
    using System;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity;
    using System.Linq;

    public class ModelReservacion : DbContext
    {
        // El contexto se ha configurado para usar una cadena de conexión 'ModelReservacion' del archivo 
        // de configuración de la aplicación (App.config o Web.config). De forma predeterminada, 
        // esta cadena de conexión tiene como destino la base de datos 'APIBoda.Models.ModelReservacion' de la instancia LocalDb. 
        // 
        // Si desea tener como destino una base de datos y/o un proveedor de base de datos diferente, 
        // modifique la cadena de conexión 'ModelReservacion'  en el archivo de configuración de la aplicación.
        public ModelReservacion()
            : base("name=ModelReservacion")
        {
        }

        // Agregue un DbSet para cada tipo de entidad que desee incluir en el modelo. Para obtener más información 
        // sobre cómo configurar y usar un modelo Code First, vea http://go.microsoft.com/fwlink/?LinkId=390109.

        public virtual DbSet<Reservacion> Reservacion { get; set; }
    }

    public class Reservacion
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Familia { get; set; }
        public int Cupo { get; set; }
        public string Asistencia { get; set; }

    }
}