

        try
        {
            Run();
        }
        catch (Exception ex)
        {
            Console.WriteLine("Sorry " + ex.Message);
        }

        Console.ReadKey();

        void Run()
        {
            try
            {
                Console.WriteLine("Enter a number: ");
                int word = int.Parse(Console.ReadLine());
            }
            catch (Exception ex)
            {
                Console.WriteLine("With message: ");
                throw;
            }

        }
