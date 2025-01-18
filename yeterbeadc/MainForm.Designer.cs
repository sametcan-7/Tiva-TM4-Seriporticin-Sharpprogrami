/*
 * Created by SharpDevelop.
 * User: Samet CAN
 * Date: 16.12.2024
 * Time: 01:27
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace yeterbeadc
{
	partial class MainForm
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.Button BtnGonder;
		private System.Windows.Forms.Button BtnMetingonder;
		private System.Windows.Forms.TextBox textcom;
		private System.Windows.Forms.TextBox textBaudrate;
		private System.Windows.Forms.TextBox textDataBits;
		private System.Windows.Forms.TextBox textSaatgönder;
		private System.Windows.Forms.TextBox textLcdsaat;
		private System.Windows.Forms.TextBox textADC;
		private System.Windows.Forms.TextBox textMetingönder;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private System.IO.Ports.SerialPort serialPort1;
		
		/// <summary>
		/// Disposes resources used by the form.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing) {
				if (components != null) {
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}
		
		/// <summary>
		/// This method is required for Windows Forms designer support.
		/// Do not change the method contents inside the source code editor. The Forms designer might
		/// not be able to load this method if it was changed manually.
		/// </summary>
		private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			this.button1 = new System.Windows.Forms.Button();
			this.button2 = new System.Windows.Forms.Button();
			this.BtnGonder = new System.Windows.Forms.Button();
			this.BtnMetingonder = new System.Windows.Forms.Button();
			this.textcom = new System.Windows.Forms.TextBox();
			this.textBaudrate = new System.Windows.Forms.TextBox();
			this.textDataBits = new System.Windows.Forms.TextBox();
			this.textSaatgönder = new System.Windows.Forms.TextBox();
			this.textLcdsaat = new System.Windows.Forms.TextBox();
			this.textADC = new System.Windows.Forms.TextBox();
			this.textMetingönder = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
			this.SuspendLayout();
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(377, 49);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(70, 43);
			this.button1.TabIndex = 0;
			this.button1.Text = "AÇ";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.Button1Click);
			// 
			// button2
			// 
			this.button2.Location = new System.Drawing.Point(377, 121);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(69, 45);
			this.button2.TabIndex = 1;
			this.button2.Text = "KAPA";
			this.button2.UseVisualStyleBackColor = true;
			this.button2.Click += new System.EventHandler(this.Button2Click);
			// 
			// BtnGonder
			// 
			this.BtnGonder.Location = new System.Drawing.Point(394, 259);
			this.BtnGonder.Name = "BtnGonder";
			this.BtnGonder.Size = new System.Drawing.Size(79, 64);
			this.BtnGonder.TabIndex = 2;
			this.BtnGonder.Text = "başlat";
			this.BtnGonder.UseVisualStyleBackColor = true;
			this.BtnGonder.Click += new System.EventHandler(this.BtnGonderClick);
			// 
			// BtnMetingonder
			// 
			this.BtnMetingonder.Location = new System.Drawing.Point(390, 421);
			this.BtnMetingonder.Name = "BtnMetingonder";
			this.BtnMetingonder.Size = new System.Drawing.Size(83, 73);
			this.BtnMetingonder.TabIndex = 3;
			this.BtnMetingonder.Text = "gönder";
			this.BtnMetingonder.UseVisualStyleBackColor = true;
			this.BtnMetingonder.Click += new System.EventHandler(this.BtnMetingonderClick);
			// 
			// textcom
			// 
			this.textcom.Location = new System.Drawing.Point(42, 49);
			this.textcom.Name = "textcom";
			this.textcom.Size = new System.Drawing.Size(183, 20);
			this.textcom.TabIndex = 4;
			this.textcom.Text = "COM yaz";
			this.textcom.TextChanged += new System.EventHandler(this.TextcomTextChanged);
			// 
			// textBaudrate
			// 
			this.textBaudrate.Location = new System.Drawing.Point(36, 103);
			this.textBaudrate.Name = "textBaudrate";
			this.textBaudrate.Size = new System.Drawing.Size(188, 20);
			this.textBaudrate.TabIndex = 5;
			this.textBaudrate.Text = "Baudrate gir";
			// 
			// textDataBits
			// 
			this.textDataBits.Location = new System.Drawing.Point(36, 159);
			this.textDataBits.Name = "textDataBits";
			this.textDataBits.Size = new System.Drawing.Size(188, 20);
			this.textDataBits.TabIndex = 6;
			this.textDataBits.Text = "Databits gir";
			// 
			// textSaatgönder
			// 
			this.textSaatgönder.Location = new System.Drawing.Point(129, 281);
			this.textSaatgönder.Name = "textSaatgönder";
			this.textSaatgönder.Size = new System.Drawing.Size(170, 20);
			this.textSaatgönder.TabIndex = 7;
			// 
			// textLcdsaat
			// 
			this.textLcdsaat.Location = new System.Drawing.Point(130, 343);
			this.textLcdsaat.Name = "textLcdsaat";
			this.textLcdsaat.Size = new System.Drawing.Size(169, 20);
			this.textLcdsaat.TabIndex = 8;
			// 
			// textADC
			// 
			this.textADC.Location = new System.Drawing.Point(130, 400);
			this.textADC.Name = "textADC";
			this.textADC.Size = new System.Drawing.Size(183, 20);
			this.textADC.TabIndex = 9;
			// 
			// textMetingönder
			// 
			this.textMetingönder.Location = new System.Drawing.Point(130, 445);
			this.textMetingönder.Name = "textMetingönder";
			this.textMetingönder.Size = new System.Drawing.Size(178, 20);
			this.textMetingönder.TabIndex = 10;
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(31, 288);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(94, 13);
			this.label1.TabIndex = 11;
			this.label1.Text = "saat başlangıç";
			// 
			// label2
			// 
			this.label2.Location = new System.Drawing.Point(33, 339);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(91, 24);
			this.label2.TabIndex = 12;
			this.label2.Text = "lcd ssaat";
			// 
			// label3
			// 
			this.label3.Location = new System.Drawing.Point(35, 400);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(89, 34);
			this.label3.TabIndex = 13;
			this.label3.Text = "adc veri";
			// 
			// label4
			// 
			this.label4.Location = new System.Drawing.Point(31, 448);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(99, 31);
			this.label4.TabIndex = 14;
			this.label4.Text = "gönder metin";
			// 
			// serialPort1
			// 
			this.serialPort1.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.SerialPort1DataReceived);
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(514, 517);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.textMetingönder);
			this.Controls.Add(this.textADC);
			this.Controls.Add(this.textLcdsaat);
			this.Controls.Add(this.textSaatgönder);
			this.Controls.Add(this.textDataBits);
			this.Controls.Add(this.textBaudrate);
			this.Controls.Add(this.textcom);
			this.Controls.Add(this.BtnMetingonder);
			this.Controls.Add(this.BtnGonder);
			this.Controls.Add(this.button2);
			this.Controls.Add(this.button1);
			this.Name = "MainForm";
			this.Text = "yeterbeadc";
			this.ResumeLayout(false);
			this.PerformLayout();

		}
	}
}
