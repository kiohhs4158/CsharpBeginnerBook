using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example504
{
    class Program
    {
        static void Main(string[] args)
        {
            Ship ship = new Ship();
            BattleShip battleship = new BattleShip();
            ship.Sail();
            battleship.Sail();
            battleship.Fight();
        }
    }
}
