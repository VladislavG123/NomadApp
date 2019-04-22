namespace NomadApp
{
    using NomadApp.Models;
    using System;
    using System.Data.Entity;
    using System.Linq;

    public class AppContext : DbContext
    {
        // Контекст настроен для использования строки подключения "AppContext" из файла конфигурации  
        // приложения (App.config или Web.config). По умолчанию эта строка подключения указывает на базу данных 
        // "NomadApp.AppContext" в экземпляре LocalDb. 
        // 
        // Если требуется выбрать другую базу данных или поставщик базы данных, измените строку подключения "AppContext" 
        // в файле конфигурации приложения.
        public AppContext()
            : base("name=AppContext")
        {
        }

        public DbSet<Order> Orders { get; set; }
        public DbSet<Publisher> Publishers { get; set; }
        public DbSet<Magazine> Magazines { get; set; }
        public DbSet<Client> Clients { get; set; }
    }

    //public class MyEntity
    //{
    //    public int Id { get; set; }
    //    public string Name { get; set; }
    //}
}