using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DogRace
{
    public partial class MainForm : Form
    {
        // Initialise an array of punters
        Punter[] myPunters = new Punter[3];
        // Initialise an array of Dogs
        Dogs[] DogsArray = new Dogs[4];
        public MainForm()
        {
            InitializeComponent();
            DogsRace();
            Punters();
            LabelsClear();
        }


        public void LabelsClear() // Clear all labels
        {
            lblShivam.Text = "";
            lblGurlal.Text = "";
            lblSukhpal.Text = "";
        }

        public void Punters()
        {
            //create an array of punters and instantiate factory class
            for (int i = 0; i < 3; i++)
            {
                myPunters[i] = Factory.GetAPunter(i);
            }

            //set the labels to the classes and update
            myPunters[0].MyLabel = lblShivam;
            myPunters[0].MyRadioButton = rbShivam;
            myPunters[0].MyRadioButton.Text = myPunters[0].Name + " has $" + myPunters[0].Cash;
            myPunters[1].MyLabel = lblSukhpal;
            myPunters[1].MyRadioButton = rbSukhpal;
            myPunters[1].MyRadioButton.Text = myPunters[1].Name + " has $" + myPunters[1].Cash;
            myPunters[2].MyLabel = lblGurlal;
            myPunters[2].MyRadioButton = rbGurlal;
            myPunters[2].MyRadioButton.Text = myPunters[2].Name + " has $" + myPunters[2].Cash;

        }

        public void GameOverCheck() // Checks to see if the game is over and close game
        {
            if (myPunters[0].Cash <= 0 && myPunters[1].Cash <= 0 && myPunters[2].Cash <= 0)
            {
                MessageBox.Show("Congratulations, all of your bettors are busted! Try Again :D");
                LabelsClear();
                ResetRace();
                this.Close();
            }

        }

        public void BettorBroke() // Checks to see if anyone is broke and cannot continue and update label and blank out radio button
        {
            if (myPunters[0].Cash <= 0)//Shivam
            {
                lblShivam.Text = "Shivam is now busted and cannot continue betting";
                rbShivam.Enabled = false;
            }
            if (myPunters[1].Cash <= 0)//Sukhpal
            {
                lblSukhpal.Text = "Sukhpal is now busted and cannot continue betting";
                rbSukhpal.Enabled = false;
            }
            if (myPunters[2].Cash <= 0)//Gurlal
            {
                lblGurlal.Text = "Gurlal is now busted and cannot continue betting";
                rbGurlal.Enabled = false;
            }

        }

        public void ResetBetAmount() // Reset the bet amounts to zero if the punter is busted
        {
            if (myPunters[0].Cash == 0)
            {
                myPunters[0].myBet.Amount = 0;
            }
            if (myPunters[1].Cash == 0)
            {
                myPunters[1].myBet.Amount = 0;
            }
            if (myPunters[2].Cash == 0)
            {
                myPunters[2].myBet.Amount = 0;
            }
        }

        public void DogsRace() // Instantiate the Dogs
        {
            DogsArray[0] = new Dogs { MyPictureBox = pbDog1, StartingPosition = pbDog1.Left, DogName = "#1", RaceTrackLength = pbRaceTrack.Width - pbDog1.Width, Randomiser = new Random() };
            DogsArray[1] = new Dogs { MyPictureBox = pbDog2, StartingPosition = pbDog2.Left, DogName = "#2", RaceTrackLength = pbRaceTrack.Width - pbDog2.Width, Randomiser = DogsArray[0].Randomiser };
            DogsArray[2] = new Dogs { MyPictureBox = pbDog3, StartingPosition = pbDog3.Left, DogName = "#3", RaceTrackLength = pbRaceTrack.Width - pbDog3.Width, Randomiser = DogsArray[0].Randomiser };
            DogsArray[3] = new Dogs { MyPictureBox = pbDog4, StartingPosition = pbDog4.Left, DogName = "#4", RaceTrackLength = pbRaceTrack.Width - pbDog4.Width, Randomiser = DogsArray[0].Randomiser };
        }
        public void ResetRace() // Reset Dog positions back to start
        {
            // Reset the label text
            myPunters[0].MyLabel.ResetText();
            myPunters[1].MyLabel.ResetText();
            myPunters[2].MyLabel.ResetText();
            //Reset the bet amounts to zero
            myPunters[0].myBet.Amount = 0;
            myPunters[1].myBet.Amount = 0;
            myPunters[2].myBet.Amount = 0;

            foreach (Dogs t in DogsArray)
            {
                t.MyPictureBox.Left = t.StartingPosition;
            }
        }

        private void btnBet_Click(object sender, EventArgs e)
        {
            int punter = 0;

            if (rbShivam.Checked)
            {
                punter = 0;
            }
            else if (rbSukhpal.Checked)
            {
                punter = 1;
            }
            else if (rbGurlal.Checked)
            {
                punter = 2;
            }

            myPunters[punter].PlaceBet((int)udBoxBet.Value, (int)udBoxDog.Value - 1); // Updates the bet amount and Dog # using the Placebet.Punter class with Form designer details


        }

        private void rbShivam_CheckedChanged(object sender, EventArgs e)
        {
            //Show that Shivam is betting in the bettor label
            lblBettor.Text = myPunters[0].Name;
            // Sets the maximum bet based off cash
            udBoxBet.Maximum = myPunters[0].Cash;
        }

        private void rbSukhpal_CheckedChanged(object sender, EventArgs e)
        {
            //Show that Sukhpal is betting in the bettor label
            lblBettor.Text = myPunters[1].Name;
            // Sets the maximum bet based off cash
            udBoxBet.Maximum = myPunters[1].Cash;
        }

        private void rbGurlal_CheckedChanged(object sender, EventArgs e)
        {
            //Show that Gurlal is betting in the bettor label
            lblBettor.Text = myPunters[2].Name;
            // Sets the maximum bet based off cash
            udBoxBet.Maximum = myPunters[2].Cash;
        }

        private void btnRace_Click(object sender, EventArgs e)
        {

            //Check to see if the punters have enough money to proceed with the race and provide warning if not
            if (myPunters[0].Cash < udBoxBet.Value && rbShivam.Enabled)
            {
                MessageBox.Show("Sorry but Shivam does not have enough cash to proceed.");
                timer1.Enabled = false;
            }
            if (myPunters[1].Cash < udBoxBet.Value && rbSukhpal.Enabled)
            {
                MessageBox.Show("Sorry but Sukhpal does not have enough cash to proceed.");
                timer1.Enabled = false;
            }
            if (myPunters[2].Cash < udBoxBet.Value && rbGurlal.Enabled)
            {
                MessageBox.Show("Sorry but Gurlal does not have enough cash to proceed.");
                timer1.Enabled = false;
            }

            else
            {
                //Reset starting positions
                foreach (Dogs t in DogsArray)
                {
                    t.MyPictureBox.Left = t.StartingPosition;
                }

                // Start the timer for the race
                timer1.Enabled = true;
                btnRace.Enabled = true;
            }

        }

        private void timer1_Tick(object sender, EventArgs e)
        { // Run the timer event for the race and return the winner and bet results

            try
            {
                int winner;

                for (int i = 0; i < DogsArray.Length; i++)
                {
                    if (DogsArray[i].Run(pbRaceTrack)) // use Dog.Run class for race and if true return a winner and stop timer event
                    {
                        winner = i;
                        timer1.Enabled = false;
                        MessageBox.Show("Dog #" + (winner + 1) + " Wins!");

                        for (int j = 0; j < myPunters.Length; j++)
                        {
                            if (myPunters[j].myBet.PayOut(winner) != 0)

                                myPunters[j].Cash += myPunters[j].myBet.PayOut(winner); // Update punters cash with the bet payout amount
                            myPunters[j].MyRadioButton.Text = myPunters[j].Name + " has $" + myPunters[j].Cash; // Updates the radio button text with new cash value

                        }

                        ResetRace(); // Resets the starting positions, bet amounts, and labels
                        ResetBetAmount(); // Reset bet amounts if bettor is bust
                        BettorBroke(); // Checks to see if anyone is bust and blank them out
                        GameOverCheck(); // Checks to see if the game is over and close if true

                        break;

                    }

                }

            }

            catch
            {
                MessageBox.Show("A bet was not placed, you could have won some coin.");
            }

        }


    }
}
