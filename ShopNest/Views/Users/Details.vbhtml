@ModelType ShopNest.User
@Code
    ViewData("Title") = "Details"
End Code

<h2>Details</h2>

<div>
    <h4>User</h4>
    <hr />
    <dl class="dl-horizontal">
        <dt>
            @Html.DisplayNameFor(Function(model) model.Name)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.Name)
        </dd>

        <dt>
            @Html.DisplayNameFor(Function(model) model.TimeZone)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.TimeZone)
        </dd>

        <dt>
            @Html.DisplayNameFor(Function(model) model.Status)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.Status)
        </dd>

        <dt>
            @Html.DisplayNameFor(Function(model) model.SharedLogin)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.SharedLogin)
        </dd>

        <dt>
            @Html.DisplayNameFor(Function(model) model.Email)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.Email)
        </dd>

        <dt>
            @Html.DisplayNameFor(Function(model) model.MobileNumber)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.MobileNumber)
        </dd>

        <dt>
            @Html.DisplayNameFor(Function(model) model.Streat)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.Streat)
        </dd>

        <dt>
            @Html.DisplayNameFor(Function(model) model.City)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.City)
        </dd>

        <dt>
            @Html.DisplayNameFor(Function(model) model.PinCode)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.PinCode)
        </dd>

        <dt>
            @Html.DisplayNameFor(Function(model) model.Country)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.Country)
        </dd>

    </dl>
</div>
<p>
    @Html.ActionLink("Edit", "Edit", New With { .id = Model.ID }) |
    @Html.ActionLink("Back to List", "Index")
</p>
