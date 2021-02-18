Public Class Form1
    Inherits System.Windows.Forms.Form
    Friend WithEvents Interval As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents MenuItem2 As System.Windows.Forms.MenuItem
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents beads As System.Windows.Forms.TextBox
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents MenuItem1 As System.Windows.Forms.MenuItem
    Friend WithEvents MainMenu1 As System.Windows.Forms.MainMenu

#Region " Windows Form Designer generated code "

    Public Sub New()
        MyBase.New()

        'This call is required by the Windows Form Designer.
        InitializeComponent()

        'Add any initialization after the InitializeComponent() call

    End Sub

    'Form overrides dispose to clean up the component list.
    Protected Overloads Overrides Sub Dispose(ByVal disposing As Boolean)
        MyBase.Dispose(disposing)
    End Sub

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    Private Sub InitializeComponent()
        Me.MainMenu1 = New System.Windows.Forms.MainMenu
        Me.Interval = New System.Windows.Forms.TextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.beads = New System.Windows.Forms.TextBox
        Me.MenuItem2 = New System.Windows.Forms.MenuItem
        Me.Timer1 = New System.Windows.Forms.Timer
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.MenuItem1 = New System.Windows.Forms.MenuItem
        '
        'MainMenu1
        '
        Me.MainMenu1.MenuItems.Add(Me.MenuItem1)
        Me.MainMenu1.MenuItems.Add(Me.MenuItem2)
        '
        'Interval
        '
        Me.Interval.Location = New System.Drawing.Point(105, 55)
        Me.Interval.MaxLength = 2
        Me.Interval.Size = New System.Drawing.Size(30, 24)
        Me.Interval.Text = "3"
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(27, 55)
        Me.Label1.Size = New System.Drawing.Size(72, 23)
        Me.Label1.Text = "Interval:"
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(27, 95)
        Me.Label2.Size = New System.Drawing.Size(55, 25)
        Me.Label2.Text = "Beads:"
        '
        'beads
        '
        Me.beads.Location = New System.Drawing.Point(88, 96)
        Me.beads.MaxLength = 6
        Me.beads.Size = New System.Drawing.Size(47, 24)
        Me.beads.Text = "108"
        '
        'MenuItem2
        '
        Me.MenuItem2.Text = "Begin"
        '
        'Timer1
        '
        Me.Timer1.Interval = 3000
        '
        'Label3
        '
        Me.Label3.Font = New System.Drawing.Font("Nina", 11.0!, System.Drawing.FontStyle.Regular)
        Me.Label3.Location = New System.Drawing.Point(6, 8)
        Me.Label3.Size = New System.Drawing.Size(156, 35)
        Me.Label3.Text = "Remember to put phone on flight mode!"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Label4
        '
        Me.Label4.Font = New System.Drawing.Font("Nina", 14.0!, System.Drawing.FontStyle.Regular)
        Me.Label4.Location = New System.Drawing.Point(21, 142)
        Me.Label4.Size = New System.Drawing.Size(140, 24)
        Me.Label4.Text = "Jai Guru Dev!"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'MenuItem1
        '
        Me.MenuItem1.Text = "Reset"
        '
        'Form1
        '
        Me.ClientSize = New System.Drawing.Size(176, 180)
        Me.Controls.Add(Me.beads)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Interval)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label4)
        Me.Menu = Me.MainMenu1
        Me.Text = "Chant Mala"

    End Sub

#End Region

    Private Sub Form1_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown
        If (e.KeyCode = System.Windows.Forms.Keys.F1) Then
            Timer1.Enabled = False
        End If
        If (e.KeyCode = System.Windows.Forms.Keys.F2) Then
            Timer1.Enabled = True
        End If
        If (e.KeyCode = System.Windows.Forms.Keys.Up) Then
            'Up
        End If
        If (e.KeyCode = System.Windows.Forms.Keys.Down) Then
            'Down
        End If
        If (e.KeyCode = System.Windows.Forms.Keys.Left) Then
            'Left
        End If
        If (e.KeyCode = System.Windows.Forms.Keys.Right) Then
            'Right
        End If
        If (e.KeyCode = System.Windows.Forms.Keys.Enter) Then
            'Enter
        End If
        If (e.KeyCode = System.Windows.Forms.Keys.D1) Then
            '1
        End If
        If (e.KeyCode = System.Windows.Forms.Keys.D2) Then
            '2
        End If
        If (e.KeyCode = System.Windows.Forms.Keys.D3) Then
            '3
        End If
        If (e.KeyCode = System.Windows.Forms.Keys.D4) Then
            '4
        End If
        If (e.KeyCode = System.Windows.Forms.Keys.D5) Then
            '5
        End If
        If (e.KeyCode = System.Windows.Forms.Keys.D6) Then
            '6
        End If
        If (e.KeyCode = System.Windows.Forms.Keys.D7) Then
            '7
        End If
        If (e.KeyCode = System.Windows.Forms.Keys.D8) Then
            '8
        End If
        If (e.KeyCode = System.Windows.Forms.Keys.D9) Then
            '9
        End If
        If (e.KeyCode = System.Windows.Forms.Keys.F8) Then
            '*
        End If
        If (e.KeyCode = System.Windows.Forms.Keys.D0) Then
            '0
        End If
        If (e.KeyCode = System.Windows.Forms.Keys.F9) Then
            '#
        End If

    End Sub


    Private Sub Interval_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Interval.TextChanged
        Timer1.Interval = Interval.Text * 1000
    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        Beep()
        beads.Text = beads.Text - 1
        If beads.Text = 0 Then
            Beep()
            Beep()
            Beep()
            Timer1.Enabled = False
        End If
    End Sub
End Class
