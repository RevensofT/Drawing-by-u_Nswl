Imports System.Windows.Forms
Imports System.IO
Imports System.Drawing

Public Class Drawing
    Private lines As New List(Of Line)
    Private tempList As List(Of Line)
    Private shapes As New List(Of List(Of Line))
    Private modes As New Dictionary(Of String, Boolean)
    Private start, [end] As Point
    Private WithEvents timer As New Timer
    Private ticks, pulseSpeed As Double
    Private pen As New Pen(Brushes.Black, 1)

#Region "Event Handlers"
    Private Sub Form1_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
        AutoSize = True
        timer.Interval = 4
        pulseSpeed = 0.1
        CanvasPBox.Image = New Bitmap(Me.CanvasPBox.Width, Me.CanvasPBox.Height)
        For Each item In ModesList.Items
            modes.Add(item, False)
        Next
        modes.Item("Free Draw") = True
        CenterToScreen()
    End Sub

    Private Sub PictureBox1_MouseDown(ByVal sender As Object, ByVal e As MouseEventArgs) Handles CanvasPBox.MouseDown
        tempList = New List(Of Line)
        start = e.Location
        timer.Start()
    End Sub

    Private Sub PictureBox1_MouseUp(ByVal sender As Object, ByVal e As MouseEventArgs) Handles CanvasPBox.MouseUp
        Select Case True
            Case modes.Item("Straight Line")
                [end] = e.Location
                Dim line As New Line(start, [end])
                line.pen.Brush = pen.Brush
                line.pen.Width = pen.Width
                lines.Add(line)
                tempList.Add(line)
                shapes.Add(tempList)

            Case modes.Item("Free Draw")
                shapes.Add(tempList)

            Case modes.Item("Crazy Straight Lines")
                shapes.Add(tempList)

        End Select
        timer.Stop()
    End Sub

    Private Sub Drawing_KeyDown(ByVal sender As Object, ByVal e As KeyEventArgs) Handles MyBase.KeyDown
        If e.KeyCode = Keys.Z AndAlso e.Control Then
            UndoLine()
        End If
    End Sub

    Private Sub PictureBox1_Paint(ByVal sender As Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles CanvasPBox.Paint
        DrawLines(e.Graphics)
    End Sub

    Private Sub CanvasPBox_Click(sender As Object, e As EventArgs) Handles CanvasPBox.Click

    End Sub

    Private Sub Timer_Tick(ByVal sender As Object, ByVal e As EventArgs) Handles timer.Tick
        [end] = New Point(CanvasPBox.PointToClient(MousePosition).X, CanvasPBox.PointToClient(MousePosition).Y)
        Dim line As New Line(start, [end])
        line.pen.Brush = pen.Brush
        line.pen.Width = pen.Width
        ticks += pulseSpeed

        Select Case True
            Case modes.Item("Free Draw")
                lines.Add(line)
                tempList.Add(line)
                start = [end]
                CanvasPBox.Refresh()

            Case modes.Item("Straight Line")
                lines.Add(line)
                CanvasPBox.Refresh()
                lines.Remove(line)

            Case modes.Item("Crazy Straight Lines")
                lines.Add(line)
                tempList.Add(line)
                CanvasPBox.Refresh()

            Case modes.Item("Pulsating")
                pen.Width = Math.Abs(Math.Sin(ticks) * PenSizeList.SelectedItem)
                lines.Add(line)
                tempList.Add(line)
                start = [end]
                CanvasPBox.Refresh()
        End Select

    End Sub

    Private Sub Undo_Click(sender As Object, e As EventArgs) Handles Undo.Click
        UndoLine()
    End Sub

    Private Sub SetSize_Click(sender As Object, e As EventArgs) Handles SetSize.Click
        ResizePictureBox()
    End Sub

    Private Sub ClearAll_Click(sender As Object, e As EventArgs) Handles ClearAll.Click
        Using g As Graphics = Graphics.FromImage(CanvasPBox.Image)
            g.Clear(Color.White)
        End Using
        Clear()
    End Sub

    Private Sub SaveImg_Click(sender As Object, e As EventArgs) Handles SaveImg.Click
        SaveImage()
    End Sub

    Private Sub PulseSpeedBttn_Click(sender As Object, e As EventArgs) Handles PulseSpeedBttn.Click
        SetPulseSpeed()
    End Sub

#Region " Colours/Settings "
    Private Sub RedColour_Click(sender As Object, e As EventArgs) Handles RedColour.Click
        pen.Brush = Brushes.Red
    End Sub

    Private Sub GreenColour_Click(sender As Object, e As EventArgs) Handles GreenColour.Click
        pen.Brush = Brushes.Lime
    End Sub

    Private Sub BlueColour_Click(sender As Object, e As EventArgs) Handles BlueColour.Click
        pen.Brush = Brushes.Blue
    End Sub

    Private Sub BlackColour_Click(sender As Object, e As EventArgs) Handles BlackColour.Click
        pen.Brush = Brushes.Black
    End Sub

    Private Sub PinkColour_Click(sender As Object, e As EventArgs) Handles PinkColour.Click
        pen.Brush = Brushes.Fuchsia
    End Sub

    Private Sub YellowColour_Click(sender As Object, e As EventArgs) Handles YellowColour.Click
        pen.Brush = Brushes.Gold
    End Sub

    Private Sub BrownColour_Click(sender As Object, e As EventArgs) Handles BrownColour.Click
        pen.Brush = Brushes.SaddleBrown
    End Sub

    Private Sub AquaColour_Click(sender As Object, e As EventArgs) Handles AquaColour.Click
        pen.Brush = Brushes.Aqua
    End Sub

    Private Sub WhiteColour_Click(sender As Object, e As EventArgs) Handles WhiteColour.Click
        pen.Brush = Brushes.White
    End Sub

    Private Sub PenSizeList_SelectedIndexChanged(sender As Object, e As EventArgs) Handles PenSizeList.SelectedIndexChanged
        Dim item As Integer = PenSizeList.SelectedItem
        ResetPenSize(item)
    End Sub

    Private Sub ModesList_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ModesList.SelectedIndexChanged
        Dim currentMode As String = ""
        For Each pair In modes
            If pair.Value = True Then
                currentMode = pair.Key
            End If
        Next
        ChangeMode(ModesList.SelectedItem, currentMode)
    End Sub
#End Region

#End Region

    Private Sub SetPulseSpeed()
        Try
            pulseSpeed = InputBox("Enter Pulse Speed:", "Set Pulse Speed", "0.1")
        Catch ex As Exception
            Return
        End Try
    End Sub

    Private Sub ResetPenSize(width As Integer)
        pen.Width = width
    End Sub

    Private Sub ResizePictureBox()
        Dim dimensions As String = CanvasPBox.Height & ", " & CanvasPBox.Width
        Dim dimArr() As String
        Try
            dimensions = InputBox("Enter Canvas Size (Height, Width):", "Resize Canvas", dimensions)
            dimArr = dimensions.Split(", ")
            CanvasPBox.Width = dimArr(1)
            CanvasPBox.Height = dimArr(0)
        Catch ex As Exception
            Return
        End Try
    End Sub

    Private Sub ChangeMode(newMode, currentMode)
        If newMode = "Pulsating" Then
            PulseSpeedBttn.Visible = True
        Else
            PulseSpeedBttn.Visible = False
        End If
        modes.Item(currentMode) = False
        modes.Item(newMode) = True
    End Sub

    Private Sub UndoLine()
        If shapes.Count > 0 Then
            shapes.Remove(shapes.Last)
            lines.Clear()

            For Each list In shapes
                For Each line In list
                    lines.Add(line)
                Next
            Next
            CanvasPBox.Refresh()
        End If
    End Sub

    Private Sub SaveImage()
        Dim img As Bitmap = CanvasPBox.Image
        '  CanvasPBox.Image.Dispose()
        InputBox("Enter Name of File:", "Save Image", "VB_IMG")
        Dim folder As New FolderBrowserDialog
        folder.ShowDialog()
        Dim _file As String = folder.SelectedPath
        Dim s = File.Create(_file)

        If Not folder.SelectedPath.Equals(String.Empty) Then
            img.Save(_file)
        End If
    End Sub

    Private Sub Save()
        Using g As Graphics = Graphics.FromImage(CanvasPBox.Image)
            DrawLines(g)
        End Using
        Clear()
    End Sub

    Private Sub Clear()
        shapes.Clear()
        lines.Clear()
        CanvasPBox.Refresh()
    End Sub

    Private Sub DrawLines(ByVal g As Graphics)
        For Each line As Line In lines
            g.DrawLine(line.pen, line.Start, line.End)
        Next
    End Sub

End Class

Public Class Line
    Public pen As New Pen(Brushes.Black, 3)
    Private _start As Point
    Private _end As Point

    Public Property Start() As Point
        Get
            Return _start
        End Get
        Set(ByVal value As Point)
            _start = value
        End Set
    End Property

    Public Property [End]() As Point
        Get
            Return _end
        End Get
        Set(ByVal value As Point)
            _end = value
        End Set
    End Property

    Public Sub New()
        Me.New(Point.Empty, Point.Empty)
    End Sub

    Public Sub New(ByVal start As Point, ByVal [end] As Point)
        _start = start
        _end = [end]
    End Sub

End Class



