namespace Seo;

public class QueryParameterController : Controller<QueryParameter, QueryParameter>
{
    public override ReadBusiness<QueryParameter> ReadBusiness => new QueryParameterBusiness();

    public override Business<QueryParameter> Business => new QueryParameterBusiness();
}