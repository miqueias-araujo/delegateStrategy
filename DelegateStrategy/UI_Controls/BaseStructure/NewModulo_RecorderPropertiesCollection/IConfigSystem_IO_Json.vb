Public Interface IConfigSystem_IO_Json
    ReadOnly Property DefaultSystemFolder As String
    ReadOnly Property EndExtensionFile As String
    ReadOnly Property Source_Files_TFS_FolderName As String
    ReadOnly Property SystemConfig_Files_FolderName As String
    Function NewUniqueFileNameStrategy(p_systemObject As IPropertiesCollection) As String
End Interface
