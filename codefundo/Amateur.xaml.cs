using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Shapes;
using System.Windows.Threading;
using Microsoft.Phone.Controls;
using System.Text;
using System.IO;
using System.IO.IsolatedStorage;

namespace codefundo
{
    public partial class Amateur : PhoneApplicationPage
    {

        int i = 15;
        int score = 0;
        DispatcherTimer timer;
        Button[] array = new Button[26];
        String finalResult;

        // Constructor
        String wordProduced;
        int totalScore = 0;

        public Amateur()
        {

            InitializeComponent();
            timer = new DispatcherTimer();
            timer.Interval = TimeSpan.FromMilliseconds(1000);
            timer.Tick += new EventHandler(method);
            timer.Start();
            i = 15;
            wordProduced = RandomString(5);
            wordBlock.Text = wordProduced;
            input.Text = "";

        }

        private void initialize()
        {

            array[0] = q;
            array[1] = w;
            array[2] = e;
            array[3] = r;
            array[4] = t;
            array[5] = y;
            array[6] = u;
            array[7] = ibutton;
            array[8] = o;
            array[9] = p;
            array[10] = a;
            array[11] = s;
            array[12] = d;
            array[13] = f;
            array[14] = g;
            array[15] = h;
            array[16] = j;
            array[17] = k;
            array[18] = l;
            array[19] = button12;
            array[20] = x;
            array[21] = c;
            array[22] = v;
            array[23] = b;
            array[24] = button17;
            array[25] = button18;

        }

        private void method(object sender, EventArgs args)
        {

            //firstword();

            string str = i.ToString();
            timerBlock.Text = str;
            i--;
            if (i == -1)
            {
                timer.Stop();
                updateScore();
                newGame();//back to the method

            }





        }

        private void newGame()
        {
            timer.Stop();
            timer = new DispatcherTimer();
            timer.Interval = TimeSpan.FromMilliseconds(1000);
            timer.Tick += new EventHandler(method);
            timer.Start();
            i = 15;
            wordBlock.Text = RandomString(6);
            wordProduced = wordBlock.Text;
           // initialize();

            //randomize();

            input.Text = "";
            var sb = (Storyboard)Resources["wordMove"];
            var anim = (DoubleAnimationUsingKeyFrames)sb.Children[0];
            Random rnd = new Random();
            Random rnd2 = new Random();
            for (int j = 0; j < 15; j++)
            {
                if (j % 2 == 0) anim.KeyFrames[j].Value = rnd.Next(-110, -60);
                else anim.KeyFrames[j].Value = rnd2.Next(60, 110);
            }
            anim = (DoubleAnimationUsingKeyFrames)sb.Children[1];
            for (int j = 0; j < 15; j++)
            {
                if (j % 3 == 0) anim.KeyFrames[j].Value = rnd.Next(-110, -50);
                else anim.KeyFrames[j].Value = rnd2.Next(100, 150);

            }

            anim = (DoubleAnimationUsingKeyFrames)sb.Children[2];
            for (int j = 0; j < 15; j++)
            {
                anim.KeyFrames[j].Value = rnd2.Next(-180, 180);

            }

            wordMove.Begin();
        }

        private static Random random = new Random((int)DateTime.Now.Ticks);
        private static string RandomString(int size)
        {
            StringBuilder builder = new StringBuilder();
            char ch;
            for (int i = 0; i < size; i++)
            {
                ch = Convert.ToChar(Convert.ToInt32(Math.Floor(26 * random.NextDouble() + 65)));
                builder.Append(ch);
            }

            return builder.ToString();
        }
   

        private void o_Click(object sender, RoutedEventArgs e)
        {
            input.Text += ((Button)sender).Content;
        }

        private void button10_Click(object sender, RoutedEventArgs e)
        {
            input.Text += ((Button)sender).Content;
        }
        private void button7_Click(object sender, RoutedEventArgs e)
        {
            input.Text += ((Button)sender).Content;
        }
        private void button14_Click(object sender, RoutedEventArgs e)
        {
            input.Text += ((Button)sender).Content;
        }

        private void q_Click(object sender, RoutedEventArgs e)
        {
            input.Text += ((Button)sender).Content;
        }

        private void w_Click(object sender, RoutedEventArgs e)
        {
            input.Text += ((Button)sender).Content;
        }

        private void e_Click(object sender, RoutedEventArgs e)
        {
            input.Text += ((Button)sender).Content;
        }

        private void r_Click(object sender, RoutedEventArgs e)
        {
            input.Text += ((Button)sender).Content;
        }

        private void t_Click(object sender, RoutedEventArgs e)
        {
            input.Text += ((Button)sender).Content;
        }

        private void y_Click(object sender, RoutedEventArgs e)
        {
            input.Text += ((Button)sender).Content;
        }

        private void u_Click(object sender, RoutedEventArgs e)
        {
            input.Text += ((Button)sender).Content;
        }

        private void ibutton_Click(object sender, RoutedEventArgs e)
        {
            input.Text += ((Button)sender).Content;
        }

        private void p_Click(object sender, RoutedEventArgs e)
        {
            input.Text += ((Button)sender).Content;
        }

        private void a_Click(object sender, RoutedEventArgs e)
        {
            input.Text += ((Button)sender).Content;
        }

        private void s_Click(object sender, RoutedEventArgs e)
        {
            input.Text += ((Button)sender).Content;
        }

        private void d_Click(object sender, RoutedEventArgs e)
        {
            input.Text += ((Button)sender).Content;
        }

        private void f_Click(object sender, RoutedEventArgs e)
        {
            input.Text += ((Button)sender).Content;
        }

        private void g_Click(object sender, RoutedEventArgs e)
        {
            input.Text += ((Button)sender).Content;
        }

        private void j_Click(object sender, RoutedEventArgs e)
        {
            input.Text += ((Button)sender).Content;
        }

        private void l_Click(object sender, RoutedEventArgs e)
        {
            input.Text += ((Button)sender).Content;
        }

        private void button12_Click(object sender, RoutedEventArgs e)
        {
            input.Text += ((Button)sender).Content;
        }

        private void x_Click(object sender, RoutedEventArgs e)
        {
            input.Text += ((Button)sender).Content;
        }

        private void v_Click(object sender, RoutedEventArgs e)
        {
            input.Text += ((Button)sender).Content;
        }

        private void b_Click(object sender, RoutedEventArgs e)
        {
            input.Text += ((Button)sender).Content;
        }

        private void button17_Click(object sender, RoutedEventArgs e)
        {
            input.Text += ((Button)sender).Content;
        }

        private void button18_Click(object sender, RoutedEventArgs e)
        {
            input.Text += ((Button)sender).Content;
        }

        private void button19_Click(object sender, RoutedEventArgs e)
        {
            timer.Stop();

            String ans = input.Text.ToString().ToUpper();
            if (ans.Equals(wordProduced))
            {
                score += i;


            }
            timer.Stop();
            updateScore();



        }

        private void updateScore()
        {
            timer.Stop();
            totalScore += 15;
            
            finalResult = score.ToString(); // +"/" + totalScore;
            scoreBlock.Text = finalResult;
            if (totalScore == 150) endGame();

            newGame();
        }

        private void button1_Click(object sender, RoutedEventArgs e)
        {
            string inputText = input.Text;
            if (inputText.Length > 0) inputText = inputText.Remove(inputText.Length - 1);
            input.Text = inputText;
        }

        private void endGame()
        {
            try {
                using (var store = IsolatedStorageFile.GetUserStoreForApplication()) {
                    IsolatedStorageFileStream rootFile = store.CreateFile("Intheroot.txt");
                    rootFile.Close();
                    if(store.FileExists("/Intheroot.txt")) {
                        try {
                            using (StreamWriter sw =new StreamWriter(store.OpenFile("Intheroot.txt",FileMode.Open,FileAccess.Write))) {
                                sw.WriteLine("Saale Kutte");
                            }
                        }
                        catch (IsolatedStorageException ex) {
                            Console.WriteLine(ex.Message);
                        }
                    }
                }
            }
                catch (IsolatedStorageException) {
                    //Somefucking thing
                }
        
            
        }

        private void pause_Click(object sender, RoutedEventArgs e)
        {

        }

        private void button2_Click(object sender, RoutedEventArgs e)
        {
            endGame();
            //this.Content = new Page2();
        }
    }
}