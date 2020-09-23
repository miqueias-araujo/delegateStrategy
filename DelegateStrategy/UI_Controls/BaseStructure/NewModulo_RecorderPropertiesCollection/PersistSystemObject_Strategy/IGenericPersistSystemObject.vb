Imports UI_Controls.PersistInJson_DeepToolsTemplate
Imports UI_Controls.ReadFromJson_DeepToolsTemplate

Public Interface IGenericPersistSystemObject
    Function GetReader() As IReadFromSource.SystemReader(Of String, IPropertiesCollection)
    Function GetWriter() As IPersistInSource.SystemWriter(Of IPropertiesCollection, Boolean)
    Function ExecReader(p_fullJsonFilePath As String) As IPropertiesCollection
    Function ExecWriter(p_systemObject As IPropertiesCollection) As Boolean
End Interface
