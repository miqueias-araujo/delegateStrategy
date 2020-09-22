Imports UI_Controls.BaseStructure
Imports UI_Controls.ValidateText_DeepToolsTemplate
Namespace ValidateName_Strategy
    Public Class GenericValidateText(Of C_ConfigType As {Class, New}, V_DeepValidatorType As {Class, New})
        Implements IGenericValidateText

        Private Property ConfigSystemComponent_Name As IConfigSystemComponent_Name Implements IGenericValidateText.ConfigSystemComponent_Name

        Public Sub New()
            ConfigSystemComponent_Name = New C_ConfigType()
        End Sub

        Public Function getValidator() As IValidateText_DeepTools.Validator(Of ISystemComponent, IResponseValidation) Implements IGenericValidateText.getValidator
            Return New IValidateText_DeepTools.Validator(Of ISystemComponent, IResponseValidation)(AddressOf ExecValidation)
        End Function

        Public Function ExecValidation(p_systemComponent As ISystemComponent) As IResponseValidation Implements IGenericValidateText.ExecValidation
            Dim a_responseValidation = New ResponseValidation

            Dim deep As IValidateText_DeepTools = New V_DeepValidatorType()
            deep.Text = p_systemComponent.ComponentValue

            Dim reponse As Boolean = ConfigSystemComponent_Name.ReponseValidator(deep)
            If reponse Then
                ConvertToValideControlFormat(p_systemComponent)
                a_responseValidation.Component = p_systemComponent
                Return a_responseValidation
            End If
            ConvertToNotValideControlFormat(p_systemComponent)
            a_responseValidation.Component = p_systemComponent
            Dim a_exception As New Exception(String.Format(ConfigSystemComponent_Name.MessageWhenErrorPropertyValue, p_systemComponent.SystemPropertyName))
            a_responseValidation.ComponentMessage = a_exception

            Return a_responseValidation
        End Function

        Sub ConvertToValideControlFormat(ByRef p_component As ISystemComponent) Implements IGenericValidateText.ConvertToValideControlFormat
            p_component.ComponentBackColorName = ConfigSystemComponent_Name.Valide_ComponentBackColorName
            p_component.ComponentFontColorName = ConfigSystemComponent_Name.Valide_ComponentFontColorName
            p_component.ComponentFontStyleCode = ConfigSystemComponent_Name.Valide_ComponentFontStyleCode
        End Sub

        Sub ConvertToNotValideControlFormat(ByRef p_component As ISystemComponent) Implements IGenericValidateText.ConvertToNotValideControlFormat
            p_component.ComponentBackColorName = ConfigSystemComponent_Name.NotValide_ComponentBackColorName
            p_component.ComponentFontColorName = ConfigSystemComponent_Name.NotValide_ComponentFontColorName
            p_component.ComponentFontStyleCode = ConfigSystemComponent_Name.NotValide_ComponentFontStyleCode
        End Sub
    End Class
End Namespace

