namespace Seo;

public class ParametersObjectBusiness : Business<ParametersObject, ParametersObject>
{
    protected override ReadRepository<ParametersObject> ReadRepository => Repository.ParametersObject;

    protected override Repository<ParametersObject> WriteRepository => Repository.ParametersObject;
}