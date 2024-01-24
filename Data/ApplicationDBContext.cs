using Microsoft.EntityFrameworkCore;
using WebAPI_Productos_ProgramacionIV.Models;

namespace WebAPI_Productos_ProgramacionIV.Data
{
    public class ApplicationDBContext : DbContext
    {

        public ApplicationDBContext
            ( 
        
                DbContextOptions<ApplicationDBContext> options 
            
            ) : base(options) // Es como un super en herencia
        {
            


        }
        
        // Creo la tabla de esta manera en la DB
        public DbSet<Producto> Producto {  get; set; }
        public DbSet<Jugador> Jugador { get; set; }
        public DbSet<Partida> Partida { get; set; }

        // Agregar datos a través de código con esta función
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Producto>().HasData(

                    new Producto
                    {

                        IdProducto = 1,
                        Nombre = "Producto 1",
                        Descripcion = "Descripcion Producto 1",
                        Cantidad = 34

                    },
                    new Producto
                    {
                        IdProducto = 2,
                        Nombre = "Producto 2",
                        Descripcion = "Descripción Producto 2",
                        Cantidad = 25

                    }

                );

            modelBuilder.Entity<Jugador>().HasData(
                
                new Jugador
                {

                    JugadorID = 1

                },

                new Jugador
                {

                    JugadorID = 2

                }
                
            );

            modelBuilder.Entity<Partida>().HasData(
                
                new Partida
                {

                    PartidaId = 1,
                    JugadorUnoID = 1,
                    JugadorDosID = 2,
                    JugadorDosIsWin = false,
                    JugadorUnoIsWin = true,
                    fechaPartida =  DateTime.Now

                },

                new Partida
                {

                    PartidaId = 2,
                    JugadorUnoID = 2,
                    JugadorDosID = 1,
                    JugadorUnoIsWin = true,
                    JugadorDosIsWin = false,
                    fechaPartida = DateTime.Parse("2024-01-22")

                }
                
                
            );

        }
        /*
         
            Siempre que haga una actualizacion en el DBContext debo hacer una migracion 

         */
    }
}
