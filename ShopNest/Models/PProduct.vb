Imports System.ComponentModel.DataAnnotations

<MetadataType(GetType(ProductMetadata))>
Partial Public Class Product

End Class
Public Class ProductMetadata
    Public Property Id As Integer
    Public Property ProductId As String
    <Required(ErrorMessage:="Product Name Is Required!")>
    Public Property ProductName As String
    <Required(ErrorMessage:="Description Is Required!")>
    Public Property Description As String
    <Required(ErrorMessage:="Category Is Required!")>
    Public Property Category As String
    <Required(ErrorMessage:="Subcategory Is Required!")>
    Public Property Subcategory As String
    <Required(ErrorMessage:="Version Is Required!")>
    Public Property Version As String
    <Required(ErrorMessage:="Launch Date Is Required!")>
    Public Property LaunchDate As Nullable(Of Date)
    <Required(ErrorMessage:="Price Is Required!")>
    Public Property Price As Nullable(Of Decimal)
    Public Property ImgID As Nullable(Of System.Guid)
    Public Property Extension As String
    Public Property FileName As String
End Class