Imports UI_Controls.BaseStructure
Imports UI_Controls.HelperFacade

Namespace WinFormMediator
    Public Interface IMediator
        Property Name As String
        Property DictHelpers_KeyStringNameProperty_ValueIHelper As Dictionary(Of String, IHelper)
        Sub AddControlTextBox(p_controlTextBox As TextBox, p_propertyName As String)
        Sub ValidateControl(p_controlName As String, p_value As String)
        Property DictSystemComponent_KeyStringComponentName As Dictionary(Of String, ISystemComponent)
        Property DictComponentBean_KeyStringComponentName As Dictionary(Of String, IComponentBean)
        Sub AddComponentBean(p_controlTextBox As TextBox, p_systemPropertyName As String)
        Function CastTextBoxToSystemComponent(p_controlTextBox As TextBox, p_systemPropertyName As String) As ISystemComponent
        Sub AddSystemComponent(p_controlTextBox As TextBox, p_systemPropertyName As String)
        Sub UpdateSystemComponent(p_controlName As String)
        Sub UpdateComponentBean(p_component As ISystemComponent)
    End Interface
End Namespace


