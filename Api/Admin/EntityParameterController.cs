namespace Seo;

public class EntityParameterController : Controller<EntityParameterView, EntityParameter>
{
    public override ReadBusiness<EntityParameterView> ReadBusiness => new EntityParameterBusiness();

    public override Business<EntityParameterView, EntityParameter> Business => new EntityParameterBusiness();

    [HttpGet]
    public EntityParameterView GetRecord(string entityType, Guid entityGuid)
    {
        return new EntityParameterBusiness().Get(entityType, entityGuid);
    }

    public override Action<EntityParameter> PreCreation => entityParameter =>
    {
        var entityType = HttpContext.ExtractProperty("entityType").ToString();
        entityParameter.EntityTypeGuid = new EntityTypeBusiness().GetGuid(entityType);
        var parametersObject = Extract<ParametersObject>();
        new ParametersObjectBusiness().Create(parametersObject);
        entityParameter.ParametersObjectId = parametersObject.Id;
    };

    public override Action<EntityParameter> PreUpdate => entityParameter => 
    {
        var parametersObject = Extract<ParametersObject>();
        parametersObject.Id = entityParameter.ParametersObjectId;
        new ParametersObjectBusiness().Update(parametersObject);
    };
}