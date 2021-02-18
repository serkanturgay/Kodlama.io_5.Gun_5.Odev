using System;

namespace Kodlama.io_5.Gun_5.Odev
{
    class Program
    {
        static void Main(string[] args)
        {
            GamerManager gamerManager = new GamerManager(new UserValidationManager());
            gamerManager.Add(new Gamer { Id = 1, FirstName = "Serkan", LastName = "Turgay", BirthYear = 1997, IdentityNumber = 12345678910 });
            OrderManager order1 = new OrderManager();
            order1.AddToCart(new Order { OrderName = "CS:GO " });
            order1.Buy(new Order { Price = 150, OrderName = "CS:GO" });
            CampaignManager campaignManager = new CampaignManager();
            campaignManager.CampaignAdd(new Campaign {CampaignName="Yeni Yil Indirimi" });

        }
    }
}
