using System;
using System.Collections.Generic;
using System.Text;

namespace Kodlama.io_5.Gun_5.Odev
{
    class UserValidationManager : IUserValidationService
    {
        public bool Validate(Gamer gamer)
        {
            if (gamer.FirstName=="Serkan" && gamer.LastName=="Turgay" && gamer.BirthYear==1997  && gamer.IdentityNumber==12345678910)
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
