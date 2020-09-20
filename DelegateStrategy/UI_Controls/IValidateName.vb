Public Interface IValidateName

    Property SystemComponent As StructuresSystem.SystemComponent
    Property ResponseValidation As StructuresSystem.ResponseValidation

    Function ExecValidation(p_systemComponent As StructuresSystem.SystemComponent) As StructuresSystem.ResponseValidation
End Interface