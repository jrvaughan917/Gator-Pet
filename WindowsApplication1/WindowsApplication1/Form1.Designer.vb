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
        Me.components = New System.ComponentModel.Container()
        Me.Feed = New System.Windows.Forms.Button()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.hunger = New System.Windows.Forms.ProgressBar()
        Me.cleanliness = New System.Windows.Forms.ProgressBar()
        Me.Happiness = New System.Windows.Forms.ProgressBar()
        Me.statusTimer = New System.Windows.Forms.Timer(Me.components)
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.moveTime = New System.Windows.Forms.Timer(Me.components)
        Me.wait = New System.Windows.Forms.Timer(Me.components)
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.TextBox5 = New System.Windows.Forms.TextBox()
        Me.Save = New System.Windows.Forms.Button()
        Me.newPet = New System.Windows.Forms.Button()
        Me.randomTime = New System.Windows.Forms.Timer(Me.components)
        Me.TextBox6 = New System.Windows.Forms.TextBox()
        Me.Clean = New System.Windows.Forms.Button()
        Me.Trick = New System.Windows.Forms.Button()
        Me.Listen = New System.Windows.Forms.Button()
        Me.money = New System.Windows.Forms.TextBox()
        Me.foodBox = New System.Windows.Forms.TextBox()
        Me.Speak = New System.Windows.Forms.Button()
        Me.buy = New System.Windows.Forms.Button()
        Me.work = New System.Windows.Forms.Button()
        Me.working = New System.Windows.Forms.Timer(Me.components)
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Feed
        '
        Me.Feed.Location = New System.Drawing.Point(12, 85)
        Me.Feed.Name = "Feed"
        Me.Feed.Size = New System.Drawing.Size(100, 23)
        Me.Feed.TabIndex = 1
        Me.Feed.Text = "Feed"
        Me.Feed.UseVisualStyleBackColor = True
        '
        'TextBox1
        '
        Me.TextBox1.BackColor = System.Drawing.Color.White
        Me.TextBox1.HideSelection = False
        Me.TextBox1.Location = New System.Drawing.Point(12, 22)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.ReadOnly = True
        Me.TextBox1.ShortcutsEnabled = False
        Me.TextBox1.Size = New System.Drawing.Size(100, 20)
        Me.TextBox1.TabIndex = 4
        Me.TextBox1.TabStop = False
        Me.TextBox1.Text = "Menu"
        Me.TextBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'hunger
        '
        Me.hunger.ForeColor = System.Drawing.Color.Maroon
        Me.hunger.Location = New System.Drawing.Point(876, 169)
        Me.hunger.Maximum = 1000
        Me.hunger.Name = "hunger"
        Me.hunger.Size = New System.Drawing.Size(100, 23)
        Me.hunger.TabIndex = 5
        '
        'cleanliness
        '
        Me.cleanliness.Location = New System.Drawing.Point(876, 229)
        Me.cleanliness.Maximum = 1000
        Me.cleanliness.Name = "cleanliness"
        Me.cleanliness.Size = New System.Drawing.Size(100, 23)
        Me.cleanliness.TabIndex = 7
        '
        'Happiness
        '
        Me.Happiness.Location = New System.Drawing.Point(877, 114)
        Me.Happiness.Maximum = 1000
        Me.Happiness.Name = "Happiness"
        Me.Happiness.Size = New System.Drawing.Size(100, 23)
        Me.Happiness.TabIndex = 8
        '
        'statusTimer
        '
        '
        'TextBox2
        '
        Me.TextBox2.BackColor = System.Drawing.Color.White
        Me.TextBox2.Location = New System.Drawing.Point(876, 12)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.ReadOnly = True
        Me.TextBox2.Size = New System.Drawing.Size(100, 20)
        Me.TextBox2.TabIndex = 9
        Me.TextBox2.Text = "Status"
        Me.TextBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'moveTime
        '
        '
        'wait
        '
        '
        'TextBox3
        '
        Me.TextBox3.BackColor = System.Drawing.Color.White
        Me.TextBox3.Location = New System.Drawing.Point(876, 143)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.ReadOnly = True
        Me.TextBox3.Size = New System.Drawing.Size(100, 20)
        Me.TextBox3.TabIndex = 11
        Me.TextBox3.Text = "Hunger"
        Me.TextBox3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TextBox5
        '
        Me.TextBox5.BackColor = System.Drawing.Color.White
        Me.TextBox5.Location = New System.Drawing.Point(876, 203)
        Me.TextBox5.Name = "TextBox5"
        Me.TextBox5.ReadOnly = True
        Me.TextBox5.Size = New System.Drawing.Size(100, 20)
        Me.TextBox5.TabIndex = 13
        Me.TextBox5.Text = "Cleanliness"
        Me.TextBox5.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Save
        '
        Me.Save.Location = New System.Drawing.Point(510, 426)
        Me.Save.Name = "Save"
        Me.Save.Size = New System.Drawing.Size(100, 23)
        Me.Save.TabIndex = 14
        Me.Save.Text = "Save"
        Me.Save.UseVisualStyleBackColor = True
        '
        'newPet
        '
        Me.newPet.Location = New System.Drawing.Point(390, 426)
        Me.newPet.Name = "newPet"
        Me.newPet.Size = New System.Drawing.Size(100, 23)
        Me.newPet.TabIndex = 15
        Me.newPet.Text = "New Pet"
        Me.newPet.UseVisualStyleBackColor = True
        '
        'randomTime
        '
        '
        'TextBox6
        '
        Me.TextBox6.BackColor = System.Drawing.Color.White
        Me.TextBox6.Location = New System.Drawing.Point(877, 85)
        Me.TextBox6.Name = "TextBox6"
        Me.TextBox6.ReadOnly = True
        Me.TextBox6.Size = New System.Drawing.Size(100, 20)
        Me.TextBox6.TabIndex = 16
        Me.TextBox6.Text = "Happiness"
        Me.TextBox6.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Clean
        '
        Me.Clean.Location = New System.Drawing.Point(11, 114)
        Me.Clean.Name = "Clean"
        Me.Clean.Size = New System.Drawing.Size(101, 23)
        Me.Clean.TabIndex = 17
        Me.Clean.Text = "Clean"
        Me.Clean.UseVisualStyleBackColor = True
        '
        'Trick
        '
        Me.Trick.Location = New System.Drawing.Point(11, 143)
        Me.Trick.Name = "Trick"
        Me.Trick.Size = New System.Drawing.Size(101, 23)
        Me.Trick.TabIndex = 18
        Me.Trick.Text = "Trick"
        Me.Trick.UseVisualStyleBackColor = True
        '
        'Listen
        '
        Me.Listen.Location = New System.Drawing.Point(11, 172)
        Me.Listen.Name = "Listen"
        Me.Listen.Size = New System.Drawing.Size(101, 23)
        Me.Listen.TabIndex = 19
        Me.Listen.Text = "Listen"
        Me.Listen.UseVisualStyleBackColor = True
        '
        'money
        '
        Me.money.BackColor = System.Drawing.Color.White
        Me.money.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.money.HideSelection = False
        Me.money.Location = New System.Drawing.Point(876, 280)
        Me.money.Name = "money"
        Me.money.ReadOnly = True
        Me.money.ShortcutsEnabled = False
        Me.money.Size = New System.Drawing.Size(100, 13)
        Me.money.TabIndex = 21
        Me.money.TabStop = False
        Me.money.Text = "Cash: $0"
        Me.money.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'foodBox
        '
        Me.foodBox.BackColor = System.Drawing.Color.White
        Me.foodBox.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.foodBox.HideSelection = False
        Me.foodBox.Location = New System.Drawing.Point(876, 306)
        Me.foodBox.Name = "foodBox"
        Me.foodBox.ReadOnly = True
        Me.foodBox.ShortcutsEnabled = False
        Me.foodBox.Size = New System.Drawing.Size(100, 13)
        Me.foodBox.TabIndex = 22
        Me.foodBox.TabStop = False
        Me.foodBox.Text = "Food: 00 lbs"
        Me.foodBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Speak
        '
        Me.Speak.Location = New System.Drawing.Point(11, 201)
        Me.Speak.Name = "Speak"
        Me.Speak.Size = New System.Drawing.Size(101, 23)
        Me.Speak.TabIndex = 20
        Me.Speak.Text = "Speak"
        Me.Speak.UseVisualStyleBackColor = True
        '
        'buy
        '
        Me.buy.Location = New System.Drawing.Point(11, 230)
        Me.buy.Name = "buy"
        Me.buy.Size = New System.Drawing.Size(101, 23)
        Me.buy.TabIndex = 23
        Me.buy.Text = "Buy Food"
        Me.buy.UseVisualStyleBackColor = True
        '
        'work
        '
        Me.work.Location = New System.Drawing.Point(11, 259)
        Me.work.Name = "work"
        Me.work.Size = New System.Drawing.Size(101, 23)
        Me.work.TabIndex = 24
        Me.work.Text = "Go to Work"
        Me.work.UseVisualStyleBackColor = True
        '
        'working
        '
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.WindowsApplication1.My.Resources.Resources.rrr
        Me.PictureBox1.Location = New System.Drawing.Point(293, 298)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(225, 80)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 10
        Me.PictureBox1.TabStop = False
        '
        'PictureBox2
        '
        Me.PictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox2.Image = Global.WindowsApplication1.My.Resources.Resources.Ally_Fire
        Me.PictureBox2.InitialImage = Nothing
        Me.PictureBox2.Location = New System.Drawing.Point(535, 306)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(100, 50)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 25
        Me.PictureBox2.TabStop = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.BackColor = System.Drawing.Color.White
        Me.BackgroundImage = Global.WindowsApplication1.My.Resources.Resources.waterfall
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(984, 461)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.work)
        Me.Controls.Add(Me.buy)
        Me.Controls.Add(Me.foodBox)
        Me.Controls.Add(Me.money)
        Me.Controls.Add(Me.Speak)
        Me.Controls.Add(Me.Listen)
        Me.Controls.Add(Me.Trick)
        Me.Controls.Add(Me.Clean)
        Me.Controls.Add(Me.TextBox6)
        Me.Controls.Add(Me.newPet)
        Me.Controls.Add(Me.Save)
        Me.Controls.Add(Me.TextBox5)
        Me.Controls.Add(Me.TextBox3)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.Happiness)
        Me.Controls.Add(Me.cleanliness)
        Me.Controls.Add(Me.hunger)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.Feed)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "Form1"
        Me.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "super gator"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Feed As System.Windows.Forms.Button
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents hunger As System.Windows.Forms.ProgressBar
    Friend WithEvents cleanliness As System.Windows.Forms.ProgressBar
    Friend WithEvents Happiness As System.Windows.Forms.ProgressBar
    Friend WithEvents statusTimer As System.Windows.Forms.Timer
    Friend WithEvents TextBox2 As System.Windows.Forms.TextBox
    Friend WithEvents moveTime As System.Windows.Forms.Timer
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents wait As System.Windows.Forms.Timer
    Friend WithEvents TextBox3 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox5 As System.Windows.Forms.TextBox
    Friend WithEvents Save As System.Windows.Forms.Button
    Friend WithEvents newPet As System.Windows.Forms.Button
    Friend WithEvents randomTime As System.Windows.Forms.Timer
    Friend WithEvents TextBox6 As System.Windows.Forms.TextBox
    Friend WithEvents Clean As System.Windows.Forms.Button
    Friend WithEvents Trick As System.Windows.Forms.Button
    Friend WithEvents Listen As System.Windows.Forms.Button
    Friend WithEvents money As System.Windows.Forms.TextBox
    Friend WithEvents foodBox As System.Windows.Forms.TextBox
    Friend WithEvents Speak As System.Windows.Forms.Button
    Friend WithEvents buy As System.Windows.Forms.Button
    Friend WithEvents work As System.Windows.Forms.Button
    Friend WithEvents working As System.Windows.Forms.Timer
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox

End Class
