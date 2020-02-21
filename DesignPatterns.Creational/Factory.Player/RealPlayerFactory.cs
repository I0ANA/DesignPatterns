using System.Runtime.Remoting.Messaging;

namespace DesignPatterns.Creational.Factory.Player
{
    public class RealPlayerFactory : IPlayerFactory
    {
        public Person Create()
        {
            return GetPlayerFromDatabase();
        }

        private Person GetPlayerFromDatabase()
        {
            throw new System.NotImplementedException();
        }
    }
}