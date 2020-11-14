using System.Windows.Forms;

namespace GameUI
{
    public class Program
    {
        public static void Main()
        {
            Application.EnableVisualStyles();
            UI ui = new UI();
            ui.Run();
        }
    }
}
