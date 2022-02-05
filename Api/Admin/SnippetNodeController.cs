namespace Seo;

public class SnippetNodeController : TreeController<NodeView, Node>
{
    public override TreeBusiness<NodeView, Node> Business => new NodeBusiness();
}