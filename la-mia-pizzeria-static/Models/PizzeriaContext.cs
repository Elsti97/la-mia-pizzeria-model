using Microsoft.EntityFrameworkCore;
using la_mia_pizzeria_static.Models;



public class PizzeriaContext : DbContext
{
    public DbSet<Pizza> Pizzas { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer("Data Source=localhost;Initial Catalog=db-pizzeria;Integrated Security=True;TrustServerCertificate=True");
    }

    public void Seed()
    {
        if (!Pizzas.Any())
        {
            var seed = new Pizza[]
            {
                    new Pizza
                    {
                        Nome = "Margherita",
                        Descrizione = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Aenean rutrum magna quis lorem pellentesque, ut mattis odio interdum. Suspendisse vel bibendum eros, non ullamcorper odio",
                        Prezzo = 5.50M
                    },
                    new Pizza
                    {
                        Nome = "Diavola",
                        Descrizione = "Morbi dapibus, purus vel consequat pretium, orci ante aliquet urna, id pretium dolor orci et nunc. Nam imperdiet mi ligula, in lobortis magna iaculis ac",
                        Prezzo = 6.50M
                    }
            };

            Pizzas.AddRange(seed);

            SaveChanges();
        }
    }
}
