using System;

namespace DesignPatterns.Creational.PlayerFactory
{
    public class RandomPlayerFactory
    {
        Person GetRandomPerson()
        {
            Person result = new Person();
             result.PassportId = GenerateRandom();
            return result;
        }

        private string GenerateRandom()
        {
            throw new NotImplementedException();
        }
    }
}