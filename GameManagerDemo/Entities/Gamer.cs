using GameManagerDemo.Abstract;
using GameManagerDemo.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameManagerDemo.Entities
{
    public class Gamer:IEntity
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public long NationalityId { get; set; }
        public int BirthYear { get; set; }

        

        
       
    }
}
