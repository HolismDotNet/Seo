namespace Seo;

public class EntityParameterBusiness : Business<EntityParameterView, EntityParameter>
{
    protected override ReadRepository<EntityParameterView> ReadRepository => Repository.EntityParameterView;

    protected override Repository<EntityParameter> WriteRepository => Repository.EntityParameter;
}