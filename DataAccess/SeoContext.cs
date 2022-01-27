namespace Seo;

public class SeoContext : DatabaseContext
{
    public override string ConnectionStringName => "Seo";

    public DbSet<Seo.EntityParameter> EntityParameters { get; set; }

    public DbSet<Seo.EntityTypeParameter> EntityTypeParameters { get; set; }

    public DbSet<Seo.ParametersObject> ParametersObjects { get; set; }

    public DbSet<Seo.QueryParameter> QueryParameters { get; set; }

    protected override void OnModelCreating(ModelBuilder builder)
    {
        base.OnModelCreating(builder);
    }
}
