namespace Pw.Account.Manager.Abstract;

public interface IEntityService
{
    T Create<T>(string id = null) where T : EntityBase, new();

    T Modify<T>(T entity) where T : EntityBase;
}