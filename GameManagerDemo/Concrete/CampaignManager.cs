using GameManagerDemo.Abstract;
using GameManagerDemo.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameManagerDemo.Concrete
{
    internal class CampaignManager : ICrudService<Campaign>
    {
        public void Add(Campaign campaign)
        {
            Console.WriteLine(campaign.CampaignName + " kampanyasi eklendi!");
        }

        public void Delete(Campaign campaign)
        {
            Console.WriteLine(campaign.CampaignName + " kampanyasi silindi!");
        }

        public void Update(Campaign campaign)
        {
            Console.WriteLine(campaign.CampaignName + "kampanyasi güncellendi!");
        }
    }
}
