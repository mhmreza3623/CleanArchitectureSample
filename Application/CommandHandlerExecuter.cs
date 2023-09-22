using Sample.Core.Interfaces;
using Sample.Core.Shared.CommandModels;

namespace Sample.Application
{
    public class CommandHandlerExecuter<T, K> : ICommandHandlerExecuter<T, K>
        where T : CommandBase
        where K : CommandResponseBase

    {
        private readonly ICommandHandler<T, K> handler;

        public CommandHandlerExecuter(ICommandHandler<T, K> handler)
        {
            this.handler = handler;
        }

        public async Task<K> Execute(T command)
        {
            var response = await handler.Execute(command);

            return response;
        }
    }
}
