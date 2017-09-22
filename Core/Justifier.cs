using System;

namespace TextJustifier.Core
{
    public class Justifier
    {
        /// <summary>
        /// Возвращает отформатированный текст
        /// </summary>
        /// <param name="entryText">Исходный текст</param>
        /// <param name="lineLength">Длина строки</param>
        /// <returns>Отформатированный текст</returns>
        public string Justify(string entryText, int lineLength)
        {
            return Justify(entryText.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries), lineLength);
        }

        private string Justify(string[] words, int lineLength)
        {
            throw new NotImplementedException();
        }
    }
}