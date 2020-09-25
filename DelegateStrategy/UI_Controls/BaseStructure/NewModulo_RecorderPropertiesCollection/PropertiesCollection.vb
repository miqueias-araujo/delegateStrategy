Imports System.Reflection
Imports System.Text.Json
Public Class PropertiesCollection(Of I_SystemObjectInterface As {Class, New})
    Inherits Dictionary(Of String, ISystemProperty)
    Implements IPropertiesCollection

    Private _PropertiesCollection_GuidCodeIdentity As String = System.Guid.NewGuid.ToString()
    Public Property PropertiesCollection_Name As String Implements IPropertiesCollection.PropertiesCollection_Name
    Public ReadOnly Property PropertiesCollection_TypeFullName As String Implements IPropertiesCollection.PropertiesCollection_TypeFullName
    Public ReadOnly Property PropertiesCollection_GuidCodeIdentity As String Implements IPropertiesCollection.PropertiesCollection_GuidCodeIdentity
        Get
            Return _PropertiesCollection_GuidCodeIdentity
        End Get

    End Property

    Public Sub New(p_object As Object)
        'Me.PropertiesCollection_GuidCodeIdentity = System.Guid.NewGuid.ToString()
        Me.PropertiesCollection_TypeFullName = p_object.GetType.FullName
        'Me.PropertiesCollection_Name = ??todo: not in use, the need we it ??


        Dim a_PropertiesFromGenericTypeInterface As List(Of PropertyInfo) = GetType(I_SystemObjectInterface).GetProperties.ToList
        Dim a_PropertiesFromObject As List(Of PropertyInfo) = p_object.GetType.GetProperties.ToList
        Dim a_SameProperties As List(Of PropertyInfo) = (From a_propGeneric In a_PropertiesFromGenericTypeInterface
                                                         Where a_PropertiesFromObject.Contains(a_propGeneric)).ToList
        If Not IsNothing(a_SameProperties) AndAlso a_SameProperties.Count > 0 Then
            For Each a_objProp As PropertyInfo In a_SameProperties
                Dim a_propName As String = a_objProp.Name
                Dim a_obj = a_objProp.GetValue(p_object, Reflection.BindingFlags.GetProperty, Nothing, Nothing, System.Globalization.CultureInfo.CurrentCulture)

                Dim sysProp As ISystemProperty = New SystemProperty(Me, a_obj)
                Add(a_propName, sysProp)
            Next
        End If


    End Sub


    Public Shadows Sub Add(key As String, value As ISystemProperty)
        Dim ExistThisPropertyNameInThisCollection As Boolean = Me.ContainsKey(key)
        If ExistThisPropertyNameInThisCollection Then
            Me(key) = value
        Else
            MyBase.Add(key, value)
        End If

    End Sub

    Public Shadows Sub Add(key As String, value As Object)
        Dim ExistThisPropertyNameInThisCollection As Boolean = Me.ContainsKey(key)
        If ExistThisPropertyNameInThisCollection Then
            Me(key) = New SystemProperty(Me, value)
        Else
            MyBase.Add(key, New SystemProperty(Me, value))
        End If

    End Sub

    Public Function GetMe_InJson() As String Implements IPropertiesCollection.GetMe_InJson
        Dim propertiesList As New List(Of String)
        Dim existPropertiesInMe As Boolean = Me.Keys.Count > 0
        If existPropertiesInMe Then
            For Each kv As KeyValuePair(Of String, ISystemProperty) In Me
                Dim a_propName As String = kv.Key
                Dim a_propJsonObj As String = kv.Value.GetMe_InJson
                Dim a_propKVJsonObj As New KeyValuePair(Of String, String)(a_propName, a_propJsonObj)
                Dim a_propCompletJsonObj As String = JsonSerializer.Serialize(a_propKVJsonObj)
                propertiesList.Add(a_propCompletJsonObj)
            Next
            Dim reponse_KV = New KeyValuePair(Of IPropertiesCollection, List(Of String))(Me, propertiesList)
            Return JsonSerializer.Serialize(reponse_KV)
        End If
        Return JsonSerializer.Serialize(Me)
    End Function
    Public Function GetThisObject() As I_SystemObjectInterface
        'Dim a_obj As I_SystemObjectInterface = New I_SystemObjectInterface
        Dim a_objReponse As I_SystemObjectInterface = New I_SystemObjectInterface
        For Each a_objProp As PropertyInfo In a_objReponse.GetType.GetProperties
            Dim a_propName = a_objProp.Name
            Dim a_propTypeFullName = a_objProp.Name.GetType

            If a_propTypeFullName.FullName.Equals(Me(a_propName).KV_KeyObjectTypeFullName_ValueJsonObject.Key) Then
                a_objProp.SetValue(a_objReponse, Me(a_propName).KV_KeyObjectTypeFullName_ValueJsonObject.Value)
            End If

        Next

        Return a_objReponse
    End Function
End Class
