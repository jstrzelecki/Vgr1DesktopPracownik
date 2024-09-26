using System;
using System.Collections.Generic;
using Avalonia.Controls;
using Avalonia.Interactivity;

namespace Vgr1Inf040123;

public partial class MainWindow : Window
{
    private readonly string smallChars = "qwertyuiopasdfghjklzxcvbnm";
    private readonly string capitalChars = "QWERTYUIOPASDFGHJKLZXCVBNM";
    private readonly string numbers = "0123456789";
    private readonly string specialCharacters = "!@#$%^&*()_+{}[]<>|";
    
    public MainWindow()
    {
        InitializeComponent();
    }

    private void GeneratePassword(object? sender, RoutedEventArgs e)
    {
        int charNum;
        try
        {
            charNum = int.Parse(CharsNum.Text!.ToString());
        }
        catch (Exception)
        {
            charNum = 0;
        }
        
        bool isBothLetters = BothLetters.IsChecked ?? false;
        bool isNumbers = Numbers.IsChecked ?? false;
        bool isSpecialChars = SpecialChars.IsChecked ?? false;
        
        
        
        
        Random rnd = new();
        
        // rnd
        // if (isBothLetters)

        
    }

    private void ApplyPassword(object? sender, RoutedEventArgs e)
    {
        // throw new System.NotImplementedException();
    }
}