using System;

namespace _2048
{
    class Program
    {
        static void Main(string[] args)
        {
            Manager manager = new Manager();
            Ui ui = new Ui();
            
            manager.CreateBoxes();    
            manager.AddRandom();      
            manager.AddRandom();      
            
            ui.PrintBoard(manager.PrintBoard(), manager.Score);

            bool loop = true;

            do
            {
                manager.Move(ui.Direction());
                ui.PrintBoard(manager.PrintBoard(), manager.Score);

                if (manager.BoardFull() == true && manager.NoMoves() == true)
                {
                    loop = false;
                }                
            } while (loop);

            ui.PrintBoard(manager.PrintBoard(), manager.Score);
            ui.GameOver();
        }
    }
}
