Public Enum Draw_mode
    free_draw
    straight_line
    crazy_straight_lines
    pulsating
End Enum

Public Class drawing
    Private Sub _load_form(S As Object, E As EventArgs) Handles MyBase.Load
        AutoSize = True
        CanvasPBox.Image = New Bitmap(Me.CanvasPBox.Width, Me.CanvasPBox.Height)
        Me.CenterToScreen()

        _init()
    End Sub

    Private Sub _init()
        Dim Ticks = 0.0
        Dim Pulse_speed = pen_puls_speed.Value
        Dim Start As Point

        Dim Pen_mode As Draw_mode

        Dim Pen As New Pen(Brushes.Black, 1)
        Dim Strokes As New Stack(Of (Brush As Brush, Size As Single, Move As Point())) 'stroke
        Dim Movement As New List(Of Point)

        With New Timer
            .Interval = 4
            AddHandler .Tick,
                Sub(S As Object, V As EventArgs)
                    Dim Updater = New Point(CanvasPBox.PointToClient(MousePosition).X,
                                                          CanvasPBox.PointToClient(MousePosition).Y)

                    Ticks += Pulse_speed / 1000

                    Movement.Add(Start)
                    Movement.Add(Updater)
                    Select Case Pen_mode
                        Case Draw_mode.straight_line
                            CanvasPBox.Refresh()
                            Movement.Remove(Updater)
                            Movement.Remove(Start)
                        Case Draw_mode.pulsating
                            Pen.Width = Math.Abs(Math.Sin(Ticks) * pen_size.Value)
                            GoTo Move_Along
                        Case Draw_mode.crazy_straight_lines
                            GoTo Refreshing
                        Case Else
Move_Along:                 Start = Updater
Refreshing:                 CanvasPBox.Refresh()
                    End Select
                End Sub

            AddHandler CanvasPBox.MouseDown, Sub(S As Object, E As MouseEventArgs)
                                                 Movement = New List(Of Point)
                                                 Start = E.Location
                                                 .Start()
                                             End Sub

            AddHandler CanvasPBox.MouseUp, Sub(S As Object, E As MouseEventArgs)
                                               If Pen_mode = Draw_mode.straight_line Then
                                                   Movement.Add(Start)
                                                   Movement.Add(E.Location)
                                               End If

                                               Strokes.Push((Pen.Brush, Pen.Width, Movement.ToArray))
                                               .Stop()
                                               CanvasPBox.Refresh()
                                           End Sub
        End With

        AddHandler MyBase.KeyDown, Sub(S As Object, E As KeyEventArgs)
                                       If E.KeyCode = Keys.Z AndAlso E.Control Then
                                           Strokes.Pop()
                                           Movement.Clear()
                                           CanvasPBox.Refresh()
                                       End If
                                   End Sub
        AddHandler Undo.Click, Sub(S As Object, V As EventArgs)
                                   Strokes.Pop()
                                   Movement.Clear()
                                   CanvasPBox.Refresh()
                               End Sub

        AddHandler CanvasPBox.Paint,
            Sub(S As Object, E As PaintEventArgs)
                With E.Graphics
                    For Each Item In Strokes
                        If Item.Move.Length > 0 Then
                            .DrawLines(New Pen(Item.Brush, Item.Size), Item.Move)
                        End If
                    Next
                    If Movement.Count > 1 Then .DrawLines(Pen, Movement.ToArray)
                End With
            End Sub

        AddHandler ClearAll.Click, Sub(S As Object, V As EventArgs)
                                       Movement.Clear()
                                       Strokes.Clear()
                                       CanvasPBox.Refresh()
                                   End Sub

        AddHandler SaveImg.Click,
            Sub(S As Object, V As EventArgs)
                Throw New NotImplementedException("Save method hasn't impleament yet.")
                'Dim img As Bitmap = CanvasPBox.Image
                ''  CanvasPBox.Image.Dispose()
                'InputBox("Enter Name of File:", "Save Image", "VB_IMG")
                'Dim folder As New FolderBrowserDialog
                'folder.ShowDialog()
                'Dim _file As String = folder.SelectedPath
                'Dim ss = File.Create(_file)

                'If folder.SelectedPath IsNot Nothing Then
                '    img.Save(_file)
                'End If
            End Sub

        AddHandler pen_free.CheckedChanged,
            Sub(S As Object, V As EventArgs)
                If DirectCast(S, RadioButton).Checked Then Pen_mode = Draw_mode.free_draw
            End Sub
        AddHandler pen_line.CheckedChanged,
            Sub(S As Object, V As EventArgs)
                If DirectCast(S, RadioButton).Checked Then Pen_mode = Draw_mode.straight_line
            End Sub
        AddHandler pen_crazy.CheckedChanged,
            Sub(S As Object, V As EventArgs)
                If DirectCast(S, RadioButton).Checked Then Pen_mode = Draw_mode.crazy_straight_lines
            End Sub
        AddHandler pen_pulsating.CheckedChanged,
            Sub(S As Object, V As EventArgs)
                If DirectCast(S, RadioButton).Checked Then Pen_mode = Draw_mode.pulsating
            End Sub

        AddHandler pen_puls_speed.ValueChanged,
            Sub(S As Object, V As EventArgs) Pulse_speed = DirectCast(S, NumericUpDown).Value
        AddHandler pen_puls_speed.KeyUp,
            Sub(S As Object, V As KeyEventArgs) Pulse_speed = DirectCast(S, NumericUpDown).Value

        AddHandler pen_size.ValueChanged,
            Sub(S As Object, V As EventArgs) Pen.Width = DirectCast(S, NumericUpDown).Value
        AddHandler pen_size.KeyUp,
            Sub(S As Object, V As KeyEventArgs) Pen.Width = DirectCast(S, NumericUpDown).Value

        AddHandler RedColour.Click, Sub(S As Object, V As EventArgs) Pen.Brush = Brushes.Red
        AddHandler GreenColour.Click, Sub(S As Object, V As EventArgs) Pen.Brush = Brushes.Lime
        AddHandler BlueColour.Click, Sub(S As Object, V As EventArgs) Pen.Brush = Brushes.Blue
        AddHandler BlackColour.Click, Sub(S As Object, V As EventArgs) Pen.Brush = Brushes.Black
        AddHandler PinkColour.Click, Sub(S As Object, V As EventArgs) Pen.Brush = Brushes.Fuchsia
        AddHandler YellowColour.Click, Sub(S As Object, V As EventArgs) Pen.Brush = Brushes.Gold
        AddHandler BrownColour.Click, Sub(S As Object, V As EventArgs) Pen.Brush = Brushes.SaddleBrown
        AddHandler AquaColour.Click, Sub(S As Object, V As EventArgs) Pen.Brush = Brushes.Aqua
        AddHandler WhiteColour.Click, Sub(S As Object, V As EventArgs) Pen.Brush = Brushes.White
    End Sub
End Class
