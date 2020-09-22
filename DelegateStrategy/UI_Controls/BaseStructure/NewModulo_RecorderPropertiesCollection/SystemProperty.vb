Imports System.Text.Json
Public Class SystemProperty
    Implements ISystemProperty

    Public Sub New(p_propertiesCollectionHost As IPropertiesCollection, p_object As Object)
        Me.PropertiesCollectionHost_GuidCodeIdentity = p_propertiesCollectionHost.PropertiesCollection_GuidCodeIdentity
        'Dim a_type As Type = Type.GetType(p_objectTypeFullName)
        'Dim obj_converted = CTypeDynamic(p_object, a_type)
        Dim a_jsonObject As String = JsonSerializer.Serialize(p_object)
        Dim a_TypeFullName As String = p_object.GetType.FullName
        Me.KV_KeyObjectTypeFullName_ValueJsonObject = New KeyValuePair(Of String, String)(a_TypeFullName, a_jsonObject)
    End Sub

    Public Property KV_KeyObjectTypeFullName_ValueJsonObject As KeyValuePair(Of String, String) Implements ISystemProperty.KV_KeyObjectTypeFullName_ValueJsonObject

    Public Property PropertiesCollectionHost_GuidCodeIdentity As String Implements ISystemProperty.PropertiesCollectionHost_GuidCodeIdentity

    Public Function GetThisObject() As KeyValuePair(Of String, Object) Implements ISystemProperty.GetThisObject
        Dim a_jsonObject = Me.KV_KeyObjectTypeFullName_ValueJsonObject.Value
        Dim a_typeFullName = Me.KV_KeyObjectTypeFullName_ValueJsonObject.Key
        Dim a_type As Type = Type.GetType(a_typeFullName)
        Dim a_object = JsonSerializer.Deserialize(a_jsonObject, a_type)
        Dim reponse As New KeyValuePair(Of String, Object)(a_typeFullName, a_object)
        Return reponse
    End Function

    Public Function GetMe_InJson() As String Implements ISystemProperty.GetMe_InJson
        Return JsonSerializer.Serialize(KV_KeyObjectTypeFullName_ValueJsonObject)
    End Function
End Class
