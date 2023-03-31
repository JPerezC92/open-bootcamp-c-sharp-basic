namespace ConsoleApp.Sesion4
{
    public class Exercise2
    {
        enum CounState
        {
            Idle,
            Running,
            Finished
        }
        public static void Execute()
        {

            CounState state = CounState.Idle;
            string? input;
            int n = 0;

            do
            {
                if (state == CounState.Idle)
                {
                    Console.WriteLine("Enter a number: ");

                    bool? result = int.TryParse(Console.ReadLine(), out n);

                    if (result == false || n == 0)
                    {
                        continue;
                    }

                    state = CounState.Running;
                    continue;
                }


                if (state == CounState.Running)
                {
                    Console.WriteLine($"Counting: {n}");

                    n = n < 0 ? n + 1 : n - 1;

                    if (n == 0)
                    {
                        state = CounState.Finished;
                    }
                }

                if (state == CounState.Finished)
                {
                    Console.WriteLine($"Counting: 0");
                    break;
                }

            } while (n == 0 || state == CounState.Running);

        }
    }
}
