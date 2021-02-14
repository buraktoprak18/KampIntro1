using GameProject1;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject1

{
    // MicroService
    class GamerManager : IGameServices
    {
        IUserValidationService _userValidationService;
        public GamerManager(IUserValidationService userValidationService)
        {
            _userValidationService = userValidationService;
        }

        public void add(Gamer gamer)
        {
            if (_userValidationService.Validate(gamer) == true)
            {
                Console.WriteLine("Doğrulanamadı Kayıt Gerçekleştirilemedi");
            }
            else
            {
                Console.WriteLine("Kayıt Oldu");
            }
        }

        public void delete(Gamer gamer)
        {
            Console.WriteLine("Kayıt Silindi");
        }

        public void update(Gamer gamer)
        {
            Console.WriteLine("Kayıt Güncellendi");
        }
    }
}
