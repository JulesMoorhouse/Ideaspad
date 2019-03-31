Imports System.Drawing.Drawing2D

Class ResizeHandle
    Inherits System.Windows.Forms.Panel

#Region " Windows Form Designer generated code "

    Public Sub New(ByVal isVertical As Boolean)
        MyBase.New()

        'This call is required by the Windows Form Designer.
        InitializeComponent()

        'Add any initialization after the InitializeComponent() call

        Dim gp As New GraphicsPath
        If isVertical Then
            gp.AddPolygon(New Point() {New Point(0, 0), New Point(0, 8), New Point(8, 4)})
        Else
            gp.AddPolygon(New Point() {New Point(0, 0), New Point(8, 0), New Point(4, 8)})

        End If
        Me.Region = New Region(gp)
    End Sub

    'UserControl overrides dispose to clean up the component list.
    Protected Overloads Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing Then
            If Not (components Is Nothing) Then
                components.Dispose()
            End If
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        '
        'ResizeHandle
        '
        Me.BackColor = System.Drawing.Color.Black
        Me.Size = New System.Drawing.Size(8, 8)

    End Sub

#End Region

End Class
