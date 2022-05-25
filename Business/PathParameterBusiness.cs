namespace Seo;

public class PathParameterBusiness : Business<PathParameterView, PathParameter>
{
    protected override Read<PathParameterView> Read => Repository.PathParameterView;

    protected override Write<PathParameter> Write => Repository.PathParameter;
}