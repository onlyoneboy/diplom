using System;
using System.Drawing;
using System.Windows.Forms;
namespace WindowsFormsApplication2
{
	partial class Form1
	{
		/// <summary>
		/// Освободить все используемые ресурсы.
		/// </summary>
		/// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
		protected override void Dispose( bool disposing )
		{
			if ( disposing && this.components != null )
				this.components.Dispose();
			base.Dispose( disposing );
		}

		#region Код, автоматически созданный конструктором форм Windows

		/// <summary>
		/// Обязательный метод для поддержки конструктора - не изменяйте
		/// содержимое данного метода при помощи редактора кода.
		/// </summary>
		private void InitializeComponent()
		{
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.label24 = new System.Windows.Forms.Label();
            this.button8 = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.button9 = new System.Windows.Forms.Button();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.label25 = new System.Windows.Forms.Label();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.label26 = new System.Windows.Forms.Label();
            this.button10 = new System.Windows.Forms.Button();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(190, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(644, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Протокол открытого распределения ключей Диффи-Хеллмана";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(12, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(209, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "1. Предварительный этап";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(12, 75);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(650, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Выбираются и публикуются простое число p и генератор α для Zp* , причем 2≤α≤p-2";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(227, 101);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(118, 49);
            this.button1.TabIndex = 3;
            this.button1.Text = "Применить изменения";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.ForeColor = System.Drawing.Color.Blue;
            this.label4.Location = new System.Drawing.Point(12, 100);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(21, 24);
            this.label4.TabIndex = 4;
            this.label4.Text = "p";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(121, 102);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 5;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(121, 128);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.ForeColor = System.Drawing.Color.Blue;
            this.label5.Location = new System.Drawing.Point(12, 126);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(21, 24);
            this.label5.TabIndex = 6;
            this.label5.Text = "α";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(351, 102);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(118, 48);
            this.button2.TabIndex = 8;
            this.button2.Text = "Сгенерировать новые значения";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(12, 182);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(130, 20);
            this.label6.TabIndex = 9;
            this.label6.Text = "2. Рабочий этап";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.Location = new System.Drawing.Point(177, 214);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(23, 24);
            this.label7.TabIndex = 10;
            this.label7.Text = "A";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label8.Location = new System.Drawing.Point(696, 214);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(22, 24);
            this.label8.TabIndex = 11;
            this.label8.Text = "B";
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button3.Location = new System.Drawing.Point(741, 44);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(217, 89);
            this.button3.TabIndex = 12;
            this.button3.Text = "Взять все значения из файла и показать результат";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label9.Location = new System.Drawing.Point(12, 238);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(374, 20);
            this.label9.TabIndex = 13;
            this.label9.Text = "Выбирает случайный секретный ключ x, 1≤x≤p-2";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label10.Location = new System.Drawing.Point(501, 238);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(374, 20);
            this.label10.TabIndex = 14;
            this.label10.Text = "Выбирает случайный секретный ключ y, 1≤y≤p-2";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label11.Location = new System.Drawing.Point(12, 310);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(275, 20);
            this.label11.TabIndex = 15;
            this.label11.Text = "Вычисляет α^x mod p и отсылает B";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label12.Location = new System.Drawing.Point(191, 341);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(448, 20);
            this.label12.TabIndex = 16;
            this.label12.Text = "---------------------------------------------------------------------------------" +
    "----->";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label13.ForeColor = System.Drawing.Color.Blue;
            this.label13.Location = new System.Drawing.Point(12, 268);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(20, 24);
            this.label13.TabIndex = 17;
            this.label13.Text = "x";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(121, 273);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(100, 20);
            this.textBox3.TabIndex = 18;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(227, 258);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(118, 49);
            this.button4.TabIndex = 19;
            this.button4.Text = "Применить изменения";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(351, 258);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(118, 49);
            this.button5.TabIndex = 20;
            this.button5.Text = "Сгенерировать новое значение";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(840, 257);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(118, 50);
            this.button6.TabIndex = 24;
            this.button6.Text = "Сгенерировать новое значение";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(716, 257);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(118, 49);
            this.button7.TabIndex = 23;
            this.button7.Text = "Применить изменения";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(610, 273);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(100, 20);
            this.textBox4.TabIndex = 22;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label14.ForeColor = System.Drawing.Color.Blue;
            this.label14.Location = new System.Drawing.Point(501, 268);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(19, 24);
            this.label14.TabIndex = 21;
            this.label14.Text = "y";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label15.ForeColor = System.Drawing.Color.Blue;
            this.label15.Location = new System.Drawing.Point(12, 337);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(99, 24);
            this.label15.TabIndex = 25;
            this.label15.Text = "α^x mod p";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label16.ForeColor = System.Drawing.Color.Blue;
            this.label16.Location = new System.Drawing.Point(777, 384);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(98, 24);
            this.label16.TabIndex = 28;
            this.label16.Text = "α^y mod p";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label17.Location = new System.Drawing.Point(317, 388);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(448, 20);
            this.label17.TabIndex = 27;
            this.label17.Text = "<--------------------------------------------------------------------------------" +
    "------";
            this.label17.Click += new System.EventHandler(this.label17_Click);
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label18.Location = new System.Drawing.Point(683, 364);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(273, 20);
            this.label18.TabIndex = 26;
            this.label18.Text = "Вычисляет α^y mod p и отсылает a";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label19.Location = new System.Drawing.Point(12, 416);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(295, 20);
            this.label19.TabIndex = 29;
            this.label19.Text = "Вычисляет (α^y)^x mod p и получает K";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label20.Location = new System.Drawing.Point(663, 416);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(295, 20);
            this.label20.TabIndex = 30;
            this.label20.Text = "Вычисляет (α^x)^y mod p и получает K";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label21.ForeColor = System.Drawing.Color.Blue;
            this.label21.Location = new System.Drawing.Point(289, 456);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(70, 24);
            this.label21.TabIndex = 31;
            this.label21.Text = "(α^y)^x";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label22.ForeColor = System.Drawing.Color.Blue;
            this.label22.Location = new System.Drawing.Point(520, 456);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(70, 24);
            this.label22.TabIndex = 32;
            this.label22.Text = "(α^x)^y";
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label23.Location = new System.Drawing.Point(466, 456);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(32, 33);
            this.label23.TabIndex = 33;
            this.label23.Text = "=";
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label24.Location = new System.Drawing.Point(31, 523);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(950, 25);
            this.label24.TabIndex = 34;
            this.label24.Text = "Итог: стороны получили общий секретный ключ K с использованием открытого канала с" +
    "вязи";
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(423, 416);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(118, 24);
            this.button8.TabIndex = 35;
            this.button8.Text = "Вычислить";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // button9
            // 
            this.button9.Location = new System.Drawing.Point(36, 690);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(131, 35);
            this.button9.TabIndex = 36;
            this.button9.Text = "Очистить лог";
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Click += new System.EventHandler(this.button9_Click);
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(36, 603);
            this.textBox5.Multiline = true;
            this.textBox5.Name = "textBox5";
            this.textBox5.ReadOnly = true;
            this.textBox5.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox5.Size = new System.Drawing.Size(945, 77);
            this.textBox5.TabIndex = 37;
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Location = new System.Drawing.Point(36, 584);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(131, 13);
            this.label25.TabIndex = 38;
            this.label25.Text = "Лог работы программы:";
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(741, 140);
            this.textBox6.Name = "textBox6";
            this.textBox6.ReadOnly = true;
            this.textBox6.Size = new System.Drawing.Size(215, 20);
            this.textBox6.TabIndex = 39;
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Location = new System.Drawing.Point(657, 143);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(78, 13);
            this.label26.TabIndex = 40;
            this.label26.Text = "Выбран файл:";
            // 
            // button10
            // 
            this.button10.Location = new System.Drawing.Point(840, 686);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(141, 39);
            this.button10.TabIndex = 41;
            this.button10.Text = "Экспорт лога в файл";
            this.button10.UseVisualStyleBackColor = true;
            this.button10.Click += new System.EventHandler(this.button10_Click);
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(1005, 733);
            this.Controls.Add(this.button10);
            this.Controls.Add(this.label26);
            this.Controls.Add(this.textBox6);
            this.Controls.Add(this.label25);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.button9);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.label24);
            this.Controls.Add(this.label23);
            this.Controls.Add(this.label22);
            this.Controls.Add(this.label21);
            this.Controls.Add(this.label20);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Diffie-Helman";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		#endregion
	}
}

