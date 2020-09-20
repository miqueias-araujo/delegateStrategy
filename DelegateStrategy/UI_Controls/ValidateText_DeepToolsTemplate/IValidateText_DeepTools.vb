Namespace ValidateText_DeepToolsTemplate
    Public Interface IValidateText_DeepTools

        Property Text As String
        Delegate Function Validator(Of In T, Out TRebsult)(arg As T) As TRebsult
        Function IsNotEmptyValue() As Boolean
        Function HasOnlyNumbers() As Boolean

        Function Has10Characters() As Boolean
    End Interface
End Namespace

