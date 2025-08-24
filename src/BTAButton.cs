using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BruhTerminal.API
{
    public class BTAButton
    {
        public int ID;
        public string Label;
        public event Action? Clicked;

        public BTAButton(int id, string label)
        {
            ID = id;
            Label = label;
        }

        public void Click()
        {
            Clicked?.Invoke();
        }
    }
}
