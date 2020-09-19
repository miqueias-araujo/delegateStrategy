Public Class Helper
    Implements IHelper

    Sub New(p_validator As IDeepTools.DeepToolsValidate(Of String, String))
        Validator = p_validator
    End Sub
    Private Property Validator As IDeepTools.DeepToolsValidate(Of String, String) Implements IHelper.Validator


    Public Function Validate(p_texte As String) As String Implements IHelper.Validate
        Return Validator.Invoke(p_texte)
    End Function
End Class
