using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TestForm
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		public bool Play;

		private void StartGame(object sender, EventArgs e)
		{
			displayBox.Text = "Would you like to play?";

			if (true == Play)
			{
				// run game
			}
		}

		private void PlayGame(object sender, EventArgs e)
		{
			if (txtBox.Text == null)
			{
				txtBox.Text = "";
			}

			string answer = (txtBox.Text).ToUpper();

			if (answer == "YES")
			{
				displayBox.Text = "Good. \n Use the buttons and the text box below to interact.";
				Play = true;
			}
			else if (answer == "NO")
			{
				displayBox.Text = "Too bad! Press \"B\" to go back.";
				Play = false;
			}
			else
			{
				displayBox.Text = "Not a valid answer! Please enter \"Yes\" or \"No\". Thanks!";
				Play = false;
			}
		}
	}
}
