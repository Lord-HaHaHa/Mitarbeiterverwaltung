﻿using System;
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

namespace Mitarbeiterverwaltung
{
    /// <summary>
    /// Interaktionslogik für MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            CMitarbeiter mitarbeiter = new CMitarbeiter();

            CAngestellter angestellter = new CAngestellter("Angestellter", "Test", 400.0);
            CAngestellter angestellter2 = new CAngestellter();

            CArbeiter arbeiter = new CArbeiter("Arbeiter", "Test", 3, 20.0);
            CArbeiter arbeiter2 = new CArbeiter();
        }
    }
}
