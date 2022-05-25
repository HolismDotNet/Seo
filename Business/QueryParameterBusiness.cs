namespace Seo;

public class QueryParameterBusiness : Business<QueryParameterView, QueryParameter>
{
    protected override Read<QueryParameterView> Read => Repository.QueryParameterView;

    protected override Write<QueryParameter> Write => Repository.QueryParameter;

    public string GetSortedQuery(object input)
    {
        return "";
    }
}