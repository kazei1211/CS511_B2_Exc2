namespace Exc_2
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Application.Run(new Form1());
        }

        public static void getOptions()
        {   // laudry
            if (Form1.isChosenLaundy)
            {
                Form1.laudryPrice.Text = "100.000";
            }else if (!Form1.isChosenLaundy)
            {
                Form1.laudryPrice.Text = "0";
            }

            // ac cleaning
            if (Form1.isCHosenACcleaning)
            {
                Form1.acCleanPrice.Text = "150.000";
            }else if (!Form1.isCHosenACcleaning)
            {
                Form1.acCleanPrice.Text = "0";
            }

            // house cleaning
            if (Form1.isChosenHouseCleaning)
            {
                Form1.cleaningPrice.Text = "200.000";
            }else if (!Form1.isChosenHouseCleaning)
            {
                Form1.cleaningPrice.Text = "0";
            }

            // full cleaning
            if (Form1.isChosenFullCleaning)
            {
                Form1.fullCleanPrice.Text = "400.000";
            }else if (!Form1.isChosenFullCleaning)
            {
                Form1.fullCleanPrice.Text = "0";
            }

            // cooking
            if (Form1.isChosenCooking)
            {
                Form1.cookingPrice.Text = "300.000";
            }
            else if (!Form1.isChosenCooking)
            {
                Form1.cookingPrice.Text = "0";
            }

            // other
            if (Form1.isChosenOther)
            {
                Form1.otherPrice.Text = "500.000";
            }
            else if (!Form1.isChosenOther)
            {
                Form1.otherPrice.Text = "0";
            }
        }
        public static void getTotal()
        {
            int count = 0;
            string price;
            int total = 0;
            if (Form1.isChosenLaundy)
            {
                total += 100000;
            }
            if (Form1.isCHosenACcleaning)
            {
                total += 150000;
            }
            if (Form1.isChosenHouseCleaning)
            {
                total += 200000;
            }
            if (Form1.isChosenFullCleaning)
            {
                total += 400000;
            }
            if (Form1.isChosenCooking)
            {
                total += 300000;
            }
            if (Form1.isChosenOther)
            {
                total += 500000;
            }

            //add "." to total
            price = total.ToString();
            if(price.Length >= 7) {
                for (int i = price.Length - 1; i >= 0; i--)
                {
                    count++;
                    if (count == 3)
                    {
                        price = price.Insert(i, ".");
                        count = 0;
                    }
                }
            }
            else
            {
                price = price.Insert(price.Length - 3, ".");
            }

            Form1.totalPrice.Text = price;
            
        }
    }
}