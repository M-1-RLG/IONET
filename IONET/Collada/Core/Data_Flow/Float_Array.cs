using System;
using System.Xml;
using System.Xml.Serialization;

namespace IONET.Collada.Core.Data_Flow
{
	[Serializable()]
	[XmlType(AnonymousType=true)]
	public partial class Float_Array : IONET.Collada.Types.Float_Array_String
	{
		[XmlAttribute("id")]
		public string ID;
		
		[XmlAttribute("name")]
		public string Name;			
		
		[XmlAttribute("count")]
		public int Count;		
		
		[XmlAttribute("digits")]
	    [System.ComponentModel.DefaultValueAttribute(typeof(int), "6")]
		public int Digits = 6;

		[XmlAttribute("magnitude")]
	    [System.ComponentModel.DefaultValueAttribute(typeof(int), "38")]
		public int Magnitude = 38;	
		
	}
}

