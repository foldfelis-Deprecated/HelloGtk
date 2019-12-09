using System;
using Gtk;

namespace HelloGtk
{
    internal static partial class MainForm
    {
        private static void Initial()
        {
            InitialForm();
            InitialComponents();
            _win.ShowAll();
        }
        
        static void Main(string[] args)
        {
            Application.Init();
            Initial();
            Application.Run();
        }
    }
}