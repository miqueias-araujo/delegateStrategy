Public Interface IHelper
    Property Validator As IDeepTools.DeepToolsValidate(Of String, Boolean)
    Function Validate(p_texte As String) As String

End Interface
