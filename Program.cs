using MorseCode;

namespace Blank
{

    class Program
    {

        public static void Main(string[] args)
        {
            Morse morse = new Morse();

            bool flag = true;

            while (flag)
            {

                Console.WriteLine("1 - decode, 2 - encode");

                string? choice = Console.ReadLine();

                string? choice2;

                if (choice == "1")
                {
                    try
                    {
                        bool correctAnswer = false;
                        Console.WriteLine("Type a message to decode: ");
                        string? code = Console.ReadLine();
                        if (code != null)
                            morse.Decode(code);
                        Console.WriteLine("Wanna continue? (Y/N): ");
                        correctAnswer = false;

                        while (!correctAnswer)
                        {
                            choice2 = Console.ReadLine();
                            if (choice2.ToUpper().Equals("N"))
                            {
                                flag = false;
                                correctAnswer = true;
                            }
                            else if (choice2.ToUpper().Equals("Y"))
                            {
                                correctAnswer = true;
                            }
                            else
                            {
                                Console.WriteLine("Please, provide correct answer (Y/N): ");
                            }

                        }
                    }
                    catch (ArgumentNullException ex)
                    {
                        Console.WriteLine($"Error: {ex.Message}");
                    }
                    catch (ArgumentException ex)
                    {
                        Console.WriteLine($"Error: {ex.Message}");
                    }

                }

                else if (choice == "2")
                {
                    try
                    {
                        bool correctAnswer = false;
                        Console.WriteLine("Type a message to encode: ");
                        string? message = Console.ReadLine();
                        if (message != null)
                            Console.WriteLine(morse.Encode(message));
                        Console.WriteLine("Wanna continue? (Y/N): ");
                        correctAnswer = false;

                        while (!correctAnswer)
                        {
                            choice2 = Console.ReadLine();
                            if (choice2.ToUpper().Equals("N"))
                            {
                                flag = false;
                                correctAnswer = true;
                            }
                            else if (choice2.ToUpper().Equals("Y"))
                            {
                                correctAnswer = true;
                            }
                            else
                            {
                                Console.WriteLine("Please, provide correct answer (Y/N): ");
                            }

                        }

                    }
                    catch (ArgumentNullException ex)
                    {
                        Console.WriteLine($"Error: {ex.Message}");
                    }
                    catch (ArgumentException ex)
                    {
                        Console.WriteLine($"Error: {ex.Message}");
                    }
                }


            }


        }

    }

}