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

namespace Test
{
    /// <summary>
    /// MainWindow.xaml에 대한 상호 작용 논리
    /// </summary>
    public partial class MainWindow : Window
    {
        Run runButton1;
        Run runButton2;

        public MainWindow()
        {
            InitializeComponent();
            Title = "ButtonTest1";

            Button btn = new Button();
            btn.HorizontalAlignment = HorizontalAlignment.Center;
            btn.VerticalAlignment = VerticalAlignment.Center;
            btn.MouseEnter += ButtonOnMouseEnter;
            btn.MouseLeave += ButtonOnMouseLeave;
            Content = btn;
            // Create the TextBlock and set as button content.
            TextBlock txtblk = new TextBlock();
            txtblk.FontSize = 24;
            txtblk.TextAlignment = TextAlignment.Center;
            btn.Content = txtblk;
            // 서식화된 텍스트 출력
            txtblk.Inlines.Add(new Italic(new Run("Click")));
            txtblk.Inlines.Add(" the ");
            txtblk.Inlines.Add(runButton1 = new Run("button"));
            txtblk.Inlines.Add(new LineBreak());
            txtblk.Inlines.Add("to launch the ");
            txtblk.Inlines.Add(new Bold(runButton2 = new Run("rocket")));
        }
        //마우스가 버튼 안으로 들어가면 Run(runButton)객체의 Foreground프로퍼티가 빨강으로 된다.
 void ButtonOnMouseEnter(object sender, MouseEventArgs args)
        {
            runButton1.Foreground = Brushes.Red;
            runButton2.Foreground = Brushes.Blue;
        }
        //마우스가 빠져 나가면 SystemColors.ControlTestBrush로 부터 기본텍스트색을 얻어와 설정한다.
 void ButtonOnMouseLeave(object sender, MouseEventArgs args)
        {
            runButton1.Foreground = SystemColors.ControlTextBrush;
            runButton2.Foreground = SystemColors.ControlTextBrush;
        }

    }
}

