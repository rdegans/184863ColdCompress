using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace _184863ColdCompress
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            string finalOutput = "";
            System.IO.StreamReader sr = new System.IO.StreamReader("input.txt", true);
            while (!sr.EndOfStream)
            {
                string currentLine = sr.ReadLine();
                string findChar = currentLine.Substring(0, 1);
                int currentIndex = 0;
                while (currentLine.Length > currentIndex)
                {
                    finalOutput += (currentLine.LastIndexOf(findChar) - currentLine.IndexOf(findChar) + 1).ToString() + " " + findChar + " ";
                    if (currentLine.LastIndexOf(findChar) + 1 < currentLine.Length)
                    {
                        findChar = currentLine.Substring(currentLine.LastIndexOf(findChar) + 1, 1);
                        currentIndex = currentLine.IndexOf(findChar);
                    }
                    else
                    {
                        currentIndex = currentLine.Length;
                    }
                    
                }
                finalOutput += Environment.NewLine; 
            }
            MessageBox.Show(finalOutput);
        }
    }
}

