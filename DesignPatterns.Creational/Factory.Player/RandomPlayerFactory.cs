using System.Runtime.InteropServices;

using System;

namespace DesignPatterns.Creational.Factory.Player
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