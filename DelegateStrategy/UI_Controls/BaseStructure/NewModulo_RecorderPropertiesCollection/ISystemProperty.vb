Public Interface ISystemProperty
    Property KV_KeyObjectTypeFullName_ValueJsonObject As KeyValuePair(Of String, String)
    Property PropertiesCollectionHost_GuidCodeIdentity As String
    Function GetThisObject() As KeyValuePair(Of String, Object)
    Function GetMe_InJson() As String
End Interface
