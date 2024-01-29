namespace Test.Week1.SingleResponsibility.Good
{
    public class TextPrinter
    {
        TextManipulator textManipulator;

        public TextPrinter(TextManipulator textManipulator)
        {
            this.textManipulator = textManipulator;
        }

        public void printText()
        {
            Console.WriteLine(textManipulator.getText());
        }

        public void printOutEachWordOfText()
        {
            //...
        }

        public void printRangeOfCharacters(int startingIndex, int endIndex)
        {
            //..
        }
    }
}
