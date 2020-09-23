<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_Principal
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.tb_name = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btn_record = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'tb_name
        '
        Me.tb_name.Location = New System.Drawing.Point(62, 20)
        Me.tb_name.Name = "tb_name"
        Me.tb_name.Size = New System.Drawing.Size(100, 20)
        Me.tb_name.TabIndex = 0
        Me.tb_name.Text = "vvvvvvvvvv"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(18, 27)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(38, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Name:"
        '
        'btn_record
        '
        Me.btn_record.Location = New System.Drawing.Point(87, 46)
        Me.btn_record.Name = "btn_record"
        Me.btn_record.Size = New System.Drawing.Size(75, 23)
        Me.btn_record.TabIndex = 2
        Me.btn_record.Text = "Record"
        Me.btn_record.UseVisualStyleBackColor = True
        '
        'frm_Principal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(203, 91)
        Me.Controls.Add(Me.btn_record)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.tb_name)
        Me.Name = "frm_Principal"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents tb_name As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents btn_record As Button
End Class
