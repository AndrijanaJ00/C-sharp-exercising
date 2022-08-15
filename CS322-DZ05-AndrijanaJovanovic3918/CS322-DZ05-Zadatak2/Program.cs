using System;

namespace CS322_DZ05_Zadatak2
{
    class Program
    {
        static void Main(string[] args)
        {
            Posetioc p1 = new Posetioc(Pomocna.randomString(), Pomocna.randomString(), Pomocna.randomBroj());
            Posetioc p2 = new Posetioc(Pomocna.randomString(), Pomocna.randomString(), Pomocna.randomBroj());

            p1.stampaj();
            p2.stampaj();

        }

    }
}
