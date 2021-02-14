using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject1
{
    interface IGameServices
    {
        void add(Gamer gamer);
        void delete(Gamer gamer);
        void update(Gamer gamer);
    }
}
