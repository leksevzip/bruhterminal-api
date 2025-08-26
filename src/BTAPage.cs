using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BruhTerminal.API
{
    public class BTAPage
    {
        public string Header { get; set; }
        public BTAContent Content { get; set; }
        public BTAButton[] Buttons { get; set; }

        public BTAPage(string header, BTAContent content, BTAButton[] buttons)
        {
            Header = header;
            Content = content;
            Buttons = buttons;

            if (buttons.GroupBy(b => b.ID).Any(g => g.Count() > 1))
            {
                throw new ArgumentException($"Duplicate button IDs are not allowed");
            }
        }

        public void Run()
        {   
            // Render header
            Console.WriteLine(Header);
            Console.WriteLine();

            // Render content
            string[] contents = Content.Text.Split();
            int Line = 1;
            for (int i = 0; i < contents.Length; i++)
            {
                if(Line > Content.Split)
                {
                    Console.Write("\n");
                    Line = 1;
                }
                else
                {
                    Line++;
                }

                Console.Write($"{contents[i]} ");
            }
            Console.WriteLine("\n");

            // Render buttons
            foreach(BTAButton button in Buttons)
            {
                Console.WriteLine($"[{button.ID}] {button.Label}");
            }

            // Handle input (obviosly)
            Console.WriteLine();
            HandleInput();
        }

        private void HandleInput()
        {
            while (true)
            {
                Console.Write("Select an option: ");
                string input = Console.ReadLine() ?? "";

                if (int.TryParse(input, out int id))
                {
                    BTAButton? button = Buttons.FirstOrDefault(b => b.ID == id);
                    if (button != null)
                    {
                        button.Click();
                        return;
                    }
                }

                Console.Clear();
                Console.WriteLine("Invalid input. Please try again.\n");
                Run();
            }
        }

    }
}
