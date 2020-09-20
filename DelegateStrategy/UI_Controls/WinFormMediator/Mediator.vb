Imports UI_Controls.BaseStructure
Imports UI_Controls.HelperFacade
Namespace WinFormMediator
    Public Class Mediator
        Implements IMediator
        Sub New()
            DictComponentBean_KeyStringComponentName = New Dictionary(Of String, IComponentBean)
            DictSystemComponent_KeyStringComponentName = New Dictionary(Of String, ISystemComponent)
            DictHelpers_KeyStringNameProperty_ValueIHelper = New Dictionary(Of String, IHelper)
            MediatorWinForm_TextBox = New MediatorWinForm_TextBox(Me)
        End Sub

        Public Property DictSystemComponent_KeyStringComponentName As Dictionary(Of String, ISystemComponent) Implements IMediator.DictSystemComponent_KeyStringComponentName
        Public Property DictComponentBean_KeyStringComponentName As Dictionary(Of String, IComponentBean) Implements IMediator.DictComponentBean_KeyStringComponentName
        Private Property DictHelpers_KeyStringNameProperty_ValueIHelper As Dictionary(Of String, IHelper) Implements IMediator.DictHelpers_KeyStringNameProperty_ValueIHelper
        Public Property MediatorWinForm_TextBox As IMediatorWinForm_TextBox Implements IMediator.MediatorWinForm_TextBox
    End Class
End Namespace

