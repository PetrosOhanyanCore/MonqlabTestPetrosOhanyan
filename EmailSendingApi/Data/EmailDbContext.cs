namespace EmailSendingApi.Data;

public class EmailDbContext : DbContext
{
    private readonly string _connectionString;

    public EmailDbContext(DbContextOptions<EmailDbContext> options, IConfiguration config) : base(options)
    {
        _connectionString = config.GetConnectionString("DefaultConnection");
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Email>()
            .HasMany(e => e.Recipients);
    }

    protected override void OnConfiguring(DbContextOptionsBuilder options) => options.UseSqlServer(_connectionString);

    /// <summary>
    /// DbSet for Emails
    /// </summary>
    public DbSet<Email> Emails { get; set; }

    /// <summary>
    /// DbSet for Recipients
    /// </summary>
    public DbSet<Recipient> Recipients { get; set; }
}