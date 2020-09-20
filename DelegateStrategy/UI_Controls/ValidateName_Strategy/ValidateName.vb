﻿Imports UI_Controls.BaseStructure
Imports UI_Controls.ValidateText_DeepToolsTemplate
Namespace ValidateName_Strategy
    Public Class ValidateName
        Implements IValidateName

        Private Property SystemComponent As ISystemComponent Implements IValidateName.SystemComponent
        Private Property ResponseValidation As IResponseValidation Implements IValidateName.ResponseValidation

        Public Function getValidator() As IValidateText_DeepTools.Validator(Of ISystemComponent, IResponseValidation) Implements IValidateName.getValidator
            Return New IValidateText_DeepTools.Validator(Of ISystemComponent, IResponseValidation)(AddressOf ExecValidation)
        End Function

        Public Function ExecValidation(p_systemComponent As ISystemComponent) As IResponseValidation Implements IValidateName.ExecValidation
            Me.SystemComponent = p_systemComponent
            Me.ResponseValidation = New ResponseValidation

            Dim deep As IValidateText_DeepTools = New ValidateText_DeepTools(p_systemComponent.ComponentValue)
            Dim reponse = deep.IsNotEmptyValue()
            reponse = reponse AndAlso deep.HasOnlyNumbers()
            If reponse Then
                ConvertToValideControlFormat(p_systemComponent)
                ResponseValidation.Component = p_systemComponent
                Return ResponseValidation
            End If
            ConvertToNotValideControlFormat(p_systemComponent)
            ResponseValidation.Component = p_systemComponent
            Dim a_exception As New Exception(String.Format("This is a not good value for the property: {0}", p_systemComponent.SystemPropertyName))
            ResponseValidation.ComponentMessage = a_exception

            Return ResponseValidation
        End Function

        Sub ConvertToValideControlFormat(ByRef p_component As ISystemComponent) Implements IValidateName.ConvertToValideControlFormat
            p_component.ComponentBackColorName = Color.White.Name
            p_component.ComponentFontColorName = Color.Black.Name
            p_component.ComponentFontStyleCode = FontStyle.Regular
        End Sub

        Sub ConvertToNotValideControlFormat(ByRef p_component As ISystemComponent) Implements IValidateName.ConvertToNotValideControlFormat
            p_component.ComponentBackColorName = Color.Salmon.Name
            p_component.ComponentFontColorName = Color.Green.Name
            p_component.ComponentFontStyleCode = FontStyle.Bold
        End Sub
    End Class
End Namespace

