using System.Linq;
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
        
        // Screen 
        private static readonly Entry Monitor = new Entry();

        private static void InitialComponents()
        {
            // Menu
            var menuBar = new MenuBar();
            var fileMenu = new Menu();
            var file = new MenuItem("File") {Submenu = fileMenu};
            menuBar.Append(file);
            
            // Buttons
            var clear = new Button("Clear");
            clear.Clicked += Clear_Clicked;
            var back = new Button("Backspace");
            back.Clicked += Backspace_Clicked;
            var close = new Button("Close");
            close.Clicked += Close_Clicked;

            var seven = new Button("7");
            seven.Clicked += Seven_Clicked;
            var eight = new Button("8");
            eight.Clicked += Eight_Clicked;
            var nine = new Button("9");
            nine.Clicked += Nine_Clicked;
            var division = new Button("/");
            division.Clicked += Division_Clicked;

            var fore = new Button("4");
            fore.Clicked += Fore_Clicked;
            var five = new Button("5");
            five.Clicked += Five_Clicked;
            var six = new Button("6");
            six.Clicked += Six_Clicked;
            var multiplied = new Button("*");
            multiplied.Clicked += Multiplied_Clicked;

            var one = new Button("1");
            one.Clicked += One_Clicked;
            var two = new Button("2");
            two.Clicked += Two_Clicked;
            var three = new Button("3");
            three.Clicked += Three_Clicked;
            var minus = new Button("-");
            minus.Clicked += Minus_Clicked;

            var zero = new Button("0");
            zero.Clicked += Zero_Clicked;
            var point = new Button(".");
            point.Clicked += Point_Clicked;
            var eq = new Button("=");
            eq.Clicked += Eq_Clicked;
            var plus = new Button("+");
            plus.Clicked += Plus_Clicked;

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
            vBox.PackStart(Monitor, false, false, 0);
            
            // Append Buttons from bottom
            vBox.PackEnd(buttons, true, true, 0);
        
            // Append the Top Layout to the window
            _win.Add(vBox);
        }
    }
}