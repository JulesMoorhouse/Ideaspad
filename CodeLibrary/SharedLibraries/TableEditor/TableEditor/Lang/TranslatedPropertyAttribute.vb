
<AttributeUsage(AttributeTargets.Property)> _
Class TranslatedPropertyAttribute
    Inherits Attribute

    Private nameKey As String
    Private descriptionKey As String

    Public Sub New(ByVal nameKey As String, ByVal descriptionKey As String)
        Me.nameKey = nameKey
        Me.descriptionKey = descriptionKey
    End Sub

    Public ReadOnly Property NameTranslationKey() As String
        Get
            Return nameKey
        End Get
    End Property

    Public ReadOnly Property DescriptionTranslationKey() As String
        Get
            Return descriptionKey
        End Get
    End Property

End Class
