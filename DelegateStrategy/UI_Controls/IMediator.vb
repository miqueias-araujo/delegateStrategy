Imports UI_Controls.StructuresSystem

Public Interface IMediator
    Property Name As String
    Sub SetControlName(p_textBox As TextBox)
    Property DictProperties_KeyStringControlName_ValueDict_KeyStringControlPropertyName_ValueStringPropertyValue As Dictionary(Of String, Dictionary(Of String, String))
    Property DictHelpers_KeyStringNameProperty_ValueIHelper As Dictionary(Of String, IHelper)
    Property DictPropertiesControlNames_KeyStringNameProperty_ValueListOfStringControlName As Dictionary(Of String, List(Of String))
    Property DictControlNamePropertyName_KeyStringControlName_ValueStringPropertyName As Dictionary(Of String, String)
    Sub ValidateControl(p_controlName As String, p_value As String)
    Sub AddControlTextBox(p_controlTextBox As TextBox, p_propertyName As String)
    Sub UpdateControlTextBox(p_textBox As TextBox, p_systemPropertyName As String)
    Sub AddControlTextBox_v2(p_controlTextBox As TextBox, p_propertyName As String)
    Sub ValidateControl_v2(p_controlName As String, p_value As String)
    Property DictSystemComponent_KeyStringComponentName As Dictionary(Of String, SystemComponent)
    Property DictComponentBean_KeyStringComponentName As Dictionary(Of String, ComponentBean)
    'Property DictHelper_KeyStringComponentName As Dictionary(Of String, IHelper)


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
    Public Class SystemProperty
        Property SystemPropertyName As String
        Property SystemPropertyTypeFullName As String
        Property SystemPropertyValue As Object
    End Class
End Namespace
