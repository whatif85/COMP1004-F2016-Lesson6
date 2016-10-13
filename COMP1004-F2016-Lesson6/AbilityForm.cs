using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace COMP1004_F2016_Lesson6
{
    public partial class AbilityForm : Form
    {
        private Random _random;

        // initialize variables in the constructor
        public AbilityForm()
        {
            InitializeComponent();
            this._initialize();
        }

        /// <summary>
        /// this method is used to initialize class member variables
        /// </summary>
        private void _initialize()
        {
            // instantiate object of type Random
            this._random = new Random();
        }

        private void RollButton_Click(object sender, EventArgs e)
        {
            // call the roll abilities method
            RollAbilities();
        }

        /// <summary>
        /// this method generates six abilities for the character sheet
        /// </summary>
        private void RollAbilities()
        {
            // roll 4d6 and assign the value to each ability
            Program.character.Strength = Roll4D6();
            StrengthTextBox.Text = Program.character.Strength.ToString();

            Program.character.Dexterity = Roll4D6();
            DexterityTextBox.Text = Program.character.Dexterity.ToString();

            Program.character.Constitution = Roll4D6();
            ConstitutionTextBox.Text = Program.character.Constitution.ToString();

            Program.character.Intelligence = Roll4D6();
            IntelligenceTextBox.Text = Program.character.Intelligence.ToString();

            Program.character.Wisdom = Roll4D6();
            WisdomTextBox.Text = Program.character.Wisdom.ToString();

            Program.character.Charisma = Roll4D6();
            CharismaTextBox.Text = Program.character.Charisma.ToString();
        }

        /// <summary>
        /// This method rolls 4 six-sided dice and return the top 3
        /// </summary>
        private int Roll4D6()
        {
            List<int> dice = new List<int>(); // instantiate an empty integer list

            // roll 4d6

            for (int count = 0; count < 4; count++)
            {
                dice.Add(this._random.Next(1, 7)); // 1 to 6 (where 1 = 0, and so on)
                // Debug.WriteLine(dice[count]); // was just for testing purposes
            }

            dice.Sort();

            // remove zeroth value from the die
            dice.RemoveAt(0);

            return dice.Sum(); ;
        }

        private void AbilityForm_Load(object sender, EventArgs e)
        {
            this.RollAbilities(); // assign random values at startup

            // comment
        }

        private void NextButton_Click(object sender, EventArgs e)
        {
            // create an instance of the next form
            // will be recreated on access because it's instantiated
            RaceForm raceForm = new RaceForm();

            //set the previous form property of the next form to this form
            raceForm.previousForm = this;

            raceForm.Show(); // show next form
            this.Hide();    // hide this form
        }
    }
}
