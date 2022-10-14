using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HullMaintenance
{
    public class INIHelper
    {
		private Dictionary<SectionKeyPair, string> SectionKeyDic;

		private struct SectionKeyPair
		{
			public string Section;
			public string Key;
		}
		public string FilePath { get; private set; }
        public Encoding textEncoding { get; set; }

        public INIHelper(string iniPath = "")
        {
			this.FilePath = iniPath;
			this.textEncoding = Encoding.UTF8;

			if (File.Exists(this.FilePath) == false)
			{
				return;
			}

			LoadFile();
        }

		public bool LoadFile(string filePath = "")
		{
			SectionKeyDic = new Dictionary<SectionKeyPair, string>();

			if (filePath != "")
			{
				this.FilePath = filePath;
			}

			if (File.Exists(this.FilePath) == false)
			{
				return false;
			}

			FileStream fs = new FileStream(this.FilePath, FileMode.Open, FileAccess.Read);
			StreamReader sr = new StreamReader((Stream)fs, this.textEncoding);

			string Section = "";

			while (sr.Peek() > -1)
			{
				string str = sr.ReadLine().Trim();
				if (str.StartsWith("#") == false && String.IsNullOrEmpty(str) == false)
				{
					if (String.IsNullOrEmpty(Section) == true)
					{
						if (str.StartsWith("[") && str.EndsWith("]"))
						{
							Section = str.Substring(1, str.Length - 2).Trim();
						}
					}
					else if (str.StartsWith("[") && str.EndsWith("]"))
					{
						Section = str.Substring(1, str.Length - 2).Trim();
					}
					else if (str.IndexOf('=') != -1)
					{
						SectionKeyPair sectionKey;
						string value = "";
						string[] keyValue = str.Split(new char[] { '=' }, 2);
						sectionKey.Section = Section;
						sectionKey.Key = keyValue[0].Trim();

						if (keyValue.Length > 1)
						{
							value = keyValue[1];
						}

						if (SectionKeyDic.ContainsKey(sectionKey) == false)
						{
							SectionKeyDic.Add(sectionKey, value);
						}
					}
				}
			}

			sr.Close();
			fs.Close();

			return true;
		}

		public string GetPrivateProfileString(string section, string key, string defaultVal)
		{
			string value = defaultVal;

			if (SectionKeyDic != null)
			{
				SectionKeyPair sectionKey;
				sectionKey.Section = section;
				sectionKey.Key = key;

				if (SectionKeyDic.ContainsKey(sectionKey) == true)
				{
					value = SectionKeyDic[sectionKey];
				}
			}
			else
			{
				return "";
			}

			return value;
		}
    }
}
