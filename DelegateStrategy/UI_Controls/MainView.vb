Imports ModelView_NewTFS


Public Class MainView

    Dim a_allControls As New List(Of Control)
    Dim a_modelView_Mediator As Object
    Dim a_object_Factory As Object

    Sub New()

        ' Cet appel est requis par le concepteur.
        InitializeComponent()

        ' Ajoutez une initialisation quelconque après l'appel InitializeComponent().
        a_allControls = (From control As Control In tab_notes.Controls).Union(From control As Control In tab_nouveau_tfs.Controls).ToList
        a_modelView_Mediator = a_object_Factory.MakeNewVersionOfModelView
    End Sub


    Private Sub Btn_enregistrer_Click(sender As Control, eventArgs As EventArgs) Handles btn_enregistrer.Click
        a_modelView_Mediator.AddControls(a_allControls)
        Dim isValuesInControlsValids = a_modelView_Mediator.ValidateAllControls_Strategy
        If isValuesInControlsValids Then
            a_modelView_Mediator.RecordAllData
            a_modelView_Mediator.ChangeColorOfRightControls
        Else
            a_modelView_Mediator.ChangeColorOfWrongControls
        End If

    End Sub

    Sub ObserverForAllTextBoxes_Leave(sender As Control, eventArgs As EventArgs) Handles tb_dossiers.Leave, tb_mot_cles.Leave, tb_notes.Leave, tb_obs.Leave, tb_tfs_description.Leave, tb_tfs_no.Leave
        Dim isThisControlRight = a_modelView_Mediator.ValidateThisControl(sender)
        If Not isThisControlRight Then
            a_modelView_Mediator.ChangeColorOfWrongControls
        Else
            a_modelView_Mediator.ChangeColorOfRightControls
            a_modelView_Mediator.RecordThisInfo(sender)
        End If

    End Sub

End Class
