namespace Exc_2
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            navBarPanel = new Panel();
            cartBtn = new PictureBox();
            homeBtn = new PictureBox();
            titlePanel = new Panel();
            appName = new Label();
            close = new Label();
            homePanel = new Panel();
            cartPanel = new Panel();
            otherPrice = new Label();
            acCleanPrice = new Label();
            fullCleanPrice = new Label();
            laudryPrice = new Label();
            cookingPrice = new Label();
            cleaningPrice = new Label();
            otherLabel = new Label();
            acCleaningLabel = new Label();
            fullCleanLabel = new Label();
            cleaningLabel = new Label();
            cookingLabel = new Label();
            laudryLabel = new Label();
            totalPrice = new Label();
            paymentLabel = new Label();
            label2 = new Label();
            titleCart = new Label();
            otherBtn = new PictureBox();
            cookingBtn = new PictureBox();
            fullCleanBtn = new PictureBox();
            houseCleanBtn = new PictureBox();
            laudryBtn = new PictureBox();
            acCleaningBtn = new PictureBox();
            title = new Label();
            navBarPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)cartBtn).BeginInit();
            ((System.ComponentModel.ISupportInitialize)homeBtn).BeginInit();
            titlePanel.SuspendLayout();
            homePanel.SuspendLayout();
            cartPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)otherBtn).BeginInit();
            ((System.ComponentModel.ISupportInitialize)cookingBtn).BeginInit();
            ((System.ComponentModel.ISupportInitialize)fullCleanBtn).BeginInit();
            ((System.ComponentModel.ISupportInitialize)houseCleanBtn).BeginInit();
            ((System.ComponentModel.ISupportInitialize)laudryBtn).BeginInit();
            ((System.ComponentModel.ISupportInitialize)acCleaningBtn).BeginInit();
            SuspendLayout();
            // 
            // navBarPanel
            // 
            navBarPanel.BackColor = Color.Snow;
            navBarPanel.Controls.Add(cartBtn);
            navBarPanel.Controls.Add(homeBtn);
            navBarPanel.Dock = DockStyle.Bottom;
            navBarPanel.Location = new Point(0, 673);
            navBarPanel.Name = "navBarPanel";
            navBarPanel.Size = new Size(415, 49);
            navBarPanel.TabIndex = 8;
            // 
            // cartBtn
            // 
            cartBtn.BackgroundImage = Properties.Resources.basket_cart;
            cartBtn.BackgroundImageLayout = ImageLayout.Zoom;
            cartBtn.Location = new Point(59, 4);
            cartBtn.Name = "cartBtn";
            cartBtn.Size = new Size(53, 45);
            cartBtn.TabIndex = 1;
            cartBtn.TabStop = false;
            cartBtn.Click += cartBtn_Click;
            // 
            // homeBtn
            // 
            homeBtn.BackgroundImage = Properties.Resources.Home_page;
            homeBtn.BackgroundImageLayout = ImageLayout.Stretch;
            homeBtn.Location = new Point(0, 4);
            homeBtn.Name = "homeBtn";
            homeBtn.Size = new Size(53, 45);
            homeBtn.TabIndex = 0;
            homeBtn.TabStop = false;
            homeBtn.Click += homeBtn_Click;
            // 
            // titlePanel
            // 
            titlePanel.BackColor = Color.Snow;
            titlePanel.Controls.Add(appName);
            titlePanel.Controls.Add(close);
            titlePanel.Dock = DockStyle.Top;
            titlePanel.Location = new Point(0, 0);
            titlePanel.Name = "titlePanel";
            titlePanel.Size = new Size(415, 46);
            titlePanel.TabIndex = 9;
            // 
            // appName
            // 
            appName.AutoSize = true;
            appName.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            appName.Location = new Point(12, 14);
            appName.Name = "appName";
            appName.Size = new Size(87, 17);
            appName.TabIndex = 1;
            appName.Text = "HouseKeeper";
            // 
            // close
            // 
            close.AutoSize = true;
            close.BackColor = Color.IndianRed;
            close.Font = new Font("Segoe UI Emoji", 9F, FontStyle.Regular, GraphicsUnit.Point);
            close.ForeColor = SystemColors.ButtonHighlight;
            close.Location = new Point(388, 9);
            close.Name = "close";
            close.Padding = new Padding(5);
            close.Size = new Size(24, 26);
            close.TabIndex = 0;
            close.Text = "X";
            close.Click += close_Click;
            // 
            // homePanel
            // 
            homePanel.Controls.Add(cartPanel);
            homePanel.Controls.Add(otherBtn);
            homePanel.Controls.Add(cookingBtn);
            homePanel.Controls.Add(fullCleanBtn);
            homePanel.Controls.Add(houseCleanBtn);
            homePanel.Controls.Add(laudryBtn);
            homePanel.Controls.Add(acCleaningBtn);
            homePanel.Controls.Add(title);
            homePanel.Dock = DockStyle.Fill;
            homePanel.Location = new Point(0, 46);
            homePanel.Name = "homePanel";
            homePanel.Size = new Size(415, 627);
            homePanel.TabIndex = 10;
            // 
            // cartPanel
            // 
            cartPanel.BackColor = Color.Bisque;
            cartPanel.Controls.Add(otherPrice);
            cartPanel.Controls.Add(acCleanPrice);
            cartPanel.Controls.Add(fullCleanPrice);
            cartPanel.Controls.Add(laudryPrice);
            cartPanel.Controls.Add(cookingPrice);
            cartPanel.Controls.Add(cleaningPrice);
            cartPanel.Controls.Add(otherLabel);
            cartPanel.Controls.Add(acCleaningLabel);
            cartPanel.Controls.Add(fullCleanLabel);
            cartPanel.Controls.Add(cleaningLabel);
            cartPanel.Controls.Add(cookingLabel);
            cartPanel.Controls.Add(laudryLabel);
            cartPanel.Controls.Add(totalPrice);
            cartPanel.Controls.Add(paymentLabel);
            cartPanel.Controls.Add(label2);
            cartPanel.Controls.Add(titleCart);
            cartPanel.Dock = DockStyle.Fill;
            cartPanel.Location = new Point(0, 0);
            cartPanel.Name = "cartPanel";
            cartPanel.Size = new Size(415, 627);
            cartPanel.TabIndex = 23;
            cartPanel.Visible = false;
            // 
            // otherPrice
            // 
            otherPrice.AutoSize = true;
            otherPrice.BackColor = Color.Transparent;
            otherPrice.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            otherPrice.ForeColor = Color.Blue;
            otherPrice.Location = new Point(267, 405);
            otherPrice.Name = "otherPrice";
            otherPrice.Size = new Size(23, 25);
            otherPrice.TabIndex = 15;
            otherPrice.Text = "0";
            // 
            // acCleanPrice
            // 
            acCleanPrice.AutoSize = true;
            acCleanPrice.BackColor = Color.Transparent;
            acCleanPrice.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            acCleanPrice.ForeColor = Color.Blue;
            acCleanPrice.Location = new Point(267, 350);
            acCleanPrice.Name = "acCleanPrice";
            acCleanPrice.Size = new Size(23, 25);
            acCleanPrice.TabIndex = 14;
            acCleanPrice.Text = "0";
            // 
            // fullCleanPrice
            // 
            fullCleanPrice.AutoSize = true;
            fullCleanPrice.BackColor = Color.Transparent;
            fullCleanPrice.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            fullCleanPrice.ForeColor = Color.Blue;
            fullCleanPrice.Location = new Point(267, 292);
            fullCleanPrice.Name = "fullCleanPrice";
            fullCleanPrice.Size = new Size(23, 25);
            fullCleanPrice.TabIndex = 13;
            fullCleanPrice.Text = "0";
            // 
            // laudryPrice
            // 
            laudryPrice.AutoSize = true;
            laudryPrice.BackColor = Color.Transparent;
            laudryPrice.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            laudryPrice.ForeColor = Color.Blue;
            laudryPrice.Location = new Point(267, 130);
            laudryPrice.Name = "laudryPrice";
            laudryPrice.Size = new Size(23, 25);
            laudryPrice.TabIndex = 12;
            laudryPrice.Text = "0";
            // 
            // cookingPrice
            // 
            cookingPrice.AutoSize = true;
            cookingPrice.BackColor = Color.Transparent;
            cookingPrice.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            cookingPrice.ForeColor = Color.Blue;
            cookingPrice.Location = new Point(267, 185);
            cookingPrice.Name = "cookingPrice";
            cookingPrice.Size = new Size(23, 25);
            cookingPrice.TabIndex = 11;
            cookingPrice.Text = "0";
            // 
            // cleaningPrice
            // 
            cleaningPrice.AutoSize = true;
            cleaningPrice.BackColor = Color.Transparent;
            cleaningPrice.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            cleaningPrice.ForeColor = Color.Blue;
            cleaningPrice.Location = new Point(267, 239);
            cleaningPrice.Name = "cleaningPrice";
            cleaningPrice.Size = new Size(23, 25);
            cleaningPrice.TabIndex = 10;
            cleaningPrice.Text = "0";
            // 
            // otherLabel
            // 
            otherLabel.AutoSize = true;
            otherLabel.BackColor = Color.Transparent;
            otherLabel.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            otherLabel.ForeColor = Color.Blue;
            otherLabel.Location = new Point(58, 409);
            otherLabel.Name = "otherLabel";
            otherLabel.Size = new Size(129, 25);
            otherLabel.TabIndex = 9;
            otherLabel.Text = "Dịch vụ khác:";
            // 
            // acCleaningLabel
            // 
            acCleaningLabel.AutoSize = true;
            acCleaningLabel.BackColor = Color.Transparent;
            acCleaningLabel.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            acCleaningLabel.ForeColor = Color.Blue;
            acCleaningLabel.Location = new Point(58, 350);
            acCleaningLabel.Name = "acCleaningLabel";
            acCleaningLabel.Size = new Size(166, 25);
            acCleaningLabel.TabIndex = 8;
            acCleaningLabel.Text = "Vệ sinh máy lạnh:";
            // 
            // fullCleanLabel
            // 
            fullCleanLabel.AutoSize = true;
            fullCleanLabel.BackColor = Color.Transparent;
            fullCleanLabel.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            fullCleanLabel.ForeColor = Color.Blue;
            fullCleanLabel.Location = new Point(58, 292);
            fullCleanLabel.Name = "fullCleanLabel";
            fullCleanLabel.Size = new Size(130, 25);
            fullCleanLabel.TabIndex = 7;
            fullCleanLabel.Text = "Tổng vệ sinh:";
            // 
            // cleaningLabel
            // 
            cleaningLabel.AutoSize = true;
            cleaningLabel.BackColor = Color.Transparent;
            cleaningLabel.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            cleaningLabel.ForeColor = Color.Blue;
            cleaningLabel.Location = new Point(58, 239);
            cleaningLabel.Name = "cleaningLabel";
            cleaningLabel.Size = new Size(94, 25);
            cleaningLabel.TabIndex = 6;
            cleaningLabel.Text = "Dọn dẹp:";
            // 
            // cookingLabel
            // 
            cookingLabel.AutoSize = true;
            cookingLabel.BackColor = Color.Transparent;
            cookingLabel.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            cookingLabel.ForeColor = Color.Blue;
            cookingLabel.Location = new Point(58, 185);
            cookingLabel.Name = "cookingLabel";
            cookingLabel.Size = new Size(86, 25);
            cookingLabel.TabIndex = 5;
            cookingLabel.Text = "Nấu ăn: ";
            // 
            // laudryLabel
            // 
            laudryLabel.AutoSize = true;
            laudryLabel.BackColor = Color.Transparent;
            laudryLabel.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            laudryLabel.ForeColor = Color.Blue;
            laudryLabel.Location = new Point(58, 130);
            laudryLabel.Name = "laudryLabel";
            laudryLabel.Size = new Size(75, 25);
            laudryLabel.TabIndex = 4;
            laudryLabel.Text = "Giặt ủi:";
            // 
            // totalPrice
            // 
            totalPrice.AutoSize = true;
            totalPrice.BackColor = Color.Transparent;
            totalPrice.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            totalPrice.ForeColor = Color.Blue;
            totalPrice.Location = new Point(267, 526);
            totalPrice.Name = "totalPrice";
            totalPrice.Size = new Size(23, 25);
            totalPrice.TabIndex = 3;
            totalPrice.Text = "0";
            // 
            // paymentLabel
            // 
            paymentLabel.AutoSize = true;
            paymentLabel.BackColor = Color.Transparent;
            paymentLabel.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            paymentLabel.ForeColor = Color.Blue;
            paymentLabel.Location = new Point(53, 526);
            paymentLabel.Name = "paymentLabel";
            paymentLabel.Size = new Size(123, 25);
            paymentLabel.TabIndex = 2;
            paymentLabel.Text = "Thanh toán: ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = Color.Black;
            label2.Location = new Point(53, 465);
            label2.Name = "label2";
            label2.Size = new Size(332, 15);
            label2.TabIndex = 1;
            label2.Text = "_________________________________________________________________";
            // 
            // titleCart
            // 
            titleCart.AutoSize = true;
            titleCart.BackColor = Color.Transparent;
            titleCart.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            titleCart.ForeColor = Color.Maroon;
            titleCart.Location = new Point(53, 51);
            titleCart.Name = "titleCart";
            titleCart.Size = new Size(309, 37);
            titleCart.TabIndex = 0;
            titleCart.Text = "THÔNG TIN GIỎ HÀNG";
            // 
            // otherBtn
            // 
            otherBtn.BackColor = Color.Turquoise;
            otherBtn.BorderStyle = BorderStyle.Fixed3D;
            otherBtn.Location = new Point(214, 442);
            otherBtn.Name = "otherBtn";
            otherBtn.Size = new Size(140, 120);
            otherBtn.TabIndex = 22;
            otherBtn.TabStop = false;
            otherBtn.Click += otherBtn_Click;
            // 
            // cookingBtn
            // 
            cookingBtn.BackColor = Color.Turquoise;
            cookingBtn.BorderStyle = BorderStyle.Fixed3D;
            cookingBtn.Location = new Point(58, 442);
            cookingBtn.Name = "cookingBtn";
            cookingBtn.Size = new Size(140, 120);
            cookingBtn.TabIndex = 21;
            cookingBtn.TabStop = false;
            cookingBtn.Click += cookingBtn_Click;
            // 
            // fullCleanBtn
            // 
            fullCleanBtn.BackColor = Color.Turquoise;
            fullCleanBtn.BorderStyle = BorderStyle.Fixed3D;
            fullCleanBtn.Location = new Point(214, 304);
            fullCleanBtn.Name = "fullCleanBtn";
            fullCleanBtn.Size = new Size(140, 120);
            fullCleanBtn.TabIndex = 20;
            fullCleanBtn.TabStop = false;
            fullCleanBtn.Click += fullCleanBtn_Click;
            // 
            // houseCleanBtn
            // 
            houseCleanBtn.BackColor = Color.Turquoise;
            houseCleanBtn.BorderStyle = BorderStyle.Fixed3D;
            houseCleanBtn.Location = new Point(58, 304);
            houseCleanBtn.Name = "houseCleanBtn";
            houseCleanBtn.Size = new Size(140, 120);
            houseCleanBtn.TabIndex = 19;
            houseCleanBtn.TabStop = false;
            houseCleanBtn.Click += houseCleanBtn_Click;
            // 
            // laudryBtn
            // 
            laudryBtn.BackColor = Color.Turquoise;
            laudryBtn.BorderStyle = BorderStyle.Fixed3D;
            laudryBtn.Location = new Point(58, 167);
            laudryBtn.Name = "laudryBtn";
            laudryBtn.Size = new Size(140, 120);
            laudryBtn.TabIndex = 18;
            laudryBtn.TabStop = false;
            laudryBtn.Click += laudryBtn_Click;
            // 
            // acCleaningBtn
            // 
            acCleaningBtn.BackColor = Color.Turquoise;
            acCleaningBtn.BorderStyle = BorderStyle.Fixed3D;
            acCleaningBtn.Location = new Point(214, 167);
            acCleaningBtn.Name = "acCleaningBtn";
            acCleaningBtn.Size = new Size(140, 120);
            acCleaningBtn.TabIndex = 17;
            acCleaningBtn.TabStop = false;
            acCleaningBtn.Click += acCleaningBtn_Click;
            // 
            // title
            // 
            title.AutoSize = true;
            title.BackColor = Color.Transparent;
            title.Font = new Font("Cambria Math", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            title.Location = new Point(79, 32);
            title.Name = "title";
            title.Size = new Size(258, 151);
            title.TabIndex = 16;
            title.Text = "GIÚP VIỆC NHÀ";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightSalmon;
            ClientSize = new Size(415, 722);
            Controls.Add(homePanel);
            Controls.Add(titlePanel);
            Controls.Add(navBarPanel);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            navBarPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)cartBtn).EndInit();
            ((System.ComponentModel.ISupportInitialize)homeBtn).EndInit();
            titlePanel.ResumeLayout(false);
            titlePanel.PerformLayout();
            homePanel.ResumeLayout(false);
            homePanel.PerformLayout();
            cartPanel.ResumeLayout(false);
            cartPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)otherBtn).EndInit();
            ((System.ComponentModel.ISupportInitialize)cookingBtn).EndInit();
            ((System.ComponentModel.ISupportInitialize)fullCleanBtn).EndInit();
            ((System.ComponentModel.ISupportInitialize)houseCleanBtn).EndInit();
            ((System.ComponentModel.ISupportInitialize)laudryBtn).EndInit();
            ((System.ComponentModel.ISupportInitialize)acCleaningBtn).EndInit();
            ResumeLayout(false);
        }

        #endregion
        //navBarPanel
        private Panel navBarPanel;
        private PictureBox homeBtn;
        private PictureBox cartBtn;

        //titlePanel
        private Panel titlePanel;
        private Label appName;
        private Label close;

        //homePanel
        public PictureBox otherBtn;
        public PictureBox cookingBtn;
        public PictureBox fullCleanBtn;
        public PictureBox houseCleanBtn;
        public PictureBox laudryBtn;
        public PictureBox acCleaningBtn;
        private Label title;

        //cartPanel
        private Label titleCart;
        private Label paymentLabel;
        private Label label2;
        private Label otherLabel;
        private Label acCleaningLabel;
        private Label fullCleanLabel;
        private Label cleaningLabel;
        private Label cookingLabel;
        private Label laudryLabel;
        public static Panel homePanel;
        public static Panel cartPanel;
        public static Label totalPrice;
        public static Label otherPrice;
        public static Label acCleanPrice;
        public static Label fullCleanPrice;
        public static Label laudryPrice;
        public static Label cookingPrice;
        public static Label cleaningPrice;
    }
}
