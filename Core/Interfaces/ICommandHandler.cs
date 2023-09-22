using Sample.Core.Shared.CommandModels;

namespace Sample.Core.Interfaces
{
    public interface ICommandHandler<T, K>
        where T : CommandBase
        where K : CommandResponseBase
    {
        Task<K> Execute(T command);
    }
}
