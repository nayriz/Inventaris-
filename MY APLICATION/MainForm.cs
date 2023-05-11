/*
 * Created by SharpDevelop.
 * User: acer
 * Date: 07/06/2019
 * Time: 9:07
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
	/// Description of Form1.
	/// </summary>
	public partial class Form1 : Form
	{
		public Form1()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		void Button3Click(object sender, EventArgs e)
		{
			
			this.WindowState =FormWindowState.Maximized;
		}
		void Button1Click(object sender, EventArgs e)
		{
			this.Close();
		}
		
	}
}
