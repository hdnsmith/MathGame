﻿namespace MathGame;

class Program
{
    static void Main()
    {
        Menu menu = new Menu();
        
        while (menu.MenuSelection != 6)
        {
            
            Menu.DisplayMenu();
            menu.GetMenuSelection();
            menu.PlaySelection();
        }
    }
}