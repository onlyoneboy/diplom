using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication2
{
	public partial class Form1 : Form
	{
		private DateTime now = DateTime.Now;
		private int p = 11;
		private int alpha = 7;
		private int temp = 0;
		private int temp2 = 0;
		private int x = 3;
		private int y = 9;
		private int alX = 2;
		private int alY = 8;
		private Random rand = new Random();
		private IContainer components = (IContainer)null;
		private Label label1;
		private Label label2;
		private Label label3;
		private Button button1;
		private Label label4;
		private TextBox textBox1;
		private TextBox textBox2;
		private Label label5;
		private Button button2;
		private Label label6;
		private Label label7;
		private Label label8;
		private Button button3;
		private Label label9;
		private Label label10;
		private Label label11;
		private Label label12;
		private Label label13;
		private TextBox textBox3;
		private Button button4;
		private Button button5;
		private Button button6;
		private Button button7;
		private TextBox textBox4;
		private Label label14;
		private Label label15;
		private Label label16;
		private Label label17;
		private Label label18;
		private Label label19;
		private Label label20;
		private Label label21;
		private Label label22;
		private Label label23;
		private Label label24;
		private Button button8;
		private OpenFileDialog openFileDialog1;
		private Button button9;
		private TextBox textBox5;
		private Label label25;
		private TextBox textBox6;
		private Label label26;
		private Button button10;
		private SaveFileDialog saveFileDialog1;

		public Form1()
		{
			InitializeComponent();
		}

		public bool IsPrime( int number )
		{
			if ( number <= 1 || number % 2 == 0 )
				return false;
			for ( int index = 3; (double)index <= Math.Sqrt( (double)number ); ++index )
			{
				if ( number % index == 0 )
					return false;
			}
			return true;
		}

		public int power( int a, int b, int n )
		{
			int num1 = a;
			int num2 = num1;
			for ( int index1 = 1; index1 < b; ++index1 )
			{
				for ( int index2 = 1; index2 < a; ++index2 )
				{
					num2 += num1;
					if ( num2 >= n )
						num2 -= n;
				}
				num1 = num2;
			}
			return num1;
		}

		public bool ReadFromFile( out int Fp, out int Falpha, out int Fx, out int Fy )
		{
			Fp = -100;
			Falpha = -100;
			Fx = -100;
			Fy = -100;
			this.openFileDialog1.InitialDirectory = "c:\\";
			this.openFileDialog1.Filter = "txt files (*.txt)|*.txt";
			this.openFileDialog1.RestoreDirectory = true;
			DialogResult dialogResult;
			if ( ( dialogResult = this.openFileDialog1.ShowDialog() ) == DialogResult.OK )
			{
				try
				{
					Stream stream;
					if ( ( stream = this.openFileDialog1.OpenFile() ) != null )
					{
						using ( stream )
						{
							using ( StreamReader streamReader = new StreamReader( stream ) )
							{
								if ( !int.TryParse( streamReader.ReadLine(), out Fp ) || !this.IsPrime( Fp ) || Fp < 1 || ( !int.TryParse( streamReader.ReadLine(), out Falpha ) || Falpha < 2 || Falpha > Fp - 2 ) || ( !int.TryParse( streamReader.ReadLine(), out Fx ) || Fx < 1 || Fx > Fp - 2 ) )
									return false;
								if ( !int.TryParse( streamReader.ReadLine(), out Fy ) || Fy < 1 || Fy > Fp - 2 )
									return false;
							}
						}
					}
				}
				catch ( Exception ex )
				{
					int num = (int)MessageBox.Show( "Ошибка! Не удалось прочитать файл с диска. Оригинальный код ошибки: " + ex.Message );
				}
			}
			if ( dialogResult != DialogResult.Cancel )
				return true;
			Fp = -500;
			Falpha = -666;
			return false;
		}

		public bool WriteToFile()
		{
			this.saveFileDialog1.InitialDirectory = Directory.GetCurrentDirectory();
			this.saveFileDialog1.Filter = "txt files (*.txt)|*.txt";
			this.saveFileDialog1.RestoreDirectory = true;
			this.now = DateTime.Now;
			this.saveFileDialog1.FileName = this.now.ToString( "dd.MM HH-mm-ss" ) + " log.txt";
			if ( this.saveFileDialog1.ShowDialog() == DialogResult.OK )
			{
				try
				{
					Stream stream;
					if ( ( stream = this.saveFileDialog1.OpenFile() ) != null )
					{
						using ( stream )
						{
							using ( StreamWriter streamWriter = new StreamWriter( stream ) )
								streamWriter.Write( this.textBox5.Text );
						}
					}
				}
				catch ( Exception ex )
				{
					int num = (int)MessageBox.Show( "Ошибка! Не удалось получить доступ к файлу на диске. Оригинальный код ошибки: " + ex.Message );
				}
			}
			return true;
		}

		private void label3_Click( object sender, EventArgs e )
		{
		}

		private void label4_Click( object sender, EventArgs e )
		{
		}

		private void button2_Click( object sender, EventArgs e )
		{
			do
				;
			while ( !this.IsPrime( this.p = this.rand.Next( 200, 20000 ) ) );
			this.alpha = this.rand.Next( 2, this.p - 1 );
			this.label4.Text = "p = " + this.p.ToString();
			this.label5.Text = "α = " + this.alpha.ToString();
			this.now = DateTime.Now;
			this.textBox5.Text = this.now.ToString() + " - Автоматически сгенерированы p и α. p = " + this.p.ToString() + ", α = " + this.alpha.ToString() + "\r\n" + this.textBox5.Text;
			if ( this.x > this.p - 2 || this.y > this.p - 2 )
			{
				int num = (int)MessageBox.Show( "Секретные ключи не подходят к новому числу p! x и y был присвоен 0, задайте им новые значения в диапазоне от 2 до p-2." );
				this.x = 0;
				this.y = 0;
				this.label15.Text = "α^x mod p = ";
				this.label16.Text = " = α^y mod p";
				this.label13.Text = "x = " + this.x.ToString();
				this.label14.Text = "y = " + this.y.ToString();
				this.label21.Text = "(α ^ y) ^ x = ";
				this.label22.Text = "(α ^ x) ^ y = ";
				this.now = DateTime.Now;
				this.textBox5.Text = this.now.ToString() + " - После изменения p и α ключам x и y был присвоен 0, так как они оказались больше чем p-2\r\n" + this.textBox5.Text;
			}
			else
			{
				this.alX = this.power( this.alpha, this.x, this.p );
				this.label15.Text = "α^x mod p = " + this.alX.ToString();
				this.alY = this.power( this.alpha, this.y, this.p );
				this.label21.Text = "(α ^ y) ^ x = ";
				this.label22.Text = "(α ^ x) ^ y = ";
				this.label16.Text = this.alY.ToString() + " = α^y mod p";
				this.now = DateTime.Now;
				this.textBox5.Text = this.now.ToString() + " - После изменения p и α были автоматически пересчитаны выражения α^x mod p и α^y mod p.\r\n" + this.textBox5.Text;
			}
		}

		private void button1_Click( object sender, EventArgs e )
		{
			if ( !int.TryParse( this.textBox1.Text, out this.temp ) || !int.TryParse( this.textBox2.Text, out this.temp2 ) || ( !this.IsPrime( this.temp ) || this.temp2 < 2 ) || this.temp2 > this.temp - 2 )
			{
				int num1 = (int)MessageBox.Show( "Данные некорректны. Проверьте ввод" );
			}
			else
			{
				this.p = (int)Convert.ToInt16( this.textBox1.Text );
				this.alpha = (int)Convert.ToInt16( this.textBox2.Text );
				this.label4.Text = "p = " + this.p.ToString();
				this.label5.Text = "α = " + this.alpha.ToString();
				if ( this.x > this.p - 2 || this.y > this.p - 2 )
				{
					int num2 = (int)MessageBox.Show( "Секретные ключи не подходят к новому числу p! x и y был присвоен 0, задайте им новые значения в диапазоне от 2 до p-2." );
					this.x = 0;
					this.y = 0;
					this.label15.Text = "α^x mod p = ";
					this.label16.Text = " = α^y mod p";
					this.label13.Text = "x = " + this.x.ToString();
					this.label14.Text = "y = " + this.y.ToString();
					this.label21.Text = "(α ^ y) ^ x = ";
					this.label22.Text = "(α ^ x) ^ y = ";
					this.now = DateTime.Now;
					this.textBox5.Text = this.now.ToString() + " - После изменения p и α ключам x и y был присвоен 0, так как они оказались больше чем p-2\r\n" + this.textBox5.Text;
				}
				else
				{
					this.alX = this.power( this.alpha, this.x, this.p );
					this.label15.Text = "α^x mod p = " + this.alX.ToString();
					this.alY = this.power( this.alpha, this.y, this.p );
					this.label16.Text = this.alY.ToString() + " = α^y mod p";
					this.label21.Text = "(α ^ y) ^ x = ";
					this.label22.Text = "(α ^ x) ^ y = ";
					this.now = DateTime.Now;
					this.textBox5.Text = this.now.ToString() + " - После изменения p и α были автоматически пересчитаны выражения α^x mod p и α^y mod p.\r\n" + this.textBox5.Text;
				}
			}
		}

		private void button5_Click( object sender, EventArgs e )
		{
			this.x = this.rand.Next( 1, this.p - 1 );
			this.label13.Text = "x = " + this.x.ToString();
			this.now = DateTime.Now;
			this.textBox5.Text = this.now.ToString() + " - Автоматически сгенерирован секретный ключ x. x = " + this.x.ToString() + "\r\n" + this.textBox5.Text;
			this.alX = this.power( this.alpha, this.x, this.p );
			this.label15.Text = "α^x mod p = " + this.alX.ToString();
			this.label21.Text = "(α ^ y) ^ x = ";
			this.label22.Text = "(α ^ x) ^ y = ";
		}

		private void button6_Click( object sender, EventArgs e )
		{
			this.y = this.rand.Next( 1, this.p - 1 );
			this.label14.Text = "y = " + this.y.ToString();
			this.now = DateTime.Now;
			this.textBox5.Text = this.now.ToString() + " - Автоматически сгенерирован секретный ключ y. y = " + this.y.ToString() + "\r\n" + this.textBox5.Text;
			this.alY = this.power( this.alpha, this.y, this.p );
			this.label16.Text = this.alY.ToString() + " = α^y mod p";
			this.label21.Text = "(α ^ y) ^ x = ";
			this.label22.Text = "(α ^ x) ^ y = ";
		}

		private void button4_Click( object sender, EventArgs e )
		{
			if ( !int.TryParse( this.textBox3.Text, out this.temp ) || this.temp < 1 || this.temp > this.p - 2 )
			{
				int num = (int)MessageBox.Show( "Данные некорректны. Проверьте ввод" );
			}
			else
			{
				this.x = (int)Convert.ToInt16( this.textBox3.Text );
				this.label13.Text = "x = " + this.x.ToString();
				this.alX = this.power( this.alpha, this.x, this.p );
				this.label15.Text = "α^x mod p = " + this.alX.ToString();
				this.label21.Text = "(α ^ y) ^ x = ";
				this.label22.Text = "(α ^ x) ^ y = ";
			}
		}

		private void button7_Click( object sender, EventArgs e )
		{
			if ( !int.TryParse( this.textBox4.Text, out this.temp ) || this.temp < 1 || this.temp > this.p - 2 )
			{
				int num = (int)MessageBox.Show( "Данные некорректны. Проверьте ввод" );
			}
			else
			{
				this.y = (int)Convert.ToInt16( this.textBox4.Text );
				this.label14.Text = "y = " + this.y.ToString();
				this.alY = this.power( this.alpha, this.y, this.p );
				this.label16.Text = this.alY.ToString() + " = α^y mod p";
				this.label21.Text = "(α ^ y) ^ x = ";
				this.label22.Text = "(α ^ x) ^ y = ";
			}
		}

		private void Form1_Load( object sender, EventArgs e )
		{
		}

		private void label17_Click( object sender, EventArgs e )
		{
		}

		private void button8_Click( object sender, EventArgs e )
		{
			if ( this.x == 0 || this.y == 0 )
			{
				int num1 = (int)MessageBox.Show( "Вы не задали новые секретные ключи после изменения p и alpha!" );
			}
			else
			{
				Label label1 = this.label21;
				string str1 = "(α ^ y) ^ x = ";
				int num2 = this.power( this.alY, this.x, this.p );
				string str2 = num2.ToString();
				string str3 = str1 + str2;
				label1.Text = str3;
				Label label2 = this.label22;
				string str4 = "(α ^ x) ^ y = ";
				num2 = this.power( this.alX, this.y, this.p );
				string str5 = num2.ToString();
				string str6 = str4 + str5;
				label2.Text = str6;
				this.now = DateTime.Now;
				TextBox textBox = this.textBox5;
				string[] strArray1 = new string[5];
				strArray1[0] = this.now.ToString();
				strArray1[1] = " - Вычислен общий секретный ключ K = ";
				string[] strArray2 = strArray1;
				int index = 2;
				num2 = this.power( this.alY, this.x, this.p );
				string str7 = num2.ToString();
				strArray2[index] = str7;
				strArray1[3] = "\r\n";
				strArray1[4] = this.textBox5.Text;
				string str8 = string.Concat( strArray1 );
				textBox.Text = str8;
			}
		}

		private void button9_Click( object sender, EventArgs e )
		{
			this.textBox5.Text = "";
		}

		private void button3_Click( object sender, EventArgs e )
		{
			int Fp;
			int Falpha;
			int Fx;
			int Fy;
			if ( this.ReadFromFile( out Fp, out Falpha, out Fx, out Fy ) )
			{
				this.textBox6.Text = this.openFileDialog1.FileName;
				this.p = Fp;
				this.alpha = Falpha;
				this.x = Fx;
				this.y = Fy;
				this.label4.Text = "p = " + this.p.ToString();
				this.label5.Text = "α = " + this.alpha.ToString();
				this.label13.Text = "x = " + this.x.ToString();
				this.label14.Text = "y = " + this.y.ToString();
				this.alX = this.power( this.alpha, this.x, this.p );
				this.alY = this.power( this.alpha, this.y, this.p );
				this.label15.Text = "α^x mod p = " + this.alX.ToString();
				this.label16.Text = this.alY.ToString() + " = α^y mod p";
				this.label21.Text = "(α ^ y) ^ x = " + this.power( this.alY, this.x, this.p ).ToString();
				this.label22.Text = "(α ^ x) ^ y = " + this.power( this.alX, this.y, this.p ).ToString();
				this.now = DateTime.Now;
				this.textBox5.Text = this.now.ToString() + " - Успешно импортированы данные из файла " + this.openFileDialog1.FileName.ToString() + "\r\n" + this.textBox5.Text;
				this.now = DateTime.Now;
				this.textBox5.Text = this.now.ToString() + " - p = " + this.p.ToString() + ", α = " + this.alpha.ToString() + ", x = " + this.x.ToString() + ", y = " + this.y.ToString() + "\r\n" + this.textBox5.Text;
				this.now = DateTime.Now;
				this.textBox5.Text = this.now.ToString() + " - Вычислен общий секретный ключ K = " + this.power( this.alY, this.x, this.p ).ToString() + "\r\n" + this.textBox5.Text;
			}
			else
			{
				if ( Fp == -500 && Falpha == -666 )
					return;
				int num = (int)MessageBox.Show( "Ошибка! Данные не были прочитаны из файла. \r\nУбедитесь, что он имеет следующую структуру: \r\np - простое число\r\nα - число в промежутке от 2 до p-2, включая концы\r\nx - число в промежутке от 1 до p-2, включая концы\r\ny - число в промежутке от 1 до p-2, включая концы\r\nНа каждой строке должно быть только число! Буквы и спец. символы не требуются" );
				this.now = DateTime.Now;
				this.textBox5.Text = this.now.ToString() + " - Ошибка при попытке импорта данных из файла " + this.openFileDialog1.FileName.ToString() + "\r\n" + this.textBox5.Text;
			}
		}

		private void button10_Click( object sender, EventArgs e )
		{
			if ( this.WriteToFile() )
			{
				this.now = DateTime.Now;
				this.textBox5.Text = this.now.ToString() + " - Лог успешно экспортирован в файл " + this.saveFileDialog1.FileName.ToString() + "\r\n" + this.textBox5.Text;
                MessageBox.Show("Лог экспортирован удачно","OK",MessageBoxButtons.OK,MessageBoxIcon.Information);
			}
			else
			{
				this.now = DateTime.Now;
				this.textBox5.Text = this.now.ToString() + " - Не удалось экспортировать лог программы в файл " + this.saveFileDialog1.FileName.ToString() + "\r\n" + this.textBox5.Text;
                MessageBox.Show("Не удалось экспортировать лог","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
			}
		}
	}
}
