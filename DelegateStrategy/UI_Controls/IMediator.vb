Public Interface IMediator
    Property DictProperties_KeyStringControlName_ValueKeyValue_KeyTypeFullNameOfControl_ValueFormControl As Dictionary(Of String, KeyValuePair(Of String, Control))
    Property DictHelpers_KeyStringNameProperty_ValueIHelper As Dictionary(Of String, IHelper)
    Property DictPropertiesControlNames_KeyStringNameProperty_ValueListOfStringControlName As Dictionary(Of String, List(Of String))
    Sub ValidateControl(p_controlName As String)
    Sub AddControlTextBox(p_controlTextBox As TextBox)
End Interface
