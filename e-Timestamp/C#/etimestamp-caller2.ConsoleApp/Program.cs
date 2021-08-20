using System;
using System.Diagnostics;

using System.IO;

namespace etimestampcaller2.ConsoleApp
{
    class MainClass
    {
        public static void Main(string[] args)
        {
			//String CMD = "/c java -jar \"timestamp.jar\" \".\\transcripts\\example_transcript_U_signed1.pdf\" \"https://time-uat.teda.th/signserver/process?workerName=teda\" \"eservice.p12\" \"DGASC4321\" \"PKCS12\" \"2\" ";

			String CMD2 = string.Empty; 
			

			//@@@@ Test open source of Transcript pdf file foler. and get name of its //
			string[] filePaths = Directory.GetFiles(@".\transcripts\", "*.pdf");
			int i = 0;
			foreach(string name in filePaths)
			{
				++i;
				Console.WriteLine("{0}.) {1} ",i,name);
                
                		CMD2 = String.Format("/c java -jar \"timestamp.jar\" \"{0}\" \"https://time-uat.teda.th/signserver/process?workerName=teda\" \"eservice_extend_1.p12\" \"Passxxxx\" \"PKCS12\" \"2\" ", name);
                		Process.Start("CMD.exe ", CMD2);
			}
			Console.WriteLine("...\n");
			
        }
    }
}
