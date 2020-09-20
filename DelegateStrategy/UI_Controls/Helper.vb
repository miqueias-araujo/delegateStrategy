Imports UI_Controls.StructuresSystem

Public Class Helper
    Implements IHelper

    Sub New(p_validator As IDeepTools.Validator(Of StructuresSystem.SystemComponent, StructuresSystem.ResponseValidation))
        Validator = p_validator
    End Sub
    Private Property Validator As IDeepTools.Validator(Of StructuresSystem.SystemComponent, StructuresSystem.ResponseValidation) Implements IHelper.Validator
    Public Function Validate(p_systemComponent As SystemComponent) As ResponseValidation Implements IHelper.Validate
        Return Validator.Invoke(p_systemComponent)
    End Function
End Class
