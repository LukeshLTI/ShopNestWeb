@ModelType IEnumerable(Of ShopNest.User)
@Code
    ViewData("Title") = "Index"
End Code

<div class="">
    <div class="clearfix"></div>

    <div class="row">
        <div class="col-md-12 col-sm-12 ">
            <div class="x_panel">
                <div class="x_title">
                    <h2>All User</h2>
                    <ul class="nav navbar-right panel_toolbox">
                        <li>
                            <a class="collapse-link"><i class="fa fa-chevron-up"></i></a>
                        </li>
                        <li>
                            @Html.ActionLink("Add User", "Create", "Users", New With {.class = "btn btn-dark"})

                        </li>
                    </ul>
                    <div class="clearfix"></div>
                </div>
                <div class="x_content">
                    <div class="row">
                        <div class="col-sm-12">
                            <div class="card-box table-responsive">

                                <table id="datatable" class="table table-striped table-bordered" style="width:100%">
                                    <thead>
                                        <tr>
                                            <th>Name</th>
                                            <th>Time Zone</th>
                                            <th>Status</th>
                                            <th>Shared Login</th>
                                            <th>Email Id</th>
                                            <th>Mobile Number</th>
                                            <th>Streat</th>
                                            <th>City</th>
                                            <th>Postal Code</th>
                                            <th>Country</th>
                                            <th>manage user</th>
                                        </tr>
                                    </thead>


                                    <tbody>
                                        @For Each item In Model
                                            @<tr>
                                                <td>@item.Name</td>
                                                <td>@item.TimeZone</td>
                                                <td>@item.Status</td>
                                                <td>@item.SharedLogin</td>
                                                <td>@item.Email</td>
                                                <td>@item.MobileNumber</td>
                                                <td>@item.Streat</td>
                                                <td>@item.City</td>
                                                <td>@item.PinCode</td>
                                                <td>@item.Country</td>
                                                <td>
                                                    <a href="/Users/Edit/@item.Id"><i class="fa fa-edit" title="Edit"></i><span class="text-muted"></span></a>   |
                                                    <a href="/Users/Details/@item.Id"><i class="fa fa-info-circle text-info" title="Details"></i></a>   |
                                                    <a href="/Users/Delete/@item.Id"><i class="fa fa-trash text-danger" title="Delete"></i></a>
                                                </td>
                                            </tr>
                                        Next

                                    </tbody>
                                </table>

                            </div>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </div>
</div>