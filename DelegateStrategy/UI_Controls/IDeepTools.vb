Public Interface IDeepTools
    Property Text As String
    Function IsNotEmptyValue(p_text As String) As Boolean
    Function HasOnlyNumbers(p_text As String) As Boolean

    Function Has10Characters(p_text As String) As Boolean
End Interface
