Imports UI_Controls.BaseStructure
Imports UI_Controls.ValidateName_Strategy
Imports UI_Controls.ValidateText_DeepToolsTemplate

Namespace HelperFacade
    Public Class Helper
        Implements IHelper
        Sub New()
        End Sub


        Private Property Validator As IValidateText_DeepTools.Validator(Of ISystemComponent, IResponseValidation) Implements IHelper.Validator
        Sub New(p_validator As IValidateText_DeepTools.Validator(Of ISystemComponent, IResponseValidation))
            Validator = p_validator
        End Sub
        Public Function Validate(p_systemComponent As ISystemComponent) As IResponseValidation Implements IHelper.Validate
            Return Validator.Invoke(p_systemComponent)
        End Function


        Private Property Recorder As IRecorder_DeepTools.Recorder Implements IHelper.Recorder

        Public Sub New(p_recorder As IRecorder_DeepTools.Recorder)
            Recorder = p_recorder
        End Sub



        Friend Function GetHelperForRecordSystemProperty() As IHelper
            Return New Helper(New GenericRecorderWinForm().getRecorder)
        End Function

        Public Function Record(p_SystemPropertieCollectionToRecord As ISystemPropertieCollectionToRecord)
            Return Recorder.Invoke(p_SystemPropertieCollectionToRecord)
        End Function

        Friend Function GetHelperForNameSystemProperty() As IHelper Implements IHelper.GetHelperForNameSystemProperty
            Return New Helper(New GenericValidateText(Of ConfigSystemComponent_Name, ValidateText_DeepTools)().getValidator)
        End Function


    End Class
End Namespace

