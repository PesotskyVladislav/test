using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;
using System.Collections.Generic;

namespace MyPoker
{

    class DrawCards
    {
        private static List<PictureBox> myPicBox = new List<PictureBox>();
   //     private static bool NewGame = true;
       
        
        public static bool ListCard(DealCards temp)
        {
            
            for (int i=0; i<=9;i++)
            {
                myPicBox.Add(new PictureBox());
              //  myPicBox[i].Name = "Picbox" + i.ToString();
                myPicBox[i].Size = new System.Drawing.Size(100, 150);
                myPicBox[i].SizeMode = PictureBoxSizeMode.Zoom;
                if (i < 2)
                {
                    myPicBox[i].Location = new System.Drawing.Point(650 + 105 * i, 600);

                }
                else
                    if (i < 4)
                    {
                        myPicBox[i].Location = new System.Drawing.Point(650 + 105 * (i - 2), 20);
                       

                    }
                switch (i)
                {
                    case 5:
                        myPicBox[i].Location = new System.Drawing.Point(300 + 110 * (i - 3), 300);

                        break;
                    case 6:
                        myPicBox[i].Location = new System.Drawing.Point(300 + 110 * (i - 3), 300);
 

                        break;
                    case 7:
                        myPicBox[i].Location = new System.Drawing.Point(300 + 110 * (i - 3), 300);
   
                            break;
                    case 8:
                            myPicBox[i].Location = new System.Drawing.Point(300 + 110 * (i - 3), 300);
                                 //   myPicBox[i].Name = "Picbox" + i.ToString();                 
                                 break;
                    case 9:
                        myPicBox[i].Location = new System.Drawing.Point(300 + 110 * (i - 3), 300);

                        //   myButton.Click += (object sender, EventArgs e) => { temp.getRiver(control); };
                        break;

                }
                myPicBox[i].TabIndex = 0;
                myPicBox[i].TabStop = false;



                temp.getControls().Add(myPicBox[i]);
            }

            return false;
        }

        public static void VisibleCards()
        {
             for (int i=0; i<=9;i++)
             {
                 myPicBox[i].Visible = false;

             }
        }

        public static void DrawCardSuitValueRobot(Card card, int i, DealCards temp)
        {
            try {
                myPicBox[i].Image = Image.FromFile(System.IO.Directory.GetCurrentDirectory() + "/CardIm/" + card.MyValue + "_" + card.MySuit + ".bmp");
            }
            catch (Exception ex) { };

            try
            {
    
                myPicBox[i].Image = Image.FromFile("..\\..\\..\\MyPoker\\bin\\Debug\"CardIm\\" + card.MyValue + "_" + card.MySuit + ".bmp");

            }
            catch (Exception ex) { };
            // myPicBox[i].Name = "Picbox" + card.MyValue + "_" + card.MySuit;

        }


        public static void DrawCardSuitValue(Card card, int i, DealCards temp)
        {
            //i = i - 1;
            //if (NewGame)
            //{
            //   NewGame=ListCard(temp);
            //}
            // if (temp.getControls().Find("PicBox"+i.ToString(), true)) 
            //  PictureBox myPicBox = new PictureBox();

            try
            {
                myPicBox[i].Image = Image.FromFile(System.IO.Directory.GetCurrentDirectory() + "/CardIm/" + card.MyValue + "_" + card.MySuit + ".bmp");
            }
            catch (Exception ex) { };
            try
            {
              
                myPicBox[i].Image = Image.FromFile("..\\..\\..\\MyPoker\\bin\\Debug\\CardIm\\" + card.MyValue + "_" + card.MySuit + ".bmp");
              
            }
            catch (Exception ex) { };
           // myPicBox[i].Image = Image.FromFile(System.IO.Directory.GetCurrentDirectory() + "/CardIm/" + card.MyValue + "_" + card.MySuit + ".bmp");
            myPicBox[i].Name = "Picbox" + card.MyValue + "_" + card.MySuit;
            if (i < 2)
            {
                myPicBox[i].Visible = true;
                
            }
            else
                if (i<4)
            {
                try
                {
                    myPicBox[i].Image = Image.FromFile(System.IO.Directory.GetCurrentDirectory() + "/CardIm/Shirt" + ".bmp");
                }
                catch (Exception ex) { };
                try
                {
                  
                    myPicBox[i].Image = Image.FromFile("..\\..\\..\\MyPoker\\bin\\Debug\\CardIm\\Shirt" + ".bmp");
                }
                catch (Exception ex) { };
                // myPicBox[i].Image = Image.FromFile(System.IO.Directory.GetCurrentDirectory() + "/CardIm/Shirt"  + ".bmp");
                myPicBox[i].Visible = true;

            }
              switch (i)
              {
                  case 5:
                      myPicBox[i].Visible = true;
                      break;
                  case 6:
                      myPicBox[i].Visible = true;
                      break;
                  case 7:
                      myPicBox[i].Visible = true;
                   //  temp.newEHButton(i);
                      break;
                  case 8:
                      myPicBox[i].Visible = true;
                     // temp.newEHButton(i);
                      break;
                  case 9:
                  //    temp.newEHButton(i);
                      myPicBox[i].Visible = true;
                      //   myButton.Click += (object sender, EventArgs e) => { temp.getRiver(control); };
                      break;

              }
            
           

           // myForm.Controls.Add(myPicBox);
            
        }



    }
}
