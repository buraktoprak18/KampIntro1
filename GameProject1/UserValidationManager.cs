using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject1
{
    class UserValidationManager : IUserValidationService
    {
        public bool Validate(Gamer gamer)
        {
            if (gamer.BirthYear == 1985 && gamer.FirstName == "BURAK"&& gamer.LastName=="TOPRAK"&& gamer.IdentityNumber == 12345)
            {
                return true;
            }
               else
            {
                return false;
            }

            
        }
    }
}
