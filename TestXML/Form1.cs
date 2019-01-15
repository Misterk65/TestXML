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
using System.Xml;
using System.Xml.Linq;

namespace TestXML
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private static void CreateLostGpsXml()
        {
            if (!File.Exists("C:\\temp\\document.xml"))
            {
                XmlDocument XmlDoc = new XmlDocument();

                //XML Declaration
                XmlDeclaration xmlDeclaration = XmlDoc.CreateXmlDeclaration("1.0", "UTF-8", null);
                XmlElement rootElement = XmlDoc.DocumentElement;
                XmlDoc.InsertBefore(xmlDeclaration, rootElement);

                //Root Element
                XmlElement root = XmlDoc.CreateElement(string.Empty, "TestSession", string.Empty);
                XmlDoc.AppendChild(root);

                XmlElement NwData = XmlDoc.CreateElement("NetworkData");
                root.AppendChild(NwData);
                

                XmlElement NwTime = XmlDoc.CreateElement("TimeStamp");
                XmlText NwTimeTxt = XmlDoc.CreateTextNode("636830829490500250");
                NwData.AppendChild(NwTime);
                NwTime.AppendChild(NwTimeTxt);

                XmlElement NwType = XmlDoc.CreateElement("Networktype");
                XmlText NwTypeTxt = XmlDoc.CreateTextNode("LTE");
                NwData.AppendChild(NwType);
                NwType.AppendChild(NwTypeTxt);

                XmlElement NwProvider = XmlDoc.CreateElement("NetworkProvider");
                XmlText NwProviderTxt = XmlDoc.CreateTextNode("KT Freetel Co. Ltd. (KR)");
                NwData.AppendChild(NwProvider);
                NwProvider.AppendChild(NwProviderTxt);

                XmlElement NwMcc = XmlDoc.CreateElement("NetworkMCC");
                XmlText NwMccTxt = XmlDoc.CreateTextNode("450");
                NwData.AppendChild(NwMcc);
                NwMcc.AppendChild(NwMccTxt);

                XmlElement NwMnc = XmlDoc.CreateElement("NetworkMNC");
                XmlText NwMncTxt = XmlDoc.CreateTextNode("08");
                NwData.AppendChild(NwMnc);
                NwMnc.AppendChild(NwMncTxt);

                XmlElement NwCellId = XmlDoc.CreateElement("NetworkCellId");
                XmlText NwCellIdTxt = XmlDoc.CreateTextNode("1469215");
                NwData.AppendChild(NwCellId);
                NwCellId.AppendChild(NwCellIdTxt);

                XmlElement NwPcellId = XmlDoc.CreateElement("NetworkPhysCellId");
                XmlText NwPcellIdTxt = XmlDoc.CreateTextNode("182");
                NwData.AppendChild(NwPcellId);
                NwPcellId.AppendChild(NwPcellIdTxt);

                XmlElement NwTraAreCod = XmlDoc.CreateElement("TrackinAreaCode");
                XmlText NwTraAreCodTxt = XmlDoc.CreateTextNode("21025");
                NwData.AppendChild(NwTraAreCod);
                NwTraAreCod.AppendChild(NwTraAreCodTxt);

                XmlElement NwBand = XmlDoc.CreateElement("BandInformation");
                XmlText NwBandTxt = XmlDoc.CreateTextNode("6400(eFDD20)");
                NwData.AppendChild(NwBand);
                NwBand.AppendChild(NwBandTxt);

                XmlElement NwBandWidth = XmlDoc.CreateElement("BandwidthInformation");
                XmlText NwBandWidthTxt = XmlDoc.CreateTextNode("20000");
                NwData.AppendChild(NwBandWidth);
                NwBandWidth.AppendChild(NwBandWidthTxt);

                XmlElement NwSigStre = XmlDoc.CreateElement("SignalStrength");
                XmlText NwSigStreTxt = XmlDoc.CreateTextNode("-103");
                NwData.AppendChild(NwSigStre);
                NwSigStre.AppendChild(NwSigStreTxt);

                XmlDoc.Save("C:\\temp\\document.xml");
            }
            else
            {
                XDocument xDocument = XDocument.Load("C:\\temp\\document.xml");
                xDocument.Root.Add(
                    new XElement("NetworkData",
                        new XElement("TimeStamp", "SnippetCode1"),
                        new XElement("Networktype", "SnippetCode1"),
                        new XElement("NetworkProvider", "SnippetCode1"),
                        new XElement("NetworkMCC", "SnippetCode1"),
                        new XElement("NetworkMNC", "SnippetCode1"),
                        new XElement("NetworkCellId", "SnippetCode1"),
                        new XElement("NetworkPhysCellId", "SnippetCode1"),
                        new XElement("TrackinAreaCode", "SnippetCode1"),
                        new XElement("BandInformation", "SnippetCode1"),
                        new XElement("BandwidthInformation", "SnippetCode1"),
                        new XElement("SignalStrength", "SnippetCode1")
                        ));
                xDocument.Save("C:\\temp\\document.xml");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            CreateLostGpsXml();
        }
    }
}
