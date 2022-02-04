namespace Seo;

public class SeoContext : DatabaseContext
{
    public override string ConnectionStringName => "Seo";

    public DbSet<Seo.EntityParameter> EntityParameters { get; set; }

    public DbSet<Seo.EntityParameterView> EntityParameterViews { get; set; }

    public DbSet<Seo.EntityTypeParameter> EntityTypeParameters { get; set; }

    public DbSet<Seo.Node> Nodes { get; set; }

    public DbSet<Seo.NodeView> NodeViews { get; set; }

    public DbSet<Seo.ParametersObject> ParametersObjects { get; set; }

    public DbSet<Seo.QueryParameter> QueryParameters { get; set; }

    public DbSet<Seo.Snippet> Snippets { get; set; }

    public DbSet<Seo.SnippetValue> SnippetValues { get; set; }

    protected override void OnModelCreating(ModelBuilder builder)
    {
        base.OnModelCreating(builder);
    }
}
