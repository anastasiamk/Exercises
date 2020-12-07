//Создать класс команда игроков Team. 
//    Максимальное количество игроков в команде 10. 
//    Создать индексатор, который перебирает всех игроков команды.  
//    Индексатор сделать перегруженным. Перебор игроков может осуществляться по номеру 
//    и по имени (будем предполагать, что имена игроков уникальны). Определить методы добавления 
//    и удаления игрока в команде. Можно ли в класс Team добавить поле название команды? 
//    И как тогда будет работать индексатор?
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _66_
{
    class Team
    {
        Player[] players;
        private const int maxcol = 10;
        public string Name { get; set; }
        public Team()
        {
            players = new Player[maxcol];
        }
        public Player this[int index]
        {
            get
            {
                if (index < players.Length - 1)
                    return players[index];
                return null;
            }
            set
            {
                if (index < players.Length - 1)
                    players[index] = value;
            }
        }
        public Player this[string name]
        {
            get
            {
                var player = players.FirstOrDefault(c => c.Name == name);
                return player;
            }
        }
        public void Add(Player player)
        {
            if (player == null)
            {
                throw new ArgumentException(nameof(player), "Player is null");
            }
            for (int i = 0; i < players.Length; i++)
            {
                if (players[i] == null)
                {
                    players[i] = player;
                    break;
                }
            }

        }
        public void Detite(Player player)
        {
            for (int i = 0; i < players.Length; i++)
            {
                if (players[i] == player)
                {
                    players[i] = null;
                    break;
                }
            }

        }
        public void Print(Team p)
        {
            foreach(var pl in p.players)
                Console.WriteLine(pl);
        }
    }
}
