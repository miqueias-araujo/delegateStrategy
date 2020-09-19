Public Interface IHelper
    Property Validator As IDeepTools.DeepToolsValidate(Of String, String)
    Function Validate(p_texte As String) As String

    Property Validator_v2 As IDeepTools.Validator_v2(Of StructuresSystem.SystemComponent, StructuresSystem.ResponseValidation)
    Function Validate_v2(p_texte As StructuresSystem.SystemComponent) As StructuresSystem.ResponseValidation

End Interface
