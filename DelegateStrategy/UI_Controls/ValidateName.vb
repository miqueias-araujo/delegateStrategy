Imports UI_Controls.StructuresSystem

Public Class ValidateName
    Implements IValidateName

    Private Property SystemComponent As SystemComponent Implements IValidateName.SystemComponent

    Private Property ResponseValidation As ResponseValidation Implements IValidateName.ResponseValidation

    Private Function ExecValidation(p_texte As String) As String Implements IValidateName.ExecValidation
        Dim deep As IDeepTools = New DeepTools(p_texte)
        Dim reponse = deep.IsNotEmptyValue()
        reponse = reponse AndAlso deep.HasOnlyNumbers()
        If reponse Then
            Return "tout et bon"
        End If
        Return "cela n'a pas fonctionnee"
    End Function
    Public Function getValidator() As IDeepTools.DeepToolsValidate(Of String, String)
        Return New IDeepTools.DeepToolsValidate(Of String, String)(AddressOf Me.ExecValidation)
    End Function

    Public Function getValidator_v2() As IDeepTools.Validator_v2(Of StructuresSystem.SystemComponent, StructuresSystem.ResponseValidation)
        Return New IDeepTools.Validator_v2(Of StructuresSystem.SystemComponent, StructuresSystem.ResponseValidation)(AddressOf ExecValidation_v2)
    End Function

    Public Function ExecValidation_v2(p_systemComponent As SystemComponent) As ResponseValidation Implements IValidateName.ExecValidation_v2
        Me.SystemComponent = p_systemComponent
        Me.ResponseValidation = New ResponseValidation

        '-----------------------------------

        Dim deep As IDeepTools = New DeepTools(p_systemComponent.ComponentValue)
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
        '-----------------------------------

        Return ResponseValidation
    End Function

    Sub ConvertToValideControlFormat(ByRef p_component As SystemComponent)
        p_component.ComponentBackColorName = Color.White.Name
        p_component.ComponentFontColorName = Color.Black.Name
        p_component.ComponentFontStyleCode = FontStyle.Regular
    End Sub

    Sub ConvertToNotValideControlFormat(ByRef p_component As SystemComponent)
        p_component.ComponentBackColorName = Color.Salmon.Name
        p_component.ComponentFontColorName = Color.Green.Name
        p_component.ComponentFontStyleCode = FontStyle.Bold
    End Sub
End Class
