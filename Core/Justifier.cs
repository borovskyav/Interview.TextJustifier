using System;

namespace TextJustifier.Core
{
    public class Justifier
    {
        public string Justify(string entryText, int stringLength)
        {
            return Justify(entryText.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries), stringLength);
        }

        private string Justify(string[] words, int stringLength)
        {
            throw new NotImplementedException();
        }
    }
}