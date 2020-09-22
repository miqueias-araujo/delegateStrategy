Imports UI_Controls.BaseStructure
Imports UI_Controls.HelperFacade

Namespace WinFormMediator
    Public Interface IMediator
        'Property Name As String
        Property DictHelpers_KeyStringNameProperty_ValueIHelper As Dictionary(Of String, IHelper)
        'Sub ValidateControl(p_controlName As String, p_value As String)
        Property DictSystemComponent_KeyStringComponentName As Dictionary(Of String, ISystemComponent)
        Property DictComponentBean_KeyStringComponentName As Dictionary(Of String, IComponentBean)
        Property MediatorWinForm_TextBox As IMediatorWinForm_TextBox
        Property MediatorWinForm_Record As IMediatorRecordWinForm
    End Interface
End Namespace


