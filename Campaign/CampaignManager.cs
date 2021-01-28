using System;
using System.Collections.Generic;
using System.Text;

namespace GameSimulation
{
    class CampaignManager : ICampaignController
    {
        public void AddCampaign(Campaign campaign)
        {
            Console.WriteLine("Campaign Added : " + campaign.CampaignName);
        }
      
        public void DeleteCampaign(Campaign campaign)
        {
            Console.WriteLine("Campaign Deleted : " + campaign.CampaignName);
        }

      
       
        public void UpdateCampaign(Campaign campaign)
        {
            Console.WriteLine("Campaign Updated : " + campaign.CampaignName);
        }
      

       
    }
}
