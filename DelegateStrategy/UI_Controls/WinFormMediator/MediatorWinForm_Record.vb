Imports UI_Controls.HelperFacade

Namespace WinFormMediator
    Friend Class MediatorWinForm_Record
        Implements IMediatorRecordWinForm

        Private mediator As Mediator

        Public Sub New(mediator As Mediator)
            Me.mediator = mediator
            Dim helperForRecordSystemProperty As IHelper = New Helper().GetHelperForRecordSystemProperty
        End Sub

        Public Property MasterMediator As IMediator Implements IMediatorRecordWinForm.MasterMediator

        Public Sub RecordAllControls() Implements IMediatorRecordWinForm.RecordAllControls
            Throw New NotImplementedException()
        End Sub
    End Class
End Namespace
