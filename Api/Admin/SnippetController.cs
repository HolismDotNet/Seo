namespace Seo;

public class SnippetController : ReadController<Snippet>
{
    public override ReadBusiness<Snippet> ReadBusiness => new SnippetBusiness();
}