using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BruhTerminal.API
{
    public class BTAButton
    {
        public int ID { get; set; }
        public string Label { get; set; }
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
