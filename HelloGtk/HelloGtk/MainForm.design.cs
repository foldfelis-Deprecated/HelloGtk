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
                Resizable = false,
            };
            
            // Events
            _win.Destroyed += (sender, args) => { Application.Quit(); };
        }

        private static void InitialComponents()
        {
            // Menu
            var menuBar = new MenuBar();
            var fileMenu = new Menu();
            var file = new MenuItem("File") {Submenu = fileMenu};
            menuBar.Append(file);
            
            // Buttons
            var clear = new Button("Clear");
            var back = new Button("Backspace");
            var close = new Button("Close");
            
            var seven = new Button("7");
            var eight = new Button("8");
            var nine = new Button("9");
            var division = new Button("/");
            
            var fore = new Button("4");
            var five = new Button("5");
            var six = new Button("6");
            var multiplied = new Button("*");
            
            var one = new Button("1");
            var two = new Button("2");
            var three = new Button("3");
            var minus = new Button("-");
            
            var zero = new Button("0");
            var point = new Button(".");
            var eq = new Button("=");
            var plus = new Button("+");
            
            // Screen 
            var screen = new Entry();
            
            // Buttons Layouts
            var buttons = new Grid
            {
                ColumnSpacing = 4,
                RowSpacing = 4,
                ColumnHomogeneous = true,
                RowHomogeneous = true,
            };

            // The following argv is not affective
            // owing to the homogeneous col and row
            const int width = 1;
            const int height = 1;

            // Add Button to buttons
            buttons.Attach(clear, 0 * width, 0 * height, width, height);
            buttons.Attach(back, 1 * width, 0 * height, width, height);
            buttons.Attach(new Label(),2 * width, 0 * height, width, height);
            buttons.Attach(close, 3 * width, 0 * height, width, height);

            buttons.Attach(seven, 0 * width, 1 * height, width, height);
            buttons.Attach(eight, 1 * width, 1 * height, width, height);
            buttons.Attach(nine, 2 * width, 1 * height, width, height);
            buttons.Attach(division, 3 * width, 1 * height, width, height);

            buttons.Attach(fore, 0 * width, 2 * height, width, height);
            buttons.Attach(five, 1 * width, 2 * height, width, height);
            buttons.Attach(six, 2 * width, 2 * height, width, height);
            buttons.Attach(multiplied, 3 * width, 2 * height, width, height);            
            
            buttons.Attach(one, 0 * width, 3 * height, width, height);
            buttons.Attach(two, 1 * width, 3 * height, width, height);
            buttons.Attach(three, 2 * width, 3 * height, width, height);
            buttons.Attach(minus, 3 * width, 3 * height, width, height);
            
            buttons.Attach(zero, 0 * width, 4 * height, width, height);
            buttons.Attach(point, 1 * width, 4 * height, width, height);
            buttons.Attach(eq, 2 * width, 4 * height, width, height);
            buttons.Attach(plus, 3 * width, 4 * height, width, height);

            // Top Layouts
            var vBox = new VBox(false, 2);
            
            // Append MenuBar from top
            vBox.PackStart(menuBar, false, false, 0);
            
            // Append Entry from top
            vBox.PackStart(screen, false, false, 0);
            
            // Append Buttons from bottom
            vBox.PackEnd(buttons, true, true, 0);
        
            // Append the Top Layout to the window
            _win.Add(vBox);
        }
    }

    internal partial class MainForm
    {
        
    }
}