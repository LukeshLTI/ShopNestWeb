Imports System
Imports System.Collections.Generic
Imports System.Data
Imports System.Data.Entity
Imports System.IO
Imports System.Linq
Imports System.Net
Imports System.Web
Imports System.Web.Mvc
Imports ShopNest

Namespace Controllers
    Public Class ProductsController
        Inherits System.Web.Mvc.Controller

        Private db As New ApplicationDBContext

        ' GET: Products
        Function Index() As ActionResult
            Return View(db.Products.ToList())
        End Function

        ' GET: Products/Details/5
        Function Details(ByVal id As Integer?) As ActionResult
            If IsNothing(id) Then
                Return New HttpStatusCodeResult(HttpStatusCode.BadRequest)
            End If
            Dim product As Product = db.Products.Find(id)
            If IsNothing(product) Then
                Return HttpNotFound()
            End If
            Return View(product)
        End Function

        ' GET: Products/Create
        Function Create() As ActionResult
            Return View()
        End Function

        ' POST: Products/Create
        'To protect from overposting attacks, enable the specific properties you want to bind to, for 
        'more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        <HttpPost()>
        <ValidateAntiForgeryToken()>
        Function Create(ByVal product As Product) As ActionResult
            If ModelState.IsValid Then
                If Request.Files.Count > 0 Then
                    Dim file = Request.Files(0)
                    If file.ContentLength > 0 Then
                        product.FileName = Path.GetFileName(file.FileName)
                        product.Extension = Path.GetExtension(product.FileName)
                        product.ImgID = Guid.NewGuid
                        Dim Fpath = Path.Combine(Server.MapPath("~/App_Data/Upload"), product.ImgID.ToString + product.Extension)
                        file.SaveAs(Fpath)
                    End If
                End If
                db.Products.Add(product)
                db.SaveChanges()
                Return RedirectToAction("Index")
                'Else
                '    ModelState.AddModelError("Description", "Description is required!")
            End If
            Return View(product)
        End Function

        ' GET: Products/Edit/5
        Function Edit(ByVal id As Integer?) As ActionResult
            If IsNothing(id) Then
                Return New HttpStatusCodeResult(HttpStatusCode.BadRequest)
            End If
            Dim product As Product = db.Products.Find(id)
            If IsNothing(product) Then
                Return HttpNotFound()
            End If
            Return View(product)
        End Function

        ' POST: Products/Edit/5
        'To protect from overposting attacks, enable the specific properties you want to bind to, for 
        'more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        <HttpPost()>
        <ValidateAntiForgeryToken()>
        Function Edit(ByVal product As Product) As ActionResult
            If ModelState.IsValid Then
                If Request.Files.Count > 0 Then
                    Dim file = Request.Files(0)
                    If file.ContentLength > 0 Then
                        product.FileName = Path.GetFileName(file.FileName)
                        product.Extension = Path.GetExtension(product.FileName)
                        product.ImgID = Guid.NewGuid
                        Dim Fpath = Path.Combine(Server.MapPath("~/App_Data/Upload"), product.ImgID.ToString + product.Extension)
                        file.SaveAs(Fpath)

                    End If
                Else
                    product.FileName = product.FileName
                    product.Extension = product.Extension
                    product.ImgID = product.ImgID
                End If
                db.Entry(product).State = EntityState.Modified
                    db.SaveChanges()
                    Return RedirectToAction("Index")
                End If
                Return View(product)
        End Function

        ' GET: Products/Delete/5
        Function Delete(ByVal id As Integer?) As ActionResult
            If IsNothing(id) Then
                Return New HttpStatusCodeResult(HttpStatusCode.BadRequest)
            End If
            Dim product As Product = db.Products.Find(id)
            If IsNothing(product) Then
                Return HttpNotFound()
            End If
            Return View(product)
        End Function

        ' POST: Products/Delete/5
        <HttpPost()>
        <ActionName("Delete")>
        <ValidateAntiForgeryToken()>
        Function DeleteConfirmed(ByVal id As Integer) As ActionResult
            Dim product As Product = db.Products.Find(id)
            db.Products.Remove(product)
            db.SaveChanges()
            Return RedirectToAction("Index")
        End Function
        Function Download(ByVal p As String, ByVal d As String) As ActionResult
            If Not IsNothing(p) Then
                If Not IsNothing(d) Then
                    Return File(Path.Combine(Server.MapPath("~/App_Data/Upload/"), p), System.Net.Mime.MediaTypeNames.Application.Octet, d)
                End If
            End If
            Return Content("file is not exist!")
        End Function
        Protected Overrides Sub Dispose(ByVal disposing As Boolean)
            If (disposing) Then
                db.Dispose()
            End If
            MyBase.Dispose(disposing)
        End Sub
    End Class
End Namespace
