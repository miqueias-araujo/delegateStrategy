Imports UI_Controls.FileAndFolders_DeepToolsTemplate
Imports UI_Controls.PersistInJson_DeepToolsTemplate
Imports UI_Controls.ReadFromJson_DeepToolsTemplate

Public Class GenericPersistSystemObject(Of C_ConfigSystemIO As {Class, New}, IO_FileAndFolderTools As {Class, New}, R_Reader As {Class, New}, W_Writer As {Class, New})
    Implements IGenericPersistSystemObject

    Private a_configIO As IConfigSystem_IO_Json = New C_ConfigSystemIO
    Private a_fileAndFolderTools As IFileAndFolders = New IO_FileAndFolderTools
    Private a_writer As IPersistInSource = New W_Writer
    Private a_writer_PersistInSource = New IPersistInSource.SystemWriter(Of IPropertiesCollection, Boolean)(AddressOf Me.ExecWriter)
    Private a_reader_ReadFromSource = New IReadFromSource.SystemReader(Of String, IPropertiesCollection)(AddressOf Me.ExecReader)

    Public Function GetReader() As IReadFromSource.SystemReader(Of String, IPropertiesCollection) Implements IGenericPersistSystemObject.GetReader

        Return a_reader_ReadFromSource
    End Function

    Public Function GetWriter() As IPersistInSource.SystemWriter(Of IPropertiesCollection, Boolean) Implements IGenericPersistSystemObject.GetWriter

        Return a_writer_PersistInSource
    End Function

    Public Function ExecReader(p_fullJsonFilePath As String) As IPropertiesCollection Implements IGenericPersistSystemObject.ExecReader
        Dim a_configIO As IConfigSystem_IO_Json = New C_ConfigSystemIO
        Dim a_fileAndFolderTools As IFileAndFolders = New IO_FileAndFolderTools
        Dim a_reader As IReadFromSource = New R_Reader
    End Function

    Public Function ExecWriter(p_systemObject As IPropertiesCollection) As Boolean Implements IGenericPersistSystemObject.ExecWriter

        Dim folderDestin As String = String.Concat(a_configIO.DefaultSystemFolder, "\", a_configIO.Source_Files_TFS_FolderName)
        Dim newFileName As String = a_configIO.NewUniqueFileNameStrategy(p_systemObject)
        p_systemObject.PropertiesCollection_Name = newFileName.Clone
        newFileName = String.Concat(newFileName, ".", a_configIO.EndExtensionFile)
        Dim fullPathFile = String.Concat(folderDestin, "\", newFileName)
        Dim jsonObject = p_systemObject.GetMe_InJson
        Dim IsFolderCreated As Boolean = a_fileAndFolderTools.CreateThisFolder(folderDestin, String.Empty)
        Dim reponseIfWrittingIsWellDonne = a_writer.PersistItThere(jsonObject, fullPathFile)
        Return reponseIfWrittingIsWellDonne
    End Function
End Class
