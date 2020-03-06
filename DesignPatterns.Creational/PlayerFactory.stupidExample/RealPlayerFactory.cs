using System.Runtime.Remoting.Messaging;

namespace DesignPatterns.Creational.PlayerFactory
{
    public class RealPlayerFactory : IPlayerFactory
    {
        public Person Create()
        {
            return GetPlayerFromDatabase();
        }

        Player IPlayerFactory.Create()
        {
            throw new System.NotImplementedException();
        }

        private Person GetPlayerFromDatabase()
        {
            throw new System.NotImplementedException();
        }
    }
}