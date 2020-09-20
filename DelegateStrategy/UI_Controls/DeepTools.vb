Public Class DeepTools
    Implements IDeepTools

    Public Property Text As String Implements IDeepTools.Text
    Sub New(p_text As String)
        Me.Text = p_text
    End Sub

    Public Function IsNotEmptyValue() As Boolean Implements IDeepTools.IsNotEmptyValue
        Return Not String.IsNullOrEmpty(Me.Text)
    End Function

    Public Function HasOnlyNumbers() As Boolean Implements IDeepTools.HasOnlyNumbers

        Dim a_number As Integer
        Return Integer.TryParse(Me.Text, a_number)
    End Function

    Public Function Has10Characters() As Boolean Implements IDeepTools.Has10Characters

        If IsNotEmptyValue() Then
            Return Me.Text.Length = 10
        End If
        Return False
    End Function
End Class
