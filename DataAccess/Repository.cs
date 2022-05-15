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
}
