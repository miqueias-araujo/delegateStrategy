Imports UI_Controls.BaseStructure
Imports UI_Controls.ValidateName_Strategy
Imports UI_Controls.ValidateText_DeepToolsTemplate

Namespace HelperFacade
    Public Class Helper
        Implements IHelper

        Sub New(p_validator As IValidateText_DeepTools.Validator(Of ISystemComponent, IResponseValidation))
            Validator = p_validator
        End Sub
        Sub New()
        End Sub
        Private Property Validator As IValidateText_DeepTools.Validator(Of ISystemComponent, IResponseValidation) Implements IHelper.Validator
        Public Function Validate(p_systemComponent As ISystemComponent) As IResponseValidation Implements IHelper.Validate
            Return Validator.Invoke(p_systemComponent)
        End Function

        Friend Function GetHelperForNameSystemProperty() As IHelper
            Return New Helper(New GenericValidateText(Of ConfigSystemComponent_Name, ValidateText_DeepTools)().getValidator)
        End Function
    End Class
End Namespace

