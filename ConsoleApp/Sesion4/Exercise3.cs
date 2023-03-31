namespace ConsoleApp.Sesion4
{
    public class Exercise3
    {
        public static void Execute()
        {
            int width = 0;
            int height = 0;
            int columns = 0;
            bool? fill = null;

            while (width == 0 || height == 0 || columns == 0 || fill == null)
            {
                if (width == 0)
                {
                    Console.WriteLine("Enter a width value");
                    bool widthParseResult = int.TryParse(Console.ReadLine(), out width);
                    if (widthParseResult == false)
                    {
                        continue;
                    }
                }

                if (height == 0)
                {
                    Console.WriteLine("Enter a height value");
                    bool heightParseResult = int.TryParse(Console.ReadLine(), out height);
                    if (heightParseResult == false)
                    {
                        continue;
                    }
                }

                if (columns == 0)
                {
                    Console.WriteLine($"Enter the numbers of columns(default:1):");
                    bool columnsParseResult = int.TryParse(Console.ReadLine(), out columns);
                    if (columnsParseResult == false)
                    {
                        columns = 1;
                        continue;
                    }
                }

                if (fill == null)
                {
                    Console.WriteLine("Do you wanna fill the form (true/false)");
                    bool _fill = false;
                    bool fillParseResult = bool.TryParse(Console.ReadLine(), out _fill);
                    if (fillParseResult == false)
                    {
                        continue;
                    }
                    fill = _fill;
                }
            }

            string shape = "";

            for (int i = 0; i < height; i++)
            {
                bool isFirst = i == 0;
                bool isLast = i == height - 1;
                string tempStr = "";

                for (int j = 0; j < width; j++)
                {
                    bool isFirstChar = j == 0;
                    bool isLastChar = j == width - 1;

                    if (isFirst || isLast || (bool)fill)
                    {
                        tempStr += "*";
                        continue;
                    }
                    tempStr += isFirstChar || isLastChar ? "*" : " ";
                    continue;
                }

                shape += $"{tempStr}\n";
            }

            for (int i = 0; i < columns; i++)
            {
                Console.WriteLine(shape);
            }
        }
    }
}