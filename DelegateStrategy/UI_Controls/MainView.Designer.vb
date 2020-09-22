<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MainView
    Inherits System.Windows.Forms.Form

    'Form remplace la méthode Dispose pour nettoyer la liste des composants.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requise par le Concepteur Windows Form
    Private components As System.ComponentModel.IContainer

    'REMARQUE : la procédure suivante est requise par le Concepteur Windows Form
    'Elle peut être modifiée à l'aide du Concepteur Windows Form.  
    'Ne la modifiez pas à l'aide de l'éditeur de code.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.tabControl_principal = New System.Windows.Forms.TabControl()
        Me.tab_nouveau_tfs = New System.Windows.Forms.TabPage()
        Me.lb_date_enregistre = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.tb_mot_cles = New System.Windows.Forms.TextBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.lb_cle_interne = New System.Windows.Forms.Label()
        Me.lb_nom_fichier_json = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.btn_enregistrer = New System.Windows.Forms.Button()
        Me.tb_obs = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.tb_tfs_description = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.tb_dossiers = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.tb_tfs_no = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.tab_notes = New System.Windows.Forms.TabPage()
        Me.tb_notes = New System.Windows.Forms.TextBox()
        Me.tabControl_principal.SuspendLayout()
        Me.tab_nouveau_tfs.SuspendLayout()
        Me.tab_notes.SuspendLayout()
        Me.SuspendLayout()
        '
        'tabControl_principal
        '
        Me.tabControl_principal.Controls.Add(Me.tab_nouveau_tfs)
        Me.tabControl_principal.Controls.Add(Me.tab_notes)
        Me.tabControl_principal.Location = New System.Drawing.Point(12, 12)
        Me.tabControl_principal.Name = "tabControl_principal"
        Me.tabControl_principal.SelectedIndex = 0
        Me.tabControl_principal.Size = New System.Drawing.Size(958, 345)
        Me.tabControl_principal.TabIndex = 0
        '
        'tab_nouveau_tfs
        '
        Me.tab_nouveau_tfs.Controls.Add(Me.lb_date_enregistre)
        Me.tab_nouveau_tfs.Controls.Add(Me.Label17)
        Me.tab_nouveau_tfs.Controls.Add(Me.tb_mot_cles)
        Me.tab_nouveau_tfs.Controls.Add(Me.Label15)
        Me.tab_nouveau_tfs.Controls.Add(Me.lb_cle_interne)
        Me.tab_nouveau_tfs.Controls.Add(Me.lb_nom_fichier_json)
        Me.tab_nouveau_tfs.Controls.Add(Me.Label10)
        Me.tab_nouveau_tfs.Controls.Add(Me.Label9)
        Me.tab_nouveau_tfs.Controls.Add(Me.btn_enregistrer)
        Me.tab_nouveau_tfs.Controls.Add(Me.tb_obs)
        Me.tab_nouveau_tfs.Controls.Add(Me.Label8)
        Me.tab_nouveau_tfs.Controls.Add(Me.tb_tfs_description)
        Me.tab_nouveau_tfs.Controls.Add(Me.Label7)
        Me.tab_nouveau_tfs.Controls.Add(Me.tb_dossiers)
        Me.tab_nouveau_tfs.Controls.Add(Me.Label5)
        Me.tab_nouveau_tfs.Controls.Add(Me.tb_tfs_no)
        Me.tab_nouveau_tfs.Controls.Add(Me.Label4)
        Me.tab_nouveau_tfs.Location = New System.Drawing.Point(4, 25)
        Me.tab_nouveau_tfs.Name = "tab_nouveau_tfs"
        Me.tab_nouveau_tfs.Padding = New System.Windows.Forms.Padding(3)
        Me.tab_nouveau_tfs.Size = New System.Drawing.Size(950, 316)
        Me.tab_nouveau_tfs.TabIndex = 0
        Me.tab_nouveau_tfs.Text = "Nouveau TFS"
        Me.tab_nouveau_tfs.UseVisualStyleBackColor = True
        '
        'lb_date_enregistre
        '
        Me.lb_date_enregistre.AutoSize = True
        Me.lb_date_enregistre.BackColor = System.Drawing.Color.Wheat
        Me.lb_date_enregistre.Location = New System.Drawing.Point(138, 212)
        Me.lb_date_enregistre.Name = "lb_date_enregistre"
        Me.lb_date_enregistre.Size = New System.Drawing.Size(87, 17)
        Me.lb_date_enregistre.TabIndex = 37
        Me.lb_date_enregistre.Text = "Auto-generé"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Location = New System.Drawing.Point(18, 212)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(115, 17)
        Me.Label17.TabIndex = 36
        Me.Label17.Text = "Date Enregistré: "
        '
        'tb_mot_cles
        '
        Me.tb_mot_cles.BackColor = System.Drawing.SystemColors.Info
        Me.tb_mot_cles.Location = New System.Drawing.Point(655, 16)
        Me.tb_mot_cles.Multiline = True
        Me.tb_mot_cles.Name = "tb_mot_cles"
        Me.tb_mot_cles.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.tb_mot_cles.Size = New System.Drawing.Size(273, 246)
        Me.tb_mot_cles.TabIndex = 35
        Me.tb_mot_cles.Text = "palavrasa"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(578, 16)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(71, 17)
        Me.Label15.TabIndex = 34
        Me.Label15.Text = "Mots clés:"
        '
        'lb_cle_interne
        '
        Me.lb_cle_interne.AutoSize = True
        Me.lb_cle_interne.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.lb_cle_interne.Location = New System.Drawing.Point(138, 246)
        Me.lb_cle_interne.Name = "lb_cle_interne"
        Me.lb_cle_interne.Size = New System.Drawing.Size(87, 17)
        Me.lb_cle_interne.TabIndex = 33
        Me.lb_cle_interne.Text = "Auto-generé"
        '
        'lb_nom_fichier_json
        '
        Me.lb_nom_fichier_json.AutoSize = True
        Me.lb_nom_fichier_json.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.lb_nom_fichier_json.Location = New System.Drawing.Point(138, 277)
        Me.lb_nom_fichier_json.Name = "lb_nom_fichier_json"
        Me.lb_nom_fichier_json.Size = New System.Drawing.Size(87, 17)
        Me.lb_nom_fichier_json.TabIndex = 32
        Me.lb_nom_fichier_json.Text = "Auto-generé"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(48, 246)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(80, 17)
        Me.Label10.TabIndex = 31
        Me.Label10.Text = "Cle interne:"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(18, 277)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(114, 17)
        Me.Label9.TabIndex = 30
        Me.Label9.Text = "Nom ficher Json:"
        '
        'btn_enregistrer
        '
        Me.btn_enregistrer.Location = New System.Drawing.Point(822, 271)
        Me.btn_enregistrer.Name = "btn_enregistrer"
        Me.btn_enregistrer.Size = New System.Drawing.Size(106, 29)
        Me.btn_enregistrer.TabIndex = 29
        Me.btn_enregistrer.Text = "Enregistrer"
        Me.btn_enregistrer.UseVisualStyleBackColor = True
        '
        'tb_obs
        '
        Me.tb_obs.Location = New System.Drawing.Point(142, 103)
        Me.tb_obs.Multiline = True
        Me.tb_obs.Name = "tb_obs"
        Me.tb_obs.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.tb_obs.Size = New System.Drawing.Size(425, 94)
        Me.tb_obs.TabIndex = 28
        Me.tb_obs.Text = "Observacoes valiosas"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(94, 103)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(42, 17)
        Me.Label8.TabIndex = 27
        Me.Label8.Text = "Obs.:"
        '
        'tb_tfs_description
        '
        Me.tb_tfs_description.Location = New System.Drawing.Point(142, 47)
        Me.tb_tfs_description.Name = "tb_tfs_description"
        Me.tb_tfs_description.Size = New System.Drawing.Size(425, 22)
        Me.tb_tfs_description.TabIndex = 26
        Me.tb_tfs_description.Text = "tfs descrip test 2"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(25, 47)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(111, 17)
        Me.Label7.TabIndex = 25
        Me.Label7.Text = "TFS description:"
        '
        'tb_dossiers
        '
        Me.tb_dossiers.Location = New System.Drawing.Point(142, 75)
        Me.tb_dossiers.Name = "tb_dossiers"
        Me.tb_dossiers.Size = New System.Drawing.Size(428, 22)
        Me.tb_dossiers.TabIndex = 24
        Me.tb_dossiers.Text = "12121,1212"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(59, 75)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(77, 17)
        Me.Label5.TabIndex = 23
        Me.Label5.Text = "Dossier(s):"
        '
        'tb_tfs_no
        '
        Me.tb_tfs_no.Location = New System.Drawing.Point(142, 19)
        Me.tb_tfs_no.Name = "tb_tfs_no"
        Me.tb_tfs_no.Size = New System.Drawing.Size(169, 22)
        Me.tb_tfs_no.TabIndex = 22
        Me.tb_tfs_no.Text = "tfsno test1"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(73, 19)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(63, 17)
        Me.Label4.TabIndex = 21
        Me.Label4.Text = "TFS NO:"
        '
        'tab_notes
        '
        Me.tab_notes.Controls.Add(Me.tb_notes)
        Me.tab_notes.Location = New System.Drawing.Point(4, 25)
        Me.tab_notes.Name = "tab_notes"
        Me.tab_notes.Padding = New System.Windows.Forms.Padding(3)
        Me.tab_notes.Size = New System.Drawing.Size(950, 316)
        Me.tab_notes.TabIndex = 1
        Me.tab_notes.Text = "Notes"
        Me.tab_notes.UseVisualStyleBackColor = True
        '
        'tb_notes
        '
        Me.tb_notes.BackColor = System.Drawing.SystemColors.Info
        Me.tb_notes.Location = New System.Drawing.Point(6, 6)
        Me.tb_notes.Multiline = True
        Me.tb_notes.Name = "tb_notes"
        Me.tb_notes.Size = New System.Drawing.Size(938, 304)
        Me.tb_notes.TabIndex = 0
        Me.tb_notes.Text = "nenhuma nota por instante"
        '
        'MainView
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(981, 371)
        Me.Controls.Add(Me.tabControl_principal)
        Me.Name = "MainView"
        Me.Text = "Enregistrer nouveau TFS"
        Me.tabControl_principal.ResumeLayout(False)
        Me.tab_nouveau_tfs.ResumeLayout(False)
        Me.tab_nouveau_tfs.PerformLayout()
        Me.tab_notes.ResumeLayout(False)
        Me.tab_notes.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents tabControl_principal As TabControl
    Friend WithEvents tab_nouveau_tfs As TabPage
    Friend WithEvents tab_notes As TabPage
    Friend WithEvents lb_date_enregistre As Label
    Friend WithEvents Label17 As Label
    Friend WithEvents tb_mot_cles As TextBox
    Friend WithEvents Label15 As Label
    Friend WithEvents lb_cle_interne As Label
    Friend WithEvents lb_nom_fichier_json As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents btn_enregistrer As Button
    Friend WithEvents tb_obs As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents tb_tfs_description As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents tb_dossiers As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents tb_tfs_no As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents tb_notes As TextBox
End Class
