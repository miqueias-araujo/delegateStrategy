Public Interface IHelper
    Property Validator As IDeepTools.Validator(Of StructuresSystem.SystemComponent, StructuresSystem.ResponseValidation)
    Function Validate(p_texte As StructuresSystem.SystemComponent) As StructuresSystem.ResponseValidation
End Interface
