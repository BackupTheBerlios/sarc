using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;

namespace AspectRatio1 {
	
	public class Form1 : System.Windows.Forms.Form {
		private System.Windows.Forms.RadioButton radioButton2;
		private System.Windows.Forms.RadioButton radioButton3;
		private System.Windows.Forms.RadioButton radioButton1;
		private System.Windows.Forms.RadioButton radioButton4;
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.GroupBox groupBox3;
		private System.Windows.Forms.GroupBox groupBox2;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.TextBox textBox1;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.LinkLabel linkLabel1;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.TextBox textBox3;
		private System.Windows.Forms.TextBox textBox2;
	
		private System.ComponentModel.Container components = null;

		public Form1() {
			InitializeComponent();
		}

		
		protected override void Dispose( bool disposing ) {
			if( disposing ) {
				if (components != null) {
					components.Dispose();
				}
			}
			base.Dispose( disposing );
		}

		#region Windows Form Designer generated code
		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent() {
			this.textBox2 = new System.Windows.Forms.TextBox();
			this.textBox3 = new System.Windows.Forms.TextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.linkLabel1 = new System.Windows.Forms.LinkLabel();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.groupBox3 = new System.Windows.Forms.GroupBox();
			this.button1 = new System.Windows.Forms.Button();
			this.button2 = new System.Windows.Forms.Button();
			this.radioButton4 = new System.Windows.Forms.RadioButton();
			this.radioButton1 = new System.Windows.Forms.RadioButton();
			this.radioButton3 = new System.Windows.Forms.RadioButton();
			this.radioButton2 = new System.Windows.Forms.RadioButton();
			this.groupBox1.SuspendLayout();
			this.groupBox2.SuspendLayout();
			this.SuspendLayout();
			// 
			// textBox2
			// 
			this.textBox2.Location = new System.Drawing.Point(144, 40);
			this.textBox2.Name = "textBox2";
			this.textBox2.Size = new System.Drawing.Size(80, 21);
			this.textBox2.TabIndex = 1;
			this.textBox2.Text = "";
			// 
			// textBox3
			// 
			this.textBox3.Enabled = false;
			this.textBox3.Location = new System.Drawing.Point(72, 89);
			this.textBox3.Name = "textBox3";
			this.textBox3.TabIndex = 1;
			this.textBox3.Text = "";
			// 
			// label4
			// 
			this.label4.Location = new System.Drawing.Point(176, 88);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(48, 23);
			this.label4.TabIndex = 2;
			this.label4.Text = "Ex. 1.78";
			this.label4.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
			// 
			// linkLabel1
			// 
			this.linkLabel1.Location = new System.Drawing.Point(16, 272);
			this.linkLabel1.Name = "linkLabel1";
			this.linkLabel1.Size = new System.Drawing.Size(144, 21);
			this.linkLabel1.TabIndex = 9;
			this.linkLabel1.TabStop = true;
			this.linkLabel1.Text = "All About Aspect Ratios";
			this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LinkLabel1LinkClicked);
			// 
			// label2
			// 
			this.label2.Location = new System.Drawing.Point(16, 24);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(40, 15);
			this.label2.TabIndex = 8;
			this.label2.Text = "Width";
			// 
			// label3
			// 
			this.label3.Location = new System.Drawing.Point(152, 160);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(40, 15);
			this.label3.TabIndex = 9;
			this.label3.Text = "Height";
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(112, 40);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(16, 16);
			this.label1.TabIndex = 9;
			this.label1.Text = "x";
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// textBox1
			// 
			this.textBox1.Location = new System.Drawing.Point(16, 40);
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(80, 21);
			this.textBox1.TabIndex = 0;
			this.textBox1.Text = "";
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.label4);
			this.groupBox1.Controls.Add(this.textBox3);
			this.groupBox1.Location = new System.Drawing.Point(8, 7);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(240, 121);
			this.groupBox1.TabIndex = 10;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Select aspect ratio";
			// 
			// groupBox2
			// 
			this.groupBox2.Controls.Add(this.label1);
			this.groupBox2.Controls.Add(this.label2);
			this.groupBox2.Controls.Add(this.textBox2);
			this.groupBox2.Controls.Add(this.textBox1);
			this.groupBox2.Location = new System.Drawing.Point(8, 136);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(240, 104);
			this.groupBox2.TabIndex = 11;
			this.groupBox2.TabStop = false;
			this.groupBox2.Text = "Enter either width or height";
			// 
			// groupBox3
			// 
			this.groupBox3.Location = new System.Drawing.Point(8, 248);
			this.groupBox3.Name = "groupBox3";
			this.groupBox3.Size = new System.Drawing.Size(240, 56);
			this.groupBox3.TabIndex = 12;
			this.groupBox3.TabStop = false;
			this.groupBox3.Text = "More information";
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(168, 208);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(64, 18);
			this.button1.TabIndex = 3;
			this.button1.Text = "Calculate";
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// button2
			// 
			this.button2.Location = new System.Drawing.Point(104, 208);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(56, 18);
			this.button2.TabIndex = 6;
			this.button2.Text = "Clear";
			this.button2.Click += new System.EventHandler(this.Button2Click);
			// 
			// radioButton4
			// 
			this.radioButton4.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.World, ((System.Byte)(0)));
			this.radioButton4.Location = new System.Drawing.Point(16, 96);
			this.radioButton4.Name = "radioButton4";
			this.radioButton4.Size = new System.Drawing.Size(64, 22);
			this.radioButton4.TabIndex = 8;
			this.radioButton4.Text = "Custom";
			this.radioButton4.CheckedChanged += new System.EventHandler(this.RadioButton4CheckedChanged);
			// 
			// radioButton1
			// 
			this.radioButton1.Checked = true;
			this.radioButton1.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.World, ((System.Byte)(0)));
			this.radioButton1.Location = new System.Drawing.Point(16, 22);
			this.radioButton1.Name = "radioButton1";
			this.radioButton1.Size = new System.Drawing.Size(200, 23);
			this.radioButton1.TabIndex = 4;
			this.radioButton1.TabStop = true;
			this.radioButton1.Text = "(1.33:1) 4:3 - TV";
			// 
			// radioButton3
			// 
			this.radioButton3.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.World, ((System.Byte)(0)));
			this.radioButton3.Location = new System.Drawing.Point(16, 67);
			this.radioButton3.Name = "radioButton3";
			this.radioButton3.Size = new System.Drawing.Size(200, 22);
			this.radioButton3.TabIndex = 7;
			this.radioButton3.Text = "(2.35:1) 24:10 - Anamorphic Scope";
			// 
			// radioButton2
			// 
			this.radioButton2.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.World, ((System.Byte)(0)));
			this.radioButton2.Location = new System.Drawing.Point(16, 45);
			this.radioButton2.Name = "radioButton2";
			this.radioButton2.Size = new System.Drawing.Size(200, 22);
			this.radioButton2.TabIndex = 5;
			this.radioButton2.Text = "(1.85:1) 16:9 - Academy Flat";
			// 
			// Form1
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 14);
			this.ClientSize = new System.Drawing.Size(256, 317);
			this.Controls.Add(this.radioButton4);
			this.Controls.Add(this.radioButton3);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.button2);
			this.Controls.Add(this.radioButton2);
			this.Controls.Add(this.radioButton1);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.groupBox1);
			this.Controls.Add(this.groupBox2);
			this.Controls.Add(this.linkLabel1);
			this.Controls.Add(this.groupBox3);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.Name = "Form1";
			this.Text = "Simple Aspect Ratio Calculator";
			this.groupBox1.ResumeLayout(false);
			this.groupBox2.ResumeLayout(false);
			this.ResumeLayout(false);
		}
		#endregion

	
		[STAThread]
		static void Main() {
			Application.Run(new Form1());
		}

		private double CalcHeight(double w, double ratio) {
			double h = w / ratio;
			h = (int) Math.Round(h);
			return h;
		}
		
		private double CalcWidth(double h, double ratio) {
			double w = h * ratio;
			w = (int) Math.Round(w);
			return w;
			
		}
		
		private void button1_Click(object sender, System.EventArgs e) {
			double w = 0;
			double h = 0;
			double ratio = 0;
			
			if (sender == button1) {
				if (radioButton1.Checked) {
					ratio = 1.333;
				} 
				else if (radioButton2.Checked) {
					ratio = 1.85;
				}
				else if (radioButton3.Checked) {
					ratio = 2.35;
				}
				else if (radioButton4.Checked) {
					ratio = double.Parse(textBox3.Text);
				}
				
				if (textBox1.Text != "") {
					try {
						w = int.Parse(textBox1.Text);
					} catch {
						Console.WriteLine("FEJL: textBox1.Text");
					}
					textBox2.Text = CalcHeight(w, ratio).ToString();
					textBox1.Enabled = false;
					textBox2.Enabled = false;
					button1.Enabled = false;
				}
				else if (textBox2.Text != "") {
					try {
						h = int.Parse(textBox2.Text);
					} catch {
						Console.WriteLine("FEJL: textBox2.Text");
					}
					textBox1.Text = CalcWidth(h, ratio).ToString();
					textBox1.Enabled = false;
					textBox2.Enabled = false;
					button1.Enabled = false;
				} 				
			}
		}
		
		void Button2Click(object sender, System.EventArgs e) {
			textBox1.Text = "";
			textBox2.Text = "";
			
			textBox1.Enabled = true;
			textBox2.Enabled = true;
			
			button1.Enabled = true;
		}
		
		void LinkLabel1LinkClicked(object sender, System.Windows.Forms.LinkLabelLinkClickedEventArgs e) {
			System.Diagnostics.Process.Start("http://www.thedigitalbits.com/articles/anamorphic/aspectratios/widescreenorama.html");
		}
		
		void RadioButton4CheckedChanged(object sender, System.EventArgs e) {
			if (radioButton4.Checked) {
				textBox3.Enabled = true;
			}
			
			if (radioButton4.Checked == false) {
				textBox3.Enabled = false;
				textBox3.Text = "";
			}
		}
		
	}
}
