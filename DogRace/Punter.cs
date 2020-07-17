using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DogRace
{
    public abstract class Punter
    {
        public string Name { get; set; } // The punters name
        public Bet myBet { get; set; } // An instance of Bet() that has his bet
        public int Cash { get; set; } // How much cash he has
        public RadioButton MyRadioButton { get; set; } // My Radiobutton
        public Label MyLabel { get; set; } // My Label

        public void UpdateLabels() // Set my label to my bets description and the label on the radio button to show the punters cash
        {
            MyLabel.Text = myBet.GetDescription();
        }

        public bool PlaceBet(int BetAmount, int DogToWin) // Place a new bet and store it in mybet field
        {
            //Place a new bet and store it
            //return true if punter had enough money to bet
            if (Cash >= BetAmount)
            {

                myBet.Amount = BetAmount;
                myBet.Dog = DogToWin;
                myBet.Bettor = this;
                

                UpdateLabels();

                return true;
            }
            //return false if punter did not have enough money and do not store
            else
            {
                MessageBox.Show(Name + " didn't have enough to bet");
                return false;
            }

        }

    }

    public class Shivam : Punter // Inherit from the Punter class
    {
        public Shivam() // Sets up the punter Shivam
        {
            Name = "Shivam";
            Cash = 50;
            myBet = new Bet()
            {
                Amount = 0,
                Dog = -1,
                Bettor = this
            };
        }

    }

    public class Sukhpal : Punter // Inherit from the Punter class
    {
        public Sukhpal() // Sets up the Punter Sukhpal
        {
            Name = "Sukhpal";
            Cash = 50;
            myBet = new Bet()
            {
                Amount = 0,
                Dog = -1,
                Bettor = this
            };
        }
    }

    public class Gurlal : Punter // Inherit from the Punter class
    {
        public Gurlal() // Sets up the punter Gurlal
        {
            Name = "Gurlal";
            Cash = 50;
            myBet = new Bet()
            {
                Amount = 0,
                Dog = -1,
                Bettor = this
            };
        }
    }
}
