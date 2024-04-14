using GameManagerDemo.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameManagerDemo.Entities
{
    public class Campaign : IEntity
    {
        public string CampaignName { get; set; }
        public float DiscountRate { get; set; }
   
    }
}
