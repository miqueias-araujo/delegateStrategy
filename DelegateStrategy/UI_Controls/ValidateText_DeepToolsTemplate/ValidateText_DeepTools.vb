Namespace ValidateText_DeepToolsTemplate
    Public Class ValidateText_DeepTools
        Implements IValidateText_DeepTools

        Public Property Text As String Implements IValidateText_DeepTools.Text
        Sub New(p_text As String)
            Me.Text = p_text
        End Sub
        Sub New()
        End Sub

        Public Function IsNotEmptyValue() As Boolean Implements IValidateText_DeepTools.IsNotEmptyValue
            Return Not String.IsNullOrEmpty(Me.Text)
        End Function

        Public Function HasOnlyNumbers() As Boolean Implements IValidateText_DeepTools.HasOnlyNumbers

            Dim a_number As Integer
            Return Integer.TryParse(Me.Text, a_number)
        End Function

        Public Function Has10Characters() As Boolean Implements IValidateText_DeepTools.Has10Characters

            If IsNotEmptyValue() Then
                Return Me.Text.Length = 10
            End If
            Return False
        End Function
    End Class
End Namespace

