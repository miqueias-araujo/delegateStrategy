Imports UI_Controls.WinFormMediator

Public Class frm_Principal
    Dim a_mediator As IMediator
    Dim a_mediatorTextBox As IMediatorWinForm_TextBox
    Public Sub New()

            ' This call is required by the designer.
            InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        a_mediator = New Mediator
        a_mediator.MediatorWinForm_TextBox.AddControlTextBox(tb_name, "Name")

    End Sub
    Private Sub tb_name_Leave(sender As Object, e As EventArgs) Handles tb_name.Leave
        a_mediator.MediatorWinForm_TextBox.ValidateControl("tb_name", tb_name.Text)
    End Sub

    Private Sub btn_record_Click(sender As Object, e As EventArgs) Handles btn_record.Click
        a_mediator.MediatorWinForm_TextBox.ValidateControl("tb_name", tb_name.Text)
    End Sub
    End Class


