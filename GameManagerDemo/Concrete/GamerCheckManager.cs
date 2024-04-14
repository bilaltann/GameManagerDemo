using GameManagerDemo.Abstract;
using GameManagerDemo.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameManagerDemo.Concrete
{
    public class GamerCheckManager : IGamerCheckService
    {
        public bool CheckIfRealPerson(Gamer gamer)
        {
           if(gamer.BirthYear==2003 && gamer.FirstName=="BİLAL" &&gamer.LastName=="TAN" && gamer.NationalityId == 12345)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }




}
