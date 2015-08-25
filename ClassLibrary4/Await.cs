using System.Threading.Tasks;
using NUnit.Framework;

namespace ClassLibrary4
{
    class Await
    {
        public static async void DoSomething()
        {
            var x = await GetIntAsync();
        }

        private static Task<int> GetIntAsync()
        {
            Task.Delay(5000);
            return new Task<int>(() => 3);
        }
    }

    [TestFixture]
    public class AwaitTests
    {
        [Test]
        public void RunSomething()
        {
            Await.DoSomething();
        }
    }
}
