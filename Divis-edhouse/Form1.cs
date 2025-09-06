using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Divis_edhouse
{
    public partial class Form1 : Form
    {
        private bool hideHelp;                  // Skrytí/zobrazení nápovědy
        private int actPictureBoxID;            // ID aktuálního pictureBoxu
        private string descriptionText;
        private PictureBox[] pictureBoxes;          // Pole pictureBoxů,ve kterých se budou obrázky vykreslovat
        private Picture[] listOfPictures;           // Pole obrázků, které se budou vykreslovat v pictureBoxech
        private Dictionary<int, int> pictureBoxAndPicture;      //Slovník obsahující informaci o tom, jaký obrázek je aktuálně vykreslený v kterém pictureBoxu (identifikované podle ID)

        public Form1()
        {
            InitializeComponent();
            HideHelp = false;
            hide_help();
            
            ActPictureBoxID = 0;         // Identifikace aktuálního obrázku 1 - 9; 0 znamená, že žádný není vybraný
            DescriptionText = "Vyberte aktuální obrázek tím, že na něj kliknete.";
            description.Text = DescriptionText;
            PictureBoxes = this.Controls.OfType<PictureBox>().ToArray();
            Array.Sort(PictureBoxes, (pb1, pb2) => string.Compare(pb1.Name, pb2.Name));
            
            PictureBoxes[0].Paint += pictureBox1_Paint;
            PictureBoxes[1].Paint += pictureBox2_Paint;
            PictureBoxes[2].Paint += pictureBox3_Paint;
            PictureBoxes[3].Paint += pictureBox4_Paint;
            PictureBoxes[4].Paint += pictureBox5_Paint;
            PictureBoxes[5].Paint += pictureBox6_Paint;
            PictureBoxes[6].Paint += pictureBox7_Paint;
            PictureBoxes[7].Paint += pictureBox8_Paint;
            PictureBoxes[8].Paint += pictureBox9_Paint;

            init_list_of_pictures();
            init_pictureBox_and_picture();

            //Načtení obrázků do pictureBoxů
            int pictureBoxIndex = 0;
            foreach (Picture picture in ListOfPictures)
            {
                PictureBoxes[pictureBoxIndex].Image = Image.FromFile(picture.Path);
                pictureBoxIndex++;
            }
            Array.Sort(ListOfPictures, (x, y) => x.PictureID.CompareTo(y.PictureID));
        }

        // Vrátí seznam všech sousedů pro všechny pictureBoxy, pomocí něj měníme obrázky na jednotlivých pictureBoxech
        private static KeyValuePair<int, KeyValuePair<string, int>[]>[] get_list_of_neighbours()
        {
            KeyValuePair<int, KeyValuePair<string, int>[]>[] result = {
                new KeyValuePair<int, KeyValuePair<string, int>[]>(1, new KeyValuePair<string, int>[4] { new KeyValuePair<string, int>("up", 0), new KeyValuePair<string, int>("right", 2), new KeyValuePair<string, int>("down", 4), new KeyValuePair<string, int>("left", 0) }),
                new KeyValuePair<int, KeyValuePair<string, int>[]>(2, new KeyValuePair<string, int>[4] { new KeyValuePair<string, int>("up", 0), new KeyValuePair<string, int>("right", 3), new KeyValuePair<string, int>("down", 5), new KeyValuePair<string, int>("left", 1) }),
                new KeyValuePair<int, KeyValuePair<string, int>[]>(3, new KeyValuePair<string, int>[4] { new KeyValuePair<string, int>("up", 0), new KeyValuePair<string, int>("right", 0), new KeyValuePair<string, int>("down", 6), new KeyValuePair<string, int>("left", 2) }),
                new KeyValuePair<int, KeyValuePair<string, int>[]>(4, new KeyValuePair<string, int>[4] { new KeyValuePair<string, int>("up", 1), new KeyValuePair<string, int>("right", 5), new KeyValuePair<string, int>("down", 7), new KeyValuePair<string, int>("left", 0) }),
                new KeyValuePair<int, KeyValuePair<string, int>[]>(5, new KeyValuePair<string, int>[4] { new KeyValuePair<string, int>("up", 2), new KeyValuePair<string, int>("right", 6), new KeyValuePair<string, int>("down", 8), new KeyValuePair<string, int>("left", 4) }),
                new KeyValuePair<int, KeyValuePair<string, int>[]>(6, new KeyValuePair<string, int>[4] { new KeyValuePair<string, int>("up", 3), new KeyValuePair<string, int>("right", 0), new KeyValuePair<string, int>("down", 9), new KeyValuePair<string, int>("left", 5) }),
                new KeyValuePair<int, KeyValuePair<string, int>[]>(7, new KeyValuePair<string, int>[4] { new KeyValuePair<string, int>("up", 4), new KeyValuePair<string, int>("right", 8), new KeyValuePair<string, int>("down", 0), new KeyValuePair<string, int>("left", 0) }),
                new KeyValuePair<int, KeyValuePair<string, int>[]>(8, new KeyValuePair<string, int>[4] { new KeyValuePair<string, int>("up", 5), new KeyValuePair<string, int>("right", 9), new KeyValuePair<string, int>("down", 0), new KeyValuePair<string, int>("left", 7) }),
                new KeyValuePair<int, KeyValuePair<string, int>[]>(9, new KeyValuePair<string, int>[4] { new KeyValuePair<string, int>("up", 6), new KeyValuePair<string, int>("right", 0), new KeyValuePair<string, int>("down", 0), new KeyValuePair<string, int>("left", 8) })
            };
            return result;
        }

        /* Inicializace pole obrázků */
        private void init_list_of_pictures()
        {
            Picture[] result = {
                new Picture(1, 1, @"Images\1.png"),
                new Picture(2, 2, @"Images\2.png"),
                new Picture(3, 3, @"Images\3.png"),
                new Picture(4, 4, @"Images\4.png"),
                new Picture(5, 5, @"Images\5.png"),
                new Picture(6, 6, @"Images\6.png"),
                new Picture(7, 7, @"Images\7.png"),
                new Picture(8, 8, @"Images\8.png"),
                new Picture(9, 9, @"Images\9.png"),
            };
            ListOfPictures = result;
        }

        /* Inicializuje PictureBoxAndPicture*/
        private void init_pictureBox_and_picture()
        {   
            Dictionary<int, int> result = new Dictionary<int, int>();
            result.Add(1, ListOfPictures[0].DefaultPosition);
            result.Add(2, ListOfPictures[1].DefaultPosition);
            result.Add(3, ListOfPictures[2].DefaultPosition);
            result.Add(4, ListOfPictures[3].DefaultPosition);
            result.Add(5, ListOfPictures[4].DefaultPosition);
            result.Add(6, ListOfPictures[5].DefaultPosition);
            result.Add(7, ListOfPictures[6].DefaultPosition);
            result.Add(8, ListOfPictures[7].DefaultPosition);
            result.Add(9, ListOfPictures[8].DefaultPosition);
            PictureBoxAndPicture = result;
        }

        // Vrátí ID obrázku, který se aktuálně nachází na pictureBoxu identifikovaném pictureBoxID
        public int get_pictureID_on_pictureBox(int pictureBoxID)
        {
            if (pictureBoxID > 0 && pictureBoxID < 10)
            {
                return PictureBoxAndPicture[pictureBoxID];
            }
            return 0;
        }
        /* Vrátí relativní cestu k obrázku, který se právě nachází na pictureBoxID */
        public string get_path_to_picture_on_pictureBox(int pictureBoxID)
        {
            if (pictureBoxID > 0 && pictureBoxID < 10)
            {
                return ListOfPictures[PictureBoxAndPicture[pictureBoxID] - 1].Path;
            }
            return "";
        }

        // Gettery/Settery
        public bool HideHelp
        {
            get { return hideHelp; }
            set { hideHelp = value; }
        }
        public int ActPictureBoxID
        {
            get { return actPictureBoxID; }
            set { actPictureBoxID = value; }
        }

        public string DescriptionText
        {
            get { return descriptionText; }
            set { descriptionText = value; }
        }
        public PictureBox[] PictureBoxes
        {
            get { return pictureBoxes; }
            set { pictureBoxes = value; }
        }
        public Picture[] ListOfPictures
        {
            get { return listOfPictures; }
            set { listOfPictures = value; }
        }
        public Dictionary<int, int> PictureBoxAndPicture
        {
            get { return pictureBoxAndPicture; }
            set { pictureBoxAndPicture = value; }
        }

        /* Vrátí pictureBox podle jeho ID */
        public PictureBox get_pictureBox_by_id(int id) {

            if (id < 1 || id > 9)
            {
                return null;
            }
            return PictureBoxes[id - 1];
        }
        /* Vrátí obrázek podle jeho ID */
        public Picture get_picture_by_id(int id)
        {
            if (id < 1 || id > 9)
            {
                return null;
            }
            return ListOfPictures[id - 1];
        }

        public int get_neighbour_of_pictureBox(int pictureBoxID, string neighbour)
        {
            int array_index = 0;
            if (neighbour.Equals("up")) {array_index = 0;}
            else if (neighbour.Equals("right")) { array_index = 1;}
            else if (neighbour.Equals("down")) { array_index = 2;}
            else if (neighbour.Equals("left")) { array_index = 3;}
            else { return 0;}

            KeyValuePair<int, KeyValuePair<string, int>[]>[] listOfNeighbours = get_list_of_neighbours();
            return listOfNeighbours[pictureBoxID-1].Value[array_index].Value;
        }

        /* Funkce které se vykonají po kliknutí na jednotlivé pictureBoxy (změna aktuálního pictureBoxu)*/
        private void pictureBox1_Click(object sender, EventArgs e) { change_act_pictureBox(1);}
        private void pictureBox2_Click(object sender, EventArgs e) { change_act_pictureBox(2);}
        private void pictureBox3_Click(object sender, EventArgs e) { change_act_pictureBox(3);}
        private void pictureBox4_Click(object sender, EventArgs e) { change_act_pictureBox(4);}
        private void pictureBox5_Click(object sender, EventArgs e) { change_act_pictureBox(5);}
        private void pictureBox6_Click(object sender, EventArgs e) { change_act_pictureBox(6);}
        private void pictureBox7_Click(object sender, EventArgs e) { change_act_pictureBox(7);}
        private void pictureBox8_Click(object sender, EventArgs e) { change_act_pictureBox(8);}
        private void pictureBox9_Click(object sender, EventArgs e) { change_act_pictureBox(9);}

        /* Vykreslení hranice kolem aktuálního pictureBoxu */
        private void draw_border(PictureBox pictureBox, PaintEventArgs e)
        {
            using (Pen pen = new Pen(Color.Black, 10))
            {
                e.Graphics.DrawRectangle(pen, 0, 0, pictureBox.Width - 1, pictureBox.Height - 1);
            }
        }

        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {
            if (ActPictureBoxID == 1) { draw_border((PictureBox)sender, e);}
        }
        private void pictureBox2_Paint(object sender, PaintEventArgs e)
        {
            if (ActPictureBoxID == 2) { draw_border((PictureBox)sender, e);}
        }
        private void pictureBox3_Paint(object sender, PaintEventArgs e)
        {
            if (ActPictureBoxID == 3) { draw_border((PictureBox)sender, e);}
        }
        private void pictureBox4_Paint(object sender, PaintEventArgs e)
        {
            if (ActPictureBoxID == 4) { draw_border((PictureBox)sender, e); }
        }
        private void pictureBox5_Paint(object sender, PaintEventArgs e)
        {
            if (ActPictureBoxID == 5) { draw_border((PictureBox)sender, e); }
        }
        private void pictureBox6_Paint(object sender, PaintEventArgs e)
        {
            if (ActPictureBoxID == 6) { draw_border((PictureBox)sender, e); }
        }
        private void pictureBox7_Paint(object sender, PaintEventArgs e)
        {
            if (ActPictureBoxID == 7) { draw_border((PictureBox)sender, e); }
        }
        private void pictureBox8_Paint(object sender, PaintEventArgs e)
        {
            if (ActPictureBoxID == 8) { draw_border((PictureBox)sender, e); }
        }
        private void pictureBox9_Paint(object sender, PaintEventArgs e)
        {
            if (ActPictureBoxID == 9) { draw_border((PictureBox)sender, e); }
        }

        /* Zrotuje obrázek vykreslený v pictureBoxu countOfRotation-krát*/
        private void do_rotation_picture(PictureBox pictureBox, int countOfRotation)
        {
            if (countOfRotation >= 0 && countOfRotation <= 3)
            {
                for (int i = 0; i < countOfRotation; i++)
                {
                    pictureBox.Image.RotateFlip(RotateFlipType.Rotate90FlipNone);
                }
            }
            pictureBox.Refresh();
        }

        // Nastavení/změna aktuálního pictureBoxu na newActPictureBoxID
        private void change_act_pictureBox(int newActPictureBoxID) {
            PictureBox pictureBox = get_pictureBox_by_id(newActPictureBoxID);
            int actPictureID = get_pictureID_on_pictureBox(newActPictureBoxID);

            // Žádný obrázek není aktuální, nastavení nového aktuálního
            if (ActPictureBoxID == 0)
            {
                change_description_text("Nyní můžete s obrázkem rotovat nebo měnit jeho pozici pomocí tlačítek níže.");
                ActPictureBoxID = newActPictureBoxID;
                pictureBox.BorderStyle = BorderStyle.FixedSingle;
                
                helpActPictureID.Text = actPictureID.ToString();
                helpCountOfRotation.Text = get_picture_by_id(actPictureID).CountOfRotation.ToString();
            }
            // Zrušení aktuálního obrázku
            else if (ActPictureBoxID == newActPictureBoxID)
            {
                change_description_text("Vyberte aktuální obrázek tím, že na něj kliknete.");
                ActPictureBoxID = 0;
                pictureBox.BorderStyle = BorderStyle.None;

                helpActPictureID.Text = "0";
            }
            else
            {
                PictureBox oldPictureBox = get_pictureBox_by_id(ActPictureBoxID);
                oldPictureBox.BorderStyle = BorderStyle.None;
                this.ActPictureBoxID = newActPictureBoxID;
                pictureBox.BorderStyle = BorderStyle.FixedSingle;

                helpActPictureID.Text = actPictureID.ToString();
                helpCountOfRotation.Text = get_picture_by_id(actPictureID).CountOfRotation.ToString();
            }
            
        }

        private void change_description_text(string newText)
        {
            DescriptionText = newText;
            description.Text = DescriptionText;
        }

        private void rotationButton_Click(object sender, EventArgs e)
        {
            if (ActPictureBoxID != 0)
            {
                PictureBox pictureBox = get_pictureBox_by_id(ActPictureBoxID);
                int pictureID = get_pictureID_on_pictureBox(ActPictureBoxID);
                Picture picture = get_picture_by_id(pictureID);
                picture.increase_rotation();
                helpCountOfRotation.Text = get_picture_by_id(pictureID).CountOfRotation.ToString();
                do_rotation_picture((PictureBox)pictureBox, 1);
            }
        }
        /* Výměna obrázků mezi aktuálním pictureBoxem s jeho horním sousedem */
        private void upArrowButton_click(object sender, EventArgs e)
        {
            change_act_pictureBox_with("up");
        }
        /* Výměna obrázků mezi aktuálním pictureBoxem s jeho pravým sousedem */
        private void rightArrowButton_Click(object sender, EventArgs e)
        {
            change_act_pictureBox_with("right");
        }
        /* Výměna obrázků mezi aktuálním pictureBoxem s jeho dolním sousedem */
        private void downArrowButton_Click(object sender, EventArgs e)
        {
            change_act_pictureBox_with("down");
        }
        /* Výměna obrázků mezi aktuálním pictureBoxem s jeho levým sousedem */
        private void leftArrowButton_Click(object sender, EventArgs e)
        {
            change_act_pictureBox_with("left");
        }

        public void set_pictures_on_pictureBoxes(int pictureBoxID1, int newPictureID1, int pictureBoxID2, int newPictureID2)
        {
            if (pictureBoxID1 > 0 && pictureBoxID1 < 10 && newPictureID1 > 0 && newPictureID1 < 10 && pictureBoxID2 > 0 && pictureBoxID2 < 10 && newPictureID2 > 0 && newPictureID2 < 10)
            {
                PictureBoxAndPicture[pictureBoxID1] = newPictureID1;
                PictureBoxAndPicture[pictureBoxID2] = newPictureID2;
            }
        }

        /*
         Vymění obrázek, který je zobrazený v pictureBoxID1 s pictureBoxID2 a naopak
         */
        private void change_pictures_between(int pictureBoxID1, int pictureBoxID2)
        {
            int actPictureID1 = get_pictureID_on_pictureBox(pictureBoxID1);
            int actPictureID2 = get_pictureID_on_pictureBox(pictureBoxID2);
            string actPictureBoxID1Path = get_path_to_picture_on_pictureBox(pictureBoxID1);
            string actPictureBoxID2Path = get_path_to_picture_on_pictureBox(pictureBoxID2);

            PictureBox pictBox1 = get_pictureBox_by_id(pictureBoxID1);
            PictureBox pictBox2 = get_pictureBox_by_id(pictureBoxID2);

            pictBox1.Image = Image.FromFile(actPictureBoxID2Path);
            pictBox2.Image = Image.FromFile(actPictureBoxID1Path);

            /* Obrázky se zrotují do původní podoby */
            do_rotation_picture(pictBox1, get_picture_by_id(actPictureID2).CountOfRotation);
            do_rotation_picture(pictBox2, get_picture_by_id(actPictureID1).CountOfRotation);

            set_pictures_on_pictureBoxes(pictureBoxID1, actPictureID2, pictureBoxID2, actPictureID1);
        }

        /* Vymění obrázek v PictureBoxu ve směru určeným parametrem neighbourDirection ("up", "right", "down", "left")*/
        private void change_act_pictureBox_with(string neighbourDirection)
        {
            if (ActPictureBoxID != 0)
            {
                int neighbourPictureBoxID = get_neighbour_of_pictureBox(ActPictureBoxID, neighbourDirection);
                if (neighbourPictureBoxID != 0)
                {
                    change_pictures_between(ActPictureBoxID, neighbourPictureBoxID);
                    change_act_pictureBox(neighbourPictureBoxID);
                }
            }
        }

        /* Skrytí nápovědy */
        private void hide_help()
        {
            helpButton.Text = "Zobrazit nápovědu";
            helpDescription1.Visible = false;
            helpDescription2.Visible = false;
            helpDescription3.Visible = false;
            helpMap1.Visible = false;
            helpMap2.Visible = false;
            helpMap3.Visible = false;
            helpRotation1.Visible = false;
            helpRotation2.Visible = false;
            helpRotation3.Visible = false;
            helpActPictureID.Visible = false;
            helpCountOfRotation.Visible = false;
        }

        /* Odkrytí nápovědy */
        private void unhide_help()
        {
            helpButton.Text = "Skrýt nápovědu";
            helpDescription1.Visible = true;
            helpDescription2.Visible = true;
            helpDescription3.Visible = true;
            helpMap1.Visible = true;
            helpMap2.Visible = true;
            helpMap3.Visible = true;
            helpRotation1.Visible = true;
            helpRotation2.Visible = true;
            helpRotation3.Visible = true;
            helpActPictureID.Visible = true;
            helpCountOfRotation.Visible = true;
        }

        /* Funkce tlačítka na zobrazení nápovědy */
        private void helpButton_Click(object sender, EventArgs e)
        {
            if (HideHelp)
            {
                HideHelp = false;
                unhide_help();
            }
            else
            {
                HideHelp = true;
                hide_help();
            }
        }
    }
}
