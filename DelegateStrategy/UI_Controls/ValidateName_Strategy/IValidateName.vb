﻿Imports UI_Controls.BaseStructure
Imports UI_Controls.ValidateText_DeepToolsTemplate

Namespace ValidateName_Strategy
    Public Interface IValidateName

        'Property SystemComponent As ISystemComponent
        'Property ResponseValidation As IResponseValidation

        Function ExecValidation(p_systemComponent As ISystemComponent) As IResponseValidation
        Sub ConvertToValideControlFormat(ByRef p_component As ISystemComponent)
        Sub ConvertToNotValideControlFormat(ByRef p_component As ISystemComponent)
        Function getValidator() As IValidateText_DeepTools.Validator(Of ISystemComponent, IResponseValidation)
    End Interface
End Namespace
