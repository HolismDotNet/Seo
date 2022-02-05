namespace Seo;

public class NodeBusiness : TreeBusiness<NodeView, Node>
{
    protected override ReadRepository<NodeView> ReadRepository => Repository.NodeView;

    protected override Repository<Node> WriteRepository => Repository.Node;
}