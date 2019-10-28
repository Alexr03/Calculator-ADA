using System;

namespace FirstAdaTask
{
    public class Menu
    {
        public enum MenuOptions
        {
            Calculator = 1,
            DebugPrintDb,
            Exit
        }
        
        public void InitiateMenu()
        {
            while (true)
            {
                ShowMenuOptions();
                if(Enum.TryParse(Console.ReadLine(), out MenuOptions menuOptions))
                {
                    ExecuteMenuOption(menuOptions);
                }
            }
        }

        public void ShowMenuOptions()
        {
            Console.WriteLine("----------------------------------------------------------------------------------");
            int id = 1;
            foreach (var v in Enum.GetNames(typeof(MenuOptions)))
            {
                Console.WriteLine($"{id}) {v}");
                id++;
            }
            Console.WriteLine("----------------------------------------------------------------------------------");
        }

        private void ExecuteMenuOption(MenuOptions option)
        {
            switch (option)
            {
                case MenuOptions.Calculator:
                {
                    Calculator calculator = new Calculator();
                    Console.Write("Please enter an equation to solve: ");
                    Console.WriteLine("The answer is: " + calculator.ComputeMath(Console.ReadLine()));
                    break;
                }
                case MenuOptions.DebugPrintDb:
                    Console.WriteLine(Program.GlobalDb.ToString());
                    break;
                case MenuOptions.Exit:
                {
                    Console.WriteLine("Quitting...");
                    Environment.Exit(0);
                    return;
                }
            }
        }
    }
}