﻿Imports System.IO

Namespace PersistInJson_DeepToolsTemplate
    Public Class PersistInJson
        Implements IPersistInSource

        Public Property Helper As HelperFacade.Helper
            Get
                Return Nothing
            End Get
            Set(value As HelperFacade.Helper)
            End Set
        End Property

        Public Function PersistItThere(p_dataOrObject As String, p_queryOrfullFilePath As String) As Boolean Implements IPersistInSource.PersistItThere

            File.WriteAllText(p_queryOrfullFilePath, p_dataOrObject)
            Return System.IO.File.Exists(p_queryOrfullFilePath)
        End Function
    End Class
End Namespace

