using System;

namespace Telephony
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            Smarthphone smarthphone = new Smarthphone("IPhone");

            string[] phones = Console.ReadLine().Split();

            foreach (var phone in phones)
            {
                Console.WriteLine(smarthphone.Call(phone));
            }

            string[] websites = Console.ReadLine().Split();

            foreach (var website in websites)
            {
                Console.WriteLine(smarthphone.Browse(website));
            }
        }
    }
}
