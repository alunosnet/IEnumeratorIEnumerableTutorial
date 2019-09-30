using System;

namespace ListCustomIEnumerator
{
    class Program
    {
        static void Main(string[] args)
        {
            ListOfClients listOfClients = new ListOfClients();

            listOfClients.Add(new Client("Joaquim", true));
            listOfClients.Add(new Client("Maria", false));

            foreach(Client c in listOfClients)
            {
                Console.WriteLine(c.ToString());
            }
        }
    }
}
