/*
 * Created by SharpDevelop.
 * User: embrapa
 * Date: 18/03/2015
 * Time: 09:14
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace DoSLD
{
	partial class MainForm
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		
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
			this.button1 = new System.Windows.Forms.Button();
			this.txtNomeArquivo = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.gdvDados = new System.Windows.Forms.DataGridView();
			this.comboBox1 = new System.Windows.Forms.ComboBox();
			this.label2 = new System.Windows.Forms.Label();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.lblValTransparencia = new System.Windows.Forms.Label();
			this.label13 = new System.Windows.Forms.Label();
			this.label12 = new System.Windows.Forms.Label();
			this.trackBar1 = new System.Windows.Forms.TrackBar();
			this.label4 = new System.Windows.Forms.Label();
			this.lblAK = new System.Windows.Forms.Label();
			this.lblBYV = new System.Windows.Forms.Label();
			this.lblGMS = new System.Windows.Forms.Label();
			this.lblRCHHex = new System.Windows.Forms.Label();
			this.cbbAK = new System.Windows.Forms.ComboBox();
			this.cbbBYV = new System.Windows.Forms.ComboBox();
			this.cbbGMS = new System.Windows.Forms.ComboBox();
			this.cbbRCHHex = new System.Windows.Forms.ComboBox();
			this.ccbTag = new System.Windows.Forms.CheckBox();
			this.rdbHex = new System.Windows.Forms.RadioButton();
			this.rdbHSV = new System.Windows.Forms.RadioButton();
			this.rdbCMYK = new System.Windows.Forms.RadioButton();
			this.rdbRGBA = new System.Windows.Forms.RadioButton();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.lblTransp_C = new System.Windows.Forms.Label();
			this.label14 = new System.Windows.Forms.Label();
			this.label15 = new System.Windows.Forms.Label();
			this.trackBar2 = new System.Windows.Forms.TrackBar();
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.label10 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.lblAK_C = new System.Windows.Forms.Label();
			this.lblBYV_C = new System.Windows.Forms.Label();
			this.lblGMS_C = new System.Windows.Forms.Label();
			this.lblRCHHex_C = new System.Windows.Forms.Label();
			this.cbbAK_C = new System.Windows.Forms.ComboBox();
			this.cbbBYV_C = new System.Windows.Forms.ComboBox();
			this.cbbGMS_C = new System.Windows.Forms.ComboBox();
			this.cbbRCHHex_C = new System.Windows.Forms.ComboBox();
			this.groupBox3 = new System.Windows.Forms.GroupBox();
			this.label3 = new System.Windows.Forms.Label();
			this.cbbClasse = new System.Windows.Forms.ComboBox();
			this.cbbRotulo = new System.Windows.Forms.ComboBox();
			this.label16 = new System.Windows.Forms.Label();
			this.cbbLabel = new System.Windows.Forms.ComboBox();
			this.label17 = new System.Windows.Forms.Label();
			this.groupBox4 = new System.Windows.Forms.GroupBox();
			this.lblFonte = new System.Windows.Forms.Label();
			this.btnFonte = new System.Windows.Forms.Button();
			this.label22 = new System.Windows.Forms.Label();
			this.lblAK_L = new System.Windows.Forms.Label();
			this.lblBYV_L = new System.Windows.Forms.Label();
			this.lblGMS_L = new System.Windows.Forms.Label();
			this.lblRCHHex_L = new System.Windows.Forms.Label();
			this.cbbAK_L = new System.Windows.Forms.ComboBox();
			this.cbbBYV_L = new System.Windows.Forms.ComboBox();
			this.cbbGMS_L = new System.Windows.Forms.ComboBox();
			this.cbbRCHHex_L = new System.Windows.Forms.ComboBox();
			this.button2 = new System.Windows.Forms.Button();
			this.textBox2 = new System.Windows.Forms.TextBox();
			this.label6 = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.gdvDados)).BeginInit();
			this.groupBox1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
			this.groupBox2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.trackBar2)).BeginInit();
			this.groupBox3.SuspendLayout();
			this.groupBox4.SuspendLayout();
			this.SuspendLayout();
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(422, 32);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(75, 23);
			this.button1.TabIndex = 0;
			this.button1.Text = "...";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.Button1Click);
			// 
			// txtNomeArquivo
			// 
			this.txtNomeArquivo.Location = new System.Drawing.Point(12, 35);
			this.txtNomeArquivo.Name = "txtNomeArquivo";
			this.txtNomeArquivo.ReadOnly = true;
			this.txtNomeArquivo.Size = new System.Drawing.Size(404, 20);
			this.txtNomeArquivo.TabIndex = 1;
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(12, 9);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(232, 23);
			this.label1.TabIndex = 2;
			this.label1.Text = "Caminho até o a planilha do Excel";
			// 
			// gdvDados
			// 
			this.gdvDados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.gdvDados.Location = new System.Drawing.Point(12, 61);
			this.gdvDados.Name = "gdvDados";
			this.gdvDados.Size = new System.Drawing.Size(834, 158);
			this.gdvDados.TabIndex = 3;
			// 
			// comboBox1
			// 
			this.comboBox1.FormattingEnabled = true;
			this.comboBox1.Location = new System.Drawing.Point(503, 34);
			this.comboBox1.Name = "comboBox1";
			this.comboBox1.Size = new System.Drawing.Size(121, 21);
			this.comboBox1.TabIndex = 4;
			this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.ComboBox1SelectedIndexChanged);
			// 
			// label2
			// 
			this.label2.Location = new System.Drawing.Point(503, 9);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(100, 23);
			this.label2.TabIndex = 5;
			this.label2.Text = "Planilhas:";
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.lblValTransparencia);
			this.groupBox1.Controls.Add(this.label13);
			this.groupBox1.Controls.Add(this.label12);
			this.groupBox1.Controls.Add(this.trackBar1);
			this.groupBox1.Controls.Add(this.label4);
			this.groupBox1.Controls.Add(this.lblAK);
			this.groupBox1.Controls.Add(this.lblBYV);
			this.groupBox1.Controls.Add(this.lblGMS);
			this.groupBox1.Controls.Add(this.lblRCHHex);
			this.groupBox1.Controls.Add(this.cbbAK);
			this.groupBox1.Controls.Add(this.cbbBYV);
			this.groupBox1.Controls.Add(this.cbbGMS);
			this.groupBox1.Controls.Add(this.cbbRCHHex);
			this.groupBox1.Location = new System.Drawing.Point(220, 235);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(202, 271);
			this.groupBox1.TabIndex = 3;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Preenchimento dos polígonos";
			// 
			// lblValTransparencia
			// 
			this.lblValTransparencia.Location = new System.Drawing.Point(53, 248);
			this.lblValTransparencia.Name = "lblValTransparencia";
			this.lblValTransparencia.Size = new System.Drawing.Size(100, 17);
			this.lblValTransparencia.TabIndex = 18;
			this.lblValTransparencia.Text = "1";
			this.lblValTransparencia.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// label13
			// 
			this.label13.Location = new System.Drawing.Point(96, 194);
			this.label13.Name = "label13";
			this.label13.Size = new System.Drawing.Size(100, 23);
			this.label13.TabIndex = 17;
			this.label13.Text = "Opaco";
			this.label13.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// label12
			// 
			this.label12.Location = new System.Drawing.Point(6, 194);
			this.label12.Name = "label12";
			this.label12.Size = new System.Drawing.Size(100, 23);
			this.label12.TabIndex = 16;
			this.label12.Text = "Transparente";
			this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// trackBar1
			// 
			this.trackBar1.Location = new System.Drawing.Point(6, 220);
			this.trackBar1.Name = "trackBar1";
			this.trackBar1.Size = new System.Drawing.Size(190, 45);
			this.trackBar1.TabIndex = 14;
			this.trackBar1.Value = 10;
			this.trackBar1.ValueChanged += new System.EventHandler(this.TrackBar1ValueChanged);
			// 
			// label4
			// 
			this.label4.Location = new System.Drawing.Point(6, 21);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(131, 23);
			this.label4.TabIndex = 13;
			this.label4.Text = "Campo com as cores:";
			// 
			// lblAK
			// 
			this.lblAK.Location = new System.Drawing.Point(8, 124);
			this.lblAK.Name = "lblAK";
			this.lblAK.Size = new System.Drawing.Size(61, 23);
			this.lblAK.TabIndex = 11;
			this.lblAK.Text = "label7";
			this.lblAK.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// lblBYV
			// 
			this.lblBYV.Location = new System.Drawing.Point(6, 101);
			this.lblBYV.Name = "lblBYV";
			this.lblBYV.Size = new System.Drawing.Size(63, 23);
			this.lblBYV.TabIndex = 10;
			this.lblBYV.Text = "label6";
			this.lblBYV.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// lblGMS
			// 
			this.lblGMS.Location = new System.Drawing.Point(6, 74);
			this.lblGMS.Name = "lblGMS";
			this.lblGMS.Size = new System.Drawing.Size(63, 23);
			this.lblGMS.TabIndex = 9;
			this.lblGMS.Text = "label5";
			this.lblGMS.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// lblRCHHex
			// 
			this.lblRCHHex.Location = new System.Drawing.Point(6, 47);
			this.lblRCHHex.Name = "lblRCHHex";
			this.lblRCHHex.Size = new System.Drawing.Size(63, 23);
			this.lblRCHHex.TabIndex = 8;
			this.lblRCHHex.Text = "label4";
			this.lblRCHHex.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// cbbAK
			// 
			this.cbbAK.FormattingEnabled = true;
			this.cbbAK.Location = new System.Drawing.Point(75, 128);
			this.cbbAK.Name = "cbbAK";
			this.cbbAK.Size = new System.Drawing.Size(121, 21);
			this.cbbAK.TabIndex = 7;
			// 
			// cbbBYV
			// 
			this.cbbBYV.FormattingEnabled = true;
			this.cbbBYV.Location = new System.Drawing.Point(75, 101);
			this.cbbBYV.Name = "cbbBYV";
			this.cbbBYV.Size = new System.Drawing.Size(121, 21);
			this.cbbBYV.TabIndex = 6;
			// 
			// cbbGMS
			// 
			this.cbbGMS.FormattingEnabled = true;
			this.cbbGMS.Location = new System.Drawing.Point(75, 74);
			this.cbbGMS.Name = "cbbGMS";
			this.cbbGMS.Size = new System.Drawing.Size(121, 21);
			this.cbbGMS.TabIndex = 5;
			// 
			// cbbRCHHex
			// 
			this.cbbRCHHex.FormattingEnabled = true;
			this.cbbRCHHex.Location = new System.Drawing.Point(75, 47);
			this.cbbRCHHex.Name = "cbbRCHHex";
			this.cbbRCHHex.Size = new System.Drawing.Size(121, 21);
			this.cbbRCHHex.TabIndex = 4;
			// 
			// ccbTag
			// 
			this.ccbTag.Location = new System.Drawing.Point(28, 89);
			this.ccbTag.Name = "ccbTag";
			this.ccbTag.Size = new System.Drawing.Size(168, 24);
			this.ccbTag.TabIndex = 12;
			this.ccbTag.Text = "Cor Hexadecimal com tag \'#\'";
			this.ccbTag.UseVisualStyleBackColor = true;
			// 
			// rdbHex
			// 
			this.rdbHex.Location = new System.Drawing.Point(6, 72);
			this.rdbHex.Name = "rdbHex";
			this.rdbHex.Size = new System.Drawing.Size(104, 24);
			this.rdbHex.TabIndex = 3;
			this.rdbHex.TabStop = true;
			this.rdbHex.Text = "Hexadecimal";
			this.rdbHex.UseVisualStyleBackColor = true;
			this.rdbHex.CheckedChanged += new System.EventHandler(this.RdbHexCheckedChanged);
			// 
			// rdbHSV
			// 
			this.rdbHSV.Enabled = false;
			this.rdbHSV.Location = new System.Drawing.Point(6, 118);
			this.rdbHSV.Name = "rdbHSV";
			this.rdbHSV.Size = new System.Drawing.Size(104, 24);
			this.rdbHSV.TabIndex = 2;
			this.rdbHSV.Text = "HSV";
			this.rdbHSV.UseVisualStyleBackColor = true;
			this.rdbHSV.Visible = false;
			this.rdbHSV.CheckedChanged += new System.EventHandler(this.RdbHSVCheckedChanged);
			// 
			// rdbCMYK
			// 
			this.rdbCMYK.Location = new System.Drawing.Point(6, 42);
			this.rdbCMYK.Name = "rdbCMYK";
			this.rdbCMYK.Size = new System.Drawing.Size(104, 24);
			this.rdbCMYK.TabIndex = 1;
			this.rdbCMYK.Text = "CMYK";
			this.rdbCMYK.UseVisualStyleBackColor = true;
			this.rdbCMYK.CheckedChanged += new System.EventHandler(this.RdbCMYKCheckedChanged);
			// 
			// rdbRGBA
			// 
			this.rdbRGBA.Checked = true;
			this.rdbRGBA.Location = new System.Drawing.Point(6, 16);
			this.rdbRGBA.Name = "rdbRGBA";
			this.rdbRGBA.Size = new System.Drawing.Size(104, 24);
			this.rdbRGBA.TabIndex = 0;
			this.rdbRGBA.TabStop = true;
			this.rdbRGBA.Text = "RGB";
			this.rdbRGBA.UseVisualStyleBackColor = true;
			this.rdbRGBA.CheckedChanged += new System.EventHandler(this.RadioButton1CheckedChanged);
			// 
			// groupBox2
			// 
			this.groupBox2.Controls.Add(this.lblTransp_C);
			this.groupBox2.Controls.Add(this.label14);
			this.groupBox2.Controls.Add(this.label15);
			this.groupBox2.Controls.Add(this.trackBar2);
			this.groupBox2.Controls.Add(this.textBox1);
			this.groupBox2.Controls.Add(this.label10);
			this.groupBox2.Controls.Add(this.label5);
			this.groupBox2.Controls.Add(this.lblAK_C);
			this.groupBox2.Controls.Add(this.lblBYV_C);
			this.groupBox2.Controls.Add(this.lblGMS_C);
			this.groupBox2.Controls.Add(this.lblRCHHex_C);
			this.groupBox2.Controls.Add(this.cbbAK_C);
			this.groupBox2.Controls.Add(this.cbbBYV_C);
			this.groupBox2.Controls.Add(this.cbbGMS_C);
			this.groupBox2.Controls.Add(this.cbbRCHHex_C);
			this.groupBox2.Location = new System.Drawing.Point(428, 235);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(202, 271);
			this.groupBox2.TabIndex = 14;
			this.groupBox2.TabStop = false;
			this.groupBox2.Text = "Contorno dos polígonos";
			// 
			// lblTransp_C
			// 
			this.lblTransp_C.Location = new System.Drawing.Point(53, 248);
			this.lblTransp_C.Name = "lblTransp_C";
			this.lblTransp_C.Size = new System.Drawing.Size(100, 17);
			this.lblTransp_C.TabIndex = 22;
			this.lblTransp_C.Text = "1";
			this.lblTransp_C.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// label14
			// 
			this.label14.Location = new System.Drawing.Point(96, 194);
			this.label14.Name = "label14";
			this.label14.Size = new System.Drawing.Size(100, 23);
			this.label14.TabIndex = 21;
			this.label14.Text = "Opaco";
			this.label14.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// label15
			// 
			this.label15.Location = new System.Drawing.Point(6, 194);
			this.label15.Name = "label15";
			this.label15.Size = new System.Drawing.Size(100, 23);
			this.label15.TabIndex = 20;
			this.label15.Text = "Transparente";
			this.label15.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// trackBar2
			// 
			this.trackBar2.Location = new System.Drawing.Point(6, 220);
			this.trackBar2.Name = "trackBar2";
			this.trackBar2.Size = new System.Drawing.Size(190, 45);
			this.trackBar2.TabIndex = 19;
			this.trackBar2.Value = 10;
			// 
			// textBox1
			// 
			this.textBox1.Location = new System.Drawing.Point(75, 157);
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(121, 20);
			this.textBox1.TabIndex = 15;
			this.textBox1.Text = "0.28";
			// 
			// label10
			// 
			this.label10.Location = new System.Drawing.Point(10, 157);
			this.label10.Name = "label10";
			this.label10.Size = new System.Drawing.Size(59, 23);
			this.label10.TabIndex = 14;
			this.label10.Text = "Espessura";
			// 
			// label5
			// 
			this.label5.Location = new System.Drawing.Point(6, 23);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(131, 23);
			this.label5.TabIndex = 13;
			this.label5.Text = "Campo com as cores:";
			// 
			// lblAK_C
			// 
			this.lblAK_C.Location = new System.Drawing.Point(24, 126);
			this.lblAK_C.Name = "lblAK_C";
			this.lblAK_C.Size = new System.Drawing.Size(45, 23);
			this.lblAK_C.TabIndex = 11;
			this.lblAK_C.Text = "label7";
			this.lblAK_C.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// lblBYV_C
			// 
			this.lblBYV_C.Location = new System.Drawing.Point(6, 103);
			this.lblBYV_C.Name = "lblBYV_C";
			this.lblBYV_C.Size = new System.Drawing.Size(63, 23);
			this.lblBYV_C.TabIndex = 10;
			this.lblBYV_C.Text = "label6";
			this.lblBYV_C.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// lblGMS_C
			// 
			this.lblGMS_C.Location = new System.Drawing.Point(6, 76);
			this.lblGMS_C.Name = "lblGMS_C";
			this.lblGMS_C.Size = new System.Drawing.Size(63, 23);
			this.lblGMS_C.TabIndex = 9;
			this.lblGMS_C.Text = "label5";
			this.lblGMS_C.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// lblRCHHex_C
			// 
			this.lblRCHHex_C.Location = new System.Drawing.Point(6, 49);
			this.lblRCHHex_C.Name = "lblRCHHex_C";
			this.lblRCHHex_C.Size = new System.Drawing.Size(63, 23);
			this.lblRCHHex_C.TabIndex = 8;
			this.lblRCHHex_C.Text = "label4";
			this.lblRCHHex_C.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// cbbAK_C
			// 
			this.cbbAK_C.FormattingEnabled = true;
			this.cbbAK_C.Location = new System.Drawing.Point(75, 130);
			this.cbbAK_C.Name = "cbbAK_C";
			this.cbbAK_C.Size = new System.Drawing.Size(121, 21);
			this.cbbAK_C.TabIndex = 7;
			// 
			// cbbBYV_C
			// 
			this.cbbBYV_C.FormattingEnabled = true;
			this.cbbBYV_C.Location = new System.Drawing.Point(75, 103);
			this.cbbBYV_C.Name = "cbbBYV_C";
			this.cbbBYV_C.Size = new System.Drawing.Size(121, 21);
			this.cbbBYV_C.TabIndex = 6;
			// 
			// cbbGMS_C
			// 
			this.cbbGMS_C.FormattingEnabled = true;
			this.cbbGMS_C.Location = new System.Drawing.Point(75, 76);
			this.cbbGMS_C.Name = "cbbGMS_C";
			this.cbbGMS_C.Size = new System.Drawing.Size(121, 21);
			this.cbbGMS_C.TabIndex = 5;
			// 
			// cbbRCHHex_C
			// 
			this.cbbRCHHex_C.FormattingEnabled = true;
			this.cbbRCHHex_C.Location = new System.Drawing.Point(75, 49);
			this.cbbRCHHex_C.Name = "cbbRCHHex_C";
			this.cbbRCHHex_C.Size = new System.Drawing.Size(121, 21);
			this.cbbRCHHex_C.TabIndex = 4;
			// 
			// groupBox3
			// 
			this.groupBox3.Controls.Add(this.rdbRGBA);
			this.groupBox3.Controls.Add(this.ccbTag);
			this.groupBox3.Controls.Add(this.rdbCMYK);
			this.groupBox3.Controls.Add(this.rdbHSV);
			this.groupBox3.Controls.Add(this.rdbHex);
			this.groupBox3.Location = new System.Drawing.Point(12, 357);
			this.groupBox3.Name = "groupBox3";
			this.groupBox3.Size = new System.Drawing.Size(202, 149);
			this.groupBox3.TabIndex = 15;
			this.groupBox3.TabStop = false;
			this.groupBox3.Text = "Sistema de cores";
			// 
			// label3
			// 
			this.label3.Location = new System.Drawing.Point(12, 222);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(122, 15);
			this.label3.TabIndex = 6;
			this.label3.Text = "Campo com a classe:";
			// 
			// cbbClasse
			// 
			this.cbbClasse.FormattingEnabled = true;
			this.cbbClasse.Location = new System.Drawing.Point(13, 240);
			this.cbbClasse.Name = "cbbClasse";
			this.cbbClasse.Size = new System.Drawing.Size(121, 21);
			this.cbbClasse.TabIndex = 7;
			// 
			// cbbRotulo
			// 
			this.cbbRotulo.FormattingEnabled = true;
			this.cbbRotulo.Location = new System.Drawing.Point(13, 282);
			this.cbbRotulo.Name = "cbbRotulo";
			this.cbbRotulo.Size = new System.Drawing.Size(121, 21);
			this.cbbRotulo.TabIndex = 17;
			// 
			// label16
			// 
			this.label16.Location = new System.Drawing.Point(12, 264);
			this.label16.Name = "label16";
			this.label16.Size = new System.Drawing.Size(122, 15);
			this.label16.TabIndex = 16;
			this.label16.Text = "Rótulo da legenda:";
			// 
			// cbbLabel
			// 
			this.cbbLabel.FormattingEnabled = true;
			this.cbbLabel.Location = new System.Drawing.Point(13, 328);
			this.cbbLabel.Name = "cbbLabel";
			this.cbbLabel.Size = new System.Drawing.Size(121, 21);
			this.cbbLabel.TabIndex = 19;
			// 
			// label17
			// 
			this.label17.Location = new System.Drawing.Point(12, 310);
			this.label17.Name = "label17";
			this.label17.Size = new System.Drawing.Size(122, 15);
			this.label17.TabIndex = 18;
			this.label17.Text = "Rótulo dos polígonos:";
			// 
			// groupBox4
			// 
			this.groupBox4.Controls.Add(this.lblFonte);
			this.groupBox4.Controls.Add(this.btnFonte);
			this.groupBox4.Controls.Add(this.label22);
			this.groupBox4.Controls.Add(this.lblAK_L);
			this.groupBox4.Controls.Add(this.lblBYV_L);
			this.groupBox4.Controls.Add(this.lblGMS_L);
			this.groupBox4.Controls.Add(this.lblRCHHex_L);
			this.groupBox4.Controls.Add(this.cbbAK_L);
			this.groupBox4.Controls.Add(this.cbbBYV_L);
			this.groupBox4.Controls.Add(this.cbbGMS_L);
			this.groupBox4.Controls.Add(this.cbbRCHHex_L);
			this.groupBox4.Location = new System.Drawing.Point(645, 240);
			this.groupBox4.Name = "groupBox4";
			this.groupBox4.Size = new System.Drawing.Size(202, 217);
			this.groupBox4.TabIndex = 23;
			this.groupBox4.TabStop = false;
			this.groupBox4.Text = "Fonte dos rótulos";
			// 
			// lblFonte
			// 
			this.lblFonte.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblFonte.Location = new System.Drawing.Point(66, 54);
			this.lblFonte.Name = "lblFonte";
			this.lblFonte.Size = new System.Drawing.Size(100, 23);
			this.lblFonte.TabIndex = 24;
			this.lblFonte.Text = "Fonte do Label";
			// 
			// btnFonte
			// 
			this.btnFonte.Location = new System.Drawing.Point(121, 18);
			this.btnFonte.Name = "btnFonte";
			this.btnFonte.Size = new System.Drawing.Size(75, 23);
			this.btnFonte.TabIndex = 23;
			this.btnFonte.Text = "Fonte";
			this.btnFonte.UseVisualStyleBackColor = true;
			this.btnFonte.Click += new System.EventHandler(this.Button3Click);
			// 
			// label22
			// 
			this.label22.Location = new System.Drawing.Point(6, 23);
			this.label22.Name = "label22";
			this.label22.Size = new System.Drawing.Size(131, 23);
			this.label22.TabIndex = 13;
			this.label22.Text = "Campo com as cores:";
			// 
			// lblAK_L
			// 
			this.lblAK_L.Location = new System.Drawing.Point(24, 178);
			this.lblAK_L.Name = "lblAK_L";
			this.lblAK_L.Size = new System.Drawing.Size(45, 23);
			this.lblAK_L.TabIndex = 11;
			this.lblAK_L.Text = "label7";
			this.lblAK_L.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// lblBYV_L
			// 
			this.lblBYV_L.Location = new System.Drawing.Point(6, 155);
			this.lblBYV_L.Name = "lblBYV_L";
			this.lblBYV_L.Size = new System.Drawing.Size(63, 23);
			this.lblBYV_L.TabIndex = 10;
			this.lblBYV_L.Text = "label6";
			this.lblBYV_L.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// lblGMS_L
			// 
			this.lblGMS_L.Location = new System.Drawing.Point(6, 128);
			this.lblGMS_L.Name = "lblGMS_L";
			this.lblGMS_L.Size = new System.Drawing.Size(63, 23);
			this.lblGMS_L.TabIndex = 9;
			this.lblGMS_L.Text = "label5";
			this.lblGMS_L.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// lblRCHHex_L
			// 
			this.lblRCHHex_L.Location = new System.Drawing.Point(6, 101);
			this.lblRCHHex_L.Name = "lblRCHHex_L";
			this.lblRCHHex_L.Size = new System.Drawing.Size(63, 23);
			this.lblRCHHex_L.TabIndex = 8;
			this.lblRCHHex_L.Text = "label4";
			this.lblRCHHex_L.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// cbbAK_L
			// 
			this.cbbAK_L.FormattingEnabled = true;
			this.cbbAK_L.Location = new System.Drawing.Point(75, 182);
			this.cbbAK_L.Name = "cbbAK_L";
			this.cbbAK_L.Size = new System.Drawing.Size(121, 21);
			this.cbbAK_L.TabIndex = 7;
			// 
			// cbbBYV_L
			// 
			this.cbbBYV_L.FormattingEnabled = true;
			this.cbbBYV_L.Location = new System.Drawing.Point(75, 155);
			this.cbbBYV_L.Name = "cbbBYV_L";
			this.cbbBYV_L.Size = new System.Drawing.Size(121, 21);
			this.cbbBYV_L.TabIndex = 6;
			// 
			// cbbGMS_L
			// 
			this.cbbGMS_L.FormattingEnabled = true;
			this.cbbGMS_L.Location = new System.Drawing.Point(75, 128);
			this.cbbGMS_L.Name = "cbbGMS_L";
			this.cbbGMS_L.Size = new System.Drawing.Size(121, 21);
			this.cbbGMS_L.TabIndex = 5;
			// 
			// cbbRCHHex_L
			// 
			this.cbbRCHHex_L.FormattingEnabled = true;
			this.cbbRCHHex_L.Location = new System.Drawing.Point(75, 101);
			this.cbbRCHHex_L.Name = "cbbRCHHex_L";
			this.cbbRCHHex_L.Size = new System.Drawing.Size(121, 21);
			this.cbbRCHHex_L.TabIndex = 4;
			// 
			// button2
			// 
			this.button2.Location = new System.Drawing.Point(720, 483);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(127, 27);
			this.button2.TabIndex = 24;
			this.button2.Text = "Criar legenda SLD";
			this.button2.UseVisualStyleBackColor = true;
			this.button2.Click += new System.EventHandler(this.Button2Click);
			// 
			// textBox2
			// 
			this.textBox2.Location = new System.Drawing.Point(630, 34);
			this.textBox2.Name = "textBox2";
			this.textBox2.Size = new System.Drawing.Size(216, 20);
			this.textBox2.TabIndex = 25;
			// 
			// label6
			// 
			this.label6.Location = new System.Drawing.Point(630, 9);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(100, 23);
			this.label6.TabIndex = 26;
			this.label6.Text = "Título da legenda:";
			//this.label6.Click += new System.EventHandler(this.Label6Click);
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(859, 518);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.textBox2);
			this.Controls.Add(this.button2);
			this.Controls.Add(this.groupBox4);
			this.Controls.Add(this.cbbLabel);
			this.Controls.Add(this.label17);
			this.Controls.Add(this.cbbRotulo);
			this.Controls.Add(this.label16);
			this.Controls.Add(this.groupBox3);
			this.Controls.Add(this.groupBox2);
			this.Controls.Add(this.groupBox1);
			this.Controls.Add(this.cbbClasse);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.comboBox1);
			this.Controls.Add(this.gdvDados);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.txtNomeArquivo);
			this.Controls.Add(this.button1);
			this.Name = "MainForm";
			this.Text = "DoSLD - V 1.01";
			this.Load += new System.EventHandler(this.MainFormLoad);
			((System.ComponentModel.ISupportInitialize)(this.gdvDados)).EndInit();
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
			this.groupBox2.ResumeLayout(false);
			this.groupBox2.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.trackBar2)).EndInit();
			this.groupBox3.ResumeLayout(false);
			this.groupBox4.ResumeLayout(false);
			this.ResumeLayout(false);
			this.PerformLayout();
		}
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.TextBox textBox2;
		private System.Windows.Forms.Label lblFonte;
		private System.Windows.Forms.Button btnFonte;
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.ComboBox cbbRCHHex_L;
		private System.Windows.Forms.ComboBox cbbGMS_L;
		private System.Windows.Forms.ComboBox cbbBYV_L;
		private System.Windows.Forms.ComboBox cbbAK_L;
		private System.Windows.Forms.Label lblRCHHex_L;
		private System.Windows.Forms.Label lblGMS_L;
		private System.Windows.Forms.Label lblBYV_L;
		private System.Windows.Forms.Label lblAK_L;
		private System.Windows.Forms.Label label22;
		private System.Windows.Forms.GroupBox groupBox4;
		private System.Windows.Forms.Label label17;
		private System.Windows.Forms.ComboBox cbbLabel;
		private System.Windows.Forms.Label label16;
		private System.Windows.Forms.ComboBox cbbRotulo;
		private System.Windows.Forms.TrackBar trackBar2;
		private System.Windows.Forms.Label label15;
		private System.Windows.Forms.Label label14;
		private System.Windows.Forms.Label lblTransp_C;
		private System.Windows.Forms.GroupBox groupBox3;
		private System.Windows.Forms.ComboBox cbbRCHHex_C;
		private System.Windows.Forms.ComboBox cbbGMS_C;
		private System.Windows.Forms.ComboBox cbbBYV_C;
		private System.Windows.Forms.ComboBox cbbAK_C;
		private System.Windows.Forms.Label lblRCHHex_C;
		private System.Windows.Forms.Label lblGMS_C;
		private System.Windows.Forms.Label lblBYV_C;
		private System.Windows.Forms.Label lblAK_C;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label10;
		private System.Windows.Forms.TextBox textBox1;
		private System.Windows.Forms.GroupBox groupBox2;
		private System.Windows.Forms.TrackBar trackBar1;
		private System.Windows.Forms.Label lblValTransparencia;
		private System.Windows.Forms.Label label12;
		private System.Windows.Forms.Label label13;
		private System.Windows.Forms.CheckBox ccbTag;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.RadioButton rdbRGBA;
		private System.Windows.Forms.RadioButton rdbCMYK;
		private System.Windows.Forms.RadioButton rdbHSV;
		private System.Windows.Forms.RadioButton rdbHex;
		private System.Windows.Forms.ComboBox cbbRCHHex;
		private System.Windows.Forms.ComboBox cbbGMS;
		private System.Windows.Forms.ComboBox cbbBYV;
		private System.Windows.Forms.ComboBox cbbAK;
		private System.Windows.Forms.Label lblRCHHex;
		private System.Windows.Forms.Label lblGMS;
		private System.Windows.Forms.Label lblBYV;
		private System.Windows.Forms.Label lblAK;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.ComboBox cbbClasse;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.ComboBox comboBox1;
		private System.Windows.Forms.DataGridView gdvDados;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox txtNomeArquivo;
		private System.Windows.Forms.Button button1;
	}
}
