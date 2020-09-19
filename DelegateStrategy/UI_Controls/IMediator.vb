Public Interface IMediator
    Property DictProperties_KeyStringControlName_ValueDict_KeyStringControlPropertyName_ValueStringPropertyValue As Dictionary(Of String, Dictionary(Of String, String))
    Property DictHelpers_KeyStringNameProperty_ValueIHelper As Dictionary(Of String, IHelper)
    Property DictPropertiesControlNames_KeyStringNameProperty_ValueListOfStringControlName As Dictionary(Of String, List(Of String))
    Property DictControlNamePropertyName_KeyStringControlName_ValueStringPropertyName As Dictionary(Of String, String)
    Sub ValidateControl(p_controlName As String, p_value As String)
    Sub AddControlTextBox(p_controlTextBox As TextBox, p_propertyName As String)
End Interface
