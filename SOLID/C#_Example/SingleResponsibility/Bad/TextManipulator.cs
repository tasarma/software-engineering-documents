namespace Test.Week1.SingleResponsibility.Bad
{
    public class TextManipulator
    {
        private string text;

        public TextManipulator(string text)
        {
            this.text = text;
        }

        public string getText()
        {
            return text;
        }

        public void appendText(string newText)
        {
            text = string.Concat(text, newText);
        }

        public string findWordAndReplace(string word, string replacementWord)
        {
            if (text.Contains(word))
            {
                text = text.Replace(word, replacementWord);
            }
            return text;
        }

        public string findWordAndDelete(string word)
        {
            if (text.Contains(word))
            {
                text = text.Replace(word, "");
            }
            return text;
        }

        public void printText()
        {
            Console.WriteLine(getText());
        }
    }
}
