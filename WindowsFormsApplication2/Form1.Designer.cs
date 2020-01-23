namespace WindowsFormsApplication2
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.FirstName = new System.Windows.Forms.TextBox();
            this.FirstNameText = new System.Windows.Forms.Label();
            this.LastName = new System.Windows.Forms.TextBox();
            this.LastNameText = new System.Windows.Forms.Label();
            this.Genre = new System.Windows.Forms.ComboBox();
            this.GenreText = new System.Windows.Forms.Label();
            this.Films = new System.Windows.Forms.ListBox();
            this.FilmText = new System.Windows.Forms.Label();
            this.SpeicalRequireText = new System.Windows.Forms.Label();
            this.SpecialRequire = new System.Windows.Forms.ListBox();
            this.Row = new System.Windows.Forms.ListBox();
            this.RowText = new System.Windows.Forms.Label();
            this.Seat = new System.Windows.Forms.ListBox();
            this.SeatText = new System.Windows.Forms.Label();
            this.SubmitButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // FirstName
            // 
            this.FirstName.Location = new System.Drawing.Point(12, 28);
            this.FirstName.Name = "FirstName";
            this.FirstName.Size = new System.Drawing.Size(188, 20);
            this.FirstName.TabIndex = 0;
            // 
            // FirstNameText
            // 
            this.FirstNameText.AutoSize = true;
            this.FirstNameText.Location = new System.Drawing.Point(12, 12);
            this.FirstNameText.Name = "FirstNameText";
            this.FirstNameText.Size = new System.Drawing.Size(57, 13);
            this.FirstNameText.TabIndex = 1;
            this.FirstNameText.Text = "First Name";
            // 
            // LastName
            // 
            this.LastName.Location = new System.Drawing.Point(12, 76);
            this.LastName.Name = "LastName";
            this.LastName.Size = new System.Drawing.Size(188, 20);
            this.LastName.TabIndex = 2;
            // 
            // LastNameText
            // 
            this.LastNameText.AutoSize = true;
            this.LastNameText.Location = new System.Drawing.Point(12, 60);
            this.LastNameText.Name = "LastNameText";
            this.LastNameText.Size = new System.Drawing.Size(58, 13);
            this.LastNameText.TabIndex = 3;
            this.LastNameText.Text = "Last Name";
            // 
            // Genre
            // 
            this.Genre.FormattingEnabled = true;
            this.Genre.Location = new System.Drawing.Point(12, 119);
            this.Genre.Name = "Genre";
            this.Genre.Size = new System.Drawing.Size(188, 21);
            this.Genre.TabIndex = 4;
            this.Genre.SelectedIndexChanged += new System.EventHandler(this.Genre_SelectedIndexChanged);
            // 
            // GenreText
            // 
            this.GenreText.AutoSize = true;
            this.GenreText.Location = new System.Drawing.Point(12, 103);
            this.GenreText.Name = "GenreText";
            this.GenreText.Size = new System.Drawing.Size(36, 13);
            this.GenreText.TabIndex = 5;
            this.GenreText.Text = "Genre";
            this.GenreText.Click += new System.EventHandler(this.label3_Click);
            // 
            // Films
            // 
            this.Films.FormattingEnabled = true;
            this.Films.Location = new System.Drawing.Point(12, 160);
            this.Films.Name = "Films";
            this.Films.Size = new System.Drawing.Size(185, 95);
            this.Films.TabIndex = 6;
            this.Films.SelectedIndexChanged += new System.EventHandler(this.Films_SelectedIndexChanged);
            // 
            // FilmText
            // 
            this.FilmText.AutoSize = true;
            this.FilmText.Location = new System.Drawing.Point(12, 144);
            this.FilmText.Name = "FilmText";
            this.FilmText.Size = new System.Drawing.Size(30, 13);
            this.FilmText.TabIndex = 7;
            this.FilmText.Text = "Films";
            // 
            // SpeicalRequireText
            // 
            this.SpeicalRequireText.AutoSize = true;
            this.SpeicalRequireText.Location = new System.Drawing.Point(12, 259);
            this.SpeicalRequireText.Name = "SpeicalRequireText";
            this.SpeicalRequireText.Size = new System.Drawing.Size(104, 13);
            this.SpeicalRequireText.TabIndex = 9;
            this.SpeicalRequireText.Text = "Special Requirments";
            this.SpeicalRequireText.Click += new System.EventHandler(this.label5_Click);
            // 
            // SpecialRequire
            // 
            this.SpecialRequire.FormattingEnabled = true;
            this.SpecialRequire.Location = new System.Drawing.Point(12, 275);
            this.SpecialRequire.Name = "SpecialRequire";
            this.SpecialRequire.Size = new System.Drawing.Size(185, 69);
            this.SpecialRequire.TabIndex = 8;
            this.SpecialRequire.SelectedIndexChanged += new System.EventHandler(this.SpecialRequire_SelectedIndexChanged);
            // 
            // Row
            // 
            this.Row.FormattingEnabled = true;
            this.Row.Location = new System.Drawing.Point(12, 362);
            this.Row.Name = "Row";
            this.Row.Size = new System.Drawing.Size(185, 69);
            this.Row.TabIndex = 10;
            // 
            // RowText
            // 
            this.RowText.AutoSize = true;
            this.RowText.Location = new System.Drawing.Point(12, 346);
            this.RowText.Name = "RowText";
            this.RowText.Size = new System.Drawing.Size(34, 13);
            this.RowText.TabIndex = 11;
            this.RowText.Text = "Rows";
            // 
            // Seat
            // 
            this.Seat.FormattingEnabled = true;
            this.Seat.Location = new System.Drawing.Point(12, 458);
            this.Seat.Name = "Seat";
            this.Seat.Size = new System.Drawing.Size(185, 69);
            this.Seat.TabIndex = 12;
            // 
            // SeatText
            // 
            this.SeatText.AutoSize = true;
            this.SeatText.Location = new System.Drawing.Point(9, 442);
            this.SeatText.Name = "SeatText";
            this.SeatText.Size = new System.Drawing.Size(34, 13);
            this.SeatText.TabIndex = 13;
            this.SeatText.Text = "Seats";
            this.SeatText.Click += new System.EventHandler(this.label1_Click);
            // 
            // SubmitButton
            // 
            this.SubmitButton.Location = new System.Drawing.Point(51, 533);
            this.SubmitButton.Name = "SubmitButton";
            this.SubmitButton.Size = new System.Drawing.Size(75, 23);
            this.SubmitButton.TabIndex = 14;
            this.SubmitButton.Text = "Submit";
            this.SubmitButton.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(220, 579);
            this.Controls.Add(this.SubmitButton);
            this.Controls.Add(this.SeatText);
            this.Controls.Add(this.Seat);
            this.Controls.Add(this.RowText);
            this.Controls.Add(this.Row);
            this.Controls.Add(this.SpeicalRequireText);
            this.Controls.Add(this.SpecialRequire);
            this.Controls.Add(this.FilmText);
            this.Controls.Add(this.Films);
            this.Controls.Add(this.GenreText);
            this.Controls.Add(this.Genre);
            this.Controls.Add(this.LastNameText);
            this.Controls.Add(this.LastName);
            this.Controls.Add(this.FirstNameText);
            this.Controls.Add(this.FirstName);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox FirstName;
        private System.Windows.Forms.Label FirstNameText;
        private System.Windows.Forms.TextBox LastName;
        private System.Windows.Forms.Label LastNameText;
        private System.Windows.Forms.ComboBox Genre;
        private System.Windows.Forms.Label GenreText;
        private System.Windows.Forms.ListBox Films;
        private System.Windows.Forms.Label FilmText;
        private System.Windows.Forms.Label SpeicalRequireText;
        private System.Windows.Forms.ListBox SpecialRequire;
        private System.Windows.Forms.ListBox Row;
        private System.Windows.Forms.Label RowText;
        private System.Windows.Forms.ListBox Seat;
        private System.Windows.Forms.Label SeatText;
        private System.Windows.Forms.Button SubmitButton;
    }
}

