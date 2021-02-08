<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Drawing
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.CanvasPBox = New System.Windows.Forms.PictureBox()
        Me.Undo = New System.Windows.Forms.Button()
        Me.SetSize = New System.Windows.Forms.Button()
        Me.RedColour = New System.Windows.Forms.Button()
        Me.GreenColour = New System.Windows.Forms.Button()
        Me.BlueColour = New System.Windows.Forms.Button()
        Me.BlackColour = New System.Windows.Forms.Button()
        Me.PinkColour = New System.Windows.Forms.Button()
        Me.YellowColour = New System.Windows.Forms.Button()
        Me.PenSizeList = New System.Windows.Forms.ComboBox()
        Me.BrownColour = New System.Windows.Forms.Button()
        Me.AquaColour = New System.Windows.Forms.Button()
        Me.WhiteColour = New System.Windows.Forms.Button()
        Me.ClearAll = New System.Windows.Forms.Button()
        Me.SaveImg = New System.Windows.Forms.Button()
        Me.ModesList = New System.Windows.Forms.ComboBox()
        Me.PulseSpeedBttn = New System.Windows.Forms.Button()
        CType(Me.CanvasPBox, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'CanvasPBox
        '
        Me.CanvasPBox.BackColor = System.Drawing.Color.White
        Me.CanvasPBox.Location = New System.Drawing.Point(151, 12)
        Me.CanvasPBox.Name = "CanvasPBox"
        Me.CanvasPBox.Size = New System.Drawing.Size(770, 770)
        Me.CanvasPBox.TabIndex = 0
        Me.CanvasPBox.TabStop = False
        '
        'Undo
        '
        Me.Undo.BackColor = System.Drawing.Color.LightGray
        Me.Undo.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Undo.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Undo.Location = New System.Drawing.Point(15, 30)
        Me.Undo.Name = "Undo"
        Me.Undo.Size = New System.Drawing.Size(105, 60)
        Me.Undo.TabIndex = 1
        Me.Undo.Text = "UNDO" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "(Ctrl + Z)" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        Me.Undo.UseMnemonic = False
        Me.Undo.UseVisualStyleBackColor = False
        '
        'SetSize
        '
        Me.SetSize.BackColor = System.Drawing.Color.LightGray
        Me.SetSize.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.SetSize.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SetSize.Location = New System.Drawing.Point(15, 96)
        Me.SetSize.Name = "SetSize"
        Me.SetSize.Size = New System.Drawing.Size(105, 60)
        Me.SetSize.TabIndex = 2
        Me.SetSize.Text = "SET SIZE"
        Me.SetSize.UseVisualStyleBackColor = False
        '
        'RedColour
        '
        Me.RedColour.BackColor = System.Drawing.Color.Red
        Me.RedColour.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.RedColour.Location = New System.Drawing.Point(52, 323)
        Me.RedColour.Name = "RedColour"
        Me.RedColour.Size = New System.Drawing.Size(31, 31)
        Me.RedColour.TabIndex = 3
        Me.RedColour.UseVisualStyleBackColor = False
        '
        'GreenColour
        '
        Me.GreenColour.BackColor = System.Drawing.Color.Lime
        Me.GreenColour.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.GreenColour.Location = New System.Drawing.Point(89, 323)
        Me.GreenColour.Name = "GreenColour"
        Me.GreenColour.Size = New System.Drawing.Size(31, 31)
        Me.GreenColour.TabIndex = 4
        Me.GreenColour.UseVisualStyleBackColor = False
        '
        'BlueColour
        '
        Me.BlueColour.BackColor = System.Drawing.Color.Blue
        Me.BlueColour.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.BlueColour.Location = New System.Drawing.Point(15, 360)
        Me.BlueColour.Name = "BlueColour"
        Me.BlueColour.Size = New System.Drawing.Size(31, 31)
        Me.BlueColour.TabIndex = 5
        Me.BlueColour.UseVisualStyleBackColor = False
        '
        'BlackColour
        '
        Me.BlackColour.BackColor = System.Drawing.Color.Black
        Me.BlackColour.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.BlackColour.Location = New System.Drawing.Point(15, 323)
        Me.BlackColour.Name = "BlackColour"
        Me.BlackColour.Size = New System.Drawing.Size(31, 31)
        Me.BlackColour.TabIndex = 6
        Me.BlackColour.UseVisualStyleBackColor = False
        '
        'PinkColour
        '
        Me.PinkColour.BackColor = System.Drawing.Color.Fuchsia
        Me.PinkColour.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.PinkColour.Location = New System.Drawing.Point(89, 360)
        Me.PinkColour.Name = "PinkColour"
        Me.PinkColour.Size = New System.Drawing.Size(31, 31)
        Me.PinkColour.TabIndex = 7
        Me.PinkColour.UseVisualStyleBackColor = False
        '
        'YellowColour
        '
        Me.YellowColour.BackColor = System.Drawing.Color.Yellow
        Me.YellowColour.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.YellowColour.Location = New System.Drawing.Point(52, 360)
        Me.YellowColour.Name = "YellowColour"
        Me.YellowColour.Size = New System.Drawing.Size(31, 31)
        Me.YellowColour.TabIndex = 8
        Me.YellowColour.UseVisualStyleBackColor = False
        '
        'PenSizeList
        '
        Me.PenSizeList.BackColor = System.Drawing.SystemColors.Window
        Me.PenSizeList.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.PenSizeList.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.PenSizeList.FormattingEnabled = True
        Me.PenSizeList.Items.AddRange(New Object() {"1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12", "13", "14", "15", "16", "17", "18", "19", "20"})
        Me.PenSizeList.Location = New System.Drawing.Point(15, 434)
        Me.PenSizeList.Name = "PenSizeList"
        Me.PenSizeList.Size = New System.Drawing.Size(105, 21)
        Me.PenSizeList.TabIndex = 9
        Me.PenSizeList.Tag = ""
        '
        'BrownColour
        '
        Me.BrownColour.BackColor = System.Drawing.Color.SaddleBrown
        Me.BrownColour.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.BrownColour.Location = New System.Drawing.Point(52, 397)
        Me.BrownColour.Name = "BrownColour"
        Me.BrownColour.Size = New System.Drawing.Size(31, 31)
        Me.BrownColour.TabIndex = 10
        Me.BrownColour.UseVisualStyleBackColor = False
        '
        'AquaColour
        '
        Me.AquaColour.BackColor = System.Drawing.Color.Aqua
        Me.AquaColour.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.AquaColour.Location = New System.Drawing.Point(15, 397)
        Me.AquaColour.Name = "AquaColour"
        Me.AquaColour.Size = New System.Drawing.Size(31, 31)
        Me.AquaColour.TabIndex = 11
        Me.AquaColour.UseVisualStyleBackColor = False
        '
        'WhiteColour
        '
        Me.WhiteColour.BackColor = System.Drawing.Color.White
        Me.WhiteColour.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.WhiteColour.Location = New System.Drawing.Point(89, 397)
        Me.WhiteColour.Name = "WhiteColour"
        Me.WhiteColour.Size = New System.Drawing.Size(31, 31)
        Me.WhiteColour.TabIndex = 12
        Me.WhiteColour.UseVisualStyleBackColor = False
        '
        'ClearAll
        '
        Me.ClearAll.BackColor = System.Drawing.Color.LightGray
        Me.ClearAll.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ClearAll.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ClearAll.Location = New System.Drawing.Point(15, 162)
        Me.ClearAll.Name = "ClearAll"
        Me.ClearAll.Size = New System.Drawing.Size(105, 60)
        Me.ClearAll.TabIndex = 15
        Me.ClearAll.Text = "CLEAR ALL LINES"
        Me.ClearAll.UseVisualStyleBackColor = False
        '
        'SaveImg
        '
        Me.SaveImg.BackColor = System.Drawing.Color.LightGray
        Me.SaveImg.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.SaveImg.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SaveImg.Location = New System.Drawing.Point(15, 228)
        Me.SaveImg.Name = "SaveImg"
        Me.SaveImg.Size = New System.Drawing.Size(105, 60)
        Me.SaveImg.TabIndex = 16
        Me.SaveImg.Text = "SAVE IMAGE"
        Me.SaveImg.UseVisualStyleBackColor = False
        '
        'ModesList
        '
        Me.ModesList.BackColor = System.Drawing.SystemColors.Window
        Me.ModesList.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ModesList.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ModesList.FormattingEnabled = True
        Me.ModesList.Items.AddRange(New Object() {"Free Draw", "Straight Line", "Crazy Straight Lines", "Pulsating"})
        Me.ModesList.Location = New System.Drawing.Point(15, 461)
        Me.ModesList.Name = "ModesList"
        Me.ModesList.Size = New System.Drawing.Size(105, 21)
        Me.ModesList.TabIndex = 17
        Me.ModesList.Tag = ""
        '
        'PulseSpeedBttn
        '
        Me.PulseSpeedBttn.BackColor = System.Drawing.Color.LightGray
        Me.PulseSpeedBttn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.PulseSpeedBttn.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PulseSpeedBttn.Location = New System.Drawing.Point(15, 488)
        Me.PulseSpeedBttn.Name = "PulseSpeedBttn"
        Me.PulseSpeedBttn.Size = New System.Drawing.Size(105, 60)
        Me.PulseSpeedBttn.TabIndex = 18
        Me.PulseSpeedBttn.Text = "SET PULSE SPEED"
        Me.PulseSpeedBttn.UseVisualStyleBackColor = False
        Me.PulseSpeedBttn.Visible = False
        '
        'Drawing
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1059, 810)
        Me.Controls.Add(Me.PulseSpeedBttn)
        Me.Controls.Add(Me.ModesList)
        Me.Controls.Add(Me.SaveImg)
        Me.Controls.Add(Me.ClearAll)
        Me.Controls.Add(Me.WhiteColour)
        Me.Controls.Add(Me.AquaColour)
        Me.Controls.Add(Me.BrownColour)
        Me.Controls.Add(Me.PenSizeList)
        Me.Controls.Add(Me.YellowColour)
        Me.Controls.Add(Me.PinkColour)
        Me.Controls.Add(Me.BlackColour)
        Me.Controls.Add(Me.BlueColour)
        Me.Controls.Add(Me.GreenColour)
        Me.Controls.Add(Me.RedColour)
        Me.Controls.Add(Me.SetSize)
        Me.Controls.Add(Me.Undo)
        Me.Controls.Add(Me.CanvasPBox)
        Me.KeyPreview = True
        Me.Name = "Drawing"
        Me.Text = "Drawing"
        CType(Me.CanvasPBox, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents CanvasPBox As Windows.Forms.PictureBox
    Friend WithEvents Undo As Windows.Forms.Button
    Friend WithEvents SetSize As Windows.Forms.Button
    Friend WithEvents RedColour As Windows.Forms.Button
    Friend WithEvents GreenColour As Windows.Forms.Button
    Friend WithEvents BlueColour As Windows.Forms.Button
    Friend WithEvents BlackColour As Windows.Forms.Button
    Friend WithEvents PinkColour As Windows.Forms.Button
    Friend WithEvents YellowColour As Windows.Forms.Button
    Friend WithEvents PenSizeList As Windows.Forms.ComboBox
    Friend WithEvents BrownColour As Windows.Forms.Button
    Friend WithEvents AquaColour As Windows.Forms.Button
    Friend WithEvents WhiteColour As Windows.Forms.Button
    Friend WithEvents ClearAll As Windows.Forms.Button
    Friend WithEvents SaveImg As Windows.Forms.Button
    Friend WithEvents ModesList As Windows.Forms.ComboBox
    Friend WithEvents PulseSpeedBttn As Windows.Forms.Button
End Class
