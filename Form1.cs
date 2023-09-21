namespace Exc_2
{
    public partial class Form1 : Form
    {
        List<Panel> panelList = new List<Panel>();
        int index = 1;
        public static bool isChosenLaundy = false;
        public static bool isCHosenACcleaning = false;
        public static bool isChosenHouseCleaning = false;
        public static bool isChosenFullCleaning = false;
        public static bool isChosenCooking = false;
        public static bool isChosenOther = false;
        public Form1()
        {
            InitializeComponent();
        }

        //Tab navigation
        private void homeBtn_Click(object sender, EventArgs e)
        {
            cartBtn.BackColor = Color.Snow;
            homeBtn.BackColor = Color.DarkGreen;
            panelList[1].Visible = false;
            panelList[0].Visible = true;
            panelList[0].BringToFront();
        }

        private void cartBtn_Click(object sender, EventArgs e)
        {
            homeBtn.BackColor = Color.Snow;
            cartBtn.BackColor = Color.DarkGreen;
            panelList[1].Visible = true;
            panelList[1].BringToFront();
            Program.getOptions();
            Program.getTotal();
        }

        private void close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //Home panel
        private void laudryBtn_Click(object sender, EventArgs e)
        {
            if (!isChosenLaundy)
            {
                laudryBtn.BackColor = Color.Teal;
                isChosenLaundy = true;
            }
            else if (isChosenLaundy)
            {
                laudryBtn.BackColor = Color.Turquoise;
                isChosenLaundy = false;
            }
        }

        private void acCleaningBtn_Click(object sender, EventArgs e)
        {
            if (!isCHosenACcleaning)
            {
                acCleaningBtn.BackColor = Color.Teal;
                isCHosenACcleaning = true;
            }
            else if (isCHosenACcleaning)
            {
                acCleaningBtn.BackColor = Color.Turquoise;
                isCHosenACcleaning = false;
            }
        }

        private void houseCleanBtn_Click(object sender, EventArgs e)
        {
            if (!isChosenHouseCleaning)
            {
                houseCleanBtn.BackColor = Color.Teal;
                isChosenHouseCleaning = true;
            }
            else if (isChosenHouseCleaning)
            {
                houseCleanBtn.BackColor = Color.Turquoise;
                isChosenHouseCleaning = false;
            }
        }

        private void fullCleanBtn_Click(object sender, EventArgs e)
        {
            if (!isChosenFullCleaning)
            {
                fullCleanBtn.BackColor = Color.Teal;
                isChosenFullCleaning = true;
            }
            else if (isChosenFullCleaning)
            {
                fullCleanBtn.BackColor = Color.Turquoise;
                isChosenFullCleaning = false;
            }
        }

        private void cookingBtn_Click(object sender, EventArgs e)
        {
            if (!isChosenCooking)
            {
                cookingBtn.BackColor = Color.Teal;
                isChosenCooking = true;
            }
            else if (isChosenCooking)
            {
                cookingBtn.BackColor = Color.Turquoise;
                isChosenCooking = false;
            }
        }

        private void otherBtn_Click(object sender, EventArgs e)
        {
            if (!isChosenOther)
            {
                otherBtn.BackColor = Color.Teal;
                isChosenOther = true;
            }
            else if (isChosenOther)
            {
                otherBtn.BackColor = Color.Turquoise;
                isChosenOther = false;
            }

        }


        //Form 1 load
        private void Form1_Load(object sender, EventArgs e)
        {
            panelList.Add(homePanel);
            panelList.Add(cartPanel);
            panelList[0].BringToFront();
        }
    }
}