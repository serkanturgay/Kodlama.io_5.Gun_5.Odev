using System;
using System.Collections.Generic;
using System.Text;

namespace Kodlama.io_5.Gun_5.Odev
{
    interface ICampaignManager
    {
        void CampaignAdd(Campaign campaign);
        void CampaignDelete(Campaign campaign);
        void CampaignUpdate(Campaign campaign);
    }
}
