/*
 * Created by SharpDevelop.
 * User: acer
 * Date: 31/05/2019
 * Time: 1:55
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using System.Linq;
using System.Data;
namespace MY_APLICATION
{
	/// <summary>
	/// Description of MainForm.
	/// </summary>
		
	public partial class MainForm : Form
	{
		MySqlConnection Koneksi = new MySqlConnection ("server=localhost; database=inevtaris; username=root; password=12345678");
		
		public MainForm()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
		}

		void Button1Click(object sender, EventArgs e)
		{
			DB db = new DB();
			
			string user, pass;
			
			user = textBox1.Text;
			pass = textBox2.Text;
			
			MySqlDataAdapter adapter = new MySqlDataAdapter();
			
			DataTable table = new DataTable();
			
			MySqlCommand command =new MySqlCommand("select * from petugas",db.getConnection());
			
			command.Parameters.Add("@usn", MySqlDbType.VarChar).Value = user;
			command.Parameters.Add("@pass", MySqlDbType.VarChar).Value = pass;
			
			adapter.SelectCommand = command;
			adapter.Fill(table);
			
				if (table.Rows.Count > 0)
			{
				MessageBox.Show("Login Berhasil ----> Silahkan Lanjut");
			}
			else
			{
				MessageBox.Show("Login Gagal ----> Silahkan Lengkapi / Benarkan");
			}
			
			this.Hide();
			Form1 ss = new Form1();
			ss.Show();
		}
		void Button2Click(object sender, EventArgs e)
		{
			this.Close();
		}
	
		void Button2MouseEnter(object sender, EventArgs e)
		{
			button2.ForeColor =Color.PaleVioletRed;
		}
		void Button2MouseLeave(object sender, EventArgs e)
		{
			button2.ForeColor = Color.Black;
		}
		void CheckBox1CheckedChanged(object sender, EventArgs e)
		{
			if(checkBox1.Checked)
			{
				textBox2.UseSystemPasswordChar = true;
			}
			else
			{
				textBox1.UseSystemPasswordChar = false;
			}
		}
		
	}
}
