using System;

namespace DE_OPDRACHT
{
    class Program
    {
        static void Main(string[] args)
        {
			string[] options = { "1", "2", "3" };
			int[] Settings = { 1, 6, 2, 1 };
			string[] forLoopSettings = { "Minimum dice value", "Maximum dice value", "Players", "Rounds" };

			Random rnd = new Random();

			int[] PlayerScore;

			menu();

			void menu()
			{
				Console.ForegroundColor = ConsoleColor.Cyan;
				Console.WriteLine("Have Fun Human, this is maybe the last time you play OwO");
				Console.WriteLine("choose a optoin or die ÙwÚ:");
				Console.WriteLine("1] Start the game!");
				Console.WriteLine("2] Read the rules O_o");
				Console.WriteLine("3] Close the game and die :)");
				Console.WriteLine("");

				string option = Console.ReadLine();
				if (option == options[0])
				{
					startGame();
				}
				else if (option == options[1])
				{
					rules();
				}
				else if (option == options[2])
				{
					Environment.Exit(0);
				}
				else
				{
					Error(1);
				}
				Console.ResetColor();
			}

			void startGame()
			{
				Console.WriteLine("How many humans? -3-");
				string answer = Console.ReadLine();
				int changedValue;

				if (Int32.TryParse(answer, out changedValue))
				{
					if (changedValue > 1 && changedValue <= 4)
					{
						Settings[2] = changedValue;
					}
					else
					{
						Error(3);
					}
				}
				else
				{
					Error(3);
				}

				PlayerScore = new int[Settings[2]];
				for (int i = 0; i < Settings[3]; i++)
				{
					Console.Clear();
					Console.WriteLine("have fun human! OwO");
					Console.Clear();
					for (int x = 0; x != Settings[2]; x++)
					{
						PlayerScore[x] = rnd.Next(Settings[0], Settings[1]) + rnd.Next(Settings[0], Settings[1]);
						Console.WriteLine($"Player {x + 1} scored: {PlayerScore[x]} Points");
					}

					Console.WriteLine();
					Console.WriteLine();
					if (Settings[2] == 2)
					{
						if (PlayerScore[0] > PlayerScore[1])
						{
							won("1");
						}
						else if (PlayerScore[0] < PlayerScore[1])
						{
							won("2");
						}
						else { tie(); }
					}
					else if (Settings[2] == 3)
					{
						if (PlayerScore[0] > PlayerScore[1] && PlayerScore[0] > PlayerScore[2])
						{
							won("1");
						}
						else if (PlayerScore[1] > PlayerScore[0] && PlayerScore[1] > PlayerScore[2])
						{
							won("2");
						}
						else if (PlayerScore[2] > PlayerScore[0] && PlayerScore[2] > PlayerScore[1])
						{
							won("3");
						}
						else { tie(); }
					}
					else if (Settings[2] == 4)
					{
						if (PlayerScore[0] > PlayerScore[1] && PlayerScore[0] > PlayerScore[2] && PlayerScore[0] > PlayerScore[3])
						{
							won("1");
						}
						else if (PlayerScore[1] > PlayerScore[0] && PlayerScore[1] > PlayerScore[2] && PlayerScore[1] > PlayerScore[3])
						{
							won("2");
						}
						else if (PlayerScore[2] > PlayerScore[0] && PlayerScore[2] > PlayerScore[1] && PlayerScore[2] > PlayerScore[3])
						{
							won("3");
						}
						else if (PlayerScore[3] > PlayerScore[0] && PlayerScore[3] > PlayerScore[1] && PlayerScore[3] > PlayerScore[2])
						{
							won("4");
						}
						else { tie(); }
					}

					Console.WriteLine("Press enter to continue");
					Console.ReadLine();
					Console.Clear();
					menu();
					void tie()
					{
						Console.ForegroundColor = ConsoleColor.DarkGreen;
						Console.WriteLine($"it is a tie human UwU");
						Console.ResetColor();
					}
					void won(string num)
					{
						Console.ForegroundColor = ConsoleColor.Green;
						Console.WriteLine($"player {num} won! OwO");
						Console.ResetColor();
					}
				}

			}

			void rules()
			{
				Console.ForegroundColor = ConsoleColor.DarkMagenta;
				Console.Clear();
				Console.WriteLine("Hi, All you need to do is to choose how many players you play!");
				Console.WriteLine("you need min. 2 players max. 4 :)");
				Console.WriteLine("One try per humon and the Highest Roll wins -3-");
				Console.WriteLine("I wish you guys good luk you wil need it! TwT");
				Console.WriteLine("Have Fun! OwO");
				Console.WriteLine("dit you really read the rules O_o If yes press Enter!");
				Console.ReadLine();
				Console.Clear();
				menu();
				Console.ResetColor();
			}

			void Error(int ErrorValue)
			{
				if (ErrorValue == 1)
				{
					Console.ForegroundColor = ConsoleColor.Red;
					Console.Clear();
					Console.WriteLine("Give a valid option! or do you realy wanna die that badly O_o \n");
					Console.ResetColor();
					menu();
				}
				else if (ErrorValue == 2)
				{
					Console.Clear();
					Console.WriteLine("Give a valid response! \n");
				}
				else if (ErrorValue == 3)
				{
					Console.ForegroundColor = ConsoleColor.Blue;
					Console.Clear();
					Console.WriteLine("You have or to many friends! or you need friends O_o \n");
					Console.ResetColor();
					startGame();
				}
			}
		}
    }
}
