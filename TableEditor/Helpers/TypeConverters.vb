Imports System.ComponentModel

Public Class TranslatedInt32Converter
    Inherits Int32Converter

    Private Shared calls As New ArrayList

    Public Overloads Overrides Function ConvertFrom(ByVal context As System.ComponentModel.ITypeDescriptorContext, ByVal culture As System.Globalization.CultureInfo, ByVal value As Object) As Object
        Try
            Return MyBase.ConvertFrom(context, culture, value)
        Catch ex As Exception
            If calls.Contains(context.PropertyDescriptor.Name) Then
                calls.Remove(context.PropertyDescriptor.Name)
            Else
                calls.Add(context.PropertyDescriptor.Name)
                MessageBox.Show(TranslationTable.GetTranslation("invalidnumber").Replace("{0}", value), TranslationTable.GetTranslation("advancedproperties"), MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        End Try
    End Function
End Class

Public Class TranslatedColorConverter
    Inherits ColorConverter

    Private Shared calls As New ArrayList

    Public Overloads Overrides Function ConvertFrom(ByVal context As System.ComponentModel.ITypeDescriptorContext, ByVal culture As System.Globalization.CultureInfo, ByVal value As Object) As Object
        Try
            Return MyBase.ConvertFrom(context, culture, value)
        Catch ex As Exception
            If calls.Contains(context.PropertyDescriptor.Name) Then
                calls.Remove(context.PropertyDescriptor.Name)
            Else
                calls.Add(context.PropertyDescriptor.Name)
                MessageBox.Show(TranslationTable.GetTranslation("invalidcolor").Replace("{0}", value), TranslationTable.GetTranslation("advancedproperties"), MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        End Try
    End Function
End Class
