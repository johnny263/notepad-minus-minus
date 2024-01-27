﻿using System;
using System.Windows.Forms;
using Dark.Net;
using NotePadMinusMinus;
using static System.Windows.Forms.DataFormats;

namespace darknet_demo_winforms;

internal static class Program
{

    public static readonly ThemeOptions ThemeOptions = new() {};

    [STAThread]
    private static void Main()
    {
        Application.EnableVisualStyles();
        Application.SetCompatibleTextRenderingDefault(false);

        IDarkNet darkNet = DarkNet.Instance;
        Theme processTheme = Theme.Auto;
        darkNet.SetCurrentProcessTheme(processTheme, ThemeOptions);
        Console.WriteLine($"Process theme is {processTheme}");

        // Console.WriteLine($"Window theme is {windowTheme}");

        Console.WriteLine($"System theme is {(darkNet.UserDefaultAppThemeIsDark ? "Dark" : "Light")}");
        Console.WriteLine($"Taskbar theme is {(darkNet.UserTaskbarThemeIsDark ? "Dark" : "Light")}");

        darkNet.UserDefaultAppThemeIsDarkChanged += (_, isSystemDarkTheme) => Console.WriteLine($"System theme is {(isSystemDarkTheme ? "Dark" : "Light")}");
        darkNet.UserTaskbarThemeIsDarkChanged += (_, isTaskbarDarkTheme) => Console.WriteLine($"Taskbar theme is {(isTaskbarDarkTheme ? "Dark" : "Light")}");

        Application.Run(new MainFormContainer());
    }

}