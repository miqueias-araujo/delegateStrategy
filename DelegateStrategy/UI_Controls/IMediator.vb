Imports UI_Controls.StructuresSystem

Public Interface IMediator
    Property Name As String
    Property DictHelpers_KeyStringNameProperty_ValueIHelper As Dictionary(Of String, IHelper)
    Sub AddControlTextBox(p_controlTextBox As TextBox, p_propertyName As String)
    Sub ValidateControl(p_controlName As String, p_value As String)
    Property DictSystemComponent_KeyStringComponentName As Dictionary(Of String, SystemComponent)
    Property DictComponentBean_KeyStringComponentName As Dictionary(Of String, ComponentBean)
    Sub AddComponentBean(p_controlTextBox As TextBox, p_systemPropertyName As String)
    Function CastTextBoxToSystemComponent(p_controlTextBox As TextBox, p_systemPropertyName As String) As SystemComponent
    Sub AddSystemComponent(p_controlTextBox As TextBox, p_systemPropertyName As String)
    Sub UpdateSystemComponent(p_controlName As String)
    Sub UpdateComponentBean(p_component As SystemComponent)
End Interface
Namespace StructuresSystem

    Public Class ComponentBean
        Property ComponentName As String 'object component from Form
        Property ComponentTypeFullName As String
        Property ComponentObject As Object
        Property SystemPropertyName As String
    End Class
    Public Class SystemComponent
        Property ComponentName As String 'object component from Form
        Property ComponentValue As String
        Property ComponentValueTypeFullName As String
        Property ComponentBackColorName As String
        Property ComponentFontStyleCode As FontStyle
        Property ComponentFontColorName As String
        Property SystemPropertyName As String
    End Class
    Public Class ResponseValidation
        Property ComponentMessage As Exception
        Property Component As SystemComponent
    End Class
End Namespace
