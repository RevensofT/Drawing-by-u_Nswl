<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class drawing
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
        Me.RedColour = New System.Windows.Forms.Button()
        Me.GreenColour = New System.Windows.Forms.Button()
        Me.BlueColour = New System.Windows.Forms.Button()
        Me.BlackColour = New System.Windows.Forms.Button()
        Me.PinkColour = New System.Windows.Forms.Button()
        Me.YellowColour = New System.Windows.Forms.Button()
        Me.BrownColour = New System.Windows.Forms.Button()
        Me.AquaColour = New System.Windows.Forms.Button()
        Me.WhiteColour = New System.Windows.Forms.Button()
        Me.ClearAll = New System.Windows.Forms.Button()
        Me.SaveImg = New System.Windows.Forms.Button()
        Me.pen_size = New System.Windows.Forms.NumericUpDown()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.pen_puls_speed = New System.Windows.Forms.NumericUpDown()
        Me.pen_pulsating = New System.Windows.Forms.RadioButton()
        Me.pen_crazy = New System.Windows.Forms.RadioButton()
        Me.pen_line = New System.Windows.Forms.RadioButton()
        Me.pen_free = New System.Windows.Forms.RadioButton()
        CType(Me.CanvasPBox, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pen_size, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.pen_puls_speed, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'CanvasPBox
        '
        Me.CanvasPBox.BackColor = System.Drawing.Color.White
        Me.CanvasPBox.Location = New System.Drawing.Point(176, 14)
        Me.CanvasPBox.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.CanvasPBox.Name = "CanvasPBox"
        Me.CanvasPBox.Size = New System.Drawing.Size(898, 888)
        Me.CanvasPBox.TabIndex = 0
        Me.CanvasPBox.TabStop = False
        '
        'Undo
        '
        Me.Undo.BackColor = System.Drawing.Color.LightGray
        Me.Undo.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Undo.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Undo.Location = New System.Drawing.Point(23, 35)
        Me.Undo.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.Undo.Name = "Undo"
        Me.Undo.Size = New System.Drawing.Size(124, 69)
        Me.Undo.TabIndex = 1
        Me.Undo.Text = "UNDO" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "(Ctrl + Z)" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        Me.Undo.UseMnemonic = False
        Me.Undo.UseVisualStyleBackColor = False
        '
        'RedColour
        '
        Me.RedColour.BackColor = System.Drawing.Color.Red
        Me.RedColour.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.RedColour.Location = New System.Drawing.Point(68, 276)
        Me.RedColour.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.RedColour.Name = "RedColour"
        Me.RedColour.Size = New System.Drawing.Size(36, 36)
        Me.RedColour.TabIndex = 3
        Me.RedColour.UseVisualStyleBackColor = False
        '
        'GreenColour
        '
        Me.GreenColour.BackColor = System.Drawing.Color.Lime
        Me.GreenColour.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.GreenColour.Location = New System.Drawing.Point(111, 276)
        Me.GreenColour.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.GreenColour.Name = "GreenColour"
        Me.GreenColour.Size = New System.Drawing.Size(36, 36)
        Me.GreenColour.TabIndex = 4
        Me.GreenColour.UseVisualStyleBackColor = False
        '
        'BlueColour
        '
        Me.BlueColour.BackColor = System.Drawing.Color.Blue
        Me.BlueColour.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.BlueColour.Location = New System.Drawing.Point(25, 318)
        Me.BlueColour.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.BlueColour.Name = "BlueColour"
        Me.BlueColour.Size = New System.Drawing.Size(36, 36)
        Me.BlueColour.TabIndex = 5
        Me.BlueColour.UseVisualStyleBackColor = False
        '
        'BlackColour
        '
        Me.BlackColour.BackColor = System.Drawing.Color.Black
        Me.BlackColour.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.BlackColour.Location = New System.Drawing.Point(25, 276)
        Me.BlackColour.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.BlackColour.Name = "BlackColour"
        Me.BlackColour.Size = New System.Drawing.Size(36, 36)
        Me.BlackColour.TabIndex = 6
        Me.BlackColour.UseVisualStyleBackColor = False
        '
        'PinkColour
        '
        Me.PinkColour.BackColor = System.Drawing.Color.Fuchsia
        Me.PinkColour.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.PinkColour.Location = New System.Drawing.Point(111, 318)
        Me.PinkColour.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.PinkColour.Name = "PinkColour"
        Me.PinkColour.Size = New System.Drawing.Size(36, 36)
        Me.PinkColour.TabIndex = 7
        Me.PinkColour.UseVisualStyleBackColor = False
        '
        'YellowColour
        '
        Me.YellowColour.BackColor = System.Drawing.Color.Yellow
        Me.YellowColour.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.YellowColour.Location = New System.Drawing.Point(68, 318)
        Me.YellowColour.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.YellowColour.Name = "YellowColour"
        Me.YellowColour.Size = New System.Drawing.Size(36, 36)
        Me.YellowColour.TabIndex = 8
        Me.YellowColour.UseVisualStyleBackColor = False
        '
        'BrownColour
        '
        Me.BrownColour.BackColor = System.Drawing.Color.SaddleBrown
        Me.BrownColour.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.BrownColour.Location = New System.Drawing.Point(68, 361)
        Me.BrownColour.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.BrownColour.Name = "BrownColour"
        Me.BrownColour.Size = New System.Drawing.Size(36, 36)
        Me.BrownColour.TabIndex = 10
        Me.BrownColour.UseVisualStyleBackColor = False
        '
        'AquaColour
        '
        Me.AquaColour.BackColor = System.Drawing.Color.Aqua
        Me.AquaColour.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.AquaColour.Location = New System.Drawing.Point(25, 361)
        Me.AquaColour.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.AquaColour.Name = "AquaColour"
        Me.AquaColour.Size = New System.Drawing.Size(36, 36)
        Me.AquaColour.TabIndex = 11
        Me.AquaColour.UseVisualStyleBackColor = False
        '
        'WhiteColour
        '
        Me.WhiteColour.BackColor = System.Drawing.Color.White
        Me.WhiteColour.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.WhiteColour.Location = New System.Drawing.Point(111, 361)
        Me.WhiteColour.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.WhiteColour.Name = "WhiteColour"
        Me.WhiteColour.Size = New System.Drawing.Size(36, 36)
        Me.WhiteColour.TabIndex = 12
        Me.WhiteColour.UseVisualStyleBackColor = False
        '
        'ClearAll
        '
        Me.ClearAll.BackColor = System.Drawing.Color.LightGray
        Me.ClearAll.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ClearAll.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.ClearAll.Location = New System.Drawing.Point(23, 110)
        Me.ClearAll.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.ClearAll.Name = "ClearAll"
        Me.ClearAll.Size = New System.Drawing.Size(124, 69)
        Me.ClearAll.TabIndex = 15
        Me.ClearAll.Text = "CLEAR"
        Me.ClearAll.UseVisualStyleBackColor = False
        '
        'SaveImg
        '
        Me.SaveImg.BackColor = System.Drawing.Color.LightGray
        Me.SaveImg.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.SaveImg.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.SaveImg.Location = New System.Drawing.Point(23, 186)
        Me.SaveImg.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.SaveImg.Name = "SaveImg"
        Me.SaveImg.Size = New System.Drawing.Size(124, 69)
        Me.SaveImg.TabIndex = 16
        Me.SaveImg.Text = "SAVE"
        Me.SaveImg.UseVisualStyleBackColor = False
        '
        'pen_size
        '
        Me.pen_size.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.pen_size.Location = New System.Drawing.Point(83, 407)
        Me.pen_size.Maximum = New Decimal(New Integer() {999, 0, 0, 0})
        Me.pen_size.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.pen_size.Name = "pen_size"
        Me.pen_size.Size = New System.Drawing.Size(64, 35)
        Me.pen_size.TabIndex = 19
        Me.pen_size.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.pen_size.Value = New Decimal(New Integer() {10, 0, 0, 0})
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label1.Location = New System.Drawing.Point(27, 409)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(50, 30)
        Me.Label1.TabIndex = 20
        Me.Label1.Text = "Size"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.pen_puls_speed)
        Me.GroupBox1.Controls.Add(Me.pen_pulsating)
        Me.GroupBox1.Controls.Add(Me.pen_crazy)
        Me.GroupBox1.Controls.Add(Me.pen_line)
        Me.GroupBox1.Controls.Add(Me.pen_free)
        Me.GroupBox1.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.GroupBox1.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.GroupBox1.Location = New System.Drawing.Point(23, 458)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(124, 225)
        Me.GroupBox1.TabIndex = 21
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Pen mode"
        '
        'pen_puls_speed
        '
        Me.pen_puls_speed.Location = New System.Drawing.Point(37, 169)
        Me.pen_puls_speed.Maximum = New Decimal(New Integer() {1000, 0, 0, 0})
        Me.pen_puls_speed.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.pen_puls_speed.Name = "pen_puls_speed"
        Me.pen_puls_speed.Size = New System.Drawing.Size(72, 33)
        Me.pen_puls_speed.TabIndex = 4
        Me.pen_puls_speed.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.pen_puls_speed.Value = New Decimal(New Integer() {10, 0, 0, 0})
        '
        'pen_pulsating
        '
        Me.pen_pulsating.AutoSize = True
        Me.pen_pulsating.Location = New System.Drawing.Point(13, 137)
        Me.pen_pulsating.Name = "pen_pulsating"
        Me.pen_pulsating.Size = New System.Drawing.Size(108, 29)
        Me.pen_pulsating.TabIndex = 3
        Me.pen_pulsating.Text = "Pulsating"
        Me.pen_pulsating.UseVisualStyleBackColor = True
        '
        'pen_crazy
        '
        Me.pen_crazy.AutoSize = True
        Me.pen_crazy.Location = New System.Drawing.Point(13, 102)
        Me.pen_crazy.Name = "pen_crazy"
        Me.pen_crazy.Size = New System.Drawing.Size(77, 29)
        Me.pen_crazy.TabIndex = 2
        Me.pen_crazy.Text = "Crazy"
        Me.pen_crazy.UseVisualStyleBackColor = True
        '
        'pen_line
        '
        Me.pen_line.AutoSize = True
        Me.pen_line.Location = New System.Drawing.Point(13, 67)
        Me.pen_line.Name = "pen_line"
        Me.pen_line.Size = New System.Drawing.Size(65, 29)
        Me.pen_line.TabIndex = 1
        Me.pen_line.Text = "Line"
        Me.pen_line.UseVisualStyleBackColor = True
        '
        'pen_free
        '
        Me.pen_free.AutoSize = True
        Me.pen_free.Checked = True
        Me.pen_free.Location = New System.Drawing.Point(13, 32)
        Me.pen_free.Name = "pen_free"
        Me.pen_free.Size = New System.Drawing.Size(66, 29)
        Me.pen_free.TabIndex = 0
        Me.pen_free.TabStop = True
        Me.pen_free.Text = "Free"
        Me.pen_free.UseVisualStyleBackColor = True
        '
        'drawing
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1236, 881)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.pen_size)
        Me.Controls.Add(Me.SaveImg)
        Me.Controls.Add(Me.ClearAll)
        Me.Controls.Add(Me.WhiteColour)
        Me.Controls.Add(Me.AquaColour)
        Me.Controls.Add(Me.BrownColour)
        Me.Controls.Add(Me.YellowColour)
        Me.Controls.Add(Me.PinkColour)
        Me.Controls.Add(Me.BlackColour)
        Me.Controls.Add(Me.BlueColour)
        Me.Controls.Add(Me.GreenColour)
        Me.Controls.Add(Me.RedColour)
        Me.Controls.Add(Me.Undo)
        Me.Controls.Add(Me.CanvasPBox)
        Me.KeyPreview = True
        Me.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.Name = "drawing"
        Me.Text = "Drawing"
        CType(Me.CanvasPBox, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pen_size, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.pen_puls_speed, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents CanvasPBox As Windows.Forms.PictureBox
    Friend WithEvents Undo As Windows.Forms.Button
    Friend WithEvents RedColour As Windows.Forms.Button
    Friend WithEvents GreenColour As Windows.Forms.Button
    Friend WithEvents BlueColour As Windows.Forms.Button
    Friend WithEvents BlackColour As Windows.Forms.Button
    Friend WithEvents PinkColour As Windows.Forms.Button
    Friend WithEvents YellowColour As Windows.Forms.Button
    Friend WithEvents BrownColour As Windows.Forms.Button
    Friend WithEvents AquaColour As Windows.Forms.Button
    Friend WithEvents WhiteColour As Windows.Forms.Button
    Friend WithEvents ClearAll As Windows.Forms.Button
    Friend WithEvents SaveImg As Windows.Forms.Button
    Friend WithEvents pen_size As NumericUpDown
    Friend WithEvents Label1 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents pen_free As RadioButton
    Friend WithEvents pen_pulsating As RadioButton
    Friend WithEvents pen_crazy As RadioButton
    Friend WithEvents pen_line As RadioButton
    Friend WithEvents pen_puls_speed As NumericUpDown
End Class
