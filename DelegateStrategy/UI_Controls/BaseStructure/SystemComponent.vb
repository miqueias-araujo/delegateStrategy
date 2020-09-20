Namespace BaseStructure
    Public Class SystemComponent
        Implements ISystemComponent
        Property ComponentName As String Implements ISystemComponent.ComponentName
        Property ComponentValue As String Implements ISystemComponent.ComponentValue
        Property ComponentValueTypeFullName As String Implements ISystemComponent.ComponentValueTypeFullName
        Property ComponentBackColorName As String Implements ISystemComponent.ComponentBackColorName
        Property ComponentFontStyleCode As FontStyle Implements ISystemComponent.ComponentFontStyleCode
        Property ComponentFontColorName As String Implements ISystemComponent.ComponentFontColorName
        Property SystemPropertyName As String Implements ISystemComponent.SystemPropertyName
    End Class
End Namespace
