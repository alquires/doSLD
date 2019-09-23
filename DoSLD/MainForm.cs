/*
 * Created by SharpDevelop.
 * User: embrapa
 * Date: 18/03/2015
 * Time: 09:14
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using System.Data.Odbc;
using System.Data.OleDb;
using System.IO;
using System.Data;

namespace DoSLD
{
	/// <summary>
	/// Description of MainForm.
	/// </summary>
	public partial class MainForm : Form
	{
		bool recarrega = true;
		DataTable dt = new DataTable();
		Font Fonte = null;

		
		public MainForm()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		public static string SelectedTable = string.Empty;
		private void Importar()
		{
			if (txtNomeArquivo.Text.Trim() != string.Empty)
			{
				try
				{
					string firstPlan = Planilhas(txtNomeArquivo.Text);
					dt = GetDataTableDBF(txtNomeArquivo.Text, firstPlan);
					gdvDados.DataSource = dt.DefaultView;
					preencheComboBox();
				}
				catch (Exception ex)
				{
					MessageBox.Show(ex.Message.ToString());
				}
			}
			recarrega = true;
		}
		public static DataTable GetDataTableDBF(string strFileName, string PrimeiraPlanilha)
		{
			try
			{
				OleDbConnection conn = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + strFileName + ";Extended Properties=\"Excel 12.0 Xml;HDR=YES\";");
				conn.Open();
				string strConsulta = "SELECT * FROM ["+PrimeiraPlanilha+"]";
				OleDbDataAdapter adapter = new OleDbDataAdapter(strConsulta,conn);
				System.Data.DataSet ds = new System.Data.DataSet();
				adapter.Fill(ds);
				conn.Close();
				return ds.Tables[0];
			}
			catch (Exception e)
			{
				MessageBox.Show("GetDataTableDBF 12 - " + e.Message);
			}
			
			try
			{
				OleDbConnection conn = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.13.0;Data Source=" + strFileName + ";Extended Properties=\"Excel 12.0 Xml;HDR=YES\";");
				conn.Open();
				string strConsulta = "SELECT * FROM ["+PrimeiraPlanilha+"]";
				OleDbDataAdapter adapter = new OleDbDataAdapter(strConsulta,conn);
				System.Data.DataSet ds = new System.Data.DataSet();
				adapter.Fill(ds);
				conn.Close();
				return ds.Tables[0];
			}
			catch (Exception e)
			{
				MessageBox.Show("GetDataTableDBF 13 - " + e.Message);
			}
			try
			{
				OleDbConnection conn = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.14.0;Data Source=" + strFileName + ";Extended Properties=\"Excel 12.0 Xml;HDR=YES\";");
				conn.Open();
				string strConsulta = "SELECT * FROM ["+PrimeiraPlanilha+"]";
				OleDbDataAdapter adapter = new OleDbDataAdapter(strConsulta,conn);
				System.Data.DataSet ds = new System.Data.DataSet();
				adapter.Fill(ds);
				conn.Close();
				return ds.Tables[0];
			}
			catch (Exception e)
			{
				MessageBox.Show("GetDataTableDBF 14 - " + e.Message);
			}
			try
			{
				OleDbConnection conn = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.15.0;Data Source=" + strFileName + ";Extended Properties=\"Excel 12.0 Xml;HDR=YES\";");
				conn.Open();
				string strConsulta = "SELECT * FROM ["+PrimeiraPlanilha+"]";
				OleDbDataAdapter adapter = new OleDbDataAdapter(strConsulta,conn);
				System.Data.DataSet ds = new System.Data.DataSet();
				adapter.Fill(ds);
				conn.Close();
				return ds.Tables[0];
			}
			catch (Exception e)
			{
				MessageBox.Show("GetDataTableDBF 15 - " + e.Message);
			}
			MessageBox.Show("GetDataTableDBF não deu em nada");
			return null;
		}
		/// <summary>
		/// Retorna o nome das planilhas existentes dentro de um arquivo excel
		/// </summary>
		/// <param name="strFileName">Nome do arquivo excel</param>
		/// <returns></returns>
		public string Planilhas(string strFileName)
		{
			DataTable dt = null;
			try
			{
				recarrega = false;
				OleDbConnection conn = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.15.0;Data Source=" + strFileName + ";Extended Properties=\"Excel 12.0 Xml;HDR=YES\";");
				conn.Open();
				dt = conn.GetOleDbSchemaTable(OleDbSchemaGuid.Tables, null);
				conn.Close();
			}
			catch (Exception a)
			{
				MessageBox.Show("15 - " + a.Message);
				try
				{
					recarrega = false;
					OleDbConnection conn = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.14.0;Data Source=" + strFileName + ";Extended Properties=\"Excel 12.0 Xml;HDR=YES\";");
					conn.Open();
					dt = conn.GetOleDbSchemaTable(OleDbSchemaGuid.Tables, null);
					conn.Close();
				}
				catch (Exception b)
				{
					MessageBox.Show("14 - " + b.Message);
					try
					{
						recarrega = false;
						OleDbConnection conn = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.13.0;Data Source=" + strFileName + ";Extended Properties=\"Excel 12.0 Xml;HDR=YES\";");
						conn.Open();
						dt = conn.GetOleDbSchemaTable(OleDbSchemaGuid.Tables, null);
						conn.Close();
					}
					catch (Exception c)
					{
						MessageBox.Show("13 - " + c.Message);
						try
						{
							recarrega = false;
							OleDbConnection conn = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + strFileName + ";Extended Properties=\"Excel 12.0 Xml;HDR=YES\";");
							conn.Open();
							dt = conn.GetOleDbSchemaTable(OleDbSchemaGuid.Tables, null);
							conn.Close();
						}
						catch (Exception d)
						{
							MessageBox.Show("12 - " + d.Message);
							
						}
					}
				}
				
			}
			//teste
			
			//dt = conn.GetOleDbSchemaTable(OleDbSchemaGuid.Tables, null);
			//string[] planExcel = new string[dt.Rows.Count];
			
			string PFolhaExcel = "";
			string[] folhaExcel = null;
			if (dt != null)
			{
				folhaExcel = new string[dt.Rows.Count];
				int i = 0;
				// Adiciona os nomes na array
				foreach(DataRow row in dt.Rows)
				{
					folhaExcel[i] = row["TABLE_NAME"].ToString();
					i++;
				}
				comboBox1.Items.AddRange(folhaExcel);
				PFolhaExcel = comboBox1.Items[0].ToString();
				comboBox1.SelectedIndex = 0;
			}
			else
			{
				return null;
			}
			return PFolhaExcel;
		}
		public void SistemaCores()
		{
			if(rdbRGBA.Checked == true)
			{
				
				//POLígono
				lblRCHHex.Text = "R";
				lblGMS.Text = "G";
				lblBYV.Text = "B";
				lblAK.Text = "";
				
				cbbRCHHex.Enabled = true;
				cbbRCHHex.Visible = true;
				cbbGMS.Enabled = true;
				cbbGMS.Visible = true;
				cbbBYV.Enabled = true;
				cbbBYV.Visible = true;
				cbbAK.Visible = false;
				cbbAK.Enabled = false;
				
				//Contorno
				lblRCHHex_C.Text = "R";
				lblGMS_C.Text = "G";
				lblBYV_C.Text = "B";
				lblAK_C.Text = "";

				cbbRCHHex_C.Enabled = true;
				cbbRCHHex_C.Visible = true;
				cbbGMS_C.Enabled = true;
				cbbGMS_C.Visible = true;
				cbbBYV_C.Enabled = true;
				cbbBYV_C.Visible = true;
				cbbAK_C.Visible = false;
				cbbAK_C.Enabled = false;
				
				
				//Label
				lblRCHHex_L.Text = "R";
				lblGMS_L.Text = "G";
				lblBYV_L.Text = "B";
				lblAK_L.Text = "";

				cbbRCHHex_L.Enabled = true;
				cbbRCHHex_L.Visible = true;
				cbbGMS_L.Enabled = true;
				cbbGMS_L.Visible = true;
				cbbBYV_L.Enabled = true;
				cbbBYV_L.Visible = true;
				cbbAK_L.Visible = false;
				cbbAK_L.Enabled = false;
				
				
				ccbTag.Visible = false;
				ccbTag.Enabled = false;
			}
			if(rdbCMYK.Checked == true)
			{
				lblRCHHex.Text = "C";
				lblGMS.Text = "M";
				lblBYV.Text = "Y";
				lblAK.Text = "K";
				
				cbbRCHHex.Enabled = true;
				cbbRCHHex.Visible = true;
				cbbGMS.Enabled = true;
				cbbGMS.Visible = true;
				cbbBYV.Enabled = true;
				cbbBYV.Visible = true;
				cbbAK.Visible = true;
				cbbAK.Enabled = true;
				
				
				//Contorno
				lblRCHHex_C.Text = "C";
				lblGMS_C.Text = "M";
				lblBYV_C.Text = "Y";
				lblAK_C.Text = "K";
				
				cbbRCHHex_C.Enabled = true;
				cbbRCHHex_C.Visible = true;
				cbbGMS_C.Enabled = true;
				cbbGMS_C.Visible = true;
				cbbBYV_C.Enabled = true;
				cbbBYV_C.Visible = true;
				cbbAK_C.Visible = true;
				cbbAK_C.Enabled = true;
				
				
				//label
				lblRCHHex_L.Text = "C";
				lblGMS_L.Text = "M";
				lblBYV_L.Text = "Y";
				lblAK_L.Text = "K";
				
				cbbRCHHex_L.Enabled = true;
				cbbRCHHex_L.Visible = true;
				cbbGMS_L.Enabled = true;
				cbbGMS_L.Visible = true;
				cbbBYV_L.Enabled = true;
				cbbBYV_L.Visible = true;
				cbbAK_L.Visible = true;
				cbbAK_L.Enabled = true;
				
				
				
				ccbTag.Visible = false;
				ccbTag.Enabled = false;
			}
			if(rdbHSV.Checked == true)
			{
				lblRCHHex.Text = "H";
				lblGMS.Text = "S";
				lblBYV.Text = "U";
				lblAK.Text = "";
				
				cbbRCHHex.Enabled = true;
				cbbRCHHex.Visible = true;
				cbbGMS.Enabled = true;
				cbbGMS.Visible = true;
				cbbBYV.Enabled = true;
				cbbBYV.Visible = true;
				cbbAK.Visible = false;
				cbbAK.Enabled = false;
				
				//Contorno
				lblRCHHex_C.Text = "H";
				lblGMS_C.Text = "S";
				lblBYV_C.Text = "U";
				lblAK_C.Text = "";
				
				cbbRCHHex_C.Enabled = true;
				cbbRCHHex_C.Visible = true;
				cbbGMS_C.Enabled = true;
				cbbGMS_C.Visible = true;
				cbbBYV_C.Enabled = true;
				cbbBYV_C.Visible = true;
				cbbAK_C.Visible = false;
				cbbAK_C.Enabled = false;
				
				
				//Label
				lblRCHHex_L.Text = "H";
				lblGMS_L.Text = "S";
				lblBYV_L.Text = "U";
				lblAK_L.Text = "";
				
				cbbRCHHex_L.Enabled = true;
				cbbRCHHex_L.Visible = true;
				cbbGMS_L.Enabled = true;
				cbbGMS_L.Visible = true;
				cbbBYV_L.Enabled = true;
				cbbBYV_L.Visible = true;
				cbbAK_L.Visible = false;
				cbbAK_L.Enabled = false;
				
				
				ccbTag.Visible = false;
				ccbTag.Enabled = false;
			}
			if(rdbHex.Checked == true)
			{
				lblRCHHex.Text = "Hex";
				lblGMS.Text = "";
				lblBYV.Text = "";
				lblAK.Text = "";
				
				cbbRCHHex.Enabled = true;
				cbbRCHHex.Visible = true;
				cbbGMS.Enabled = false;
				cbbGMS.Visible = false;
				cbbBYV.Enabled = false;
				cbbBYV.Visible = false;
				cbbAK.Visible = false;
				cbbAK.Enabled = false;
				
				
				//Contorno
				lblRCHHex_C.Text = "Hex";
				lblGMS_C.Text = "";
				lblBYV_C.Text = "";
				lblAK_C.Text = "";
				
				cbbRCHHex_C.Enabled = true;
				cbbRCHHex_C.Visible = true;
				cbbGMS_C.Enabled = false;
				cbbGMS_C.Visible = false;
				cbbBYV_C.Enabled = false;
				cbbBYV_C.Visible = false;
				cbbAK_C.Visible = false;
				cbbAK_C.Enabled = false;
				
				
				//Label
				lblRCHHex_L.Text = "Hex";
				lblGMS_L.Text = "";
				lblBYV_L.Text = "";
				lblAK_L.Text = "";
				
				cbbRCHHex_L.Enabled = true;
				cbbRCHHex_L.Visible = true;
				cbbGMS_L.Enabled = false;
				cbbGMS_L.Visible = false;
				cbbBYV_L.Enabled = false;
				cbbBYV_L.Visible = false;
				cbbAK_L.Visible = false;
				cbbAK_L.Enabled = false;
				
				
				
				ccbTag.Visible = true;
				ccbTag.Enabled = true;
			}
		}
		public string RGB2Hex(int R, int G, int B)
		{
			
			Color cor = Color.FromArgb(R,G,B);
			string CorHex = "#" + cor.R.ToString("X2") + cor.G.ToString("X2") + cor.B.ToString("X2");
			return CorHex;
		}
		public string CMYK2Hex(int C, int M, int Y, int K)
		{
			int R = 255*(1-C)*(1-K);
			int G = 255*(1-M)*(1-K);
			int B = 255*(1-Y)*(1-K);
			
			return RGB2Hex(R, G,B);
		}
		public void preencheComboBox()
		{
			string [] valores = new string [dt.Columns.Count];
			
			for(int a = 0; a < dt.Columns.Count; a++)
			{
				valores[a] = dt.Columns[a].ColumnName;
			}
			
			cbbRotulo.Items.Clear();
			cbbClasse.Items.Clear();
			cbbLabel.Items.Clear();
			
			cbbRCHHex.Items.Clear();
			cbbGMS.Items.Clear();
			cbbBYV.Items.Clear();
			cbbAK.Items.Clear();
			
			cbbRCHHex_C.Items.Clear();
			cbbGMS_C.Items.Clear();
			cbbBYV_C.Items.Clear();
			cbbAK_C.Items.Clear();
			
			cbbRCHHex_L.Items.Clear();
			cbbGMS_L.Items.Clear();
			cbbBYV_L.Items.Clear();
			cbbAK_L.Items.Clear();
			
			
			
			cbbRotulo.Items.AddRange(valores);
			cbbClasse.Items.AddRange(valores);
			cbbLabel.Items.AddRange(valores);
			
			cbbRCHHex.Items.AddRange(valores);
			cbbGMS.Items.AddRange(valores);
			cbbBYV.Items.AddRange(valores);
			cbbAK.Items.AddRange(valores);
			
			cbbRCHHex_C.Items.AddRange(valores);
			cbbGMS_C.Items.AddRange(valores);
			cbbBYV_C.Items.AddRange(valores);
			cbbAK_C.Items.AddRange(valores);
			
			cbbRCHHex_L.Items.AddRange(valores);
			cbbGMS_L.Items.AddRange(valores);
			cbbBYV_L.Items.AddRange(valores);
			cbbAK_L.Items.AddRange(valores);
			
		}
		public string montaSLD()
		{

			//cria string com cabeçalho
			string SLD =
				"<?xml version=\"1.0\" encoding=\"UTF-8\"?>\r\n" +
				"<sld:StyledLayerDescriptor xmlns:sld=\"http://www.opengis.net/sld\" xmlns=\"http://www.opengis.net/ogc\" xmlns:gml=\"http://www.opengis.net/gml\" xmlns:ogc=\"http://www.opengis.net/ogc\" xmlns:xsi=\"http://www.w3.org/2001/XMLSchema-instance\" version=\"1.0.0\" xsi:schemaLocation=\"http://www.opengis.net/sld http://schemas.opengis.net/sld/1.0.0/StyledLayerDescriptor.xsd\">\r\n" +
				"   <!--\r\n" +
				"	Produzido com doSLD.exe\r\n"+
				"	Hilton Luís Ferraz da Silveira\r\n"+
				"	Embrapa Solos - UEP Recife\r\n"+
				"	-->\r\n" +
				"	<sld:NamedLayer>\r\n" +
				"		<sld:Name>"+ comboBox1.SelectedItem.ToString().Split('$')[0] +"</sld:Name>\r\n" +//"		<sld:Name>0</sld:Name>\r\n" +
				"		<sld:UserStyle>" +
				"			<!--\r\n" +
				"			style should be applied on layer \"0\", reference the style by it's name \"propertyIsEqualTo\" \r\n" +
				"			-->\r\n" +
				"			<sld:Name>"+ comboBox1.SelectedItem.ToString().Split('$')[0] +"</sld:Name>\r\n" + //"			<sld:Name>propertyIsEqualTo</sld:Name>\r\n" +
				"			<sld:Title>"+ textBox2.Text +"</sld:Title>\r\n" + //"			<sld:Title>propertyIsEqualTo</sld:Title>\r\n" +
				"			<sld:FeatureTypeStyle>\r\n";
			
			try
			{
				
				
				//monta o miolo
				for (int a = 0; a < dt.Rows.Count; a++)
				{

					int nunColClasse = dt.Columns[cbbClasse.SelectedItem.ToString()].Ordinal;
					int nunColRotLeg = dt.Columns[cbbRotulo.SelectedItem.ToString()].Ordinal;
					int nunColRotPol = dt.Columns[cbbLabel.SelectedItem.ToString()].Ordinal;
					int nunColLabel = dt.Columns[cbbLabel.SelectedItem.ToString()].Ordinal;
					
					string PropertyName = cbbClasse.SelectedItem.ToString();
					string LabelPropertyName = cbbLabel.SelectedItem.ToString();
					string Literal = dt.Rows[a].ItemArray[nunColRotLeg].ToString();
					//string LegLabel = dt.Rows[a].ItemArray[nunColRotLeg].ToString();
					//string TituloLeg = dt.Rows[a].ItemArray[nunColRotLeg].ToString();
					
					string HexCorPol = "";
					string HexCorLin = "";
					string HexCorLabel = "";
					
					
					if(rdbRGBA.Checked)
					{
						int intRCHHex = dt.Columns[cbbRCHHex.SelectedItem.ToString()].Ordinal;
						int intGMS =  dt.Columns[cbbGMS.SelectedItem.ToString()].Ordinal;
						int intBYV = dt.Columns[cbbBYV.SelectedItem.ToString()].Ordinal;
						//int intAK = dt.Columns[cbbAK.SelectedItem.ToString()].Ordinal;
						
						int intRCHHex_L = dt.Columns[cbbRCHHex_L.SelectedItem.ToString()].Ordinal;
						int intGMS_L =  dt.Columns[cbbGMS_L.SelectedItem.ToString()].Ordinal;
						int intBYV_L = dt.Columns[cbbBYV_L.SelectedItem.ToString()].Ordinal;
						//int intAK_L = dt.Columns[cbbAK_L.SelectedItem.ToString()].Ordinal;
						
						int intRCHHex_C = dt.Columns[cbbRCHHex_C.SelectedItem.ToString()].Ordinal;
						int intGMS_C =  dt.Columns[cbbGMS_C.SelectedItem.ToString()].Ordinal;
						int intBYV_C = dt.Columns[cbbBYV_C.SelectedItem.ToString()].Ordinal;
						//int intAK_C = dt.Columns[cbbAK_C.SelectedItem.ToString()].Ordinal;
						
						int Red = Int32.Parse(dt.Rows[a].ItemArray[intRCHHex].ToString());
						int Green = Int32.Parse(dt.Rows[a].ItemArray[intGMS].ToString());
						int Blue = Int32.Parse(dt.Rows[a].ItemArray[intBYV].ToString());
						HexCorPol = RGB2Hex(Red, Green, Blue);
						
						Red = Int32.Parse(dt.Rows[a].ItemArray[intRCHHex_C].ToString());
						Green = Int32.Parse(dt.Rows[a].ItemArray[intGMS_C].ToString());
						Blue = Int32.Parse(dt.Rows[a].ItemArray[intBYV_C].ToString());
						HexCorLin = RGB2Hex(Red, Green, Blue);
						
						Red = Int32.Parse(dt.Rows[a].ItemArray[intRCHHex_L].ToString());
						Green = Int32.Parse(dt.Rows[a].ItemArray[intGMS_L].ToString());
						Blue = Int32.Parse(dt.Rows[a].ItemArray[intBYV_L].ToString());
						HexCorLabel = RGB2Hex(Red, Green, Blue);
						
						
					}
					else if(rdbCMYK.Checked)
					{
						int intRCHHex = dt.Columns[cbbRCHHex.SelectedItem.ToString()].Ordinal;
						int intGMS =  dt.Columns[cbbGMS.SelectedItem.ToString()].Ordinal;
						int intBYV = dt.Columns[cbbBYV.SelectedItem.ToString()].Ordinal;
						int intAK = dt.Columns[cbbAK.SelectedItem.ToString()].Ordinal;
						
						int intRCHHex_L = dt.Columns[cbbRCHHex_L.SelectedItem.ToString()].Ordinal;
						int intGMS_L =  dt.Columns[cbbGMS_L.SelectedItem.ToString()].Ordinal;
						int intBYV_L = dt.Columns[cbbBYV_L.SelectedItem.ToString()].Ordinal;
						int intAK_L = dt.Columns[cbbAK_L.SelectedItem.ToString()].Ordinal;
						
						int intRCHHex_C = dt.Columns[cbbRCHHex_C.SelectedItem.ToString()].Ordinal;
						int intGMS_C =  dt.Columns[cbbGMS_C.SelectedItem.ToString()].Ordinal;
						int intBYV_C = dt.Columns[cbbBYV_C.SelectedItem.ToString()].Ordinal;
						int intAK_C = dt.Columns[cbbAK_C.SelectedItem.ToString()].Ordinal;
						
						int Cyan = Int32.Parse(dt.Rows[a].ItemArray[intRCHHex].ToString());
						int Magenta = Int32.Parse(dt.Rows[a].ItemArray[intGMS].ToString());
						int Yellow = Int32.Parse(dt.Rows[a].ItemArray[intBYV].ToString());
						int Key = Int32.Parse(dt.Rows[a].ItemArray[intAK].ToString());
						
						HexCorPol = CMYK2Hex(Cyan, Magenta, Yellow, Key);
						
						Cyan = Int32.Parse(dt.Rows[a].ItemArray[intRCHHex_L].ToString());
						Magenta = Int32.Parse(dt.Rows[a].ItemArray[intGMS_L].ToString());
						Yellow = Int32.Parse(dt.Rows[a].ItemArray[intBYV_L].ToString());
						Key = Int32.Parse(dt.Rows[a].ItemArray[intAK_L].ToString());
						HexCorLabel = CMYK2Hex(Cyan, Magenta, Yellow, Key);
						
						Cyan = Int32.Parse(dt.Rows[a].ItemArray[intRCHHex_C].ToString());
						Magenta = Int32.Parse(dt.Rows[a].ItemArray[intGMS_C].ToString());
						Yellow = Int32.Parse(dt.Rows[a].ItemArray[intBYV_C].ToString());
						Key = Int32.Parse(dt.Rows[a].ItemArray[intAK_C].ToString());
						HexCorLin = CMYK2Hex(Cyan, Magenta, Yellow, Key);
						
					}
					//esse nem entra
					else if(rdbHSV.Checked)
					{
						/*int intRGBA = dt.Columns[cbbRCHHex.SelectedItem.ToString()].Ordinal;
					int intGMS =  dt.Columns[cbbGMS.SelectedItem.ToString()].Ordinal;
					int intBYV = dt.Columns[cbbBYV.SelectedItem.ToString()].Ordinal;
					//int intAK = dt.Columns[cbbAK.SelectedItem.ToString()].Ordinal;
					
					int intRGBA_L = dt.Columns[cbbRCHHex_L.SelectedItem.ToString()].Ordinal;
					int intGMS_L =  dt.Columns[cbbGMS_L.SelectedItem.ToString()].Ordinal;
					int intBYV_L = dt.Columns[cbbBYV_L.SelectedItem.ToString()].Ordinal;
					//int intAK_L = dt.Columns[cbbAK_L.SelectedItem.ToString()].Ordinal;
					
					int intRGBA_C = dt.Columns[cbbRCHHex_C.SelectedItem.ToString()].Ordinal;
					int intGMS_C =  dt.Columns[cbbGMS_C.SelectedItem.ToString()].Ordinal;
					int intBYV_C = dt.Columns[cbbBYV_C.SelectedItem.ToString()].Ordinal;
					//int intAK_C = dt.Columns[cbbAK_C.SelectedItem.ToString()].Ordinal;
						 */
					}
					else if(rdbHex.Checked)
					{
						int intRCHHex = dt.Columns[cbbRCHHex.SelectedItem.ToString()].Ordinal;
						int intRCHHex_L = dt.Columns[cbbRCHHex_L.SelectedItem.ToString()].Ordinal;
						int intRCHHex_C = dt.Columns[cbbRCHHex_C.SelectedItem.ToString()].Ordinal;
						
						if(ccbTag.Checked == false)
						{
							HexCorPol = "#" + dt.Rows[a].ItemArray[intRCHHex].ToString();
						}
						else
						{
							HexCorPol = dt.Rows[a].ItemArray[intRCHHex].ToString();
						}
					}
					
					
					double TranspPol = Double.Parse(lblValTransparencia.Text);
					double TranspLin = Double.Parse(lblTransp_C.Text);
					string TracoEsp = textBox1.Text;
					
					int TamFonte = Convert.ToInt32(Fonte.Size);
					//TamFonte.Replace(',','.');
					string NomeFonte = Fonte.Name;
					string EstiloFonte = "normal";
					if (Fonte.Bold)
					{
						EstiloFonte = "bold";
					}
					
					//dt.Rows[a].ItemArray
					
					SLD = SLD +
						"				<sld:Rule><!-- INICIO --> " + "\r\n" +
						"					<sld:Name>" + Literal + "</sld:Name>" + "\r\n" + //ddsdsd
						"					<sld:Title>" + Literal + "</sld:Title>" + "\r\n" + //sdsdds
						"					<ogc:Filter>" + "\r\n" +
						"						<ogc:PropertyIsEqualTo>" + "\r\n" +
						"							<ogc:PropertyName>" + PropertyName + "</ogc:PropertyName>" + "\r\n" +
						"							<ogc:Literal>" + Literal + "</ogc:Literal>" + "\r\n" +
						"						</ogc:PropertyIsEqualTo>" + "\r\n" +
						"					</ogc:Filter>" + "\r\n" +
						"					<sld:PolygonSymbolizer>" + "\r\n" +
						"						<sld:Fill>" + "\r\n" +
						"							<!--  dá a coor ao polígoono em hex   -->" + "\r\n" +
						" 							<sld:CssParameter name=\"fill\">" + HexCorPol + "</sld:CssParameter>" + "\r\n" +
						"							<sld:CssParameter name=\"fill-opacity\">" + TranspPol.ToString() + "</sld:CssParameter>" + "\r\n" +
						"						</sld:Fill>" + "\r\n" +
						"						<sld:Stroke>" + "\r\n" +
						"							<!--" + "\r\n" +
						"							Cor da linha do polígono" + "\r\n" +
						"							-->" + "\r\n" +
						"							<sld:CssParameter name=\"stroke\">" + HexCorLin + "</sld:CssParameter>" + "\r\n" +
						"							<sld:CssParameter name=\"stroke-opacity\">" + TranspLin.ToString() + "</sld:CssParameter>" + "\r\n" +
						"							<sld:CssParameter name=\"stroke-width\">" + TracoEsp + "</sld:CssParameter>" + "\r\n" +
						"						</sld:Stroke>" + "\r\n" +
						"					</sld:PolygonSymbolizer>" + "\r\n" +
						"					<sld:TextSymbolizer>" + "\r\n" +
						"						<sld:Label>" + "\r\n" +
						"							<ogc:PropertyName>"+ LabelPropertyName +"</ogc:PropertyName>" + "\r\n" +
						"						</sld:Label>" + "\r\n" +
						"						<sld:Font>" + "\r\n" +
						"							<sld:CssParameter name=\"font-family\">" + NomeFonte + "</sld:CssParameter>" + "\r\n" +
						"							<sld:CssParameter name=\"font-weight\">" + EstiloFonte + "</sld:CssParameter>" + "\r\n" +
						"							<sld:CssParameter name=\"font-size\">" + TamFonte.ToString() + "</sld:CssParameter>" + "\r\n" +
						"						</sld:Font>" + "\r\n" +
						"						<sld:Fill>" + "\r\n" +
						"							<sld:CssParameter name=\"fill\">" + HexCorLabel + "</sld:CssParameter>" + "\r\n" +
						"						</sld:Fill>" + "\r\n" +
						"					</sld:TextSymbolizer>" + "\r\n" +
						"				</sld:Rule> <!-- FIM -->" + "\r\n";
					

				}
				
				
				//monta o rabo do foguete
				SLD = SLD +
					" 			</sld:FeatureTypeStyle>" + "\r\n" +
					"		</sld:UserStyle>" + "\r\n" +
					"	</sld:NamedLayer>" + "\r\n" +
					"</sld:StyledLayerDescriptor>";
			}
			catch
			{
				MessageBox.Show("Um erro ocorreu durante a montagem dos parâmetros do arquivo SLD. Verifique se todos os itens foram corretamente preenchidos.");
			}
			return SLD;
		}
		public bool CheckParametros()
		{
			//check #1 - O arquivo XLS foi carregado?
			if(comboBox1.SelectedIndex ==-1)
			{
				MessageBox.Show("Verifique se a planilha foi corretamente carregada.");
				return false;
			}
			//check #2 - a definição da classe foi corretamente selecionada
			if(cbbClasse.SelectedIndex ==-1)
			{
				MessageBox.Show("Verifique se a definição da classe foi corretamente selecionada");
				return false;
			}
			//check #3 - a definição do rótulo da legenda foi corretamente selecionada
			if(cbbRotulo.SelectedIndex ==-1)
			{
				MessageBox.Show("Verifique se a definição do rótulo da legenda foi corretamente selecionada");
				return false;
			}
			//check #4 - a definição a definição do rótulo do polígono foi corretamente selecionada
			if(cbbLabel.SelectedIndex ==-1)
			{
				MessageBox.Show("Verifique se a definição a definição do rótulo do polígono foi corretamente selecionada");
				return false;
			}
			//check #5 - verifica sistema de cores
			if(rdbRGBA.Checked)
			{
				if(cbbRCHHex.SelectedIndex == -1 | cbbGMS.SelectedIndex == -1 |cbbBYV.SelectedIndex == -1)
				{
					MessageBox.Show("Verifique se os valores de RGB para cor dos polígonos foram corretamente selecionados");
					return false;
				}
				if(cbbRCHHex_C.SelectedIndex == -1 | cbbGMS_C.SelectedIndex == -1 |cbbBYV_C.SelectedIndex == -1)
				{
					MessageBox.Show("Verifique se os valores de RGB para cor dos polígonos foram corretamente selecionados");
					return false;
				}
				if(cbbRCHHex_L.SelectedIndex == -1 | cbbGMS_L.SelectedIndex == -1 |cbbBYV_L.SelectedIndex == -1)
				{
					MessageBox.Show("Verifique se os valores de RGB para cor dos polígonos foram corretamente selecionados");
					return false;
				}
			}
			else if(rdbCMYK.Checked)
			{
				if(cbbRCHHex.SelectedIndex == -1 | cbbGMS.SelectedIndex == -1 |cbbBYV.SelectedIndex == -1 | cbbAK.SelectedIndex == -1)
				{
					MessageBox.Show("Verifique se os valores de CMYK para cor dos polígonos foram corretamente selecionados");
					return false;
				}
				if(cbbRCHHex_C.SelectedIndex == -1 | cbbGMS_C.SelectedIndex == -1 |cbbBYV_C.SelectedIndex == -1| cbbAK_C.SelectedIndex == -1)
				{
					MessageBox.Show("Verifique se os valores de CMYK para cor do contorno dos polígonos foram corretamente selecionados");
					return false;
				}
				//check #7 - Verifica a definição das cores
				if(cbbRCHHex_L.SelectedIndex == -1 | cbbGMS_L.SelectedIndex == -1 |cbbBYV_L.SelectedIndex == -1| cbbAK_L.SelectedIndex == -1)
				{
					MessageBox.Show("Verifique se os valores de CMYK para cor dos rótulos dos polígonos foram corretamente selecionados");
					return false;
				}
			}
			else if(rdbHex.Checked)
			{
				if(cbbRCHHex.SelectedIndex == -1 )
				{
					MessageBox.Show("Verifique se os valores de Hexadecimal para cor dos polígonos foram corretamente selecionados");
					return false;
				}
				if(cbbRCHHex_C.SelectedIndex == -1)
				{
					MessageBox.Show("Verifique se os valores de Hexadecimal para cor do contorno dos polígonos foram corretamente selecionados");
					return false;
				}
				//check #7 - Verifica a definição das cores
				if(cbbRCHHex_L.SelectedIndex == -1)
				{
					MessageBox.Show("Verifique se os valores de Hexadecimal para cor dos rótulos dos polígonos foram corretamente selecionados");
					return false;
				}
			}

			return true;
		}
		
		//=======================================
		//
		//					EVENTOS
		//
		//=======================================
		
		void Button1Click(object sender, EventArgs e)
		{
			OpenFileDialog fdlg = new OpenFileDialog();
			fdlg.Title = "Selecione o arquivo";
			//fdlg.InitialDirectory = @"C:\Geoprocessamento\Temporarios_pessoais\RicardoDart\GeoNode\ZAAL\Geodados";
			fdlg.FileName = txtNomeArquivo.Text;
			fdlg.Filter = "XLSX Files(*.xlsx)|*.xlsx|XLS Files(*.xls)|*.xls";
			fdlg.FilterIndex = 1;
			fdlg.RestoreDirectory = true;
			if (fdlg.ShowDialog() == DialogResult.OK)
			{
				txtNomeArquivo.Text = fdlg.FileName;
				Importar();
				Application.DoEvents();
			}
		}
		void ComboBox1SelectedIndexChanged(object sender, EventArgs e)
		{
			if (recarrega == true)
			{
				string firstPlan = comboBox1.SelectedItem.ToString();
				dt = GetDataTableDBF(txtNomeArquivo.Text, firstPlan);
				gdvDados.DataSource = dt.DefaultView;
				preencheComboBox();
			}
		}
		void RadioButton1CheckedChanged(object sender, EventArgs e)
		{
			SistemaCores();
		}
		void RdbCMYKCheckedChanged(object sender, EventArgs e)
		{
			SistemaCores();
		}
		void RdbHSVCheckedChanged(object sender, EventArgs e)
		{
			SistemaCores();
		}
		void RdbHexCheckedChanged(object sender, EventArgs e)
		{
			SistemaCores();
		}
		void MainFormLoad(object sender, EventArgs e)
		{
			SistemaCores();
			Fonte = lblFonte.Font;
			lblFonte.Text = Fonte.Name;
		}
		void TrackBar1ValueChanged(object sender, EventArgs e)
		{
			double valor = trackBar1.Value / 10.0;
			lblValTransparencia.Text =  valor.ToString();
		}
		void Button3Click(object sender, EventArgs e)
		{
			FontDialog font = new FontDialog();
			font.Font = lblFonte.Font;
			
			if(font.ShowDialog()== DialogResult.OK)
			{
				Fonte = font.Font;
				lblFonte.Font = Fonte;
				lblFonte.Text = Fonte.Name;
			}
			
		}
		void Button2Click(object sender, EventArgs e)
		{
			try
			{
				if (CheckParametros())
				{
					SaveFileDialog sfdSLD = new SaveFileDialog();
					sfdSLD.Filter = "Arquivo SLD (*.sld)|*.sld";
					if(sfdSLD.ShowDialog() == DialogResult.OK)
					{
						StreamWriter sw = new StreamWriter(sfdSLD.FileName);
						string TextoSLD = montaSLD();
						sw.WriteLine(TextoSLD);
						sw.Close();
						MessageBox.Show("Arquivo SLD gerado com sucesso!");
					}
				}
			}
			catch
			{
				
			}
		}
	}
}

