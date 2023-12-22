using Microsoft.EntityFrameworkCore;
using Pw.Account.Manager.Entities;

namespace Pw.Account.Manager.Storage;

public sealed class ApplicationContext : DbContext
{
    public DbSet<AccountEntity> Accounts => Set<AccountEntity>();
    public DbSet<AccountSettingsEntity> AccountSettings => Set<AccountSettingsEntity>();
    public DbSet<CharacterEntity> Characters => Set<CharacterEntity>();
    public DbSet<PromoBoxEntity> PromoBoxes => Set<PromoBoxEntity>();
    public DbSet<PromoItemEntity> PromoItems => Set<PromoItemEntity>();
    public ApplicationContext() => Database.EnsureCreated();
 
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlite("Data Source=manager.db");
    }
}