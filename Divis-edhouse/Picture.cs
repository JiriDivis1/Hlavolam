namespace Divis_edhouse
{
    public class Picture
    {
        private int pictureID;              // Identifikátor obrázku (1 - 9)
        private int defaultPosition;        // ID PictureBoxu, ve kterém se má tento obrázek defaultně zobrazit
        private string path;
        private int countOfRotation;        // Počet provedených rotací s obrázkem

        public Picture () { }
        public Picture(int pictureID, int defaultPosition, string path)
        {
            PictureID = pictureID;
            DefaultPosition = defaultPosition;
            Path = path;
            CountOfRotation = 0;
        }

        // Gettery/Settery
        public int PictureID
        {
            get { return pictureID; }
            set { pictureID = value; }
        }
        public int DefaultPosition
        {
            get { return defaultPosition; }
            set { defaultPosition = value; }
        }

        public string Path
        {
            get { return path; }
            set { path = value; }
        }
        public int CountOfRotation
        {
            get { return countOfRotation; }
            set { countOfRotation = value; }
        }
        
        public void increase_rotation()
        {
            CountOfRotation = (CountOfRotation + 1) % 4;
        }
        
    }
}