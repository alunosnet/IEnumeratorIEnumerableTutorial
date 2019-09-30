using System;
using System.Collections.Generic;
using System.Text;

namespace ListCustomIEnumerator
{
    class Client
    {
        string name;
        bool active;

        public Client(string name,bool active)
        {
            this.name = name;
            this.active = active;
        }

        public bool GetActive() => this.active;

        public override string ToString()
        {
            return name + " "+active;
        }
    }
}
