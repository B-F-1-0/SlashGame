using System.Diagnostics.Metrics;

namespace SlashGame
{
    public partial class Form1 : Form
    {
        // list of squares
        string[] squares = new string[] { "a1", "a2", "a3", "b1", "b2", "b3", "c1", "c2", "c3" };

        // selected squares
        int[] selectedSquares = new int[] { 0, 0, 0, 0, 0, 0, 0, 0, 0 };

        // error variable
        bool error = false;

        // set slashes
        int slashnumber = 8;
        int score = 0;
        int maxTime = initialTime;

        // constants
        const int initialTime = 1000;
        const int minTime = 45;

        public Form1()
        {
            InitializeComponent();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void startButton_Click(object sender, EventArgs e)
        {
            try
            {
                start();
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error has occurred. " + ex,"Error");
            }
        }

        private void start()
        {
            scoreLabel.Text = "Your score: 0";
            score = 0;
            slashnumber = 1;
            maxTime = initialTime;
            setButtons(true);
            selectSlash(slashnumber);
            setTimer(initialTime);
        }

        private void setTimer(int time)
        {
            // reset timer
            gameTimer.Stop();
            // time = 1000 is about 15 seconds, so time * 15 milliseconds = final time
            timeProgressBar.Maximum = time;
            // flick the timer to ensure it is at max
            timeProgressBar.Value = time - 1;
            timeProgressBar.Value = time;
            // start the timer
            gameTimer.Start();
        }

        private void gameTimer_Tick(object sender, EventArgs e)
        {
            if (timeProgressBar.Value > 0)
            {
                timeProgressBar.Value--;
            }
            // if out of time, game over
            if (timeProgressBar.Value == 0)
            {
                gameTimer.Stop();
                MessageBox.Show("You ran out of time and got slashed! Game over.", "Out of time");
                resetSquares();
                setButtons(false);
            }
        }

        private void setButtons(bool enable)
        {
            if (enable)
            {
                a1Button.Enabled = true;
                a2Button.Enabled = true;
                a3Button.Enabled = true;
                b1Button.Enabled = true;
                b2Button.Enabled = true;
                b3Button.Enabled = true;
                c1Button.Enabled = true;
                c2Button.Enabled = true;
                c3Button.Enabled = true;
                startButton.Enabled = false;
            }
            else
            {
                a1Button.Enabled = false;
                a2Button.Enabled = false;
                a3Button.Enabled = false;
                b1Button.Enabled = false;
                b2Button.Enabled = false;
                b3Button.Enabled = false;
                c1Button.Enabled = false;
                c2Button.Enabled = false;
                c3Button.Enabled = false;
                startButton.Enabled = true;
            }
        }

        private void resetSquares()
        {
            // resets the background color of all squares
            a1SlashLabel.BackColor = Color.White;
            a2SlashLabel.BackColor = Color.White;
            a3SlashLabel.BackColor = Color.White;
            b1SlashLabel.BackColor = Color.White;
            b2SlashLabel.BackColor = Color.White;
            b3SlashLabel.BackColor = Color.White;
            c1SlashLabel.BackColor = Color.White;
            c2SlashLabel.BackColor = Color.White;
            c3SlashLabel.BackColor = Color.White;
            // reset selected squares
            for (int i = 0; i < selectedSquares.Length; i++)
            {
                selectedSquares[i] = 0;
                Console.WriteLine(i);
            }
        }

        private void selectSlash(int slashes)
        {
            resetSquares();
            Random rng = new Random();
            for (int i = 0; i < slashes; i++)
            {
                int index = rng.Next(squares.Length); // get index from random value in squares array
                while (selectedSquares[index] == 1) // if there is a repeat, keep looping until we get a new number
                {
                    index = rng.Next(squares.Length);
                    Console.WriteLine(index.ToString() + " " + selectedSquares[index].ToString());
                }
                selectedSquares[index] = 1;
                switch (index)
                {
                    case 0:
                        a1SlashLabel.BackColor = Color.Black;
                        break;
                    case 1:
                        a2SlashLabel.BackColor = Color.Black;
                        break;
                    case 2:
                        a3SlashLabel.BackColor = Color.Black;
                        break;
                    case 3:
                        b1SlashLabel.BackColor = Color.Black;
                        break;
                    case 4:
                        b2SlashLabel.BackColor = Color.Black;
                        break;
                    case 5:
                        b3SlashLabel.BackColor = Color.Black;
                        break;
                    case 6:
                        c1SlashLabel.BackColor = Color.Black;
                        break;
                    case 7:
                        c2SlashLabel.BackColor = Color.Black;
                        break;
                    case 8:
                        c3SlashLabel.BackColor = Color.Black;
                        break;
                    default:
                        MessageBox.Show("An error has occurred. An invalid square index was returned.", "Error");
                        error = true;
                        break;
                }
            }
        }

        private void checkSlash(int location)
        {
            switch (score) // make game harder as it goes on
            {
                case 2:
                    slashnumber = 2;
                    break;
                case 5:
                    slashnumber = 3;
                    break;
                case 8:
                    slashnumber = 4;
                    break;
                case 11:
                    slashnumber = 5;
                    break;
                case 15:
                    slashnumber = 6;
                    break;
                case 20:
                    slashnumber = 7;
                    break;
                case 25:
                    slashnumber = 8;
                    break;
            }
            if (selectedSquares[location] == 0)
            {
                score++;
                scoreLabel.Text = "Your score: " + score;
                selectSlash(slashnumber);
                Random rng = new Random();
                // deduct a random time
                if (maxTime > minTime)
                {
                    maxTime = maxTime - rng.Next(25, 50);
                }
                if (maxTime < minTime) // minimum time without being too unfair
                {
                    maxTime = minTime;
                }
                setTimer(maxTime);
            }
            else
            {
                gameTimer.Stop();
                MessageBox.Show("You clicked a slasher square and got slashed! Game over.", "Whoops");
                timeProgressBar.Value = 0;
                resetSquares();
                setButtons(false);
            }
        }

        private void a1Button_Click(object sender, EventArgs e)
        {
            checkSlash(0);
        }

        private void a2Button_Click(object sender, EventArgs e)
        {
            checkSlash(1);
        }

        private void a3Button_Click(object sender, EventArgs e)
        {
            checkSlash(2);
        }

        private void b1Button_Click(object sender, EventArgs e)
        {
            checkSlash(3);
        }

        private void b2Button_Click(object sender, EventArgs e)
        {
            checkSlash(4);
        }

        private void b3Button_Click(object sender, EventArgs e)
        {
            checkSlash(5);
        }

        private void c1Button_Click(object sender, EventArgs e)
        {
            checkSlash(6);
        }

        private void c2Button_Click(object sender, EventArgs e)
        {
            checkSlash(7);
        }

        private void c3Button_Click(object sender, EventArgs e)
        {
            checkSlash(8);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            scoreLabel.Text = "Your score: 0";
            gameTimer.Tick += new EventHandler(gameTimer_Tick);
        }
    }
}