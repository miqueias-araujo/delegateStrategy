Namespace BaseStructure
    Public Class ConfigSystem_IO_Json
        Implements IConfigSystem_IO_Json

        Public Sub New()
            Me.a_systemConfig_Files_FolderName = Environment.CurrentDirectory
        End Sub
        Dim a_systemConfig_Files_FolderName As String = Environment.CurrentDirectory
        Public ReadOnly Property DefaultSystemFolder As String Implements IConfigSystem_IO_Json.DefaultSystemFolder
            Get
                Return a_systemConfig_Files_FolderName
            End Get
        End Property

        Public ReadOnly Property EndExtensionFile As String Implements IConfigSystem_IO_Json.EndExtensionFile
            Get
                Return "json"
            End Get
        End Property

        Public ReadOnly Property Source_Files_TFS_FolderName As String Implements IConfigSystem_IO_Json.Source_Files_TFS_FolderName
            Get
                Return "TFS_Files"
            End Get
        End Property

        Public ReadOnly Property SystemConfig_Files_FolderName As String Implements IConfigSystem_IO_Json.SystemConfig_Files_FolderName
            Get
                Return "System_Config_Files"
            End Get
        End Property

        Public Function NewUniqueFileNameStrategy(p_systemObject As IPropertiesCollection) As String Implements IConfigSystem_IO_Json.NewUniqueFileNameStrategy
            Dim a_guid As String = String.Empty
            If Not IsNothing(p_systemObject.PropertiesCollection_GuidCodeIdentity) AndAlso p_systemObject.PropertiesCollection_GuidCodeIdentity.Length > 5 Then
                a_guid = p_systemObject.PropertiesCollection_GuidCodeIdentity
            Else
                a_guid = System.Guid.NewGuid.ToString
            End If
            Dim objTypeName As String = String.Empty

            If Not IsNothing(p_systemObject) Then
                objTypeName = p_systemObject.GetType.Name
            End If

            Return String.Concat(objTypeName, "_", a_guid)

        End Function


    End Class
End Namespace

