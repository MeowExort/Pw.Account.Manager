using Microsoft.Extensions.Logging;
using Pw.Account.Manager.Abstract;

namespace Pw.Account.Manager.Services;

public class EntityService : IEntityService
{
    private readonly ILogger<EntityService> _logger;

    public EntityService(ILogger<EntityService> logger)
    {
        _logger = logger;
    }

    public T Create<T>(string id = null) where T : EntityBase, new()
    {
        var entity = new T
        {
            CreatedAt = DateTime.Now,
            Id = id ?? Guid.NewGuid().ToString("N")
        };
        _logger.LogDebug("Создана сущность с типом {Name}", typeof(T).Name);
        return entity;
    }

    public T Modify<T>(T entity) where T : EntityBase
    {
        entity.ModifiedAt = DateTime.Now;
        _logger.LogDebug("Изменена сущность с Id {Id} и типом {Name}", entity.Id, typeof(T).Name);
        return entity;
    }
}