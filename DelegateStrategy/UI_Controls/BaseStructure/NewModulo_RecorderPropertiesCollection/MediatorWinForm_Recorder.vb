Imports System.Text.Json
Imports UI_Controls.HelperFacade

Namespace WinFormMediator
    Friend Class MediatorWinForm_Recorder
        Implements IMediatorWinForm_Recorder

        Private mediator As IMediator
        Private objectSupapo As ITFS_Type_Testing = New TFS_Type_Testing With {.Name = mediator.DictSystemComponent_KeyStringComponentName("tb_name").ComponentValue}
        Private propCollection As IPropertiesCollection = New PropertiesCollection(Of TFS_Type_Testing)(objectSupapo)
        Private a_writerMediator As IHelper = New Helper().GetHelperForPersistInJson

        Public Sub New(mediator As IMediator)
            Me.mediator = mediator
            Dim helperForPersistInJson As IHelper = New Helper().GetHelperForPersistInJson
        End Sub



        Public Sub PersistAllForm() Implements IMediatorWinForm_Recorder.PersistAllForm
            If Not IsNothing(mediator.DictSystemComponent_KeyStringComponentName) AndAlso mediator.DictSystemComponent_KeyStringComponentName.Count > 0 Then

                a_writerMediator.Write(propCollection)

            End If

        End Sub
    End Class
End Namespace
