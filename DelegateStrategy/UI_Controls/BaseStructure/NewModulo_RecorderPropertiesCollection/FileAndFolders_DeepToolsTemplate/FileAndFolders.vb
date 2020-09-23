Namespace FileAndFolders_DeepToolsTemplate
    Public Class FileAndFolders
        Implements IFileAndFolders

        Public Function ExistThisFolder(p_fullFolderPath As String) As Boolean Implements IFileAndFolders.ExistThisFolder
            Throw New NotImplementedException()
        End Function

        Public Function ExistThisFile(p_fullFolderPath As String, p_FileDotExtention As String) As Boolean Implements IFileAndFolders.ExistThisFile
            Throw New NotImplementedException()
        End Function

        Public Function CreateThisFolder(p_hostFullFolderPath As String, p_newFolderName As String) As Boolean Implements IFileAndFolders.CreateThisFolder
            Throw New NotImplementedException()
        End Function

        Public Function CreateThisTextFile(p_hostFullFolderPath As String, p_FileDotExtention As String) As Boolean Implements IFileAndFolders.CreateThisTextFile
            Throw New NotImplementedException()
        End Function

        Public Function GetListOfAllFilesInThisFolder(p_hostFullFolderPath As String) As List(Of String) Implements IFileAndFolders.GetListOfAllFilesInThisFolder
            Throw New NotImplementedException()
        End Function
    End Class
End Namespace

