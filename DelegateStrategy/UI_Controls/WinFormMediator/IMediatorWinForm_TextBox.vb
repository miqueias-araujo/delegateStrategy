Imports UI_Controls.BaseStructure
Namespace WinFormMediator
    Public Interface IMediatorWinForm_TextBox
        Property MasterMediator As IMediator
        Sub ValidateControl(p_controlName As String, p_value As String)
        Sub UpdateSystemComponent(p_controlName As String)
        Sub UpdateComponentBean(p_component As ISystemComponent)
        Sub AddControlTextBox(p_controlTextBox As TextBox, p_propertyName As String)
        Sub AddSystemComponent(p_controlTextBox As TextBox, p_systemPropertyName As String)
        Function CastTextBoxToSystemComponent(p_controlTextBox As TextBox, p_systemPropertyName As String) As ISystemComponent
        Sub AddComponentBean(p_controlTextBox As TextBox, p_systemPropertyName As String)
        Function GetComponenteBean(p_controlTextBox As TextBox, p_systemPropertyName As String) As IComponentBean
    End Interface
End Namespace