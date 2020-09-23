Imports System.Text.Json
Imports UI_Controls.HelperFacade

Namespace WinFormMediator
    Friend Class MediatorWinForm_Recorder
        Implements IMediatorWinForm_Recorder

        Private mediator As IMediator

        Public Sub New(mediator As IMediator)
            Me.mediator = mediator
            Dim helperForPersistInJson As IHelper = New Helper().GetHelperForPersistInJson



        End Sub



        Public Sub PersistAllForm() Implements IMediatorWinForm_Recorder.PersistAllForm
            If Not IsNothing(mediator.DictSystemComponent_KeyStringComponentName) AndAlso mediator.DictSystemComponent_KeyStringComponentName.Count > 0 Then
                Dim objectSupapo As New TFS_Type_Testing With {.Name = mediator.DictSystemComponent_KeyStringComponentName("tb_name").ComponentValue}
                Dim propCollection As New PropertiesCollection(Of TFS_Type_Testing)(objectSupapo)

                'tests:
                Dim jsonformat As String = propCollection.GetMe_InJson
                Dim info1 = propCollection.PropertiesCollection_GuidCodeIdentity
                Dim info2 = propCollection.PropertiesCollection_Name
                Dim info3 = propCollection.PropertiesCollection_TypeFullName
                Dim infoComplete = propCollection
                Dim obj = infoComplete.GetThisObject

                Dim a_writerMediator = New Helper().GetHelperForPersistInJson
                a_writerMediator.Write(propCollection)



            End If

        End Sub
    End Class
End Namespace
