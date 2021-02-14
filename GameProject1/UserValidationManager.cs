using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject1
{
    class UserValidationManager : IUserValidationService
    {
        public bool Validate(Gamer gamer)
        {
            if (gamer.Id==1 && gamer.BirthYear == 2001 && gamer.FirstName == "BURAK"&& gamer.LastName=="TOPRAK"&& gamer.IdentityNumber == 12345)
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
