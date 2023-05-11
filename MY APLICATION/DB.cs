/*
 * Created by SharpDevelop.
 * User: acer
 * Date: 01/06/2019
 * Time: 4:54
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using MySql.Data.MySqlClient;

namespace MY_APLICATION
{
	/// <summary>
	/// Description of DB.
	/// </summary>
	public class DB
	{
		MySqlConnection Koneksi = new MySqlConnection ("server=localhost; database=inventaris; username=root; password =12345678");
	
		//buka Koneksi DB
		public void OpenConnection()
		{
			if( Koneksi.State == System.Data.ConnectionState.Closed)
			{
				Koneksi.Open();				 
			}
		}
		
		//Tutup Koneksi DB
		public void CloseConnection()
		{
			if( Koneksi.State == System.Data.ConnectionState.Open)
			{
				Koneksi.Close();
			}
			
		}
		
		//function buat mengembalikan koneksi
		public MySqlConnection getConnection()
		{
			return Koneksi;
		}
	}
}
