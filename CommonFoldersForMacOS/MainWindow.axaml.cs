using System;
using System.Diagnostics;
using Avalonia.Controls;
using Avalonia.Input;

namespace CommonFoldersForMacOS;

public partial class MainWindow : Window
{
    private readonly string user_dir = "/Users/" + Environment.UserName;

    public MainWindow()
    {
        InitializeComponent();
        Loaded += (_,_) =>
        {
            var lang = Language.Get();
            Title = lang[1];
            home.Content = lang[1];
            pic.Content = lang[2];
            doc.Content = lang[3];
            dl.Content = lang[4];
            music.Content = lang[5];
            movie.Content = lang[6];
            desktop.Content = lang[7];
            app.Content = lang[8];
        };
    }

    private void OpenFolder(object sender, TappedEventArgs e)
    {
        Process.Start("open", user_dir + (sender as Button)!.Tag);
    }
}