Imports System.ComponentModel

Class TranslatedPropertyDescriptor
    Inherits PropertyDescriptor

    Private basePropertyDescriptor As PropertyDescriptor

    Private propName As String
    Private propDesc As String

    Sub New(ByVal basePropertyDescriptor As PropertyDescriptor)
        MyBase.New(basePropertyDescriptor)

        Me.basePropertyDescriptor = basePropertyDescriptor
    End Sub

    Public Overrides Function CanResetValue(ByVal component As Object) As Boolean
        Return basePropertyDescriptor.CanResetValue(component)
    End Function

    Public Overrides ReadOnly Property ComponentType() As System.Type
        Get
            Return basePropertyDescriptor.ComponentType
        End Get
    End Property

    Public Overrides Function GetValue(ByVal component As Object) As Object
        Return basePropertyDescriptor.GetValue(component)
    End Function

    Public Overrides ReadOnly Property IsReadOnly() As Boolean
        Get
            Return basePropertyDescriptor.IsReadOnly
        End Get
    End Property

    Public Overrides ReadOnly Property PropertyType() As System.Type
        Get
            Return basePropertyDescriptor.PropertyType
        End Get
    End Property

    Public Overrides Sub ResetValue(ByVal component As Object)
        basePropertyDescriptor.ResetValue(component)
    End Sub

    Public Overrides Sub SetValue(ByVal component As Object, ByVal value As Object)
        basePropertyDescriptor.SetValue(component, value)
    End Sub

    Public Overrides Function ShouldSerializeValue(ByVal component As Object) As Boolean
        Return basePropertyDescriptor.ShouldSerializeValue(component)
    End Function

    Public Overrides ReadOnly Property DisplayName() As String
        Get
            ' Check if the property has translation
            Dim att As Attribute 
            For Each att In basePropertyDescriptor.Attributes
                If TypeOf (att) Is TranslatedPropertyAttribute Then
                    ' Do the translation
                    If TranslationTable.ContainsTranslation(CType(att, TranslatedPropertyAttribute).NameTranslationKey) Then
                        Return TranslationTable.GetTranslation(CType(att, TranslatedPropertyAttribute).NameTranslationKey)
                    End If
                End If
            Next
            Return basePropertyDescriptor.DisplayName
        End Get
    End Property

    Public Overrides ReadOnly Property Description() As String
        Get
            ' Check if the property has translation
            Dim att As Attribute 
            For Each att In basePropertyDescriptor.Attributes
                If TypeOf (att) Is TranslatedPropertyAttribute Then
                    ' Do the translation
                    If TranslationTable.ContainsTranslation(CType(att, TranslatedPropertyAttribute).DescriptionTranslationKey) Then
                        Return TranslationTable.GetTranslation(CType(att, TranslatedPropertyAttribute).DescriptionTranslationKey)
                    End If
                End If
            Next
            Return basePropertyDescriptor.Description
        End Get

    End Property

End Class
