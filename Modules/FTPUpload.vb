Imports System.Net
Imports System.IO
Imports System.Collections
Imports System.Environment

Module FTPUpload
    'Dim Application_DirectoryPath as String = My.Application.Info.DirectoryPath

    Public Sub FileUpload_All(ByRef SubFolder As String)

        'TODO: FileUpload_All: Create File in SpecialFolder.Personal

        Dim My_FTP_FileUpload As String = GetFolderPath(SpecialFolder.Personal) + SubFolder ' "Uploads"

        For Each CurrentFile As String In IO.Directory.GetFiles(My_FTP_FileUpload)

            My.Computer.Network.UploadFile(CurrentFile, _
                                           My.Settings.FTP_Req_URL + "/" + New IO.FileInfo(CurrentFile).Name, _
                                           My.Settings.FTP_Email, _
                                           My.Settings.FTP_Passw, _
                                           My.Settings.APPLICATION_DEBUG, _
                                           500, _
                                           FileIO.UICancelOption.ThrowException)
            'TODO: FileUpload_All: Add file names to a log of some kind
        Next
        'TODO: FileUpload_All: Display the Log Array()
    End Sub


    'Structure ReadNames
    '    Shared Names As New ArrayList()
    'End Structure
    'Private Function Read_File_Names() As ReadNames
    '    Dim ReadWebRequest As FtpWebRequest = FtpWebRequest.Create(My.Settings.FTP_Req_URL)

    '    ReadWebRequest.Credentials = New NetworkCredential(My.Settings.FTP_Email, My.Settings.FTP_Passw)
    '    ReadWebRequest.Method = WebRequestMethods.Ftp.ListDirectory

    '    Dim StreamReader As New StreamReader(ReadWebRequest.GetResponse().GetResponseStream())

    '    Dim StringRead As String = StreamReader.ReadLine()

    '    While Not StringRead Is Nothing

    '        ReadNames.Names.Add(StringRead)
    '        StringRead = StreamReader.ReadLine()
    '    End While


    '    StreamReader.Close()
    '    StreamReader = Nothing
    '    ReadWebRequest = Nothing

    'End Function

End Module
