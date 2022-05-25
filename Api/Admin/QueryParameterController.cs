namespace Seo;

public class QueryParameterController : Controller<QueryParameterView, QueryParameter>
{
    public override ReadBusiness<QueryParameterView> ReadBusiness => new QueryParameterBusiness();

    public override Business<QueryParameterView, QueryParameter> Business => new QueryParameterBusiness();
}