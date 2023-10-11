using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RockPaperScissorsGame
{
    public partial class Form1 : Form
    {
        Random random = new Random();
        public Form1()
        {
            InitializeComponent();
        }

        private void playButton_Click(object sender, EventArgs e)
        {
            int computerTurn = random.Next(1, 4);
            int playerTurn = random.Next(1, 4);

            //Assign pictures to random number
            switch (computerTurn)
            {
                case 1:
                    computerPictureBox.ImageLocation = @"C:\Users\mateu\Desktop\rps\rock.png";
                    computerPictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
                    break;
                case 2:
                    computerPictureBox.ImageLocation = @"C:\Users\mateu\Desktop\rps\paper.png";
                    computerPictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
                    break;
                case 3:
                    computerPictureBox.ImageLocation = @"C:\Users\mateu\Desktop\rps\scissors.png";
                    computerPictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
                    break;
                default:
                    computerPictureBox.ImageLocation = @"C:\Users\mateu\Desktop\rps\rock.png";
                    computerPictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
                    break;
               
                  
            }
            //Assign pictures to random number
            switch (playerTurn)
            {
                case 1:
                    playerPictureBox.ImageLocation = @"C:\Users\mateu\Desktop\rps\rock.png";
                    playerPictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
                    break;
                case 2:
                    playerPictureBox.ImageLocation = @"C:\Users\mateu\Desktop\rps\paper.png";
                    playerPictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
                    break;
                case 3:
                    playerPictureBox.ImageLocation = @"C:\Users\mateu\Desktop\rps\scissors.png";
                    playerPictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
                    break;
                default:
                    playerPictureBox.ImageLocation = @"C:\Users\mateu\Desktop\rps\rock.png";
                    playerPictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
                    break;

            }
            determineWinner(computerTurn, playerTurn);
            
        }
        public void determineWinner(int computerScore, int playerScore)
        {
            if (computerScore == 1 && playerScore == 2)
            {
                label1.Text = "You win!";
            }
            else if(computerScore == 1 && playerScore == 3)
            {
                label1.Text = "The Computer Wins!";
            }
            else if (computerScore == 2 && playerScore == 1)
            {
                label1.Text = "The Computer Wins!";
            }
            else if (computerScore == 2 && playerScore == 3)
            {
                label1.Text = "You win!";
            }
            else if (computerScore == 3 && playerScore == 1)
            {
                label1.Text = "You win!";
            }
            else if (computerScore == 3 && playerScore == 2)
            {
                label1.Text = "The Computer Wins!";
            }
            else
            {
                label1.Text = "There's a tie!";
            }

        }    
    }
}
