namespace Seo;

public class EntityParameterController : Controller<EntityParameterView, EntityParameter>
{
    public override ReadBusiness<EntityParameterView> ReadBusiness => new EntityParameterBusiness();

    public override Business<EntityParameterView, EntityParameter> Business => new EntityParameterBusiness();
}