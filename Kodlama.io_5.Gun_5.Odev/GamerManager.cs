using System;
using System.Collections.Generic;
using System.Text;

namespace Kodlama.io_5.Gun_5.Odev
{
    //Mernis = MicroService
    class GamerManager : IGamerService
    {
        IUserValidationService _userValidationService;

        public GamerManager(IUserValidationService userValidationService)
        {
            this._userValidationService = userValidationService;
        }

        public void Add(Gamer gamer)
        {
            if (_userValidationService.Validate(gamer)==true)
            {
                Console.WriteLine("Kayit Oldu");
            }
            else
            {
                Console.WriteLine("Kayit Basarisiz. Kimlik Dogrulanamadi");
            }

        }

        public void Delete(Gamer gamer)
        {
            Console.WriteLine("Kayit Silindi");
        }

        public void Update(Gamer gamer)
        {
            Console.WriteLine("Kayit Guncellendi");
        }
    }
}
