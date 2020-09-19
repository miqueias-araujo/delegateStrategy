Imports UI_Controls.StructuresSystem

Public Class Helper
    Implements IHelper

    'Sub New(p_validator As IDeepTools.DeepToolsValidate(Of String, String))
    '    Validator = p_validator
    'End Sub

    Sub New(p_validator As IDeepTools.Validator_v2(Of StructuresSystem.SystemComponent, StructuresSystem.ResponseValidation))
        Validator_v2 = p_validator
    End Sub
    Private Property Validator As IDeepTools.DeepToolsValidate(Of String, String) Implements IHelper.Validator

    Private Property Validator_v2 As IDeepTools.Validator_v2(Of StructuresSystem.SystemComponent, StructuresSystem.ResponseValidation) Implements IHelper.Validator_v2


    Public Function Validate(p_texte As String) As String Implements IHelper.Validate
        Return Validator.Invoke(p_texte)
    End Function

    Public Function Validate_v2(p_texte As SystemComponent) As ResponseValidation Implements IHelper.Validate_v2
        Return Validator_v2.Invoke(p_texte)
    End Function
End Class
