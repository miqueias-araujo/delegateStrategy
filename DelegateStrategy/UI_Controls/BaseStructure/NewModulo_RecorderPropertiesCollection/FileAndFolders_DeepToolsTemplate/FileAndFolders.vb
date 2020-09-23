Imports System.IO

Namespace FileAndFolders_DeepToolsTemplate
    Public Class FileAndFolders
        Implements IFileAndFolders

        Public Function ExistThisFolder(p_fullFolderPath As String) As Boolean Implements IFileAndFolders.ExistThisFolder
            Return System.IO.Directory.Exists(p_fullFolderPath)
        End Function

        Public Function ExistThisFile(p_fullFolderPath As String, p_FileDotExtention As String) As Boolean Implements IFileAndFolders.ExistThisFile
            Dim fullNewFolderPAth As String = ""
            If Not String.IsNullOrEmpty(p_FileDotExtention) Then
                fullNewFolderPAth = String.Concat(p_fullFolderPath, "\", p_FileDotExtention)
            End If
            Return System.IO.File.Exists(fullNewFolderPAth)
        End Function

        Public Function CreateThisFolder(p_hostFullFolderPath As String, p_newFolderName As String) As Boolean Implements IFileAndFolders.CreateThisFolder
            Dim fullNewFolderPAth As String = p_hostFullFolderPath
            If Not String.IsNullOrEmpty(p_newFolderName) Then
                fullNewFolderPAth = String.Concat(p_hostFullFolderPath, "\", p_newFolderName)
            End If

            Directory.CreateDirectory(fullNewFolderPAth)
            Return ExistThisFolder(fullNewFolderPAth)
        End Function

        Public Function CreateThisTextFile(p_hostFullFolderPath As String, p_FileDotExtention As String) As Boolean Implements IFileAndFolders.CreateThisTextFile
            Dim a_existThisFolder As Boolean = ExistThisFolder(p_hostFullFolderPath)
            If Not a_existThisFolder Then
                CreateThisFolder(p_hostFullFolderPath, String.Empty)
            End If
            Dim a_fullFilePath As String = String.Concat(p_hostFullFolderPath, "\", p_FileDotExtention)
            Dim existeFileName As Boolean = System.IO.File.Exists(a_fullFilePath)
            If Not existeFileName Then
                System.IO.File.Create(a_fullFilePath)
            Else
                Dim a_fileNameSplited As String() = a_fullFilePath.Split(".")
                Dim a_timeInString = DateTime.Now.ToString("yyyy-MM-dd_HH:mm:ss")
                a_fullFilePath = String.Concat(a_fileNameSplited(0), "_", a_timeInString, ".", a_fileNameSplited(1))
                System.IO.File.Create(a_fullFilePath)
            End If
            Return System.IO.File.Exists(a_fullFilePath)
        End Function

        Public Function GetListOfAllFilesInThisFolder(p_hostFullFolderPath As String) As List(Of String) Implements IFileAndFolders.GetListOfAllFilesInThisFolder
            Dim allFiles = My.Computer.FileSystem.GetFiles(p_hostFullFolderPath).ToList
            Return allFiles
        End Function

    End Class
End Namespace

