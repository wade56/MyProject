Public Class MyUserControl

   Inherits UserControl

   Public Shared ReadOnly TextProperty As DependencyProperty =
        DependencyProperty.Register("Text", GetType(String), GetType(MyUserControl))

   Public Property Text As String
      Get
         Return CStr(GetValue(TextProperty))
      End Get
      Set(value As String)
         SetValue(TextProperty, value)
      End Set
   End Property

End Class
