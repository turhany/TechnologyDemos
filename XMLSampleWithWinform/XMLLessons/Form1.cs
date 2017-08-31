using System;
using System.Data;
using System.Windows.Forms;
using System.Xml;
//XPath name space ekliyoruz
using System.Xml.XPath;
using System.Data.SqlClient;
using System.IO;

namespace XMLLessons
{
	public partial class Form1 : Form
	{
		String XMLFilePath = Application.StartupPath + "//EmployeeList.xml";

		public Form1()
		{
			InitializeComponent();
		}

		private void ReadDataButton_Click(object sender, EventArgs e)
		{
			//XML veri tipinde data verir
			DataSet DS = new DataSet();
			DS.ReadXml(XMLFilePath);

			XMLDataGridView.DataSource = DS.Tables[0];

		}

		private void SearchXMLDataButton_Click(object sender, EventArgs e)
		{
			XmlDocument XMLFile = new XmlDocument();
			XMLFile.Load(XMLFilePath);

			XmlNode SelectedXMLNode = XMLFile.ChildNodes[1];

			foreach (XmlNode item in SelectedXMLNode)//Calısan
			{
				//if (item.ChildNodes[0].InnerText == "Zübeyir")//Adı
				if (item.Attributes["TCNo"].Value == "12345678902")
				{
					MessageBox.Show("Eleman bulundu: \n" + item.ChildNodes[0].InnerText + " " + item.ChildNodes[1].InnerText + "\n" + item.ChildNodes[2].InnerText);
					break;
				}
			}

		}

		private void SearchXMLDataButton2_Click(object sender, EventArgs e)
		{
			//Xpath - Daha hızlı arama yapılmasını sağlamaktadır
			//@ işreti attribute anlamına gelmektedir

			XmlDocument XMLFile = new XmlDocument();
			XMLFile.Load(XMLFilePath);

			//Calisanlar içinde olan Calisan nesnelerinin içinede TCNo = 12345678903 olan node bana bul
			XmlNode SelectedXMLNode = XMLFile.SelectSingleNode("Calisanlar/Calisan[@TCNo=12345678903]");

			MessageBox.Show("Eleman bulundu: \n" + SelectedXMLNode.ChildNodes[0].InnerText + " " + SelectedXMLNode.ChildNodes[1].InnerText + "\n" + SelectedXMLNode.ChildNodes[2].InnerText);

		}
		 
		private void SearchXMLDataButton3_Click(object sender, EventArgs e)
		{
			//Elementlerde innertext, Attributelerde ise valu kullanılır datayı almak için

			XPathDocument XMLFile = new XPathDocument(XMLFilePath);
			XPathNavigator XPathNav = XMLFile.CreateNavigator();
			XPathNodeIterator SelectedNode = XPathNav.Select("Calisanlar/Calisan/Adi");

			String NameString = String.Empty;
			while (SelectedNode.MoveNext())
			{
				NameString +=  SelectedNode.Current.InnerXml + "\n";
			}

			MessageBox.Show(NameString);
		}

		private void UpdateXMLDataButton_Click(object sender, EventArgs e)
		{
			XmlDocument XMLFile = new XmlDocument();
			XMLFile.Load(XMLFilePath);

			//Calisanlar içinde olan Calisan nesnelerinin içinede TCNo = 12345678903 olan node bana bul
			XmlNode SelectedXMLNode = XMLFile.SelectSingleNode("Calisanlar/Calisan[@TCNo=12345678903]");

			if (SelectedXMLNode != null)
			{
				SelectedXMLNode.ChildNodes[0].InnerText = "Fatma";
				XMLFile.Save(XMLFilePath);

				MessageBox.Show("Veri güncellendi.");
			}
			else
			{
				MessageBox.Show("Kişi bulunamadı.");
			}
		}

		private void DeleteXMLDataButton_Click(object sender, EventArgs e)
		{
			XmlDocument XMLFile = new XmlDocument();
			XMLFile.Load(XMLFilePath);

			//Calisanlar içinde olan Calisan nesnelerinin içinede TCNo = 12345678903 olan node bana bul
			XmlNode SelectedXMLNode = XMLFile.SelectSingleNode("Calisanlar/Calisan[@TCNo=12345678903]");

			if (SelectedXMLNode != null)
			{
				XMLFile.DocumentElement.RemoveChild(SelectedXMLNode);
				XMLFile.Save(XMLFilePath);

				MessageBox.Show("Veri Silindi");
			}
			else
			{
				MessageBox.Show("Silinecek veri yok!");
			}
		}

		private void AddXMLDataButton_Click(object sender, EventArgs e)
		{
			XmlDocument XMLFile = new XmlDocument();
			XMLFile.Load(XMLFilePath);

			//En üst node oluşturulması
			XmlElement MyElement = XMLFile.CreateElement("Calisan");
			//Calisan nodunun TCNo attribte oluşturulması
			XmlAttribute MyElementAttribute = XMLFile.CreateAttribute("TCNo");
			//TCNo attribute değer atanması
			MyElementAttribute.Value = "12345678904";
			//Attribute Calisan içine eklenmesi
			MyElement.Attributes.Append(MyElementAttribute);


			//Adi nodunun oluştururlması
			XmlNode XMlAdiNode = XMLFile.CreateNode(XmlNodeType.Element, "Adi","");
			//Adi node içine değer atanması
			XMlAdiNode.InnerText = "Buse";
			MyElement.AppendChild(XMlAdiNode);

			//Soyadi nodunun oluştururlması
			XmlNode XMlSoyadiNode = XMLFile.CreateNode(XmlNodeType.Element, "Soyadi", "");
			//Soyadi node içine değer atanması
			XMlSoyadiNode.InnerText = "HAVALI";
			MyElement.AppendChild(XMlSoyadiNode);

			//DogumYili nodunun oluştururlması
			XmlNode XMlDogumYiliNode = XMLFile.CreateNode(XmlNodeType.Element, "DogumYili", "");
			//Soyadi node içine değer atanması
			XMlDogumYiliNode.InnerText = "HAVALI";
			MyElement.AppendChild(XMlDogumYiliNode);

			XMLFile.DocumentElement.AppendChild(MyElement);

			XMLFile.Save(XMLFilePath);

			MessageBox.Show("Veri eklendi.");
		}

		private void SQLToXMLButton_Click(object sender, EventArgs e)
		{
            //Kullanmak için aşağıdaki linkte yer alan AdventureWorks2008R2_SR1.exe dosya ile AdventureWorksLT database kurunuz
            //http://msftdbprodsamples.codeplex.com/releases/view/55926

            SqlConnection Conn = new SqlConnection("server=.; Database=AdventureWorksLT; trusted_connection=true");
			SqlDataAdapter SDAdapter = new SqlDataAdapter("Select * From [SalesLT].[Product]", Conn);
			DataTable DTable = new DataTable("Product");
			SDAdapter.Fill(DTable);

			DataSet DS = new DataSet("Products");
			DS.Tables.Add(DTable);

			DS.WriteXml(Application.StartupPath + "\\SqlToXML.xml");

			MessageBox.Show("Sql datası XML olarak kaydedildi"); 
		}

		private void XMLToSQLButton_Click(object sender, EventArgs e)
		{
			FolderBrowserDialog FDialog = new FolderBrowserDialog();
			DialogResult DResult = FDialog.ShowDialog();

			if (DResult == System.Windows.Forms.DialogResult.OK)
			{
				String XMLFile = FDialog.SelectedPath + "\\SqlToXml.xml";

				if (File.Exists(XMLFile))
				{
					SqlConnection Conn = new SqlConnection("server=.; Database=AdventureWorksLT; trusted_connection=true");
					SqlDataAdapter SDAdapter = new SqlDataAdapter("Select * From [SalesLT].[Product]", Conn);

					SqlCommandBuilder SComman = new SqlCommandBuilder(SDAdapter);

					DataSet DS = new DataSet();
					DS.ReadXml(XMLFile);

					SDAdapter.Update(DS.Tables[0]);

					MessageBox.Show("XML data Veri tabanın eklendi!");
				}
				else
				{
					MessageBox.Show("Dosya bulunamadı \n SqlToXML.xml");
				}
			}
			else
			{
				MessageBox.Show("Dosya seçilmedi!");
			}
		}

		private void GenerateXMLSchemaButton_Click(object sender, EventArgs e)
		{
			SqlConnection Conn = new SqlConnection("server=.; Database=AdventureWorksLT; trusted_connection=true");
			SqlDataAdapter SDAdapter = new SqlDataAdapter("Select * From [SalesLT].[Product]", Conn);

			DataSet DS = new DataSet("XUrunler");
			DataTable DTable = new DataTable("XUrun");
			SDAdapter.Fill(DTable);

			DS.Tables.Add(DTable);

			String XMLSchemaFilePath = Application.StartupPath + "\\MySchema.xsd";
			DS.WriteXmlSchema(XMLSchemaFilePath);

			MessageBox.Show("Schema oluşturuldu.");
		}

		private void SQLToXMLWithSchemaButton_Click(object sender, EventArgs e)
		{
			//Schema dosyası adresi
			String SchemaFile = Application.StartupPath + "\\MySchema.xsd";

			//AS ile aslında schema içindeki alanlar ile eşleştirilmeli 
			SqlConnection Conn = new SqlConnection("server=.; Database=AdventureWorksLT; trusted_connection=true");
			SqlDataAdapter SDAdapter = new SqlDataAdapter("Select Name AS Name , ProductNumber AS ProductNumber,Color AS Color From [SalesLT].[Product]", Conn);
			DataTable DTable = new DataTable("XUrun");
			DTable.ReadXmlSchema(SchemaFile);
			SDAdapter.Fill(DTable);

			DataSet DS = new DataSet("XUrunler");
			DS.Tables.Add(DTable);

			DS.WriteXml(Application.StartupPath + "\\SqlToXML.xml");

			MessageBox.Show("Sql datası XML olarak kaydedildi"); 
		}

		private void XMLSchemaValidationButton_Click(object sender, EventArgs e)
		{
			//Schema dosyası adresi
			String SchemaFile = Application.StartupPath + "\\MySchema.xsd";

			//XML reader ayarlarının yapılması
			XmlReaderSettings XMLReadSet = new XmlReaderSettings();
			XMLReadSet.Schemas.Add("", SchemaFile);
			XMLReadSet.ValidationType = ValidationType.Schema;
			XMLReadSet.ValidationEventHandler += new System.Xml.Schema.ValidationEventHandler(XMLReadSet_ValidationEventHandler);


			XmlReader XReader = XmlReader.Create(XMLFilePath);

			while (XReader.Read())
			{
				
			}

			if (ErrorMessage == String.Empty)
			{
				//Schema ile XML uyumludur
				MessageBox.Show("OK");
			}
			else
			{
				MessageBox.Show(ErrorMessage);
			}
		}

		String ErrorMessage = String.Empty;
		void XMLReadSet_ValidationEventHandler(object sender, System.Xml.Schema.ValidationEventArgs e)
		{
			if (e.Severity == System.Xml.Schema.XmlSeverityType.Error)
			{
				ErrorMessage += "Hata Mesajı: " + e.Message + "\r\n";
			}
			else  
			{
				ErrorMessage += "Uyarı Mesajı: " + e.Message + "\r\n";
			}
		}

		private void Form1_Load(object sender, EventArgs e)
		{

		}
	}
}
