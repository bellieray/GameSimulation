using System;
using System.Collections.Generic;
using System.Text;

namespace GameSimulation
{
    interface ICampaignController
    {
        void UpdateCampaign(Campaign campaign);
        void DeleteCampaign(Campaign campaign);
        void AddCampaign(Campaign campaign);
    }
}
