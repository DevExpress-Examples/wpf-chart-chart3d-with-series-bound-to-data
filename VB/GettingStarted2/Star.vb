Public Class Star
    Dim mHipID As Int32
    Dim mSpectr As String
    Dim mX, mY, mZ, mLuminocity, mColorIndex As Double

    Public ReadOnly Property HipID() As Int32
        Get
            Return mHipID
        End Get
    End Property

    Public ReadOnly Property Spectr() As String
        Get
            Return mSpectr
        End Get
    End Property

    Public ReadOnly Property X() As Double
        Get
            Return mX
        End Get
    End Property

    Public ReadOnly Property Y() As Double
        Get
            Return mY
        End Get
    End Property

    Public ReadOnly Property Z() As Double
        Get
            Return mZ
        End Get
    End Property

    Public ReadOnly Property Luminocity() As Double
        Get
            Return mLuminocity
        End Get
    End Property

    Public ReadOnly Property ColorIndex() As Double
        Get
            Return mColorIndex
        End Get
    End Property

    Public Sub New(
            ByVal id As Int32,
            ByVal x As Double,
            ByVal y As Double,
            ByVal z As Double,
            ByVal spectr As String,
            ByVal luminocity As Double,
            ByVal colorIndex As Double)
        mHipID = id
        mX = x
        mY = y
        mZ = z
        mSpectr = spectr
        mLuminocity = luminocity
        mColorIndex = colorIndex
    End Sub
End Class
