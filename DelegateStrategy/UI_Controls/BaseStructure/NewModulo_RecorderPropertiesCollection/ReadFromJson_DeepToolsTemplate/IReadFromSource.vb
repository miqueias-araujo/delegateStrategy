Namespace ReadFromJson_DeepToolsTemplate
    Public Interface IReadFromSource
        Delegate Function SystemReader(Of In T, Out TRebsult)(arg As T) As TRebsult
    End Interface
End Namespace

