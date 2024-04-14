using GameManagerDemo.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameManagerDemo.Entities
{
    internal class Game:IEntity
    {
        public string GameName { get; set; }
        public int GamePrice { get; set; }
    }
}
