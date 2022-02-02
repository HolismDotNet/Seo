namespace Seo;

public class EntityParameterController : Controller<EntityParameterView, EntityParameter>
{
    public override ReadBusiness<EntityParameterView> ReadBusiness => new EntityParameterBusiness();

    public override Business<EntityParameterView, EntityParameter> Business => new EntityParameterBusiness();

    public override Action<EntityParameter> PreCreation => entityParameter =>
    {
        var entityType = HttpContext.ExtractProperty("entityType").ToString();
        entityParameter.EntityTypeGuid = new EntityTypeBusiness().GetGuid(entityType);
        var parametersObject = Extract<ParametersObject>();
        new ParametersObjectBusiness().Create(parametersObject);
        entityParameter.ParametersObjectId = parametersObject.Id;
    };
}