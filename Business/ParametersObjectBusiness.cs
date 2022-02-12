namespace Seo;

public class ParametersObjectBusiness : Business<ParametersObject, ParametersObject>
{
    protected override Read<ParametersObject> Read => Repository.ParametersObject;

    protected override Write<ParametersObject> Write => Repository.ParametersObject;

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