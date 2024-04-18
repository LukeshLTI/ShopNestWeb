@ModelType ShopNest.Product
@Code
    ViewData("Title") = "Details"
End Code

<h2>Product Details</h2>
<hr />
<div class="card">
    <div class="card-body">
        <h2 class="card-title text-center mb-4">@Model.ProductName</h2>
        <ul class="list-group">
            <li class="list-group-item">
                <strong>@Html.DisplayNameFor(Function(model) model.ProductId):</strong> <span class="float-right">@Html.DisplayFor(Function(model) model.ProductId)</span>
            </li>
            <li class="list-group-item">
                <strong>@Html.DisplayNameFor(Function(model) model.Description):</strong> <span class="float-right">@Html.DisplayFor(Function(model) model.Description)</span>
            </li>
            <li class="list-group-item">
                <strong>@Html.DisplayNameFor(Function(model) model.Version):</strong> <span class="float-right">@Html.DisplayFor(Function(model) model.Version)</span>
            </li>
            <li class="list-group-item">
                <strong>@Html.DisplayNameFor(Function(model) model.LaunchDate):</strong> <span class="float-right">@Html.DisplayFor(Function(model) model.LaunchDate)</span>
            </li>
            <li class="list-group-item">
                <strong>@Html.DisplayNameFor(Function(model) model.Category):</strong> <span class="float-right">@Html.DisplayFor(Function(model) model.Category)</span>
            </li>
            <li class="list-group-item">
                <strong>@Html.DisplayNameFor(Function(model) model.Subcategory):</strong> <span class="float-right">@Html.DisplayFor(Function(model) model.Subcategory)</span>
            </li>
            <li class="list-group-item">
                <strong>@Html.DisplayNameFor(Function(model) model.FileName):</strong> <span class="float-right">@Html.DisplayFor(Function(model) model.FileName)</span>
                <br />
                <img src="/Products/Download?p=@Model.ImgID.ToString@Model.Extension&d=@Model.FileName" alt="Product Image" width="25%" height="43%" />
            </li>

        </ul>
    </div>
</div>
<p>
    @Html.ActionLink("Edit", "Edit", New With {.id = Model.Id}, New With {.class = "btn btn-primary"}) |
    @Html.ActionLink("Back to List", "Index", "", New With {.class = "btn btn-primary"})
</p>


   
