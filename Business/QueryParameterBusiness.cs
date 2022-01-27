namespace Seo;

public class QueryParameterBusiness : Business<QueryParameter, QueryParameter>
{
    protected override ReadRepository<QueryParameter> ReadRepository => Repository.QueryParameter;

    protected override Repository<QueryParameter> Repository => Repository.QueryParameter;
}