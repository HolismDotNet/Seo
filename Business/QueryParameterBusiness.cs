namespace Seo;

public class QueryParameterBusiness : Business<Seo.QueryParameter, Seo.QueryParameter>
{
    protected override Read<Seo.QueryParameter> Read => Seo.Repository.QueryParameter;

    protected override Write<Seo.QueryParameter> Write => Seo.Repository.QueryParameter;
}