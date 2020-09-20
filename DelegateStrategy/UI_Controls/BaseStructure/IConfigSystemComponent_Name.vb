Imports UI_Controls.ValidateText_DeepToolsTemplate

Namespace BaseStructure
    Friend Interface IConfigSystemComponent_Name
        ReadOnly Property Valide_ComponentFontColorName As String
        ReadOnly Property Valide_ComponentBackColorName As String
        ReadOnly Property Valide_ComponentFontStyleCode As FontStyle
        ReadOnly Property NotValide_ComponentBackColorName As String
        ReadOnly Property NotValide_ComponentFontColorName As String
        ReadOnly Property NotValide_ComponentFontStyleCode As FontStyle
        Function MessageWhenErrorPropertyValue() As String
        Function ReponseValidator(deep As IValidateText_DeepTools) As Boolean
    End Interface
End Namespace
