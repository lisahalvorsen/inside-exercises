namespace Inside;

public class Exercise321A : IExercise
{
    public void Run()
    {
        var charCounter = new CharCounter();
        charCounter.AddNewText();
    }

    private class CharCounter
    {
        private static int _range = 250;
        private int[] _counts = new int[_range];
        private string _text = "something";
        
        internal void AddNewText()
        {
            while (!string.IsNullOrWhiteSpace(_text))
            {
                _text = Console.ReadLine();
                foreach (var character in _text ?? string.Empty)
                {
                    _counts[(int)character]++;
                }

                for (var i = 0; i < _range; i++)
                {
                    if (_counts[i] > 0)
                    {
                        var character = (char)i;
                        Console.WriteLine(character + " - " + _counts[i]);
                    }
                }
            }
        }
    }
}