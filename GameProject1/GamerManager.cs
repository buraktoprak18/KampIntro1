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
            _userValidationService = _userValidationService;
        }

        public void add(Gamer gamer)
        {
            if (_userValidationService.Validate(gamer) == true)
            {
                Console.WriteLine("Kayıt Oldu");
            }
            else
            {
                Console.WriteLine("Doğrulanamadı Kayıt Gerçekleştirilemedi");
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
