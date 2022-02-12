namespace Seo;

public class EntityParameterBusiness : Business<EntityParameterView, EntityParameter>
{
    protected override Read<EntityParameterView> Read => Repository.EntityParameterView;

    protected override Write<EntityParameter> Write => Repository.EntityParameter;

    public EntityParameterView Get(string entityType, Guid entityGuid)
    {
        var entityTypeGuid = new EntityTypeBusiness().GetGuid(entityType);
        var entityParameter = Read.Get(i => i.EntityTypeGuid == entityTypeGuid && i.EntityGuid == entityGuid);
        if (entityParameter == null)
        {
            var newRecord = new EntityParameter();
            newRecord.EntityTypeGuid = entityTypeGuid;
            newRecord.EntityGuid = entityGuid;
            newRecord.ParametersObjectId = new ParametersObjectBusiness().CreateEmpty().Id;
            Create(newRecord);
            entityParameter = Get(newRecord.Id);
        }
        return entityParameter;
    }
}