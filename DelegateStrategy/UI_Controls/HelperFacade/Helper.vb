Imports UI_Controls.BaseStructure
Imports UI_Controls.FileAndFolders_DeepToolsTemplate
Imports UI_Controls.PersistInJson_DeepToolsTemplate
Imports UI_Controls.ReadFromJson_DeepToolsTemplate
Imports UI_Controls.ValidateName_Strategy
Imports UI_Controls.ValidateText_DeepToolsTemplate
Imports UI_Controls.WinFormMediator

Namespace HelperFacade
    Public Class Helper
        Implements IHelper
        Sub New()
        End Sub
        Sub New(p_validator As IValidateText_DeepTools.Validator(Of ISystemComponent, IResponseValidation))
            Validator = p_validator
        End Sub
        Sub New(p_writer As IPersistInSource.SystemWriter(Of IPropertiesCollection, Boolean))
            SystemWriter = p_writer
        End Sub


        Private Property SystemWriter As IPersistInSource.SystemWriter(Of IPropertiesCollection, Boolean) Implements IHelper.SystemWriter
        Public Function Write(p_propertiesCollection As IPropertiesCollection) As Boolean Implements IHelper.Write
            Return SystemWriter.Invoke(p_propertiesCollection)
        End Function
        Friend Function GetHelperForPersistInJson() As IHelper Implements IHelper.GetHelperForPersistInJson
            Return New Helper(New GenericPersistSystemObject(Of ConfigSystem_IO_Json, FileAndFolders, ReadFromJson, PersistInJson)().GetWriter)
        End Function




        Private Property Validator As IValidateText_DeepTools.Validator(Of ISystemComponent, IResponseValidation) Implements IHelper.Validator
        Public Function Validate(p_systemComponent As ISystemComponent) As IResponseValidation Implements IHelper.Validate
            Return Validator.Invoke(p_systemComponent)
        End Function

        Friend Function GetHelperForNameSystemProperty() As IHelper Implements IHelper.GetHelperForNameSystemProperty
            Return New Helper(New GenericValidateText(Of ConfigSystemComponent_Name, ValidateText_DeepTools)().getValidator)
        End Function



    End Class
End Namespace

