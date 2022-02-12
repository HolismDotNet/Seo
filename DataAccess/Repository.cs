namespace Seo;

public class Repository
{
    public static Write<Seo.EntityParameter> EntityParameter
    {
        get
        {
            return new Write<Seo.EntityParameter>(new SeoContext());
        }
    }

    public static Write<Seo.EntityParameterView> EntityParameterView
    {
        get
        {
            return new Write<Seo.EntityParameterView>(new SeoContext());
        }
    }

    public static Write<Seo.EntityTypeParameter> EntityTypeParameter
    {
        get
        {
            return new Write<Seo.EntityTypeParameter>(new SeoContext());
        }
    }

    public static Write<Seo.Node> Node
    {
        get
        {
            return new Write<Seo.Node>(new SeoContext());
        }
    }

    public static Write<Seo.NodeView> NodeView
    {
        get
        {
            return new Write<Seo.NodeView>(new SeoContext());
        }
    }

    public static Write<Seo.ParametersObject> ParametersObject
    {
        get
        {
            return new Write<Seo.ParametersObject>(new SeoContext());
        }
    }

    public static Write<Seo.QueryParameter> QueryParameter
    {
        get
        {
            return new Write<Seo.QueryParameter>(new SeoContext());
        }
    }

    public static Write<Seo.Snippet> Snippet
    {
        get
        {
            return new Write<Seo.Snippet>(new SeoContext());
        }
    }

    public static Write<Seo.SnippetValue> SnippetValue
    {
        get
        {
            return new Write<Seo.SnippetValue>(new SeoContext());
        }
    }
}
