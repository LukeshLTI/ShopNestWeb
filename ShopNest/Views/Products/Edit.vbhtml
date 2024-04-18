@ModelType ShopNest.Product
@Code
    ViewData("Title") = "Edit"

    Dim itemList As IEnumerable(Of SelectListItem) = {
      New SelectListItem() With {.Value = "electronics", .Text = "Electronics"},
      New SelectListItem() With {.Value = "clothing", .Text = "Clothing"},
      New SelectListItem() With {.Value = "books", .Text = "Books"},
      New SelectListItem() With {.Value = "home-appliances", .Text = "Home Appliances"},
      New SelectListItem() With {.Value = "sports-outdoors", .Text = "Sports & Outdoors"},
      New SelectListItem() With {.Value = "beauty-health", .Text = "Beauty & Health"},
      New SelectListItem() With {.Value = "toys-games", .Text = "Toys & Games"},
      New SelectListItem() With {.Value = "furniture", .Text = "Furniture"},
      New SelectListItem() With {.Value = "food-drinks", .Text = "Food & Drinks"},
      New SelectListItem() With {.Value = "automotive", .Text = "Automotive"}
      }

End Code


@Using (Html.BeginForm("Edit", "Products", FormMethod.Post, htmlAttributes:=New With {.enctype = "multipart/form-data"}))
    @Html.AntiForgeryToken()
    @<div Class="">
        <div Class="page-title">
            <div Class="title_left">
                <h5>Package Product</h5>
            </div>            
        </div>
        <div Class="clearfix"></div>
        <div Class="row">
            <div Class="col-md-12 col-sm-12 ">
                <div Class="x_panel">
                    <div Class="x_title">
                        <h2>Update a Product</h2>
                        <ul Class="nav navbar-right panel_toolbox">
                            <li>
                                <a Class="collapse-link"><i class="fa fa-chevron-up"></i></a>
                            </li>
                        </ul>
                        <div Class="clearfix"></div>
                    </div>
                    <div Class="x_content">
                        <br />
                        @* @Html.ValidationSummary()*@
                        <form id="demo-form2" data-parsley-validate Class="form-horizontal form-label-left">

                            <div Class="item form-group">
                                <Label Class="col-form-label col-md-3 col-sm-3 label-align" for="ProductName">
                                    Product Name <span Class="required">*</span>
                                </Label>
                                <div Class="col-md-6 col-sm-6 ">
                                    @Html.EditorFor(Function(model) model.ProductName, New With {.htmlAttributes = New With {.class = "form-control"}})
                                    @Html.ValidationMessageFor(Function(model) model.ProductName, "", New With {.class = "text-danger"})
                                </div>
                            </div>
                            <div Class="item form-group">
                                <Label for="middle-name" class="col-form-label col-md-3 col-sm-3 label-align">Category</Label>
                                <div Class="col-md-6 col-sm-6 ">
                                    @Html.DropDownListFor(Function(model) model.Category, itemList, "Select Category", New With {.class = "form-control", .id = "category"})
                                    @Html.ValidationMessageFor(Function(model) model.Category, "", New With {.class = "text-danger"})
                                </div>
                            </div>
                            <div Class="item form-group">
                                <Label for="middle-name" class="col-form-label col-md-3 col-sm-3 label-align">Sub Category</Label>
                                <div Class="col-md-6 col-sm-6 ">
                                    <select name="Subcategory" id="subcategory" Class="form-control" style="display: none;" >
                                        <option value="">Select</option>
                                    </select>

                                </div>
                            </div>
                            <div Class="item form-group">
                                <Label Class="col-form-label col-md-3 col-sm-3 label-align" for="last-name">
                                    Description <span class="required">*</span>
                                </Label>
                                <div Class="col-md-6 col-sm-6 ">
                                    <textarea Class="form-control" rows="3" cols="4" name="Description"></textarea>                                   
                                    @Html.ValidationMessageFor(Function(model) model.Description, "", New With {.class = "text-danger"})
                                </div>
                            </div>
                            <div Class="item form-group">
                                <Label Class="col-form-label col-md-3 col-sm-3 label-align" for="last-name">
                                    Version <span class="required">*</span>
                                </Label>
                                <div Class="col-md-6 col-sm-6 ">
                                    @Html.EditorFor(Function(model) model.Version, New With {.htmlAttributes = New With {.class = "form-control"}})
                                    @Html.ValidationMessageFor(Function(model) model.Version, "", New With {.class = "text-danger"})
                                </div>
                            </div>
                            <div class="item form-group">
                                <label class="col-form-label col-md-3 col-sm-3 label-align">
                                    Launch Date <span class="required">*</span>
                                </label>
                                <div class="col-md-6 col-sm-6 ">
                                    <input class="date-picker form-control" name="LaunchDate" value="" placeholder="dd-mm-yyyy" type="text" required="required" onfocus="this.type='date'" onmouseover="this.type='date'" onclick="this.type='date'" onblur="this.type='text'" onmouseout="timeFunctionLong(this)">
                                    <script>
                                        function timeFunctionLong(input) {
                                            setTimeout(function () {
                                                input.type = 'text';
                                            }, 60000);
                                        }
                                    </script>
                                </div>
                            </div>
                            <div Class="item form-group">
                                <Label Class="col-form-label col-md-3 col-sm-3 label-align" for="last-name">
                                    Price <span class="required">*</span>
                                </Label>
                                <div Class="col-md-6 col-sm-6 ">
                                    @Html.EditorFor(Function(model) model.Price, New With {.htmlAttributes = New With {.class = "form-control"}})
                                    @Html.ValidationMessageFor(Function(model) model.Price, "", New With {.class = "text-danger"})

                                    <div class="btn-group m-3">
                                        <a class="btn" title="Insert picture (or just drag &amp; drop)" id="pictureBtn"><i class="fa fa-picture-o">Add Image</i></a>
                                        <input type="file" name="file" data-role="magic-overlay" data-target="#pictureBtn" data-edit="insertImage" accept=".jpg,.png" title="Choose Image">
                                    </div>
                                </div>
                            </div>

                            <div Class="ln_solid"></div>
                            <div Class="item form-group">
                                <div Class="col-md-6 col-sm-6 offset-md-3">
                                    <a href="/Home/Index" Class="btn btn-primary" type="button">Cancel</a>
                                    <Button Class="btn btn-primary" type="reset">Reset</Button>
                                    <Button type="submit" Class="btn btn-success">Submit</Button>
                                </div>
                            </div>

                        </form>
                    </div>
                </div>
            </div>
        </div>

    </div>

End Using

<script>
    $(document).ready(function () {
        $('#category').change(function () {
            var category = $(this).val();
            $('#subcategory').empty().hide();
            if (category !== '') {
                var subcategories = getSubCategories(category);
                if (subcategories) {
                    $('#subcategory').append(subcategories).show();
                }
            }
        });

        function getSubCategories(category) {
            switch (category) {
                case 'electronics':
                    return `
                    <option value="smartphones">Smartphones</option>
                    <option value="laptops">Laptops</option>
                    <option value="televisions">Televisions</option>
                    <option value="headphones">Headphones</option>
                    <option value="cameras">Cameras</option>`;
                case 'clothing':
                    return `
                    <option value="men">Men</option>
                    <option value="women">Women</option>
                    <option value="kids">Kids</option>
                    <option value="accessories">Accessories</option>
                    <option value="shoes">Shoes</option>`;
                case 'books':
                    return `
                    <option value="fiction">Fiction</option>
                    <option value="non-fiction">Non-fiction</option>
                    <option value="mystery">Mystery</option>
                    <option value="biography">Biography</option>
                    <option value="self-help">Self-help</option>`;
                case 'home-appliances':
                    return `
                    <option value="refrigerators">Refrigerators</option>
                    <option value="washing-machines">Washing Machines</option>
                    <option value="vacuum-cleaners">Vacuum Cleaners</option>
                    <option value="microwaves">Microwaves</option>
                    <option value="air-conditioners">Air Conditioners</option>`;
                case 'sports-outdoors':
                    return `
                    <option value="fitness-equipment">Fitness Equipment</option>
                    <option value="outdoor-clothing">Outdoor Clothing</option>
                    <option value="camping-gear">Camping Gear</option>
                    <option value="biking-accessories">Biking Accessories</option>
                    <option value="hiking-gear">Hiking Gear</option>`;
                case 'beauty-health':
                    return `
                    <option value="skincare">Skincare</option>
                    <option value="haircare">Haircare</option>
                    <option value="makeup">Makeup</option>
                    <option value="personal-care">Personal Care</option>
                    <option value="supplements">Supplements</option>`;
                case 'toys-games':
                    return `
                    <option value="board-games">Board Games</option>
                    <option value="puzzles">Puzzles</option>
                    <option value="action-figures">Action Figures</option>
                    <option value="dolls">Dolls</option>
                    <option value="educational-toys">Educational Toys</option>`;
                case 'furniture':
                    return `
                    <option value="living-room">Living Room</option>
                    <option value="bedroom">Bedroom</option>
                    <option value="kitchen-dining">Kitchen & Dining</option>
                    <option value="office">Office</option>
                    <option value="outdoor">Outdoor</option>`;
                case 'food-drinks':
                    return `
                    <option value="snacks">Snacks</option>
                    <option value="beverages">Beverages</option>
                    <option value="groceries">Groceries</option>
                    <option value="desserts">Desserts</option>
                    <option value="canned-food">Canned Food</option>`;
                case 'automotive':
                    return `
                    <option value="car-parts">Car Parts</option>
                    <option value="car-accessories">Car Accessories</option>
                    <option value="tools">Tools</option>
                    <option value="maintenance">Maintenance</option>
                    <option value="electronics">Electronics</option>`;
                default:
                    return '';
            }
        }
    });
</script>


