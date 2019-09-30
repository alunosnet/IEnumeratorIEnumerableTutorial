using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace ListCustomIEnumerator
{
    class ListOfClientsEnum : IEnumerator
    {
        List<Client> TheList;

        int position = -1;

        public ListOfClientsEnum(List<Client> theList)
        {
            TheList = theList;
            this.position = -1;
        }

        object IEnumerator.Current
        {
            get
            {
                try
                {
                    return TheList[position];
                }
                catch
                {
                    throw new Exception("Error in the position");
                }
            }
        }

        public bool MoveNext()
        {
            while (true) {
                position++;
                if (position >= TheList.Count-1)
                    return false;
                if (TheList[position].GetActive())
                    break;
            }
            return (position < TheList.Count);
        }
        
        public void Reset()
        {
            position = -1;
        }
    }
}
