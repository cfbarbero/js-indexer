using System;

namespace ConsoleApplication
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var app = new Microsoft.Extensions.CommandLineUtils.CommandLineApplication();
            app.Command("catapult", config => { });
            app.Command("snowball", config => { });
            //give people help with --help
            app.HelpOption("-? | -h | --help");
            app.Execute(args);
        }
    }
}
