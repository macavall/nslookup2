using System.Net;

namespace nslookup2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Do a few lookups by host name and address  
            DNSLookup(args[0]);
            //DNSLookup("207.46.16.248");

            // Keep the console window open in debug mode  
            //Console.WriteLine("Press any key to exit.");
            //Console.ReadKey();
        }

        protected static void DNSLookup(string hostNameOrAddress)
        {
            Console.WriteLine("Lookup: {0}\n", hostNameOrAddress);

            IPHostEntry hostEntry = Dns.GetHostEntry(hostNameOrAddress);
            Console.WriteLine("  Host Name: {0}", hostEntry.HostName);

            IPAddress[] ips = hostEntry.AddressList;
            foreach (IPAddress ip in ips)
            {
                Console.WriteLine("  Address: {0}", ip);
            }

            Console.WriteLine();
        }
    }
}