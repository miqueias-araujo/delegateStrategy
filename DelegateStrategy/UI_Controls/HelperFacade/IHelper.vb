Imports UI_Controls.BaseStructure
Imports UI_Controls.ValidateText_DeepToolsTemplate
Namespace HelperFacade
    Public Interface IHelper
        Property Validator As IValidateText_DeepTools.Validator(Of ISystemComponent, IResponseValidation)
        Function Validate(p_texte As ISystemComponent) As IResponseValidation
    End Interface
End Namespace

