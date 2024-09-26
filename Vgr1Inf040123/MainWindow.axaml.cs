using System;
using System.Collections.Generic;
using System.Linq;
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
            charNum = int.Parse(NumericTypeTextBox.Text!.ToString());
        }
        catch (Exception)
        {
            charNum = 0;
        }
        
        bool isBothLetters = BothLetters.IsChecked ?? false;
        bool isNumbers = Numbers.IsChecked ?? false;
        bool isSpecialChars = SpecialChars.IsChecked ?? false;
        
        string password = "";
        
        Random rnd = new();
        
        if (isBothLetters && charNum>0)
        {
            password += capitalChars[rnd.Next(capitalChars.Length)];
            charNum--;
        }

        if (isNumbers && charNum > 0)
        {
            password += numbers[rnd.Next(numbers.Length)];
            charNum--;
        }

        if (isSpecialChars && charNum > 0)
        {
            password += specialCharacters[rnd.Next(specialCharacters.Length)];
            charNum--;
        }

        while (charNum>0)
        {
            password += smallChars[rnd.Next(smallChars.Length)];
            charNum--;
        }

        Console.WriteLine(password);
    }

    private void ApplyPassword(object? sender, RoutedEventArgs e)
    {
        // throw new System.NotImplementedException();
    }

    private void NumericTypeTextBox_OnTextChanged(object? sender, TextChangedEventArgs e)
    {
        if (sender is TextBox textBox)
        {
            var newString = new string( textBox.Text?.Where(char.IsDigit).ToArray());
            if (newString != textBox.Text)
            {
                textBox.Text = newString;
            }
        }
    }
}