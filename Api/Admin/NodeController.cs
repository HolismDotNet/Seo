namespace Seo;

public class SnippetNodeController : ReadController<NodeView>
{
    public override ReadBusiness<NodeView> ReadBusiness => new NodeBusiness();
}