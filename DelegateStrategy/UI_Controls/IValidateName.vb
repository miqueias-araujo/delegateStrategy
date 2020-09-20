Public Interface IValidateName

    Property SystemComponent As StructuresSystem.SystemComponent
    Property ResponseValidation As StructuresSystem.ResponseValidation

    Function ExecValidation(p_systemComponent As StructuresSystem.SystemComponent) As StructuresSystem.ResponseValidation
    Sub ConvertToValideControlFormat(ByRef p_component As StructuresSystem.SystemComponent)
    Sub ConvertToNotValideControlFormat(ByRef p_component As StructuresSystem.SystemComponent)
    Function getValidator() As IDeepTools.Validator(Of StructuresSystem.SystemComponent, StructuresSystem.ResponseValidation)
End Interface