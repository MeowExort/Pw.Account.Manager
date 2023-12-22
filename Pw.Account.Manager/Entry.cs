using Microsoft.Extensions.DependencyInjection;
using Pw.Account.Manager.Abstract;
using Pw.Account.Manager.Services;

namespace Pw.Account.Manager;

public static class Entry
{
    public static IServiceCollection AddDomain(this IServiceCollection serviceCollection)
    {
        serviceCollection.AddTransient<IEntityService, EntityService>();
        return serviceCollection;
    }
}