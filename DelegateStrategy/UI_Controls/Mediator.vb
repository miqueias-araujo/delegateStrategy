Imports UI_Controls.StructuresSystem

Public Class Mediator
    Implements IMediator
    Sub New()
        DictComponentBean_KeyStringComponentName = New Dictionary(Of String, ComponentBean)
        DictSystemComponent_KeyStringComponentName = New Dictionary(Of String, SystemComponent)
        DictHelpers_KeyStringNameProperty_ValueIHelper = New Dictionary(Of String, IHelper)
        DictHelpers_KeyStringNameProperty_ValueIHelper.Add("Name", New Helper(New ValidateName().getValidator))
    End Sub

    Public Property DictSystemComponent_KeyStringComponentName As Dictionary(Of String, SystemComponent) Implements IMediator.DictSystemComponent_KeyStringComponentName
    Public Property DictComponentBean_KeyStringComponentName As Dictionary(Of String, ComponentBean) Implements IMediator.DictComponentBean_KeyStringComponentName
    Private Property Name As String Implements IMediator.Name
    Private Property DictHelpers_KeyStringNameProperty_ValueIHelper As Dictionary(Of String, IHelper) Implements IMediator.DictHelpers_KeyStringNameProperty_ValueIHelper

    Public Sub ValidateControl(p_controlName As String, p_value As String) Implements IMediator.ValidateControl
        UpdateSystemComponent(p_controlName)
        Dim a_systemComponent As SystemComponent = DictSystemComponent_KeyStringComponentName(p_controlName)
        Dim reponseValidation As ResponseValidation = DictHelpers_KeyStringNameProperty_ValueIHelper(a_systemComponent.SystemPropertyName).Validate(a_systemComponent)
        UpdateComponentBean(reponseValidation.Component)

        If Not IsNothing(reponseValidation.ComponentMessage) Then
            MsgBox(reponseValidation.ComponentMessage.Message)
        End If

    End Sub

    Private Sub UpdateComponentBean(p_component As SystemComponent) Implements IMediator.UpdateComponentBean
        Dim a_controlName As String = p_component.ComponentName
        Dim a_componentBean As ComponentBean = DictComponentBean_KeyStringComponentName(p_component.ComponentName)
        Dim a_newTextBoxControl As New TextBox
        If a_componentBean.ComponentTypeFullName.Equals(a_newTextBoxControl.GetType.FullName) Then
            a_newTextBoxControl = a_componentBean.ComponentObject
            a_newTextBoxControl.BackColor = Color.FromName(p_component.ComponentBackColorName)
            a_newTextBoxControl.ForeColor = Color.FromName(p_component.ComponentFontColorName)
            a_newTextBoxControl.Font = New Font(a_newTextBoxControl.Font, p_component.ComponentFontStyleCode)
            a_newTextBoxControl.Text = p_component.ComponentValue
            a_newTextBoxControl.Refresh()
        Else
            Throw New Exception(String.Format("The type of this component in Form is not configuratede: {0}", a_componentBean.ComponentTypeFullName))
        End If
    End Sub

    Private Sub UpdateSystemComponent(p_controlName As String) Implements IMediator.UpdateSystemComponent
        Dim a_componentBean As ComponentBean = DictComponentBean_KeyStringComponentName(p_controlName)
        Dim a_textBoxToGetType As New TextBox
        If Not a_componentBean.ComponentTypeFullName.Equals(a_textBoxToGetType.GetType.FullName) Then
            Throw New Exception(String.Format("The type of this component in Form is not configuratede: {0}", a_componentBean.ComponentTypeFullName))
        End If
        Dim a_newSystemComponent = CastTextBoxToSystemComponent(a_componentBean.ComponentObject, a_componentBean.SystemPropertyName)
        DictSystemComponent_KeyStringComponentName(p_controlName) = a_newSystemComponent
    End Sub

    Public Sub AddControlTextBox(p_controlTextBox As TextBox, p_propertyName As String) Implements IMediator.AddControlTextBox
        AddComponentBean(p_controlTextBox, p_propertyName)
        AddSystemComponent(p_controlTextBox, p_propertyName)
    End Sub

    Private Sub AddSystemComponent(p_controlTextBox As TextBox, p_systemPropertyName As String) Implements IMediator.AddSystemComponent
        If IsNothing(p_controlTextBox) Then
            Throw New Exception("This Control is Nothing")
        End If
        Dim a_controlName As String = p_controlTextBox.Name
        Dim a_isComponentIn_DictComponentBean As Boolean = Me.DictSystemComponent_KeyStringComponentName.ContainsKey(a_controlName)
        Dim a_systemComponent As SystemComponent = CastTextBoxToSystemComponent(p_controlTextBox, p_systemPropertyName)
        If a_isComponentIn_DictComponentBean Then
            DictSystemComponent_KeyStringComponentName(a_controlName) = a_systemComponent
        Else
            DictSystemComponent_KeyStringComponentName.Add(a_controlName, a_systemComponent)
        End If
    End Sub

    Private Function CastTextBoxToSystemComponent(p_controlTextBox As TextBox, p_systemPropertyName As String) As SystemComponent Implements IMediator.CastTextBoxToSystemComponent

        Dim a_systemComponent As New SystemComponent With {
            .SystemPropertyName = p_systemPropertyName,
            .ComponentBackColorName = p_controlTextBox.BackColor.Name,
            .ComponentFontColorName = p_controlTextBox.ForeColor.Name,
            .ComponentFontStyleCode = p_controlTextBox.Font.Style,
            .ComponentName = p_controlTextBox.Name,
            .ComponentValueTypeFullName = p_controlTextBox.Text.GetType.FullName,
            .ComponentValue = p_controlTextBox.Text
        }
        Return a_systemComponent
    End Function

    Private Sub AddComponentBean(p_controlTextBox As TextBox, p_systemPropertyName As String) Implements IMediator.AddComponentBean
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
