namespace Seo;

public class ParametersObjectBusiness : Business<ParametersObject, ParametersObject>
{
    protected override ReadRepository<ParametersObject> ReadRepository => Repository.ParametersObject;

    protected override Repository<ParametersObject> WriteRepository => Repository.ParametersObject;

    public ParametersObject CreateEmpty()
    {
        var parametersObject = new ParametersObject();
        parametersObject.PageTitle = "";
        parametersObject.MetaTitle = "";
        parametersObject.MetaDescription = "";
        parametersObject.Keywords = "";
        parametersObject.PageDescription = "";
        Create(parametersObject);
        return parametersObject;
    }
}