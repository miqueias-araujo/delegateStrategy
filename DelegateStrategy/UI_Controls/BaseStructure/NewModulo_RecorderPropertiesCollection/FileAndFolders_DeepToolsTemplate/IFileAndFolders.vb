Namespace FileAndFolders_DeepToolsTemplate
    Public Interface IFileAndFolders
        Function ExistThisFolder(p_fullFolderPath As String) As Boolean
        Function ExistThisFile(p_fullFolderPath As String, p_FileDotExtention As String) As Boolean
        Function CreateThisFolder(p_hostFullFolderPath As String, p_newFolderName As String) As Boolean
        Function CreateThisTextFile(p_hostFullFolderPath As String, p_FileDotExtention As String) As Boolean
        Function GetListOfAllFilesInThisFolder(p_hostFullFolderPath As String) As List(Of String)
    End Interface
End Namespace

