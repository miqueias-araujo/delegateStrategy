Public Class Mediator
    Implements IMediator
    Sub New()
        DictProperties_KeyStringControlName_ValueDict_KeyStringControlPropertyName_ValueStringPropertyValue = New Dictionary(Of String, Dictionary(Of String, String))
        DictHelpers_KeyStringNameProperty_ValueIHelper = New Dictionary(Of String, IHelper)
        DictPropertiesControlNames_KeyStringNameProperty_ValueListOfStringControlName = New Dictionary(Of String, List(Of String))
        DictControlNamePropertyName_KeyStringControlName_ValueStringPropertyName = New Dictionary(Of String, String)
        DictHelpers_KeyStringNameProperty_ValueIHelper.Add("Name", New ValidateName()
    End Sub

    Private Property DictProperties_KeyStringControlName_ValueDict_KeyStringControlPropertyName_ValueStringPropertyValue As Dictionary(Of String, Dictionary(Of String, String)) Implements IMediator.DictProperties_KeyStringControlName_ValueDict_KeyStringControlPropertyName_ValueStringPropertyValue

    Private Property DictHelpers_KeyStringNameProperty_ValueIHelper As Dictionary(Of String, IHelper) Implements IMediator.DictHelpers_KeyStringNameProperty_ValueIHelper

    Private Property DictPropertiesControlNames_KeyStringNameProperty_ValueListOfStringControlName As Dictionary(Of String, List(Of String)) Implements IMediator.DictPropertiesControlNames_KeyStringNameProperty_ValueListOfStringControlName

    Private Property DictControlNamePropertyName_KeyStringControlName_ValueStringPropertyName As Dictionary(Of String, String) Implements IMediator.DictControlNamePropertyName_KeyStringControlName_ValueStringPropertyName

    Public Sub ValidateControl(p_controlName As String) Implements IMediator.ValidateControl
        Dim propertyName As String = DictControlNamePropertyName_KeyStringControlName_ValueStringPropertyName(p_controlName)
        Dim value As String = DictProperties_KeyStringControlName_ValueDict_KeyStringControlPropertyName_ValueStringPropertyValue(p_controlName)("Value")
        Dim reponseValidation As String = DictHelpers_KeyStringNameProperty_ValueIHelper(propertyName).Validate(value)
        MsgBox(reponseValidation)

    End Sub

    Public Sub AddControlTextBox(p_controlTextBox As TextBox, p_propertyName As String) Implements IMediator.AddControlTextBox
        Dim a_controlName As String = p_controlTextBox.Name
        Dim a_typeFullName As String = p_controlTextBox.GetType.FullName
        Dim a_value = p_controlTextBox.Text
        Dim a_backColorName = p_controlTextBox.BackColor.Name
        Dim a_existProperty_In_DictPropertiesControlNames As Boolean = DictPropertiesControlNames_KeyStringNameProperty_ValueListOfStringControlName.ContainsKey(p_propertyName)
        Dim a_existProperty_In_DictHelpers As Boolean = DictHelpers_KeyStringNameProperty_ValueIHelper.ContainsKey(p_propertyName)
        Dim a_existProperty = a_existProperty_In_DictHelpers AndAlso a_existProperty_In_DictPropertiesControlNames

        Dim a_existeControlName_In_DictControlNamePropertyName_KeyStringControlName_ValueStringPropertyName = DictControlNamePropertyName_KeyStringControlName_ValueStringPropertyName.ContainsKey(a_controlName)

        If Not a_existProperty_In_DictHelpers Then
            Throw New Exception(String.Format("La propriete {0} n'est pas configure", p_propertyName))
        End If

        If Not a_existeControlName_In_DictControlNamePropertyName_KeyStringControlName_ValueStringPropertyName Then
            DictControlNamePropertyName_KeyStringControlName_ValueStringPropertyName.Add(a_controlName, p_propertyName)
        Else
            DictControlNamePropertyName_KeyStringControlName_ValueStringPropertyName(a_controlName) = p_propertyName
        End If

        If Not a_existProperty Then
            DictPropertiesControlNames_KeyStringNameProperty_ValueListOfStringControlName.Add(p_propertyName, New List(Of String) From {a_controlName})
            DictProperties_KeyStringControlName_ValueDict_KeyStringControlPropertyName_ValueStringPropertyValue.Add(
               a_controlName,
               New Dictionary(Of String, String)())
            DictProperties_KeyStringControlName_ValueDict_KeyStringControlPropertyName_ValueStringPropertyValue(a_controlName).
                Add("TypeFullName", a_typeFullName)
            DictProperties_KeyStringControlName_ValueDict_KeyStringControlPropertyName_ValueStringPropertyValue(a_controlName).
                Add("Value", a_value)
            DictProperties_KeyStringControlName_ValueDict_KeyStringControlPropertyName_ValueStringPropertyValue(a_controlName).
                Add("BackColorName", a_backColorName)

        Else
            DictProperties_KeyStringControlName_ValueDict_KeyStringControlPropertyName_ValueStringPropertyValue(a_controlName) =
                New Dictionary(Of String, String)()
            DictProperties_KeyStringControlName_ValueDict_KeyStringControlPropertyName_ValueStringPropertyValue(a_controlName).
                Add("TypeFullName", a_typeFullName)
            DictProperties_KeyStringControlName_ValueDict_KeyStringControlPropertyName_ValueStringPropertyValue(a_controlName).
                Add("Value", a_value)
            DictProperties_KeyStringControlName_ValueDict_KeyStringControlPropertyName_ValueStringPropertyValue(a_controlName).
                Add("BackColorName", a_backColorName)
        End If

    End Sub
End Class
