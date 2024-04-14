using GameManagerDemo.Abstract;
using GameManagerDemo.Concrete;
using GameManagerDemo.Entities;

namespace GameManagerDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Gamer gamer1 = new Gamer
            {
                FirstName = "BİLAL",
                LastName = "TAN",
                NationalityId = 12345,
                BirthYear = 2003
            };
                
            Game game1 = new Game
            {
                GameName = "Fifa 23",
                GamePrice = 1480
            };
            Game game2 = new Game
            {
                GameName = "Euro Track",
                GamePrice = 900
            };

            Campaign campaign1 = new Campaign
            {
                CampaignName = "End of Summer Discounts",
                DiscountRate= 0.3f 
            };
            Campaign campaign2 = new Campaign
            {
                CampaignName = "10th Anniversary Campaign",
                DiscountRate = 0.1f
            };

            IGamerCheckService gamerCheckService = new GamerCheckManager();
            GamerManager gamerManager1 = new GamerManager(gamerCheckService);

            gamerManager1.Add(gamer1);
            
            
            CampaignManager campaignManager1 = new CampaignManager();
            campaignManager1.Add(campaign1);
            campaignManager1.Update(campaign1);

            GameSalesManager gameSalesManager1= new GameSalesManager();
            gameSalesManager1.RegularSales(gamer1, game1);
            gameSalesManager1.BargainSale(gamer1, game2,campaign1);

            Console.ReadLine();
            
        }
    }
}
