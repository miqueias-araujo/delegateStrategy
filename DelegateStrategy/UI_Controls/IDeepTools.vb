Public Interface IDeepTools

    Property Text As String
    Delegate Function DeepToolsValidate(Of In T, Out TRebsult)(arg As T) As TRebsult
    Delegate Function Validator_v2(Of In T, Out TRebsult)(arg As T) As TRebsult
    'Delegate Function Validator_v2() As IDeepTools.DeepToolsValidate(Of StructuresSystem.SystemComponent, StructuresSystem.ResponseValidation)
    Function IsNotEmptyValue() As Boolean
    Function HasOnlyNumbers() As Boolean

    Function Has10Characters() As Boolean
End Interface
