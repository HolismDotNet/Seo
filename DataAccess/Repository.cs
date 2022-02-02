namespace Seo;

public class Repository
{
    public static Repository<Seo.EntityParameter> EntityParameter
    {
        get
        {
            return new Repository<Seo.EntityParameter>(new SeoContext());
        }
    }

    public static Repository<Seo.EntityParameterView> EntityParameterView
    {
        get
        {
            return new Repository<Seo.EntityParameterView>(new SeoContext());
        }
    }

    public static Repository<Seo.EntityTypeParameter> EntityTypeParameter
    {
        get
        {
            return new Repository<Seo.EntityTypeParameter>(new SeoContext());
        }
    }

    public static Repository<Seo.ParametersObject> ParametersObject
    {
        get
        {
            return new Repository<Seo.ParametersObject>(new SeoContext());
        }
    }

    public static Repository<Seo.QueryParameter> QueryParameter
    {
        get
        {
            return new Repository<Seo.QueryParameter>(new SeoContext());
        }
    }
}
