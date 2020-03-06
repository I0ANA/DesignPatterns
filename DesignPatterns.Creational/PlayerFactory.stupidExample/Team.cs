using System.Collections.Generic;

namespace DesignPatterns.Creational.PlayerFactory
{
    public class Team
    {
        private readonly IPlayerFactory _playerFactory;

        Team(IPlayerFactory playerFactory)
        {
            _playerFactory = playerFactory;
        }

        public List<Player> GetTeam()
        {

            var list = new List<Player>();
            for (int i = 0; i < 10; i++)
            {
                    list.Add(_playerFactory.Create());
            }

            return list;
        }
    }
}