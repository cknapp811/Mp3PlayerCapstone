Public Class Song
    Private mp3Title As String
    Private mp3Dir As String

    Public Property songTitle() As String
        Get
            Return Me.mp3Title
        End Get
        Set(value As String)
            Me.mp3Title = value
        End Set
    End Property

    Public Property songDir() As String
        Get
            Return Me.mp3Dir
        End Get
        Set(value As String)
            Me.mp3Dir = value
        End Set
    End Property

    Public Overrides Function ToString() As String
        Return songTitle & "=" & songDir
    End Function
End Class
