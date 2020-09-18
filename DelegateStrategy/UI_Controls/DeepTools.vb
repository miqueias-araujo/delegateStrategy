Public Class DeepTools
    Implements IDeepTools

    Public Property Text As String Implements IDeepTools.Text
    Sub New(p_text)
        Me.Text = p_text
    End Sub

    Public Function IsNotEmptyValue(p_text As String) As Boolean Implements IDeepTools.IsNotEmptyValue
        Me.Text = p_text
        Return Not String.IsNullOrEmpty(p_text)
    End Function

    Public Function HasOnlyNumbers(p_text As String) As Boolean Implements IDeepTools.HasOnlyNumbers
        Me.Text = p_text
        Dim a_number As Integer
        Return Integer.TryParse(p_text, a_number)
    End Function

    Public Function Has10Characters(p_text As String) As Boolean Implements IDeepTools.Has10Characters
        Me.Text = p_text
        If IsNotEmptyValue(p_text) Then
            Return p_text.Length = 10
        End If
        Return False
    End Function
End Class
