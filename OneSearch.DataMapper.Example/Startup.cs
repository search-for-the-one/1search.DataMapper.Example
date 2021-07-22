using Microsoft.Extensions.DependencyInjection;
using Neo.ConsoleApp.DependencyInjection;
using OneSearch.DataMapper.Extensions;
using OneSearch.DataMapper.Messaging.RabbitMq;

namespace OneSearch.DataMapper.Example
{
    public class Startup : ConsoleAppStartup<int>
    {
        protected override void ConfigureServices(IServiceCollection services)
        {
            services
                .UseRabbitMq(Configuration)
                .AddDataMapper<MessageMapper>(Configuration);
        }
    }
}