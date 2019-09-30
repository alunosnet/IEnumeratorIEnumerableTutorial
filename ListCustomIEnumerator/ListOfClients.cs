using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace ListCustomIEnumerator
{
    class ListOfClients : IEnumerable
    {
        List<Client> TheList = new List<Client>();


        public void Add(Client c)
        {
            TheList.Add(c);
        }

        public IEnumerator GetEnumerator()
        {
            return new ListOfClientsEnum(TheList);
        }
    }
}
