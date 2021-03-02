
namespace TestApp
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
			this.components = new System.ComponentModel.Container();
			this.red1 = new System.Windows.Forms.NumericUpDown();
			this.green1 = new System.Windows.Forms.NumericUpDown();
			this.blue1 = new System.Windows.Forms.NumericUpDown();
			this.blue2 = new System.Windows.Forms.NumericUpDown();
			this.green2 = new System.Windows.Forms.NumericUpDown();
			this.red2 = new System.Windows.Forms.NumericUpDown();
			this.amountOfFirst = new System.Windows.Forms.NumericUpDown();
			this.timer1 = new System.Windows.Forms.Timer(this.components);
			((System.ComponentModel.ISupportInitialize)(this.red1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.green1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.blue1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.blue2)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.green2)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.red2)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.amountOfFirst)).BeginInit();
			this.SuspendLayout();
			// 
			// red1
			// 
			this.red1.Location = new System.Drawing.Point(12, 12);
			this.red1.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
			this.red1.Name = "red1";
			this.red1.Size = new System.Drawing.Size(120, 25);
			this.red1.TabIndex = 0;
			this.red1.Value = new decimal(new int[] {
            255,
            0,
            0,
            0});
			// 
			// green1
			// 
			this.green1.Location = new System.Drawing.Point(138, 12);
			this.green1.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
			this.green1.Name = "green1";
			this.green1.Size = new System.Drawing.Size(120, 25);
			this.green1.TabIndex = 1;
			// 
			// blue1
			// 
			this.blue1.Location = new System.Drawing.Point(264, 12);
			this.blue1.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
			this.blue1.Name = "blue1";
			this.blue1.Size = new System.Drawing.Size(120, 25);
			this.blue1.TabIndex = 2;
			// 
			// blue2
			// 
			this.blue2.Location = new System.Drawing.Point(264, 43);
			this.blue2.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
			this.blue2.Name = "blue2";
			this.blue2.Size = new System.Drawing.Size(120, 25);
			this.blue2.TabIndex = 5;
			this.blue2.Value = new decimal(new int[] {
            255,
            0,
            0,
            0});
			// 
			// green2
			// 
			this.green2.Location = new System.Drawing.Point(138, 43);
			this.green2.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
			this.green2.Name = "green2";
			this.green2.Size = new System.Drawing.Size(120, 25);
			this.green2.TabIndex = 4;
			// 
			// red2
			// 
			this.red2.Location = new System.Drawing.Point(12, 43);
			this.red2.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
			this.red2.Name = "red2";
			this.red2.Size = new System.Drawing.Size(120, 25);
			this.red2.TabIndex = 3;
			// 
			// amountOfFirst
			// 
			this.amountOfFirst.Location = new System.Drawing.Point(12, 74);
			this.amountOfFirst.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
			this.amountOfFirst.Name = "amountOfFirst";
			this.amountOfFirst.Size = new System.Drawing.Size(372, 25);
			this.amountOfFirst.TabIndex = 6;
			this.amountOfFirst.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
			// 
			// timer1
			// 
			this.timer1.Interval = 1;
			this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
			// 
			// Form1
			// 
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
			this.ClientSize = new System.Drawing.Size(397, 301);
			this.Controls.Add(this.amountOfFirst);
			this.Controls.Add(this.blue2);
			this.Controls.Add(this.green2);
			this.Controls.Add(this.red2);
			this.Controls.Add(this.blue1);
			this.Controls.Add(this.green1);
			this.Controls.Add(this.red1);
			this.Font = new System.Drawing.Font("Segoe UI", 10F);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.MaximizeBox = false;
			this.Name = "Form1";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "TestApp";
			((System.ComponentModel.ISupportInitialize)(this.red1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.green1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.blue1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.blue2)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.green2)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.red2)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.amountOfFirst)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.NumericUpDown red1;
		private System.Windows.Forms.NumericUpDown green1;
		private System.Windows.Forms.NumericUpDown blue1;
		private System.Windows.Forms.NumericUpDown blue2;
		private System.Windows.Forms.NumericUpDown green2;
		private System.Windows.Forms.NumericUpDown red2;
		private System.Windows.Forms.NumericUpDown amountOfFirst;
		private System.Windows.Forms.Timer timer1;
	}
}

