Namespace BaseStructure
    Public Class ConfigSystem_IO_Json
        Implements IConfigSystem_IO_Json

        Public ReadOnly Property DefaultSystemFolder As String Implements IConfigSystem_IO_Json.DefaultSystemFolder
            Get
                Throw New NotImplementedException()
            End Get
        End Property

        Public ReadOnly Property ExtensionJsonFile As String Implements IConfigSystem_IO_Json.ExtensionJsonFile
            Get
                Throw New NotImplementedException()
            End Get
        End Property

        Public ReadOnly Property TFS_Files_FolderName As String Implements IConfigSystem_IO_Json.TFS_Files_FolderName
            Get
                Throw New NotImplementedException()
            End Get
        End Property

        Public ReadOnly Property SystemConfig_Files_FolderName As String Implements IConfigSystem_IO_Json.SystemConfig_Files_FolderName
            Get
                Throw New NotImplementedException()
            End Get
        End Property
    End Class
End Namespace

