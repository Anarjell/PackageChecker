﻿namespace PackageChecker.Files
{
	public class FileRecord
	{
		public string Signature { get; set; }

		public string FilePath { get; set; }

		public string FileVersion { get; set; }

		public string ProductVersion { get; set; }

		public string AssemblyName { get; set; }

		public string ReferencesCheck { get; set; }

		public bool DoHighlight { get; set; }
	}
}
