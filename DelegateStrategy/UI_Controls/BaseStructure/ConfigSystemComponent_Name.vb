Imports UI_Controls.ValidateText_DeepToolsTemplate

Namespace BaseStructure
    Friend Class ConfigSystemComponent_Name
        Implements IConfigSystemComponent_Name

        Public ReadOnly Property Valide_ComponentFontColorName As String Implements IConfigSystemComponent_Name.Valide_ComponentFontColorName
            Get
                Return Color.Black.Name
            End Get
        End Property

        Public ReadOnly Property Valide_ComponentBackColorName As String Implements IConfigSystemComponent_Name.Valide_ComponentBackColorName
            Get
                Return Color.White.Name
            End Get
        End Property

        Public ReadOnly Property Valide_ComponentFontStyleCode As FontStyle Implements IConfigSystemComponent_Name.Valide_ComponentFontStyleCode
            Get
                Return FontStyle.Regular
            End Get
        End Property

        Public ReadOnly Property NotValide_ComponentBackColorName As String Implements IConfigSystemComponent_Name.NotValide_ComponentBackColorName
            Get
                Return Color.Salmon.Name
            End Get
        End Property

        Public ReadOnly Property NotValide_ComponentFontColorName As String Implements IConfigSystemComponent_Name.NotValide_ComponentFontColorName
            Get
                Return Color.Green.Name
            End Get
        End Property

        Public ReadOnly Property NotValide_ComponentFontStyleCode As FontStyle Implements IConfigSystemComponent_Name.NotValide_ComponentFontStyleCode
            Get
                Return FontStyle.Bold
            End Get
        End Property

        Public Function MessageWhenErrorPropertyValue() As String Implements IConfigSystemComponent_Name.MessageWhenErrorPropertyValue
            Return "This is a not good value for the property: {0}"
        End Function

        Public Function ReponseValidator(deep As IValidateText_DeepTools) As Boolean Implements IConfigSystemComponent_Name.ReponseValidator
            Return deep.IsNotEmptyValue AndAlso deep.Has10Characters
        End Function
    End Class
End Namespace
