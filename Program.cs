using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using MusicHub.Data;
using MusicHub.Interfaces;
using MusicHub.Repositories;

namespace MusicHub
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // C:\Users\<YourName>\AppData\Roaming\MusicHub\database.db
            string? dbFolder = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData),"MusicHub");
            Directory.CreateDirectory(dbFolder);
            string? dbPath = Path.Combine(dbFolder, "database.db");

            ApplicationConfiguration.Initialize();
            IHost? host = Host.CreateDefaultBuilder()
                .ConfigureServices(services =>
                {
                    //Database
                    services.AddDbContext<MusicHubDbContext>(options =>
                        options.UseSqlite($"Data Source={dbPath}"));
                    //Repositories
                    services.AddScoped<IUserRepository, UserRepository>();
                    services.AddScoped<IAlbumRepository, AlbumRepository>();
                    services.AddScoped<ISongRepository, SongRepository>();
                    //Forms
                    services.AddTransient<MusicHub>();
                    services.AddTransient<ManageMusicHub>();
                    services.AddTransient<LoginForm>();
                    services.AddTransient<CreateEditAlbum>();
                    services.AddTransient<CreateEditSong>();
                    //UserControls
                    services.AddTransient<ArtistList>();
                    services.AddTransient<AlbumList>();
                    services.AddTransient<SongList>();
                    services.AddTransient<AlbumManage>();
                    services.AddTransient<SongManage>();
                })
            .Build();

            var services = host.Services;
            Application.Run(new MusicHubAppContext(services));
            using (var scope = host.Services.CreateScope())
            {
                var db = scope.ServiceProvider.GetRequiredService<MusicHubDbContext>();
                db.Database.Migrate();
            }
        }
    }
}
