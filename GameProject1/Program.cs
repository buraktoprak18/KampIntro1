using System;

namespace GameProject1
{
    class Program
    {
        static void Main(string[] args)
        {
            GamerManager gamerManager = new GamerManager(new UserValidationManager());
            gamerManager.add(new Gamer { Id = 1, BirthYear = 2001, FirstName = "BURAK", LastName = "TOPRAK", IdentityNumber = 12345});
        }
    }
}
