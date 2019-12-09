using Gdk;
using Gtk;
using Window = Gtk.Window;

namespace HelloGtk
{
    internal partial class MainForm
    {
        private static Window _win;
        private static void InitialForm()
        {
            // Attribute
            _win = new Window("Hello Gtk")
            {
                DefaultSize = new Size(400, 300),
                Resizable = true
            };
            
            // Events
            _win.Destroyed += (sender, args) => { Application.Quit(); };
        }

        private static void InitialComponents()
        {
            
        }
    }
}