namespace Pet_Age_Calculator
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
            this.btnConvert = new System.Windows.Forms.Button();
            this.btnCat = new System.Windows.Forms.Button();
            this.btnTurtle = new System.Windows.Forms.Button();
            this.Dog = new System.Windows.Forms.Button();
            this.txtAgeInDogYears = new System.Windows.Forms.TextBox();
            this.txtAgeInCatYears = new System.Windows.Forms.TextBox();
            this.txtAgeInTurtleYears = new System.Windows.Forms.TextBox();
            this.txtAgeInYears = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnConvert
            // 
            this.btnConvert.Location = new System.Drawing.Point(221, 168);
            this.btnConvert.Name = "btnConvert";
            this.btnConvert.Size = new System.Drawing.Size(75, 23);
            this.btnConvert.TabIndex = 0;
            this.btnConvert.Text = "Convert";
            this.btnConvert.UseVisualStyleBackColor = true;
            this.btnConvert.Click += new System.EventHandler(this.btnConvert_Click);
            // 
            // btnCat
            // 
            this.btnCat.Location = new System.Drawing.Point(68, 168);
            this.btnCat.Name = "btnCat";
            this.btnCat.Size = new System.Drawing.Size(75, 23);
            this.btnCat.TabIndex = 1;
            this.btnCat.Text = "Cat";
            this.btnCat.UseVisualStyleBackColor = true;
            this.btnCat.Click += new System.EventHandler(this.btnCat_Click);
            // 
            // btnTurtle
            // 
            this.btnTurtle.Location = new System.Drawing.Point(68, 245);
            this.btnTurtle.Name = "btnTurtle";
            this.btnTurtle.Size = new System.Drawing.Size(75, 23);
            this.btnTurtle.TabIndex = 2;
            this.btnTurtle.Text = "Turtle";
            this.btnTurtle.UseVisualStyleBackColor = true;
            this.btnTurtle.Click += new System.EventHandler(this.btnTurtle_Click);
            // 
            // Dog
            // 
            this.Dog.Location = new System.Drawing.Point(68, 95);
            this.Dog.Name = "Dog";
            this.Dog.Size = new System.Drawing.Size(75, 23);
            this.Dog.TabIndex = 3;
            this.Dog.Text = "Dog";
            this.Dog.UseVisualStyleBackColor = true;
            // 
            // txtAgeInDogYears
            // 
            this.txtAgeInDogYears.Location = new System.Drawing.Point(50, 124);
            this.txtAgeInDogYears.Name = "txtAgeInDogYears";
            this.txtAgeInDogYears.Size = new System.Drawing.Size(100, 23);
            this.txtAgeInDogYears.TabIndex = 4;
            // 
            // txtAgeInCatYears
            // 
            this.txtAgeInCatYears.Location = new System.Drawing.Point(50, 197);
            this.txtAgeInCatYears.Name = "txtAgeInCatYears";
            this.txtAgeInCatYears.Size = new System.Drawing.Size(100, 23);
            this.txtAgeInCatYears.TabIndex = 5;
            // 
            // txtAgeInTurtleYears
            // 
            this.txtAgeInTurtleYears.Location = new System.Drawing.Point(50, 274);
            this.txtAgeInTurtleYears.Name = "txtAgeInTurtleYears";
            this.txtAgeInTurtleYears.Size = new System.Drawing.Size(100, 23);
            this.txtAgeInTurtleYears.TabIndex = 6;
            // 
            // txtAgeInYears
            // 
            this.txtAgeInYears.Location = new System.Drawing.Point(125, 42);
            this.txtAgeInYears.Name = "txtAgeInYears";
            this.txtAgeInYears.Size = new System.Drawing.Size(100, 23);
            this.txtAgeInYears.TabIndex = 7;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(377, 328);
            this.Controls.Add(this.txtAgeInYears);
            this.Controls.Add(this.txtAgeInTurtleYears);
            this.Controls.Add(this.txtAgeInCatYears);
            this.Controls.Add(this.txtAgeInDogYears);
            this.Controls.Add(this.Dog);
            this.Controls.Add(this.btnTurtle);
            this.Controls.Add(this.btnCat);
            this.Controls.Add(this.btnConvert);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btnConvert;
        private Button btnCat;
        private Button btnTurtle;
        private Button Dog;
        private TextBox txtAgeInDogYears;
        private TextBox txtAgeInCatYears;
        private TextBox txtAgeInTurtleYears;
        private TextBox txtAgeInYears;
    }
}