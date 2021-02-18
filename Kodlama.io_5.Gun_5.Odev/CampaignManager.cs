using System;
using System.Collections.Generic;
using System.Text;

namespace Kodlama.io_5.Gun_5.Odev
{
    class CampaignManager : ICampaignManager
    {
        public void CampaignAdd(Campaign campaign)
        {
            Console.WriteLine(campaign.CampaignName + "Kampanya Eklendi");
        }

        public void CampaignDelete(Campaign campaign)
        {
            Console.WriteLine(campaign.CampaignName + "Kampanya Silindi");
        }

        public void CampaignUpdate(Campaign campaign)
        {
            Console.WriteLine(campaign.CampaignName + "Kampanya Guncellendi");
        }
    }
}
