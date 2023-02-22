<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.lblCostOfStay = New System.Windows.Forms.Label()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.btnCost = New System.Windows.Forms.Button()
        Me.lblNumberOfNights = New System.Windows.Forms.Label()
        Me.picAirbnb = New System.Windows.Forms.PictureBox()
        Me.txtNumNights = New System.Windows.Forms.TextBox()
        Me.lblCostHead = New System.Windows.Forms.Label()
        Me.lblOrlAir = New System.Windows.Forms.Label()
        Me.lblCostDisplay = New System.Windows.Forms.Label()
        CType(Me.picAirbnb, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblCostOfStay
        '
        Me.lblCostOfStay.AutoSize = True
        Me.lblCostOfStay.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCostOfStay.Location = New System.Drawing.Point(459, 227)
        Me.lblCostOfStay.Name = "lblCostOfStay"
        Me.lblCostOfStay.Size = New System.Drawing.Size(119, 24)
        Me.lblCostOfStay.TabIndex = 0
        Me.lblCostOfStay.Text = "Cost of Stay"
        '
        'btnClear
        '
        Me.btnClear.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClear.Location = New System.Drawing.Point(534, 351)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(104, 33)
        Me.btnClear.TabIndex = 1
        Me.btnClear.Text = "Clear"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExit.Location = New System.Drawing.Point(659, 351)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(104, 33)
        Me.btnExit.TabIndex = 2
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'btnCost
        '
        Me.btnCost.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCost.Location = New System.Drawing.Point(409, 351)
        Me.btnCost.Name = "btnCost"
        Me.btnCost.Size = New System.Drawing.Size(104, 33)
        Me.btnCost.TabIndex = 3
        Me.btnCost.Text = "Display Cost"
        Me.btnCost.UseVisualStyleBackColor = True
        '
        'lblNumberOfNights
        '
        Me.lblNumberOfNights.AutoSize = True
        Me.lblNumberOfNights.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNumberOfNights.Location = New System.Drawing.Point(449, 135)
        Me.lblNumberOfNights.Name = "lblNumberOfNights"
        Me.lblNumberOfNights.Size = New System.Drawing.Size(179, 24)
        Me.lblNumberOfNights.TabIndex = 4
        Me.lblNumberOfNights.Text = "Number of Nights:"
        '
        'picAirbnb
        '
        Me.picAirbnb.Image = CType(resources.GetObject("picAirbnb.Image"), System.Drawing.Image)
        Me.picAirbnb.Location = New System.Drawing.Point(12, 2)
        Me.picAirbnb.Name = "picAirbnb"
        Me.picAirbnb.Size = New System.Drawing.Size(368, 450)
        Me.picAirbnb.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picAirbnb.TabIndex = 5
        Me.picAirbnb.TabStop = False
        '
        'txtNumNights
        '
        Me.txtNumNights.Location = New System.Drawing.Point(683, 135)
        Me.txtNumNights.Name = "txtNumNights"
        Me.txtNumNights.Size = New System.Drawing.Size(53, 20)
        Me.txtNumNights.TabIndex = 6
        '
        'lblCostHead
        '
        Me.lblCostHead.AutoSize = True
        Me.lblCostHead.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCostHead.Location = New System.Drawing.Point(531, 65)
        Me.lblCostHead.Name = "lblCostHead"
        Me.lblCostHead.Size = New System.Drawing.Size(151, 16)
        Me.lblCostHead.TabIndex = 7
        Me.lblCostHead.Text = "Only $79.00 per night"
        '
        'lblOrlAir
        '
        Me.lblOrlAir.AutoSize = True
        Me.lblOrlAir.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblOrlAir.Location = New System.Drawing.Point(491, 23)
        Me.lblOrlAir.Name = "lblOrlAir"
        Me.lblOrlAir.Size = New System.Drawing.Size(215, 31)
        Me.lblOrlAir.TabIndex = 8
        Me.lblOrlAir.Text = "Orlando AirBnB"
        '
        'lblCostDisplay
        '
        Me.lblCostDisplay.AutoSize = True
        Me.lblCostDisplay.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCostDisplay.Location = New System.Drawing.Point(697, 235)
        Me.lblCostDisplay.Name = "lblCostDisplay"
        Me.lblCostDisplay.Size = New System.Drawing.Size(40, 16)
        Me.lblCostDisplay.TabIndex = 9
        Me.lblCostDisplay.Text = "$553"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DarkOliveGreen
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.lblCostDisplay)
        Me.Controls.Add(Me.lblOrlAir)
        Me.Controls.Add(Me.lblCostHead)
        Me.Controls.Add(Me.txtNumNights)
        Me.Controls.Add(Me.picAirbnb)
        Me.Controls.Add(Me.lblNumberOfNights)
        Me.Controls.Add(Me.btnCost)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.lblCostOfStay)
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Airbnb Reservation"
        CType(Me.picAirbnb, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblCostOfStay As Label
    Friend WithEvents btnClear As Button
    Friend WithEvents btnExit As Button
    Friend WithEvents btnCost As Button
    Friend WithEvents lblNumberOfNights As Label
    Friend WithEvents picAirbnb As PictureBox
    Friend WithEvents txtNumNights As TextBox
    Friend WithEvents lblCostHead As Label
    Friend WithEvents lblOrlAir As Label
    Friend WithEvents lblCostDisplay As Label
End Class
