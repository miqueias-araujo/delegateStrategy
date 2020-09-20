Imports UI_Controls.BaseStructure
Imports UI_Controls.HelperFacade

Namespace WinFormMediator
    Public Class MediatorWinForm_TextBox
        Implements IMediatorWinForm_TextBox
        Public Property MasterMediator As IMediator Implements IMediatorWinForm_TextBox.MasterMediator
        Sub New(p_masterMediator As IMediator)
            Me.MasterMediator = p_masterMediator
            Dim helperForNameSystemProperty As IHelper = New Helper().GetHelperForNameSystemProperty
            MasterMediator.DictHelpers_KeyStringNameProperty_ValueIHelper.Add("Name", helperForNameSystemProperty)
        End Sub

        Public Sub ValidateControl(p_controlName As String, p_value As String) Implements IMediatorWinForm_TextBox.ValidateControl
            UpdateSystemComponent(p_controlName)
            Dim a_systemComponent As ISystemComponent = MasterMediator.DictSystemComponent_KeyStringComponentName(p_controlName)
            Dim reponseValidation As IResponseValidation = MasterMediator.DictHelpers_KeyStringNameProperty_ValueIHelper(a_systemComponent.SystemPropertyName).Validate(a_systemComponent)
            UpdateComponentBean(reponseValidation.Component)

            If Not IsNothing(reponseValidation.ComponentMessage) Then
                MsgBox(reponseValidation.ComponentMessage.Message)
            End If

        End Sub
        Friend Sub UpdateComponentBean(p_component As ISystemComponent) Implements IMediatorWinForm_TextBox.UpdateComponentBean
            Dim a_controlName As String = p_component.ComponentName
            Dim a_componentBean As IComponentBean = MasterMediator.DictComponentBean_KeyStringComponentName(p_component.ComponentName)
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
        Friend Sub UpdateSystemComponent(p_controlName As String) Implements IMediatorWinForm_TextBox.UpdateSystemComponent
            Dim a_componentBean As IComponentBean = MasterMediator.DictComponentBean_KeyStringComponentName(p_controlName)
            Dim a_textBoxToGetType As New TextBox
            If Not a_componentBean.ComponentTypeFullName.Equals(a_textBoxToGetType.GetType.FullName) Then
                Throw New Exception(String.Format("The type of this component in Form is not configuratede: {0}", a_componentBean.ComponentTypeFullName))
            End If
            Dim a_newSystemComponent = CastTextBoxToSystemComponent(a_componentBean.ComponentObject, a_componentBean.SystemPropertyName)
            MasterMediator.DictSystemComponent_KeyStringComponentName(p_controlName) = a_newSystemComponent
        End Sub

        Public Sub AddControlTextBox(p_controlTextBox As TextBox, p_propertyName As String) Implements IMediatorWinForm_TextBox.AddControlTextBox
            AddComponentBean(p_controlTextBox, p_propertyName)
            AddSystemComponent(p_controlTextBox, p_propertyName)
        End Sub

        Private Sub AddSystemComponent(p_controlTextBox As TextBox, p_systemPropertyName As String) Implements IMediatorWinForm_TextBox.AddSystemComponent
            If IsNothing(p_controlTextBox) Then
                Throw New Exception("This Control is Nothing")
            End If
            Dim a_controlName As String = p_controlTextBox.Name
            Dim a_isComponentIn_DictComponentBean As Boolean = MasterMediator.DictSystemComponent_KeyStringComponentName.ContainsKey(a_controlName)
            Dim a_systemComponent As ISystemComponent = CastTextBoxToSystemComponent(p_controlTextBox, p_systemPropertyName)
            If a_isComponentIn_DictComponentBean Then
                MasterMediator.DictSystemComponent_KeyStringComponentName(a_controlName) = a_systemComponent
            Else
                MasterMediator.DictSystemComponent_KeyStringComponentName.Add(a_controlName, a_systemComponent)
            End If
        End Sub

        Private Function CastTextBoxToSystemComponent(p_controlTextBox As TextBox, p_systemPropertyName As String) As ISystemComponent Implements IMediatorWinForm_TextBox.CastTextBoxToSystemComponent

            Dim a_systemComponent As ISystemComponent = New SystemComponent With {
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

        Private Sub AddComponentBean(p_controlTextBox As TextBox, p_systemPropertyName As String) Implements IMediatorWinForm_TextBox.AddComponentBean
            If IsNothing(p_controlTextBox) Then
                Throw New Exception("This Control is Nothing")
            End If
            Dim a_controlName As String = p_controlTextBox.Name
            Dim a_componenteBean As IComponentBean = GetComponenteBean(p_controlTextBox, p_systemPropertyName)
            Dim a_isComponentIn_DictComponentBean As Boolean = MasterMediator.DictComponentBean_KeyStringComponentName.ContainsKey(a_controlName)

            If a_isComponentIn_DictComponentBean Then
                MasterMediator.DictComponentBean_KeyStringComponentName(a_controlName) = a_componenteBean
            Else
                MasterMediator.DictComponentBean_KeyStringComponentName.Add(a_controlName, a_componenteBean)
            End If
        End Sub
        Private Function GetComponenteBean(p_controlTextBox As TextBox, p_systemPropertyName As String) As IComponentBean Implements IMediatorWinForm_TextBox.GetComponenteBean
            Dim a_controlName As String = p_controlTextBox.Name
            Dim a_componenteBean As IComponentBean = New ComponentBean With {
            .ComponentName = a_controlName,
            .ComponentTypeFullName = p_controlTextBox.GetType.FullName,
            .ComponentObject = p_controlTextBox,
            .SystemPropertyName = p_systemPropertyName}
            Return a_componenteBean
        End Function
    End Class
End Namespace