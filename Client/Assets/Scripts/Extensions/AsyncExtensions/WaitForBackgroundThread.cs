using System.Runtime.CompilerServices;
using System.Threading.Tasks;

namespace Client.Extensions
{
    public class WaitForBackgroundThread
    {
        public ConfiguredTaskAwaitable.ConfiguredTaskAwaiter GetAwaiter()
        {
            return Task.Run(() => { }).ConfigureAwait(false).GetAwaiter();
        }
    }
}