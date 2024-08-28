using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace footballGame
{
    public partial class Form1 : Form

    {
        private int currentHoleNum = 1;
        private int distancetoHole = 543;
        private int distanceHit = 0;
        private int scoreNum = 0;
        private int numRand = 1;
        private int numRand2 = 1;
        private int hazardTrue = 1;

        private Random random = new Random();
        public Form1()
        {
            InitializeComponent();

             
            holeN.Text = currentHoleNum.ToString();
        
            clubType.SelectedIndexChanged += new EventHandler(clubType_SelectedIndexChanged);
           

            distance.Text = distancetoHole.ToString();

            hazard.Text = "Clear";

            

        }


        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {


        }

        private void hit_Click(object sender, EventArgs e)
        {
            distancetoHole = Math.Abs(distancetoHole);
            distancetoHole -= distanceHit;
            distancetoHole = Math.Abs(distancetoHole);
            distance.Text = distancetoHole.ToString();
            
            if (distancetoHole <0)
            {
                
                distancetoHole = Math.Abs(distancetoHole);
            }
            else if (distancetoHole <=10)
            {
                distance.Text = "Ball in hole, Click Next Hole to Move on";
            }
            scoreNum++;
            overallScore.Text = scoreNum.ToString();
            numRand2 = random.Next(1, 5);
            
            if (distancetoHole < 0)
            {
                distancetoHole = Math.Abs(distancetoHole);
            }
           
            if(distancetoHole < 15 && distancetoHole > 0 )
            {
                shotResult.Text = "Ball On green";
            }
            
            else if(distancetoHole >=15){
                if (hazardTrue == 2)
                {
                    switch (numRand2)
                    {
                        case 1:
                            shotResult.Text = "Ball In Water, You Will drop and get one penalty stroke";
                            scoreNum++;
                            break;
                        case 2:
                        case 3:
                        case 4:
                            shotResult.Text ="Ball In fairway, Nice Drive";
                            break;
                        case 5:
                            shotResult.Text = "Ball in Rough";
                            scoreNum++;
                            break;
                    }
                


                }
                else if (hazardTrue == 3)
                {
                    switch (numRand2)
                    {
                        case 1:
                            shotResult.Text = "Ball In Sand, Good Luck";
                            scoreNum++;
                            break;
                        case 2:
                        case 3:
                        case 4:
                            shotResult.Text ="Ball In fairway, Nice Shot";
                            break;
                        case 5:
                            shotResult.Text = "Ball in Rough";
                            scoreNum++;
                            break;


                    }
                }
                else if (hazardTrue == 1)
                {
                    switch (numRand2)
                    {
                        case 1:
                        case 2:
                        case 3:

                            shotResult.Text ="Ball In fairway, Nice Shot";
                            break;
                        case 4:
                        case 5:
                            shotResult.Text = "Ball in Rough";
                            scoreNum++;
                            break;
                    }
                }
            }


        }
        // do not Delete below line will break code
        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void clubType_SelectedIndexChanged(object sender, EventArgs e)
        {

            {
                string club = clubType.SelectedItem.ToString();

                switch (club)
                {
                    case "Driver":
                        distanceHit = random.Next(270, 300);
                        break;
                    case "Fairway Wood":
                        distanceHit = random.Next(250, 269);
                        break;
                    case "Long Iron":
                        distanceHit = random.Next(220, 249);
                        break;
                    case "Mid Iron":
                        distanceHit = random.Next(155, 219);
                        break;
                    case "Short Iron":
                        distanceHit = random.Next(125, 185);
                        break;
                    case "Pitching Wedge":
                        distanceHit = random.Next(56, 124);
                        break;
                    case "Sand Wedge":
                        distanceHit = random.Next(15, 55);
                        break;
                    case "Putter":
                        distanceHit = random.Next(1, 14);
                        break;
                    default:
                        distanceHit = 0; // Set a default value if none of the cases match
                        break;
                }
            }
            
        }


        private void finishHole_Click(object sender, EventArgs e)
        {
            currentHoleNum++;
            holeN.Text = currentHoleNum.ToString();
            shotResult.Text = "     ";
            string par = parAmount.ToString();
           



            numRand = random.Next(1, 3);
                switch (numRand)
                {
                    case 2:
                        hazard.Text = "Water";
                    hazardTrue = 2;
                        break;
                    case 3:
                        hazard.Text = "Sand Trap";
                    hazardTrue = 3;
                    break;
                    case 1:
                        hazard.Text = "None";
                    hazardTrue = 1;
                    break;
                    default:
                        break;
                }


            

            switch (currentHoleNum)

            {
                case 2:
                    distancetoHole = 263; par = "Par - 4"; break;
                    


                case 3:
                    distancetoHole = 350; par = "Par - 4"; break;
                    

                case 4:
                    distancetoHole = 170; par = "Par - 3"; break;
                    
                case 5:
                    distancetoHole = 374; par = "Par - 4"; break;
                    
                case 6:
                    distancetoHole = 465; par = "Par - 4"; break;
                    
                case 7:
                    distancetoHole = 504; par = "Par - 5"; break;
                    
                case 8:
                    distancetoHole = 205; par = "Par - 3"; break;
                    
                case 9:
                    distancetoHole = 430; par = "Par - 4"; break;
                    
                case 10:
                    distancetoHole = 105; par = "Par - 3"; break;
                    
                case 11:
                    distancetoHole = 367; par = "Par - 4"; break;
                    
                case 12:
                    distancetoHole = 495; par = "Par - 5"; break;
                  
                case 13:
                    distancetoHole = 570; par = "Par - 5"; break;
                    
                case 14:
                    distancetoHole = 400; par = "Par - 4"; break;
                    
                case 15:
                    distancetoHole = 320; par = "Par - 4"; break;
                    
                case 16:
                    distancetoHole = 185; par = "Par - 3"; break;
                case 17:
                    distancetoHole = 200; par = "Par - 3"; break;
                case 18:
                    distancetoHole = 600; par = "Par - 5"; break;
                default:
                    par = "Par -5 ";
                    break;
            }
            parAmount.Text = par;
            if (currentHoleNum == 19)
            {
                holeN.Text = "Your Round is Over, CLick Again for new round";
                par = "Good Job";
                

            }
            else if (currentHoleNum>19)
            {
                currentHoleNum = 0;
                holeN.Text = "Click Next Hole to Start Next Round";
                par = "Par - 5";
                distancetoHole = 543;
                scoreNum  = 0;
                overallScore.Text = scoreNum.ToString();
                
            }
            
            distance.Text = (distancetoHole).ToString();


        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Score_Click(object sender, EventArgs e)
        {

        }

        private void parAmount_Click(object sender, EventArgs e)
        {

        }
    }
}
