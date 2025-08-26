
namespace BruhTerminal.API
{
    public class BTAContent
    {
        public string Text { get; set; }
        public uint Split { get; set; }

        public BTAContent(string text, uint split)
        {
            Text = text;
            Split = split;
        }
    }
}
