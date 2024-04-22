namespace RailwayReservationUI
{
    partial class Dashboard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Dashboard));
            pnlTop = new Panel();
            btnClose = new Button();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            pnlLeft = new Panel();
            btnExit = new Button();
            btnTicketBooking = new Button();
            btnRoute = new Button();
            btnTrains = new Button();
            btnEmployee = new Button();
            btnDashboard = new Button();
            pnlTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            pnlLeft.SuspendLayout();
            SuspendLayout();
            // 
            // pnlTop
            // 
            pnlTop.BackColor = SystemColors.MenuText;
            pnlTop.Controls.Add(btnClose);
            pnlTop.Controls.Add(label1);
            pnlTop.Controls.Add(pictureBox1);
            pnlTop.Dock = DockStyle.Top;
            pnlTop.Location = new Point(0, 0);
            pnlTop.Name = "pnlTop";
            pnlTop.Size = new Size(1396, 40);
            pnlTop.TabIndex = 0;
            // 
            // btnClose
            // 
            btnClose.FlatAppearance.BorderSize = 0;
            btnClose.FlatAppearance.MouseOverBackColor = Color.DarkSlateGray;
            btnClose.FlatStyle = FlatStyle.Flat;
            btnClose.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnClose.ForeColor = SystemColors.ActiveCaption;
            btnClose.Location = new Point(1366, 5);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(24, 31);
            btnClose.TabIndex = 3;
            btnClose.Text = "X";
            btnClose.UseVisualStyleBackColor = true;
            btnClose.Click += btnClose_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Nirmala UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.LightGray;
            label1.Location = new Point(43, 3);
            label1.Name = "label1";
            label1.Size = new Size(371, 25);
            label1.TabIndex = 2;
            label1.Text = "R a i l w a y  R e s e r v a t i o n  S y s t e m";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(0, 3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(52, 26);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            // 
            // pnlLeft
            // 
            pnlLeft.BackColor = Color.FromArgb(24, 30, 54);
            pnlLeft.Controls.Add(btnExit);
            pnlLeft.Controls.Add(btnTicketBooking);
            pnlLeft.Controls.Add(btnRoute);
            pnlLeft.Controls.Add(btnTrains);
            pnlLeft.Controls.Add(btnEmployee);
            pnlLeft.Controls.Add(btnDashboard);
            pnlLeft.Dock = DockStyle.Left;
            pnlLeft.Location = new Point(0, 40);
            pnlLeft.Name = "pnlLeft";
            pnlLeft.Size = new Size(195, 794);
            pnlLeft.TabIndex = 1;
            // 
            // btnExit
            // 
            btnExit.BackColor = Color.Transparent;
            btnExit.FlatAppearance.BorderColor = Color.FromArgb(255, 224, 192);
            btnExit.FlatAppearance.BorderSize = 0;
            btnExit.FlatAppearance.MouseDownBackColor = Color.DarkSlateGray;
            btnExit.FlatAppearance.MouseOverBackColor = Color.DarkSlateGray;
            btnExit.FlatStyle = FlatStyle.Flat;
            btnExit.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnExit.ForeColor = SystemColors.Control;
            btnExit.Image = (Image)resources.GetObject("btnExit.Image");
            btnExit.ImageAlign = ContentAlignment.MiddleLeft;
            btnExit.Location = new Point(3, 693);
            btnExit.Name = "btnExit";
            btnExit.Padding = new Padding(10, 0, 0, 0);
            btnExit.Size = new Size(191, 83);
            btnExit.TabIndex = 2;
            btnExit.Text = " &Exit";
            btnExit.TextAlign = ContentAlignment.MiddleLeft;
            btnExit.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnExit.UseVisualStyleBackColor = false;
            btnExit.Click += btnExit_Click;
            // 
            // btnTicketBooking
            // 
            btnTicketBooking.BackColor = Color.Transparent;
            btnTicketBooking.FlatAppearance.BorderColor = Color.FromArgb(255, 224, 192);
            btnTicketBooking.FlatAppearance.BorderSize = 0;
            btnTicketBooking.FlatAppearance.MouseDownBackColor = Color.DarkSlateGray;
            btnTicketBooking.FlatAppearance.MouseOverBackColor = Color.DarkSlateGray;
            btnTicketBooking.FlatStyle = FlatStyle.Flat;
            btnTicketBooking.Font = new Font("Century Gothic", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnTicketBooking.ForeColor = SystemColors.Control;
            btnTicketBooking.Image = (Image)resources.GetObject("btnTicketBooking.Image");
            btnTicketBooking.ImageAlign = ContentAlignment.MiddleLeft;
            btnTicketBooking.Location = new Point(-1, 411);
            btnTicketBooking.Name = "btnTicketBooking";
            btnTicketBooking.Padding = new Padding(10, 0, 0, 0);
            btnTicketBooking.Size = new Size(194, 83);
            btnTicketBooking.TabIndex = 2;
            btnTicketBooking.Text = "   Ticket &Booking";
            btnTicketBooking.TextAlign = ContentAlignment.MiddleLeft;
            btnTicketBooking.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnTicketBooking.UseVisualStyleBackColor = false;
            // 
            // btnRoute
            // 
            btnRoute.BackColor = Color.Transparent;
            btnRoute.FlatAppearance.BorderColor = Color.FromArgb(255, 224, 192);
            btnRoute.FlatAppearance.BorderSize = 0;
            btnRoute.FlatAppearance.MouseDownBackColor = Color.DarkSlateGray;
            btnRoute.FlatAppearance.MouseOverBackColor = Color.DarkSlateGray;
            btnRoute.FlatStyle = FlatStyle.Flat;
            btnRoute.Font = new Font("Century Gothic", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnRoute.ForeColor = SystemColors.Control;
            btnRoute.Image = (Image)resources.GetObject("btnRoute.Image");
            btnRoute.ImageAlign = ContentAlignment.MiddleLeft;
            btnRoute.Location = new Point(0, 325);
            btnRoute.Name = "btnRoute";
            btnRoute.Padding = new Padding(10, 0, 0, 0);
            btnRoute.Size = new Size(194, 83);
            btnRoute.TabIndex = 2;
            btnRoute.Text = "   &Route";
            btnRoute.TextAlign = ContentAlignment.MiddleLeft;
            btnRoute.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnRoute.UseVisualStyleBackColor = false;
            // 
            // btnTrains
            // 
            btnTrains.BackColor = Color.Transparent;
            btnTrains.FlatAppearance.BorderColor = Color.FromArgb(255, 224, 192);
            btnTrains.FlatAppearance.BorderSize = 0;
            btnTrains.FlatAppearance.MouseDownBackColor = Color.DarkSlateGray;
            btnTrains.FlatAppearance.MouseOverBackColor = Color.DarkSlateGray;
            btnTrains.FlatStyle = FlatStyle.Flat;
            btnTrains.Font = new Font("Century Gothic", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnTrains.ForeColor = SystemColors.Control;
            btnTrains.Image = (Image)resources.GetObject("btnTrains.Image");
            btnTrains.ImageAlign = ContentAlignment.MiddleLeft;
            btnTrains.Location = new Point(0, 238);
            btnTrains.Name = "btnTrains";
            btnTrains.Padding = new Padding(10, 0, 0, 0);
            btnTrains.Size = new Size(194, 83);
            btnTrains.TabIndex = 2;
            btnTrains.Text = "   &Trains";
            btnTrains.TextAlign = ContentAlignment.MiddleLeft;
            btnTrains.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnTrains.UseVisualStyleBackColor = false;
            // 
            // btnEmployee
            // 
            btnEmployee.BackColor = Color.Transparent;
            btnEmployee.FlatAppearance.BorderColor = Color.FromArgb(255, 224, 192);
            btnEmployee.FlatAppearance.BorderSize = 0;
            btnEmployee.FlatAppearance.MouseDownBackColor = Color.DarkSlateGray;
            btnEmployee.FlatAppearance.MouseOverBackColor = Color.DarkSlateGray;
            btnEmployee.FlatStyle = FlatStyle.Flat;
            btnEmployee.Font = new Font("Century Gothic", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnEmployee.ForeColor = SystemColors.Control;
            btnEmployee.Image = (Image)resources.GetObject("btnEmployee.Image");
            btnEmployee.ImageAlign = ContentAlignment.MiddleLeft;
            btnEmployee.Location = new Point(-2, 151);
            btnEmployee.Name = "btnEmployee";
            btnEmployee.Padding = new Padding(10, 0, 0, 0);
            btnEmployee.Size = new Size(194, 83);
            btnEmployee.TabIndex = 2;
            btnEmployee.Text = "   &Employees";
            btnEmployee.TextAlign = ContentAlignment.MiddleLeft;
            btnEmployee.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnEmployee.UseVisualStyleBackColor = false;
            // 
            // btnDashboard
            // 
            btnDashboard.BackColor = Color.Transparent;
            btnDashboard.FlatAppearance.BorderColor = Color.FromArgb(255, 224, 192);
            btnDashboard.FlatAppearance.BorderSize = 0;
            btnDashboard.FlatAppearance.MouseDownBackColor = Color.DarkSlateGray;
            btnDashboard.FlatAppearance.MouseOverBackColor = Color.DarkSlateGray;
            btnDashboard.FlatStyle = FlatStyle.Flat;
            btnDashboard.Font = new Font("Century Gothic", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnDashboard.ForeColor = SystemColors.Control;
            btnDashboard.Image = (Image)resources.GetObject("btnDashboard.Image");
            btnDashboard.ImageAlign = ContentAlignment.MiddleLeft;
            btnDashboard.Location = new Point(-1, 64);
            btnDashboard.Name = "btnDashboard";
            btnDashboard.Padding = new Padding(10, 0, 0, 0);
            btnDashboard.Size = new Size(194, 83);
            btnDashboard.TabIndex = 2;
            btnDashboard.Text = "   &Dashboard";
            btnDashboard.TextAlign = ContentAlignment.MiddleLeft;
            btnDashboard.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnDashboard.UseVisualStyleBackColor = false;
            // 
            // Dashboard
            // 
            AutoScaleMode = AutoScaleMode.None;
            BackColor = Color.FromArgb(46, 51, 73);
            ClientSize = new Size(1396, 834);
            Controls.Add(pnlLeft);
            Controls.Add(pnlTop);
            Font = new Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ForeColor = Color.FromArgb(64, 64, 64);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Dashboard";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Railway Reservation System";
            pnlTop.ResumeLayout(false);
            pnlTop.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            pnlLeft.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlTop;
        private Panel pnlLeft;
        private PictureBox pictureBox1;
        private Label label1;
        private Button btnDashboard;
        private Button btnEmployee;
        private Button btnTrains;
        private Button btnRoute;
        private Button btnTicketBooking;
        private Button btnExit;
        private Button btnClose;
    }
}
