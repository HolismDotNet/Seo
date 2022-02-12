namespace Seo;

public class SnippetNodeController : TreeController<NodeView, Node>
{
    public override ReadBusiness<NodeView> ReadBusiness => new NodeBusiness();

    public override TreeBusiness<NodeView, Node> Business => new NodeBusiness();

}