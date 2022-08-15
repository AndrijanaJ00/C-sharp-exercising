using System; 
using System.Linq; 

namespace CS322_DZ05_Zadatak2
{
    class Pomocna
    {
        public static Random ran = new Random();
        public static int randomBroj()
        {
            return ran.Next(1, 200);
        }

        public static string randomString()
        {
            String b = "abcdefghijklmnopqrstuvwxyz";
            int length = 8;
            String random = "";

            for (int i = 0; i < length; i++)
            {
                int a = ran.Next(26);
                random = random + b.ElementAt(a);
            }
            random = char.ToUpper(random[0]) + random.Substring(1);

            return random;
        }
    }
}
