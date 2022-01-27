namespace Seo;

public class QueryParameterBusiness : Business<Seo.QueryParameter, Seo.QueryParameter>
{
    protected override ReadRepository<Seo.QueryParameter> ReadRepository => Seo.Repository.QueryParameter;

    protected override Repository<Seo.QueryParameter> WriteRepository => Seo.Repository.QueryParameter;
}