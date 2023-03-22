namespace Bridges.Logic
{
    public class MyString
    {
        private readonly string _text;

        public MyString(string text)
        {
            _text = text;
        }

        public string ReadBridge()
        {
            string myBridge = Console.ReadLine();
            return myBridge;
        }

        public bool ValidateBases()
        {
            string aux = _text;
            if (aux[0] != '*' || aux[aux.Length-1] != '*')
            {
                return false;
            }
            for (int i = 1; i < aux.Length-2; i++)
            {
                if (aux[i] == '*')
                {
                    return false;
                }
            }
            return true;
        }

        public bool ValidateComponents()
        {
            string aux = _text;
            for (int i = 0; i < aux.Length; i++)
            {
                if (aux[i] != '*' && aux[i] != '=' && aux[i] != '+')
                {
                    return false;
                }
            }
            return true;
        }

        public bool IsSimetric()
        {
            string aux = _text;
            int n = aux.Length / 2;
            for (int i = 0; i < n; i++)
            {
                if (aux[i] != aux[aux.Length - i - 1])
                {
                    return false;
                }
            }
            return true;
        }

        public bool ValidatePlatformsAndReinforcements()
        {
            string aux = _text;
            int n = aux.Length / 2;
            int plataformsCount = 0;
            for (int i = 1; i < aux.Length-2; i++)
            {
                if (aux[i] == '=')
                {
                    plataformsCount++;
                }
                if (aux[i] == '+' && plataformsCount < 3)
                {
                    plataformsCount = 0;
                }
                if (aux[i] == '+' && plataformsCount == 3)
                {
                    if (i != (n + 2))
                    {
                        return false;
                    } 
                    else
                    {
                        plataformsCount = 0;
                    }
                }
                if (plataformsCount > 3)
                {
                    return false;
                }
            }
            return true;
        }

        public string? PrintString(MyString myBridge)
        {
            string output = string.Empty;
            for (int i = 0; i < _text.Length; i++)
            {
                output += $"{_text[i]}";
            }
            return output;
        }

    }
}