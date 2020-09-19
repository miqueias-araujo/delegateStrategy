Public Interface IHelper
    Property Validator As IDeepTools.DeepToolsValidate(Of String, String)
    Function Validate(p_texte As String) As String

End Interface
