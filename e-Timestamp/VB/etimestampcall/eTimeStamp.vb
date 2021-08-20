Imports System
Imports System.Diagnostics
Imports System.IO


Module eTimeStamp


    Sub Main()
        Dim filePaths() As String = Directory.GetFiles(".\transcripts\", "*.pdf")
        Dim i As Integer = 0
        Dim CMD2 As String = String.Empty
        For Each name As String In filePaths
            Console.WriteLine("file"":"" {0}", name)
            CMD2 = String.Format("/c java -jar ""timestamp.jar"" {0} ""https://time-uat.teda.th/signserver/process?workerName=teda"" ""eservice_extend_1.p12"" ""Pom@654321"" ""PKCS12"" ""2"" ", name)
            Process.Start("CMD.exe ", CMD2)
        Next

        Console.WriteLine("...\n")

    End Sub

End Module
