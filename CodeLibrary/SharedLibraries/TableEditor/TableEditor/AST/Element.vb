Imports System.Web.UI
Imports System.ComponentModel
Imports System.IO

MustInherit Class Element
    Implements ICustomTypeDescriptor

    Private props As PropertyDescriptorCollection

    Public MustOverride Sub GenerateHTML(ByVal output As HtmlTextWriter)

    Public MustOverride Sub GeneratePlainText(ByVal output As TextWriter)

    Protected Function GetHexColor(ByVal colorObj As System.Drawing.Color) As String
        Dim ret As String = "#"

        If colorObj.R < 10 Then
            ret += "0" + Hex(colorObj.R)
        Else
            ret += Hex(colorObj.R)
        End If

        If colorObj.G < 10 Then
            ret += "0" + Hex(colorObj.G)
        Else
            ret += Hex(colorObj.G)
        End If

        If colorObj.B < 10 Then
            ret += "0" + Hex(colorObj.B)
        Else
            ret += Hex(colorObj.B)
        End If

        Return ret
    End Function


#Region "For properties names and descriptions"

    Public Function GetAttributes() As System.ComponentModel.AttributeCollection Implements System.ComponentModel.ICustomTypeDescriptor.GetAttributes
        Return TypeDescriptor.GetAttributes(Me, True)
    End Function

    Public Function GetClassName() As String Implements System.ComponentModel.ICustomTypeDescriptor.GetClassName
        Return TypeDescriptor.GetClassName(Me, True)
    End Function

    Public Function GetComponentName() As String Implements System.ComponentModel.ICustomTypeDescriptor.GetComponentName
        Return TypeDescriptor.GetComponentName(Me, True)
    End Function

    Public Function GetConverter() As System.ComponentModel.TypeConverter Implements System.ComponentModel.ICustomTypeDescriptor.GetConverter
        Return TypeDescriptor.GetConverter(Me, True)
    End Function

    Public Function GetDefaultEvent() As System.ComponentModel.EventDescriptor Implements System.ComponentModel.ICustomTypeDescriptor.GetDefaultEvent
        Return TypeDescriptor.GetDefaultEvent(Me, True)
    End Function

    Public Function GetDefaultProperty() As System.ComponentModel.PropertyDescriptor Implements System.ComponentModel.ICustomTypeDescriptor.GetDefaultProperty
        Return TypeDescriptor.GetDefaultProperty(Me, True)
    End Function

    Public Function GetEditor(ByVal editorBaseType As System.Type) As Object Implements System.ComponentModel.ICustomTypeDescriptor.GetEditor
        Return TypeDescriptor.GetEditor(Me, editorBaseType, True)
    End Function

    Public Overloads Function GetEvents() As System.ComponentModel.EventDescriptorCollection Implements System.ComponentModel.ICustomTypeDescriptor.GetEvents
        Return TypeDescriptor.GetEvents(Me, True)
    End Function

    Public Overloads Function GetEvents1(ByVal attributes() As System.Attribute) As System.ComponentModel.EventDescriptorCollection Implements System.ComponentModel.ICustomTypeDescriptor.GetEvents
        Return TypeDescriptor.GetEvents(Me, attributes, True)
    End Function

    Public Overloads Function GetProperties() As System.ComponentModel.PropertyDescriptorCollection Implements System.ComponentModel.ICustomTypeDescriptor.GetProperties
        'Only do once
        If (props Is Nothing) Then
            'Get the collection of properties
            Dim baseProps As PropertyDescriptorCollection = TypeDescriptor.GetProperties(Me, True)
            props = New PropertyDescriptorCollection(Nothing)

            'For each property use a property descriptor of our own
            Dim oProp As PropertyDescriptor 
            For Each oProp In baseProps
                ' Create the translated property descriptor and add it to the collection
                props.Add(New TranslatedPropertyDescriptor(oProp))
            Next
        End If
        Return props
    End Function

    Public Overloads Function GetProperties1(ByVal attributes() As System.Attribute) As System.ComponentModel.PropertyDescriptorCollection Implements System.ComponentModel.ICustomTypeDescriptor.GetProperties
        'Only do once
        If (props Is Nothing) Then
            'Get the collection of properties
            Dim baseProps As PropertyDescriptorCollection = TypeDescriptor.GetProperties(Me, True)
            props = New PropertyDescriptorCollection(Nothing)

            'For each property use a property descriptor of our own
            Dim oProp As PropertyDescriptor 
            For Each oProp In baseProps
                ' Create the translated property descriptor and add it to the collection
                props.Add(New TranslatedPropertyDescriptor(oProp))
            Next
        End If
        Return props
    End Function

    Public Function GetPropertyOwner(ByVal pd As System.ComponentModel.PropertyDescriptor) As Object Implements System.ComponentModel.ICustomTypeDescriptor.GetPropertyOwner
        Return Me
    End Function

#End Region
End Class
