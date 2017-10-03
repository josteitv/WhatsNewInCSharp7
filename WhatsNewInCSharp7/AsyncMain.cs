using System.Threading.Tasks;

namespace WhatsNewInCSharp7
{
    public class AsyncMain
    {

        public static int Main()
        {
            return DoAsyncWork().GetAwaiter().GetResult();
        }

//        public async Task<int> Main()
//        {
//            return await DoAsyncWork();
//        }

        private static async Task<int> DoAsyncWork()
        {
            await Task.Delay(1000);
            return 1;
        }

    }
}
