using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Markup;
using System.Windows.Media;
using System.Windows.Threading;

namespace LabPyatnashki
{
    public partial class MainWindow : Window
    {
        private String CheatCode = "ilovepi";
        private DispatcherTimer Timer;
        private bool finished = false, CheatActivated = false;
        private int NumberOfTurns, CurTime = 0, CheatProgress = 0;
        private Random Rand = new Random();
        private int[,] GameTable = new int[6, 6], GameTableCopy = new int[6, 6];
        private int ZeroRow = 4, ZeroCol = 4;
        private TextBox T = new TextBox
        {
            IsReadOnly = true,
            BorderBrush = (SolidColorBrush)new BrushConverter().ConvertFromString("#FFFFFF"),
            Background = (SolidColorBrush)new BrushConverter().ConvertFromString("#FFD1D1D1"),
            Foreground = (SolidColorBrush)new BrushConverter().ConvertFromString("#FFBB3C3C"),
            FontSize = 40,
            Height = 125,
            Width = 125,
            HorizontalContentAlignment = HorizontalAlignment.Center,
            VerticalContentAlignment = VerticalAlignment.Center,
        };
        void InitGame()
        {
            Timer.Stop();
            CheatActivated = false;
            CheatProgress = 0;
            CurTime = 0;
            Time.Content = "0:0";
            finished = false;
            NumberOfTurns = 0;
            Turns.Content = "0";
            GenerateNewGameTable();
            RedrawTable();
        }
        void GenerateNewGameTable()
        {
            for (int i = 1; i <= 4; i++)
                for (int j = 1; j <= 4; j++)
                    GameTable[i, j] = (i - 1) * 4 + j;
            for (int i = 1; i <= 4; i++)
                for (int j = 1; j <= 4; j++)
                {
                    int pos = Rand.Next(1, 16);
                    Swap(ref GameTable[i, j], ref GameTable[pos / 4 + 1, pos % 4 + 1]);
                }
            for (int i = 1; i <= 4; i++)
                for (int j = 1; j <= 4; j++)
                    if (GameTable[i, j] == 16)
                    {
                        ZeroRow = i;
                        ZeroCol = j;
                    }
            for (int i = 1; i <= 4; i++)
                for (int j = 1; j <= 4; j++)
                    GameTableCopy[i, j] = GameTable[i, j];
        }
        void RedrawTable()
        {
            for (int i = 1; i <= 4; i++)
                for (int j = 1; j <= 4; j++)
                {
                    TextBox T1 = XamlReader.Parse(XamlWriter.Save(T)) as TextBox;
                    T1.Text = (GameTable[i, j]).ToString();
                    if (GameTable[i, j] == 16)
                    {
                        T1.Text = "";
                        T1.Background = (SolidColorBrush)new BrushConverter().ConvertFromString("#888888");
                    }
                    Table.Children.Add(T1);
                    Grid.SetRow(T1, i - 1);
                    Grid.SetColumn(T1, j - 1);
                }
        }
        bool Win()
        {
            bool ans = true;
            for (int i = 1; i <= 3; i++)
                for (int j = 1; j <= 4; j++)
                    if (GameTable[i, j] != (i - 1) * 4 + j)
                        ans = false;
            if (!((GameTable[4, 1] == 13 && GameTable[4, 2] == 14 && GameTable[4, 3] == 15) ||
                (GameTable[4, 1] == 13 && GameTable[4, 2] == 15 && GameTable[4, 3] == 14)))
                ans = false;
            return ans;
        }
        void Table_OnPreviewMouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            if (finished)
                return;
            var point = Mouse.GetPosition(Table);
            int row = 1;
            int col = 1;
            double accumulatedHeight = 0.0;
            double accumulatedWidth = 0.0;
            foreach (var rowDefinition in Table.RowDefinitions)
            {
                accumulatedHeight += rowDefinition.ActualHeight;
                if (accumulatedHeight >= point.Y)
                    break;
                row++;
            }
            foreach (var columnDefinition in Table.ColumnDefinitions)
            {
                accumulatedWidth += columnDefinition.ActualWidth;
                if (accumulatedWidth >= point.X)
                    break;
                col++;
            }
            int[][] near = { new int[]{ 1, 0 }, new int[]{ -1, 0 }, new int[]{ 0, 1 }, new int[]{ 0, -1 } };
            foreach(int[] i in near)
            {
                if (row + i[0] == ZeroRow && col + i[1] == ZeroCol)
                    ZeroSwap(row, col);
            }
            if (Win())
            {
                Timer.Stop();
                MessageBoxResult result = MessageBox.Show(Time.Content.ToString(), NumberOfTurns);
                switch (result)
                {
                    case MessageBoxResult.Yes:
                        InitGame();
                        break;
                    case MessageBoxResult.No:
                        Close();
                        break;
                }
            }
        }
        void ZeroSwap(int row, int col)
        {
            TextBox T1 = XamlReader.Parse(XamlWriter.Save(T)) as TextBox,
                    T2 = XamlReader.Parse(XamlWriter.Save(T)) as TextBox;
            T1.Text = "";
            T1.Background = (SolidColorBrush)new BrushConverter().ConvertFromString("#888888");
            T2.Text = GameTable[row, col].ToString();
            Swap(ref GameTable[row, col], ref GameTable[ZeroRow, ZeroCol]);
            Table.Children.Add(T1);
            Grid.SetRow(T1, row - 1);
            Grid.SetColumn(T1, col - 1);
            Table.Children.Add(T2);
            Grid.SetRow(T2, ZeroRow - 1);
            Grid.SetColumn(T2, ZeroCol - 1);
            ZeroRow = row;
            ZeroCol = col;
            NumberOfTurns++;
            Turns.Content = NumberOfTurns.ToString();
            if (!Timer.IsEnabled)
                Timer.Start();
        }
        static void Swap<T>(ref T a, ref T b)
        {
            T c = a;
            a = b;
            b = c;
        }
        private void NewGameButton_PreviewMouseDown(object sender, MouseButtonEventArgs e)
        {
            InitGame();
        }
        private void QuitButton_PreviewMouseDown(object sender, MouseButtonEventArgs e)
        {
            Close();
        }
        private void ResetButton_PreviewMouseDown(object sender, MouseButtonEventArgs e)
        {
            Timer.Stop();
            CheatActivated = false;
            CheatProgress = 0;
            CurTime = 0;
            Time.Content = "0:0";
            finished = false;
            NumberOfTurns = 0;
            Turns.Content = "0";
            for (int i = 1; i <= 4; i++)
                for (int j = 1; j <= 4; j++)
                {
                    GameTable[i, j] = GameTableCopy[i, j];
                    if (GameTable[i, j] == 16)
                    {
                        ZeroRow = i;
                        ZeroCol = j;
                    }
                }
            RedrawTable();
        }
        private void timer_Tick(object sender, EventArgs e)
        {
            CurTime++;
            Time.Content = $"{CurTime/60}:{CurTime % 60}";
        }
        private void Window_KeyDown(object sender, KeyEventArgs e)
        {
            if (!CheatActivated && e.Key.ToString().ToLower() == CheatCode[CheatProgress].ToString())
                CheatProgress++;
            else
                CheatProgress = 0;
            if (CheatProgress == CheatCode.Length)
            {
                if (!Timer.IsEnabled)
                    Timer.Start();
                CheatActivated = true;
                for (int i = 1; i <= 4; i++)
                    for (int j = 1; j <= 4; j++)
                        GameTable[i, j] = (i - 1) * 4 + j;
                Swap(ref GameTable[4, 3], ref GameTable[4, 4]);
                ZeroCol = 3;
                ZeroRow = 4;
                RedrawTable();
            }
        }
        public MainWindow()
        {
            InitializeComponent();
            Timer = new DispatcherTimer();
            Timer.Tick += new EventHandler(timer_Tick);
            Timer.Interval = new TimeSpan(0, 0, 1);
            InitGame();
        }
    }
}
