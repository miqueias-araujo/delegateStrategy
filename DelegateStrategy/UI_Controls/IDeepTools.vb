Public Interface IDeepTools

    Property Text As String
    Delegate Function DeepToolsValidate(Of In T, Out TRebsult)(arg As T) As TRebsult
    Function IsNotEmptyValue() As Boolean
    Function HasOnlyNumbers() As Boolean

    Function Has10Characters() As Boolean
End Interface
