﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace HomeWork
{
    class Program
    {
        [STAThread]
        static void Main(string[] args)
        {
            var str = Clipboard.GetText().Split(',', ';', ':', '!', '?', '.', '\n', '\r', '\t', ' ', '<', '>', ')', '(', '{', '}');
            str.Distinct().Take(1000).OrderBy(x => x, StringComparer.OrdinalIgnoreCase).Where(x => !string.IsNullOrEmpty(x)).ToList().ForEach(Console.WriteLine);
            Console.ReadLine();
        }
        
    }
}
