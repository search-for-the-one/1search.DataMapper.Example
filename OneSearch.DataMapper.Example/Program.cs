using System.Threading.Tasks;

namespace OneSearch.DataMapper.Example
{
    class Program
    {
        private static async Task<int> Main(string[] args)
        {
            return await new Startup().RunAsync<DataMapperApp>();
        }
    }
}