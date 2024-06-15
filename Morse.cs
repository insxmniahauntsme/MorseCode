namespace MorseCode
{

    class Morse
    {

        static readonly Dictionary<string, char> _morseDict = new Dictionary<string, char>
        {
            {".-", 'A'}, {"-...", 'B'}, {"-.-.", 'C'}, {"-..", 'D'}, {".", 'E'},
            {"..-.", 'F'}, {"--.", 'G'}, {"....", 'H'}, {"..", 'I'}, {".---", 'J'},
            {"-.-", 'K'}, {".-..", 'L'}, {"--", 'M'}, {"-.", 'N'}, {"---", 'O'},
            {".--.", 'P'}, {"--.-", 'Q'}, {".-.", 'R'}, {"...", 'S'}, {"-", 'T'},
            {"..-", 'U'}, {"...-", 'V'}, {".--", 'W'}, {"-..-", 'X'}, {"-.--", 'Y'},
            {"--..", 'Z'}, {"-----", '0'}, {".----", '1'}, {"..---", '2'}, {"...--", '3'},
            {"....-", '4'}, {".....", '5'}, {"-....", '6'}, {"--...", '7'}, {"---..", '8'},
            {"----.", '9'}
        };

        public void Decode(string morseCode)
        {
            //розбиття коду морзе на слова
            string[] encodedWords = morseCode.Split("   ");
            List<string> decodedWords = new List<string>();

            //перебір слів
            foreach (string word in encodedWords)
            {

                string[] characters = word.Split(" ");  //розбиття слів на літери
                string decodedWord = "";

                //перебір літер
                foreach (string character in characters)
                {
                    if (_morseDict.ContainsKey(character))
                        decodedWord += _morseDict[character];

                }

                decodedWords.Add(decodedWord);

            }

            string decodedSentence = string.Join(" ", decodedWords);
            Console.WriteLine(decodedSentence);
        }

        public string Encode(string message)
        {
            string[] decodedWords = message.ToUpper().Split(" ");
            List<string> encodedLetters = new List<string>();
            List<string> encodedWords = new List<string>();
            string encodedMessage = "";

            //перебір токенів, витягнутих з повідомлення
            foreach (string word in decodedWords)
            {
                //розбиття слів на літери
                char[] letters = word.ToCharArray();

                //перебір літер
                foreach (char letter in letters)
                {
                    //знаходження відповідників в KeyValuePair та їх запис у список закодованих літер
                    foreach (KeyValuePair<string, char> kvp in _morseDict)
                    {
                        if (letter == kvp.Value)
                        {
                            encodedLetters.Add(kvp.Key);
                        }

                    }

                }

                encodedLetters.Add(" ");

                encodedMessage = string.Join(" ", encodedLetters);

            }

            return encodedMessage;
        }
    }
}