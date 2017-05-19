

Imports System
Imports System.IO
Imports System.Text
Public Class Form1

    Dim ran As New Random
    Dim ran2 As New Integer
    Dim x As New Integer
    Dim d As New Integer
    Dim w As New Integer
    Dim m As New Integer
    Dim v As New Integer
    Dim cash As New Integer
    Dim food As New Integer
    Dim added As New Integer
    Dim pSave As String = Application.LocalUserAppDataPath + "pet.txt"
    Dim choice As New Integer
    Dim alive As New Boolean
    Dim log As String
    Dim timePlayed As Integer


    Private Sub TableLayoutPanel1_Paint(sender As Object, e As PaintEventArgs)
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Me.Visible = False
start:
        If My.Computer.FileSystem.FileExists(pSave) Then
            loadPet()
        Else
            petCreate()
        End If
        PictureBox2.Visible = False
        Me.Visible = True
        statusTimer.Start()
        randomTime.Interval = 60000
        randomTime.Start()

        moveTime.Interval = 1000
        statusTimer.Interval = statusTimer.Interval * 5
        working.Interval = 6000
        timePlayed = 0
        wait.Interval = wait.Interval + 250
        PictureBox1.Image = My.Resources.ll
        'MsgBox(moveTime.Interval.ToString)
        x = 1
        w = 0
        v = 1
        d = ran.Next(0, 2)
        moveTime.Enabled = True
        m = 50

        added = 100
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Feed.Click

        If (food >= 5) Then
            food = food - 5
            foodBox.Text = "Food: " + food.ToString + " lbs"
            Feed.Enabled = False
            moveTime.Enabled = False
            PictureBox1.Image = My.Resources.open
            PictureBox2.Location = New Point(PictureBox1.Location.X - 100, PictureBox1.Location.Y + 10)
            PictureBox2.Image = My.Resources.food
            PictureBox2.Visible = True

            If (hunger.Value + added < hunger.Maximum) Then
                hunger.Value = hunger.Value + added
            Else
                hunger.Value = hunger.Maximum
            End If

            wait.Enabled = True
        Else
            MessageBox.Show("Not enough food")
        End If
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles statusTimer.Tick
        If (hunger.Value - v > 0) Then
            hunger.Value = hunger.Value - v
        Else
            hunger.Value = 0
        End If
        If (Happiness.Value - v > 0) Then
            Happiness.Value = Happiness.Value - (v * 4)
        Else
            Happiness.Value = 0
        End If


        If (cleanliness.Value - v > 0) Then
            cleanliness.Value = cleanliness.Value - v
        Else
            cleanliness.Value = 0
        End If
        If (hunger.Value = 0 Or Happiness.Value = 0) Then
            moveTime.Stop()
            statusTimer.Stop()
            randomTime.Stop()
            PictureBox1.Image = My.Resources.Dies

            MessageBox.Show("Your pet has died.")

            Me.Close()

        End If
    End Sub

    Private Sub moveTime_Tick(sender As Object, e As EventArgs) Handles moveTime.Tick
        If (PictureBox1.Location.X < 250) Then
            d = 1
        ElseIf (PictureBox1.Location.X > 640) Then
            d = 0
        End If
        If (d = 0) Then
            If (x = 1) Then
                PictureBox1.Location = New Point(PictureBox1.Location.X - m, PictureBox1.Location.Y)
                PictureBox1.Image = My.Resources.ll
            ElseIf (x = 2) Then
                PictureBox1.Location = New Point(PictureBox1.Location.X - m, PictureBox1.Location.Y)
                PictureBox1.Image = My.Resources.lm
            ElseIf (x = 3) Then
                PictureBox1.Location = New Point(PictureBox1.Location.X - m, PictureBox1.Location.Y)
                PictureBox1.Image = My.Resources.lr
            ElseIf (x = 4) Then
                PictureBox1.Location = New Point(PictureBox1.Location.X - m, PictureBox1.Location.Y)
                PictureBox1.Image = My.Resources.lm
            Else
                d = ran.Next(0, 2)
                x = 0
            End If
        ElseIf (d = 1) Then
            If (x = 1) Then
                PictureBox1.Location = New Point(PictureBox1.Location.X + m, PictureBox1.Location.Y)
                PictureBox1.Image = My.Resources.rl
            ElseIf (x = 2) Then
                PictureBox1.Location = New Point(PictureBox1.Location.X + m, PictureBox1.Location.Y)
                PictureBox1.Image = My.Resources.rm
            ElseIf (x = 3) Then
                PictureBox1.Location = New Point(PictureBox1.Location.X + m, PictureBox1.Location.Y)
                PictureBox1.Image = My.Resources.rr

            ElseIf (x = 4) Then
                PictureBox1.Location = New Point(PictureBox1.Location.X + m, PictureBox1.Location.Y)
                PictureBox1.Image = My.Resources.rm
            Else
                d = ran.Next(0, 2)
                x = 0
            End If
        End If
        x = x + 1
    End Sub

    Private Sub wait_Tick(sender As Object, e As EventArgs) Handles wait.Tick
        Feed.Enabled = False
        Trick.Enabled = False
        Listen.Enabled = False
        Speak.Enabled = False
        work.Enabled = False

        Clean.Enabled = False

        If (w = 4) Then
            randomTime.Start()
            moveTime.Start()
            PictureBox2.Visible = False
            w = 0
            wait.Stop()
            If (Happiness.Value + 100 >= Happiness.Maximum) Then
                Happiness.Value = Happiness.Maximum
            Else
                Happiness.Value = Happiness.Value + 100
            End If

            Feed.Enabled = True

            Clean.Enabled = True
            Trick.Enabled = True
            Listen.Enabled = True
            Speak.Enabled = True
            work.Enabled = True


        End If
        w = w + 1
    End Sub


    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Save.Click
        savePet()
    End Sub
    Private Sub loadPet()
        Dim fileReader As String

        Dim objReader As New System.IO.StreamReader(pSave)
        fileReader = objReader.ReadLine()
        Name = fileReader
        ' MsgBox(Name)
        fileReader = objReader.ReadLine() & vbNewLine
        hunger.Value = fileReader
        'MsgBox(fileReader)

        'MsgBox(fileReader)
        fileReader = objReader.ReadLine() & vbNewLine
        cleanliness.Value = fileReader
        fileReader = objReader.ReadLine() & vbNewLine
        Happiness.Value = fileReader
        fileReader = objReader.ReadLine() & vbNewLine
        cash = fileReader
        fileReader = objReader.ReadLine() & vbNewLine
        food = fileReader
        fileReader = objReader.ReadLine() & vbNewLine
        log = fileReader
        money.Text = "Cash: $" + cash.ToString
        foodBox.Text = "Food: " + food.ToString + " lbs"


        objReader.Close()
        Me.Text = Name
    End Sub
    Private Sub savePet()
        Dim petSave As FileStream = File.Create(pSave)
        Dim info As Byte() = New UTF8Encoding(True).GetBytes(Name & vbCrLf & hunger.Value.ToString & vbCrLf & cleanliness.Value.ToString & vbCrLf & Happiness.Value.ToString & vbCrLf & cash & vbCrLf & food & vbCrLf & log)
        petSave.Write(info, 0, info.Length)
        MessageBox.Show(Save, "Thank you for saving")
        petSave.Close()
    End Sub



    Private Sub Clean_Click(sender As Object, e As EventArgs) Handles Clean.Click
        cleanliness.Enabled = False
        moveTime.Enabled = False
        PictureBox1.Image = My.Resources.open
        PictureBox2.Location = New Point(PictureBox1.Location.X, PictureBox1.Location.Y - 50)
        PictureBox2.Image = My.Resources.Clean
        PictureBox2.Visible = True
        If (cleanliness.Value + added < cleanliness.Maximum) Then
            cleanliness.Value = cleanliness.Value + added
        Else
            cleanliness.Value = cleanliness.Maximum

        End If

        wait.Enabled = True
    End Sub

    Private Sub Button1_Click_2(sender As Object, e As EventArgs) Handles newPet.Click
        Me.Visible = False
        petCreate()
        Me.Visible = True
    End Sub
    Private Sub petCreate()
        Name = InputBox("What would you like to name ur pet?", "Name")
        If (Name = "") Then
            Name = "Jack"
        End If
        hunger.Value = hunger.Maximum
        Happiness.Value = Happiness.Maximum
        cleanliness.Value = hunger.Value
        cash = 20
        food = 5
        Dim petSave As FileStream = File.Create(pSave)
        Dim info As Byte() = New UTF8Encoding(True).GetBytes(Name & vbCrLf & hunger.Value.ToString & vbCrLf & cleanliness.Value.ToString & vbCrLf & Happiness.Value.ToString & vbCrLf & cash & vbCrLf & food & vbCrLf & log)
        petSave.Write(info, 0, info.Length)
        petSave.Close()
        Me.Text = Name
        money.Text = "Cash: $" + cash.ToString
        foodBox.Text = "Food: " + food.ToString + " lbs"
    End Sub

    Private Sub work_Click(sender As Object, e As EventArgs) Handles work.Click

        Me.Enabled = False
        moveTime.Stop()
        statusTimer.Stop()
        randomTime.Stop()
        PictureBox1.Visible = False
        MessageBox.Show("Your pet is going to work")
        Me.BackgroundImage = My.Resources.underwater
        w = 0
        working.Start()




    End Sub


    Private Sub working_Tick(sender As Object, e As EventArgs) Handles working.Tick
        w = w + 1
        If (w >= 0) Then
            Me.Enabled = True
            moveTime.Start()
            statusTimer.Start()
            PictureBox1.Visible = True
            cash = cash + 50
            money.Text = "Cash: $" + cash.ToString
            working.Stop()
            Me.BackgroundImage = My.Resources.waterfall

        End If



    End Sub

    Private Sub buy_Click(sender As Object, e As EventArgs) Handles buy.Click
        If (cash >= 10) Then
            food = food + 20
            cash = cash - 10
            money.Text = "Cash: $" + cash.ToString
            foodBox.Text = "Food: " + food.ToString + " lbs"

        End If
    End Sub



    Private Sub Trick_Click(sender As Object, e As EventArgs) Handles Trick.Click
        moveTime.Stop()
        wait.Start()
        PictureBox1.Image = My.Resources.open
        PictureBox2.Location = New Point(PictureBox1.Location.X - 100, PictureBox1.Location.Y + 10)
        PictureBox2.Image = My.Resources.Ally_Fire
        PictureBox2.Visible = True

    End Sub

    Private Sub Listen_Click(sender As Object, e As EventArgs) Handles Listen.Click
        log = InputBox("What would u like ur gator to remember for you?", "Log")
    End Sub

    Private Sub Speak_Click(sender As Object, e As EventArgs) Handles Speak.Click
        MessageBox.Show(log)

    End Sub

    Private Sub randomTime_Tick(sender As Object, e As EventArgs) Handles randomTime.Tick

        ran2 = ran.Next(0, 20)
        timePlayed = timePlayed + 1
        Select Case ran2
            Case 1
                Speak.PerformClick()
            Case 2
                Trick.PerformClick()
            Case 3
                MessageBox.Show("I found a cupcake")
                food = food + 5
                foodBox.Text = "Food: " + food.ToString + " lbs"
            Case 4
                MessageBox.Show("You have been playing for " + timePlayed.ToString + " minutes", "Time Played this session")
            Case 5
                MessageBox.Show("Hello")
            Case 6
                MessageBox.Show("I want a cupcake")
            Case 7
                MessageBox.Show("Isn't the world amazing")
            Case 9
                MessageBox.Show("I found buried treasure")
                cash = cash + 50
                money.Text = "Cash: $" + cash.ToString
        End Select


    End Sub
End Class
