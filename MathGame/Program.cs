namespace MathGame;

internal static class Program
{
    private static void Main()
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