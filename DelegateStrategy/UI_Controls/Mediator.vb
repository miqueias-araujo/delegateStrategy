Imports UI_Controls.StructuresSystem

Public Class Mediator
    Implements IMediator
    Sub New()
        DictProperties_KeyStringControlName_ValueDict_KeyStringControlPropertyName_ValueStringPropertyValue = New Dictionary(Of String, Dictionary(Of String, String))
        DictPropertiesControlNames_KeyStringNameProperty_ValueListOfStringControlName = New Dictionary(Of String, List(Of String))
        DictControlNamePropertyName_KeyStringControlName_ValueStringPropertyName = New Dictionary(Of String, String)

        DictComponentBean_KeyStringComponentName = New Dictionary(Of String, ComponentBean)
        DictComponent_KeyStringComponentName = New Dictionary(Of String, SystemComponent)

        DictHelpers_KeyStringNameProperty_ValueIHelper = New Dictionary(Of String, IHelper)
        DictHelpers_KeyStringNameProperty_ValueIHelper.Add("Name", New Helper(New ValidateName().getValidator_v2))
    End Sub

    Public Property DictComponent_KeyStringComponentName As Dictionary(Of String, SystemComponent) Implements IMediator.DictComponent_KeyStringComponentName

    Public Property DictComponentBean_KeyStringComponentName As Dictionary(Of String, ComponentBean) Implements IMediator.DictComponentBean_KeyStringComponentName

    'Public Property DictHelper_KeyStringComponentName As Dictionary(Of String, IHelper) Implements IMediator.DictHelper_KeyStringComponentName
    Public Property Name As String Implements IMediator.Name

    Private Property DictProperties_KeyStringControlName_ValueDict_KeyStringControlPropertyName_ValueStringPropertyValue As Dictionary(Of String, Dictionary(Of String, String)) Implements IMediator.DictProperties_KeyStringControlName_ValueDict_KeyStringControlPropertyName_ValueStringPropertyValue

    Private Property DictHelpers_KeyStringNameProperty_ValueIHelper As Dictionary(Of String, IHelper) Implements IMediator.DictHelpers_KeyStringNameProperty_ValueIHelper

    Private Property DictPropertiesControlNames_KeyStringNameProperty_ValueListOfStringControlName As Dictionary(Of String, List(Of String)) Implements IMediator.DictPropertiesControlNames_KeyStringNameProperty_ValueListOfStringControlName

    Private Property DictControlNamePropertyName_KeyStringControlName_ValueStringPropertyName As Dictionary(Of String, String) Implements IMediator.DictControlNamePropertyName_KeyStringControlName_ValueStringPropertyName

    Public Sub ValidateControl(p_controlName As String, p_value As String) Implements IMediator.ValidateControl
        DictProperties_KeyStringControlName_ValueDict_KeyStringControlPropertyName_ValueStringPropertyValue(p_controlName)("Value") = p_value
        Dim propertyName As String = DictControlNamePropertyName_KeyStringControlName_ValueStringPropertyName(p_controlName)
        Dim value As String = DictProperties_KeyStringControlName_ValueDict_KeyStringControlPropertyName_ValueStringPropertyValue(p_controlName)("Value")
        Dim reponseValidation As String = DictHelpers_KeyStringNameProperty_ValueIHelper(propertyName).Validate(value)
        MsgBox(reponseValidation)

    End Sub

    Public Sub ValidateControl_v2(p_controlName As String, p_value As String) Implements IMediator.ValidateControl_v2
        'DictProperties_KeyStringControlName_ValueDict_KeyStringControlPropertyName_ValueStringPropertyValue(p_controlName)("Value") = p_value
        Dim a_systemComponent As SystemComponent = DictComponent_KeyStringComponentName(p_controlName)

        'Dim propertyName As String = DictControlNamePropertyName_KeyStringControlName_ValueStringPropertyName(p_controlName)
        'Dim value As String = DictProperties_KeyStringControlName_ValueDict_KeyStringControlPropertyName_ValueStringPropertyValue(p_controlName)("Value")
        Dim reponseValidation As ResponseValidation = DictHelpers_KeyStringNameProperty_ValueIHelper(a_systemComponent.SystemPropertyName).Validate_v2(a_systemComponent)
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

    Public Sub UpdateControlTextBox(p_textBox As TextBox, p_systemPropertyName As String) Implements IMediator.UpdateControlTextBox
        Throw New NotImplementedException()
    End Sub

    Public Sub SetControlName(p_textBox As TextBox) Implements IMediator.SetControlName
        'AddControlTextBox(p_textBox, "Name")
        AddControlTextBox_v2(p_textBox, "Name")
    End Sub
    Public Sub AddControlTextBox_v2(p_controlTextBox As TextBox, p_propertyName As String) Implements IMediator.AddControlTextBox_v2
        AddComponentBean(p_controlTextBox, p_propertyName)
        AddSystemComponent(p_controlTextBox, p_propertyName)
    End Sub

    Private Sub AddSystemComponent(p_controlTextBox As TextBox, p_systemPropertyName As String)
        If IsNothing(p_controlTextBox) Then
            Throw New Exception("This Control is Nothing")
        End If
        Dim a_controlName As String = p_controlTextBox.Name
        Dim a_isComponentIn_DictComponentBean As Boolean = Me.DictComponent_KeyStringComponentName.ContainsKey(a_controlName)
        Dim a_systemComponent As New SystemComponent With {
            .SystemPropertyName = p_systemPropertyName,
            .ComponentBackColorName = p_controlTextBox.BackColor.Name,
            .ComponentFontColorName = p_controlTextBox.ForeColor.Name,
            .ComponentFontStyleCode = p_controlTextBox.Font.Style,
            .ComponentName = p_controlTextBox.Name,
            .ComponentValueTypeFullName = p_controlTextBox.Text.GetType.FullName,
            .ComponentValue = p_controlTextBox.Text
        }
        If a_isComponentIn_DictComponentBean Then
            DictComponent_KeyStringComponentName(a_controlName) = a_systemComponent
        Else
            DictComponent_KeyStringComponentName.Add(a_controlName, a_systemComponent)
        End If
    End Sub

    Private Sub AddComponentBean(p_controlTextBox As TextBox, p_systemPropertyName As String) ' todo: implement from interface
        If IsNothing(p_controlTextBox) Then
            Throw New Exception("This Control is Nothing")
        End If
        Dim a_controlName As String = p_controlTextBox.Name
        Dim a_isComponentIn_DictComponentBean As Boolean = Me.DictComponentBean_KeyStringComponentName.ContainsKey(a_controlName)
        Dim a_componenteBean As New ComponentBean With {
                .ComponentName = a_controlName,
                .ComponentTypeFullName = p_controlTextBox.GetType.FullName,
                .ComponentObject = p_controlTextBox,
                .SystemPropertyName = p_systemPropertyName}
        If a_isComponentIn_DictComponentBean Then
            DictComponentBean_KeyStringComponentName(a_controlName) = a_componenteBean
        Else
            DictComponentBean_KeyStringComponentName.Add(a_controlName, a_componenteBean)
        End If
    End Sub
End Class
