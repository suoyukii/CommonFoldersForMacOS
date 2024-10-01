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
    }

    private void OpenFolder(object sender, TappedEventArgs e)
    {
        Process.Start("open", user_dir + (sender as Button)!.Tag);
    }
}