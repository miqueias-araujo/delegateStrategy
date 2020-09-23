Imports UI_Controls.BaseStructure
Imports UI_Controls.PersistInJson_DeepToolsTemplate
Imports UI_Controls.ValidateText_DeepToolsTemplate
Namespace HelperFacade
    Public Interface IHelper
        Property Validator As IValidateText_DeepTools.Validator(Of ISystemComponent, IResponseValidation)
        Function Validate(p_texte As ISystemComponent) As IResponseValidation
        Function GetHelperForNameSystemProperty() As IHelper

        Property SystemWriter As IPersistInSource.SystemWriter(Of IPropertiesCollection, Boolean)
        Function Write(p_propertiesCollection As IPropertiesCollection) As Boolean
        Function GetHelperForPersistInJson() As IHelper
    End Interface
End Namespace

