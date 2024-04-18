@ModelType IEnumerable(Of ShopNest.Product)
@Code
    ViewData("Title") = "Index"
End Code


<div class="">
    <div class="clearfix"></div>

    <div class="row">
        <div class="col-md-12 col-sm-12 ">
            <div class="x_panel">
                <div class="x_title">
                    <h2>Products</h2>
                    <ul class="nav navbar-right panel_toolbox">
                        <li>
                            <a class="collapse-link"><i class="fa fa-chevron-up"></i></a>
                        </li>
                        <li>
                            @Html.ActionLink("Add Product", "Create", "Products", New With {.class = "btn btn-dark"})

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
                                            <th>Product Name</th>
                                            <th>Category</th>
                                            <th>Subcategory</th>
                                            <th>Price</th>
                                            <th>File Name</th>
                                            <th>Action</th>
                                        </tr>
                                    </thead>


                                    <tbody>
                                        @For Each item In Model
                                            @<tr>
                                                <td>@item.ProductName</td>
                                                <td>@item.Category</td>
                                                <td>@item.Subcategory</td>
                                                <td>@item.Price</td>
                                                <td>@item.FileName</td>
                                                <td>
                                                    <a href="/Products/Edit/@item.Id"><i class="fa fa-edit" title="Edit"></i><span class="text-muted"></span></a>   |
                                                    <a href="/Products/Details/@item.Id"><i class="fa fa-info-circle text-info" title="Details"></i></a>   |
                                                    <a href="/Products/Delete/@item.Id"><i class="fa fa-trash text-danger" title="Delete"></i></a>
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
