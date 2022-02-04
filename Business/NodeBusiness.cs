namespace Seo;

public class NodeBusiness : Business<NodeView, Node>
{
    protected override ReadRepository<NodeView> ReadRepository => Repository.NodeView;

    protected override Repository<Node> WriteRepository => Repository.Node;
}