
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;
using StudentForYou;

namespace Studentforyousubjects
{
   public class ButtonAdder
    {

        public ButtonAdder()
        {
        }

           public Button AddIconButton(int numberofbuttons)
            {
                System.Windows.Forms.Button btn = new System.Windows.Forms.Button();
                btn.Top = numberofbuttons * 40;
                btn.Width = 40;
            btn.BackgroundImage = Image.FromFile(@"Resources\chaticon.png");
                btn.Height = 40;
                btn.Left = 950;
                return btn;
            }

       


    }
      


    }


    

/*System.Windows.Forms.Button btn = new System.Windows.Forms.Button();
            this.Controls.Add(btn);
            btn.Top = A * 40;
            btn.Width = 1120;
            btn.Height = 40;
            btn.TextAlign = ContentAlignment.MiddleCenter;
            btn.Left = 15;
            btn.Text = "Like: " + likes + " Views: " + views + " Answers: " + answers + " ' " + question + " ' ";
            A += 1;
            btn.Click += delegate (object sender, EventArgs e)
            {
                button_click(sender, e, question);
int count = Int32.Parse(views);
count++;
                views = count.ToString();
                string[] lines = File.ReadAllLines(@"..\Debug\Resources\recentquestions.txt");
string[] line = lines[placeToReplace].Split(',');
line[1] = views;
                string newLine = line[0] + "," + line[1] + "," + line[2] + "," + line[3];
lines[placeToReplace] = newLine;
                StreamWriter writeText = new StreamWriter(@"..\Debug\Resources\recentquestions.txt");

                for (int currentLine = 0; currentLine<lines.Length; ++currentLine)
                {
                    if (currentLine == placeToReplace)
                    {
                        writeText.WriteLine(lines[placeToReplace]);
                    }
                    else
                    {
                        writeText.WriteLine(lines[currentLine]);
                    }
                }
                writeText.Close();
                this.Close();
            };
            return btn;
            */