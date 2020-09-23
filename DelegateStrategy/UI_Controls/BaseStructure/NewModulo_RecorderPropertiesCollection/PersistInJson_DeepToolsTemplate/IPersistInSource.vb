Namespace PersistInJson_DeepToolsTemplate
    Public Interface IPersistInSource
        Delegate Function SystemWriter(Of In T, Out TRebsult)(arg As T) As TRebsult
        Function PersistItThere(p_dataOrObject As String, p_queryOrfullFilePath As String) As Boolean
    End Interface
End Namespace

