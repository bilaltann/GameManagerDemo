using GameManagerDemo.Abstract;
using GameManagerDemo.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameManagerDemo.Concrete
{
    internal class GamerManager : ICrudService<Gamer>
    {
        IGamerCheckService _gamerCheckService;

        public GamerManager(IGamerCheckService gamerCheckService)
        {
            _gamerCheckService = gamerCheckService;
        }

        public  void Add(Gamer gamer)
        {

            if (_gamerCheckService.CheckIfRealPerson(gamer)==true)
            {

                Console.WriteLine(gamer.FirstName +" " + gamer.LastName + " adli kullanici eklendi!");
            }
            else
            {
                Console.WriteLine("Kayıt başarısız!");
            }

        }

        public void Delete(Gamer gamer)
        {
            Console.WriteLine(gamer.FirstName + "  " +  gamer.LastName +  "  adli kullanici silindi!");
        }

        public void Update(Gamer gamer)
        {
            Console.WriteLine(gamer.FirstName + "  " +  gamer.LastName + " adli kullanici güncellendi!");
        }
    }
}
