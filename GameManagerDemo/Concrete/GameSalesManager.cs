using GameManagerDemo.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameManagerDemo.Concrete
{
    internal class GameSalesManager
    {
        public void RegularSales(Gamer gamer,Game game)
        {
            Console.WriteLine(gamer.FirstName+" "+ gamer.LastName+ " adli oyuncuya " + game.GameName + "  oyunu " + game.GamePrice+" TL'na satidi!");
        }

        public void BargainSale(Gamer gamer,Game game,Campaign campaign) 
        {
            Console.WriteLine(gamer.FirstName + " " +  gamer.LastName + " adli oyuncuya " + game.GameName + " oyunu  "+ campaign.CampaignName+" kampanyasiyla " 
                + (game.GamePrice - (game.GamePrice*campaign.DiscountRate)) + " TL'na satildi!");
        }
    }
}
