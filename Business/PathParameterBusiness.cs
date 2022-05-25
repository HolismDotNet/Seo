namespace Seo;

public class PathParameterBusiness : Business<PathParameterView, PathParameter>
{
    protected override Read<PathParameterView> Read => Repository.PathParameterView;

    protected override Write<PathParameter> Write => Repository.PathParameter;

    public PathParameterView Get(string path)
    {
        var pathParameter = Get(i => i.Path == path);
        return pathParameter;
    }
}