using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;

namespace JTQuickTrippin
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var app = new QuickTrippinApp();
            app.Run();
        }

    }
}