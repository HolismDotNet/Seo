namespace Seo;

public class SeoContext : DatabaseContext
{
    public override string ConnectionStringName => "Seo";

    public DbSet<Seo.EntityParameter> EntityParameters { get; set; }

    public DbSet<Seo.EntityParameterView> EntityParameterViews { get; set; }

    public DbSet<Seo.EntityTypeParameter> EntityTypeParameters { get; set; }

    public DbSet<Seo.ParametersObject> ParametersObjects { get; set; }

    public DbSet<Seo.PathParameter> PathParameters { get; set; }

    public DbSet<Seo.PathParameterView> PathParameterViews { get; set; }

    public DbSet<Seo.QueryParameter> QueryParameters { get; set; }

    public DbSet<Seo.QueryParameterView> QueryParameterViews { get; set; }

    protected override void OnModelCreating(ModelBuilder builder)
    {
        base.OnModelCreating(builder);
    }
}
