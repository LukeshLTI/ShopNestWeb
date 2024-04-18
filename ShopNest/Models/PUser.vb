Imports System.ComponentModel.DataAnnotations
Imports System.Data.Entity.Core.Objects.DataClasses

<MetadataType(GetType(UserMetadata))>
Partial Public Class User

End Class

Public Class UserMetadata
    Public Property ID As Integer
    <Required(ErrorMessage:="Name is Required!")>
    Public Property Name As String
    <Required(ErrorMessage:="Time Zone is Required!")>
    Public Property TimeZone As String
    <Required(ErrorMessage:="Status is Required!")>
    Public Property Status As String
    <Required(ErrorMessage:="Shared Login is Required!")>
    Public Property SharedLogin As String
    <Required(ErrorMessage:="Email is Required!")>
    <EmailAddress(ErrorMessage:="Mail id is not Correct!")>
    Public Property Email As String
    <Required(ErrorMessage:="Mobile Number is Required!")>
    <RegularExpression("^[0-9]{10}$", ErrorMessage:="Invalid Mobile Number.")>
    Public Property MobileNumber As String
    <Required(ErrorMessage:="Streat is Required!")>
    Public Property Streat As String
    <Required(ErrorMessage:="City is Required!")>
    Public Property City As String
    <Required(ErrorMessage:="PinCode is Required!")>
    Public Property PinCode As Nullable(Of Integer)
    <Required(ErrorMessage:="Country is Required!")>
    Public Property Country As String

    Public Overridable Property UserRolesMappings As ICollection(Of UserRolesMapping) = New HashSet(Of UserRolesMapping)
End Class
