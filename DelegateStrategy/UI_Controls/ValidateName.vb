Public Class ValidateName
    Implements IValidateName

    Private Function ExecValidation(p_texte As String) As String Implements IValidateName.ExecValidation
        Dim deep As IDeepTools = New DeepTools(p_texte)
        Dim reponse = deep.IsNotEmptyValue()
        reponse = reponse AndAlso deep.HasOnlyNumbers()
        If reponse Then
            Return "tout et bon"
        End If
        Return "cela n'a pas fonctionnee"
    End Function
    Public Function getValidator() As IDeepTools.DeepToolsValidate(Of String, Boolean)
        Return New IDeepTools.DeepToolsValidate(Of String, Boolean)(AddressOf Me.ExecValidation)
    End Function
End Class
