Imports System.Reflection

Class UndoRedo

    Private Shared undo As New Stack
    Private Shared redo As New Stack
    Private Shared working As Boolean

    Public Shared Sub PerformUndo()
        working = True
        Dim st As State = undo.Pop()
        redo.Push(st)
        st.Undo()
        working = False
    End Sub

    Public Shared Sub PerformRedo()
        working = True
        Dim st As State = redo.Pop()
        undo.Push(st)
        st.Redo()
        working = False
    End Sub

    Public Shared Sub NewState(ByVal state As State)
        If Not working Then
            undo.Push(state)
            redo.Clear()
        End If
    End Sub

    Public Shared ReadOnly Property CanUndo()
        Get
            Return undo.Count > 0
        End Get
    End Property

    Public Shared ReadOnly Property CanRedo()
        Get
            Return redo.Count > 0
        End Get
    End Property

    Public Shared Sub Clear()
        undo.Clear()
        redo.Clear()
    End Sub
End Class

Class State

    Public Overridable Sub Undo()

    End Sub

    Public Overridable Sub Redo()

    End Sub

End Class

Class PropertyChangeState
    Inherits State

    Private obj As Object
    Private propName As String
    Private oldValue As Object
    Private newValue As Object

    Public Sub New(ByVal obj As Object, ByVal propName As String, ByVal oldValue As Object, ByVal newValue As Object)
        Me.obj = obj
        Me.propName = propName
        Me.oldValue = oldValue
        Me.newValue = newValue
    End Sub

    Public Overrides Sub Undo()
        Dim flags As BindingFlags = BindingFlags.Public Or BindingFlags.NonPublic Or BindingFlags.Instance Or BindingFlags.Static

        Dim propertyInfo As PropertyInfo = obj.GetType().GetProperty(propName, flags)

        If Not propertyInfo Is Nothing Then
            If (propertyInfo.CanWrite) Then
                propertyInfo.SetValue(obj, oldValue, Nothing)
            End If
        Else
            Dim fieldInfo As FieldInfo = obj.GetType().GetField(propName, flags)
            fieldInfo.SetValue(obj, oldValue)
        End If

    End Sub

    Public Overrides Sub Redo()
        Dim flags As BindingFlags = BindingFlags.Public Or BindingFlags.NonPublic Or BindingFlags.Instance Or BindingFlags.Static

        Dim propertyInfo As PropertyInfo = obj.GetType().GetProperty(propName, flags)

        If Not propertyInfo Is Nothing Then
            If (propertyInfo.CanWrite) Then
                propertyInfo.SetValue(obj, newValue, Nothing)
            End If
        Else
            Dim fieldInfo As FieldInfo = obj.GetType().GetField(propName, flags)
            fieldInfo.SetValue(obj, newValue)
        End If

    End Sub

End Class

Class ControlChangeState
    Inherits State

    Private rtb As RichTextBoxEx

    Public Sub New(ByVal rtb As RichTextBoxEx)
        Me.rtb = rtb
    End Sub

    Public Overrides Sub Undo()
        rtb.Undo()
    End Sub

    Public Overrides Sub Redo()
        rtb.Redo()
    End Sub
End Class

Class SizeChangeState
    Inherits State

    Private list As ArrayList
    Private pos As Integer
    Private oldValue As Integer
    Private newValue As Integer

    Public Sub New(ByVal list As ArrayList, ByVal pos As Integer, ByVal oldValue As Integer, ByVal newValue As Integer)
        Me.list = list
        Me.pos = pos
        Me.oldValue = oldValue
        Me.newValue = newValue
    End Sub

    Public Overrides Sub Undo()
        list(pos) = oldValue
    End Sub

    Public Overrides Sub Redo()
        list(pos) = newValue
    End Sub
End Class

