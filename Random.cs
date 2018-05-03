using System.Reactive.Linq;
using Eto.Forms;
using System;
class Program
{
    static void Main()
    {
        new TextBox().Events().KeyUp
            .Select(k => k.KeyData)
            .Where(k => k == (Keys.Control | Keys.C))
            .Subscribe(k => Console.WriteLine("Control + C Was pressed"));
    }
}