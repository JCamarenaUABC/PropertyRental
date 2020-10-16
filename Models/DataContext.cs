using Microsoft.EntityFrameworkCore;

namespace PropertyRental.Models
{
    public class DataContext: DbContext
    {
  /*
        Run migrations everytime something changes on the models
        - dotnet ef migrations add <someName>
        - dotnet ef database update
    */
        public DataContext(DbContextOptions<DataContext> options) : base(options){

        }

        //specify which of your models /clases will become tables on the DB
        public DbSet<Property> Properties{get; set;}

    }
}


/*
dotnet add package  Microsoft.EntityFrameworkCore;
dotnet tool install --global dotnet-ef

dotnet add packge  Microsoft.EntityFrameworkCore.Sqlite

*/