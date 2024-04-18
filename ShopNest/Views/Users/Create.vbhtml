@ModelType ShopNest.User
@Code
    ViewData("Title") = "Create"
    Dim itemList As IEnumerable(Of SelectListItem) = {
    New SelectListItem() With {.Value = "active", .Text = "Active"},
    New SelectListItem() With {.Value = "inactive", .Text = "InActive"}
            }
End Code



@Using (Html.BeginForm())
    @Html.AntiForgeryToken()

    @*@<div class="form-horizontal">
            <h4>User</h4>
            <hr />
            @Html.ValidationSummary(True, "", New With {.class = "text-danger"})
            <div class="form-group">
                @Html.LabelFor(Function(model) model.Name, htmlAttributes:=New With {.class = "control-label col-md-2"})
                <div class="col-md-10">
                    @Html.EditorFor(Function(model) model.Name, New With {.htmlAttributes = New With {.class = "form-control"}})
                    @Html.ValidationMessageFor(Function(model) model.Name, "", New With {.class = "text-danger"})
                </div>
            </div>

            <div class="form-group">
                @Html.LabelFor(Function(model) model.TimeZone, htmlAttributes:=New With {.class = "control-label col-md-2"})
                <div class="col-md-10">
                    @Html.EditorFor(Function(model) model.TimeZone, New With {.htmlAttributes = New With {.class = "form-control"}})
                    @Html.ValidationMessageFor(Function(model) model.TimeZone, "", New With {.class = "text-danger"})
                </div>
            </div>

            <div class="form-group">
                @Html.LabelFor(Function(model) model.Status, htmlAttributes:=New With {.class = "control-label col-md-2"})
                <div class="col-md-10">
                    @Html.EditorFor(Function(model) model.Status, New With {.htmlAttributes = New With {.class = "form-control"}})
                    @Html.ValidationMessageFor(Function(model) model.Status, "", New With {.class = "text-danger"})
                </div>
            </div>

            <div class="form-group">
                @Html.LabelFor(Function(model) model.SharedLogin, htmlAttributes:=New With {.class = "control-label col-md-2"})
                <div class="col-md-10">
                    @Html.EditorFor(Function(model) model.SharedLogin, New With {.htmlAttributes = New With {.class = "form-control"}})
                    @Html.ValidationMessageFor(Function(model) model.SharedLogin, "", New With {.class = "text-danger"})
                </div>
            </div>

            <div class="form-group">
                @Html.LabelFor(Function(model) model.Email, htmlAttributes:=New With {.class = "control-label col-md-2"})
                <div class="col-md-10">
                    @Html.EditorFor(Function(model) model.Email, New With {.htmlAttributes = New With {.class = "form-control"}})
                    @Html.ValidationMessageFor(Function(model) model.Email, "", New With {.class = "text-danger"})
                </div>
            </div>

            <div class="form-group">
                @Html.LabelFor(Function(model) model.MobileNumber, htmlAttributes:=New With {.class = "control-label col-md-2"})
                <div class="col-md-10">
                    @Html.EditorFor(Function(model) model.MobileNumber, New With {.htmlAttributes = New With {.class = "form-control"}})
                    @Html.ValidationMessageFor(Function(model) model.MobileNumber, "", New With {.class = "text-danger"})
                </div>
            </div>

            <div class="form-group">
                @Html.LabelFor(Function(model) model.Streat, htmlAttributes:=New With {.class = "control-label col-md-2"})
                <div class="col-md-10">
                    @Html.EditorFor(Function(model) model.Streat, New With {.htmlAttributes = New With {.class = "form-control"}})
                    @Html.ValidationMessageFor(Function(model) model.Streat, "", New With {.class = "text-danger"})
                </div>
            </div>

            <div class="form-group">
                @Html.LabelFor(Function(model) model.City, htmlAttributes:=New With {.class = "control-label col-md-2"})
                <div class="col-md-10">
                    @Html.EditorFor(Function(model) model.City, New With {.htmlAttributes = New With {.class = "form-control"}})
                    @Html.ValidationMessageFor(Function(model) model.City, "", New With {.class = "text-danger"})
                </div>
            </div>

            <div class="form-group">
                @Html.LabelFor(Function(model) model.PinCode, htmlAttributes:=New With {.class = "control-label col-md-2"})
                <div class="col-md-10">
                    @Html.EditorFor(Function(model) model.PinCode, New With {.htmlAttributes = New With {.class = "form-control"}})
                    @Html.ValidationMessageFor(Function(model) model.PinCode, "", New With {.class = "text-danger"})
                </div>
            </div>

            <div class="form-group">
                @Html.LabelFor(Function(model) model.Country, htmlAttributes:=New With {.class = "control-label col-md-2"})
                <div class="col-md-10">
                    @Html.EditorFor(Function(model) model.Country, New With {.htmlAttributes = New With {.class = "form-control"}})
                    @Html.ValidationMessageFor(Function(model) model.Country, "", New With {.class = "text-danger"})
                </div>
            </div>

            <div class="form-group">
                <div class="col-md-offset-2 col-md-10">
                    <input type="submit" value="Create" class="btn btn-default" />
                </div>
            </div>
        </div>*@
    @<div Class="">
        @*<div class="page-title">
                <div Class="title_left">
                    <h3> Form Wizards</h3>
                </div>

                <div Class="title_right">
                    <div Class="col-md-5 col-sm-5  form-group row pull-right top_search">
                        <div Class="input-group">
                            <input type = "text" Class="form-control" placeholder="Search for...">
                            <span Class="input-group-btn">
                                <Button Class="btn btn-secondary" type="button">Go!</button>
                            </span>
                        </div>
                    </div>
                </div>
            </div>*@
        <div Class="clearfix"></div>

        <div Class="row">

            <div Class="col-md-12 col-sm-12 ">
                <div Class="x_panel">
                    <!--<div Class="x_title">
                        <h2> New User</h2>
                        <ul Class="nav navbar-right panel_toolbox">
                            <li>
                                <a Class="collapse-link"><i class="fa fa-chevron-up"></i></a>
                            </li>-->
                            @*<li class="dropdown">
                                    <a href = "#" Class="dropdown-toggle" data-toggle="dropdown" role="button" aria-expanded="false"><i Class="fa fa-wrench"></i></a>
                                    <ul Class="dropdown-menu" role="menu">
                                        <li>
                                                                    <a href = "#" > Settings 1</a>
                                        </li>
                                        <li>
                                                                    <a href = "#" > Settings 2</a>
                                        </li>
                                    </ul>
                                </li>
                                <li>
                                                                    <a Class="close-link"><i class="fa fa-close"></i></a>
                                </li>*@
                        <!--</ul>
                        <div Class="clearfix"></div>
                    </div>-->
                    <div Class="x_content">

                        <h2>Create User</h2>
                        <!-- Tabs -->
                        <div id="wizard_verticle" Class="form_wizard wizard_verticle">
                            <ul Class="list-unstyled wizard_steps">
                                <li>
                                    <a href="#step-11">
                                        <span class="step_no">1</span>
                                    </a>
                                </li>
                                <li>
                                    <a href="#step-22">
                                        <span class="step_no">2</span>
                                    </a>
                                </li>
                               
                            </ul>

                            <div id="step-11">
                                @*<h2 class="StepTitle">Step 1 Content</h2>*@
                                @* <form Class="form-horizontal form-label-left">*@

                                <h2 class="StepTitle">User Info</h2>

                                <div Class="form-group row">
                                    <Label Class="col-form-label col-md-3 col-sm-3 label-align" for="first-name">
                                        Name <span class="required">*</span>
                                    </Label>
                                    <div Class="col-md-6 col-sm-6">
                                        @*<input type="text" id="first-name2" required="required" class="form-control">*@
                                        @Html.EditorFor(Function(model) model.Name, New With {.htmlAttributes = New With {.class = "form-control", .required = "required"}})
                                        @Html.ValidationMessageFor(Function(model) model.Name, "", New With {.class = "text-danger"})
                                    </div>
                                </div>
                                <div Class="form-group row">
                                    <Label Class="col-form-label col-md-3 col-sm-3 label-align" for="last-name">
                                        Time Zone <span Class="required">*</span>
                                    </Label>
                                    <div Class="col-md-6 col-sm-6">
                                        @*<input type="text" id="last-name2" name="last-name" required="required" class="form-control">*@
                                        @Html.EditorFor(Function(model) model.TimeZone, New With {.htmlAttributes = New With {.class = "form-control", .required = "required"}})
                                        @Html.ValidationMessageFor(Function(model) model.TimeZone, "", New With {.class = "text-danger"})
                                    </div>
                                </div>
                                <div Class="form-group row">
                                    <Label for="middle-name" class="col-form-label col-md-3 col-sm-3 label-align">Status <span class="required">*</span></Label>
                                    <div Class="col-md-6 col-sm-6">
                                        @Html.DropDownListFor(Function(model) model.Status, itemList, "Select Category", New With {.class = "form-control", .id = "category"})
                                        @Html.ValidationMessageFor(Function(model) model.Status, "", New With {.class = "text-danger"})
                                    </div>
                                </div>
                                <div Class="form-group row">
                                    <Label Class="col-form-label col-md-3 col-sm-3 label-align">Shared Login <span class="required">*</span></Label>
                                    <div Class="col-md-6 col-sm-6">
                                        <div id="gender2" Class="btn-group" data-toggle="buttons">
                                            <Label Class="btn btn-primary" data-toggle-class="btn-primary" data-toggle-passive-class="btn-secondary">
                                                <input type="radio" name="SharedLogin" value="yes" Class="join-btn"> &nbsp; Yes &nbsp;
                                            </Label>
                                            <Label Class="btn btn-primary" data-toggle-class="btn-primary" data-toggle-passive-class="btn-secondary">
                                                <input type="radio" min="" name="SharedLogin" value="no" Class="join-btn" checked=""> No
                                            </Label>
                                        </div>
                                    </div>
                                </div>
                                <div Class="form-group row">
                                    <Label Class="col-form-label col-md-3 col-sm-3 label-align" for="last-name">
                                        Type of User <span Class="required">*</span>
                                    </Label>
                                    <div Class="col-md-6 col-sm-6">
                                        <select Class="form-control" name="type">
                                            <option value="">Select Type</option>
                                            <option value="customer">Customer</option>
                                            <option value="admin">Admin</option>
                                            <option value="superAdmin">Super Admin</option>
                                        </select>

                                    </div>
                                </div>
                                @*<div class="form-group row">
            <Label Class="col-form-label col-md-3 col-sm-3 label-align">
                Date Of Birth <span class="required">*</span>
            </label>
            <div Class="col-md-6 col-sm-6">
                <input id = "birthday2" Class="date-picker form-control" required="required" type="text">
            </div>
        </div>*@

                                @* </form>*@
                            </div>
                            <div id="step-22">
                                <h2 class="StepTitle">Contact Details</h2>
                                <div Class="form-group row">
                                    <Label Class="col-form-label col-md-3 col-sm-3 label-align" for="first-name">
                                        Email Id <span Class="required">*</span>
                                    </Label>
                                    <div Class="col-md-6 col-sm-6">
                                        @*<input type="text" id="first-name2" required="required" class="form-control">*@
                                        @Html.EditorFor(Function(model) model.Email, New With {.htmlAttributes = New With {.class = "form-control", .required = "required", .type = "email"}})
                                        @Html.ValidationMessageFor(Function(model) model.Email, "", New With {.class = "text-danger"})
                                    </div>
                                </div>
                                <div Class="form-group row">
                                    <Label Class="col-form-label col-md-3 col-sm-3 label-align" for="first-name">
                                        Mobile Number <span Class="required">*</span>
                                    </Label>
                                    <div Class="col-md-6 col-sm-6">
                                        @*<input type="text" id="first-name2" required="required" class="form-control">*@
                                        @Html.EditorFor(Function(model) model.MobileNumber, New With {.htmlAttributes = New With {.class = "form-control", .required = "required", .type = "number"}})
                                        @Html.ValidationMessageFor(Function(model) model.MobileNumber, "", New With {.class = "text-danger"})
                                    </div>
                                </div>
                                <div Class="form-group row">
                                    <Label Class="col-form-label col-md-3 col-sm-3 label-align" for="first-name">
                                        Streat <span class="required">*</span>
                                    </Label>
                                    <div Class="col-md-6 col-sm-6">
                                        @*<input type="text" id="first-name2" required="required" class="form-control">*@
                                        @Html.EditorFor(Function(model) model.Streat, New With {.htmlAttributes = New With {.class = "form-control", .required = "required"}})
                                        @Html.ValidationMessageFor(Function(model) model.Streat, "", New With {.class = "text-danger"})
                                    </div>
                                </div>
                                <div Class="form-group row">
                                    <Label Class="col-form-label col-md-3 col-sm-3 label-align" for="first-name">
                                        City <span class="required">*</span>
                                    </Label>
                                    <div Class="col-md-6 col-sm-6">
                                        @*<input type="text" id="first-name2" required="required" class="form-control">*@
                                        @Html.EditorFor(Function(model) model.City, New With {.htmlAttributes = New With {.class = "form-control", .required = "required"}})
                                        @Html.ValidationMessageFor(Function(model) model.City, "", New With {.class = "text-danger"})
                                    </div>
                                </div>
                                <div Class="form-group row">
                                    <Label Class="col-form-label col-md-3 col-sm-3 label-align" for="first-name">
                                        Postal Code <span Class="required">*</span>
                                    </Label>
                                    <div Class="col-md-6 col-sm-6">
                                        @*<input type="text" id="first-name2" required="required" class="form-control">*@
                                        @Html.EditorFor(Function(model) model.PinCode, New With {.htmlAttributes = New With {.class = "form-control", .required = "required", .type = "number"}})
                                        @Html.ValidationMessageFor(Function(model) model.PinCode, "", New With {.class = "text-danger"})
                                    </div>
                                </div>
                                <div Class="form-group row">
                                    <Label Class="col-form-label col-md-3 col-sm-3 label-align">country</Label>
                                    <div Class="col-md-6 col-sm-6">
                                        <select Class="form-control" name="country">
                                            <option value="">Select a country</option>
                                            <option value="Afghanistan"> Afghanistan</option>
                                            <option value="Åland Islands"> Åland Islands</option>
                                            <option value="Albania"> Albania</option>
                                            <option value="Algeria"> Algeria</option>
                                            <option value="American Samoa"> American Samoa</option>
                                            <option value="Andorra"> Andorra</option>
                                            <option value="Angola"> Angola</option>
                                            <option value="Anguilla"> Anguilla</option>
                                            <option value="Antarctica"> Antarctica</option>
                                            <option value="Antigua and Barbuda"> Antigua And Barbuda</option>
                                            <option value="Argentina"> Argentina</option>
                                            <option value="Armenia"> Armenia</option>
                                            <option value="Aruba"> Aruba</option>
                                            <option value="Australia"> Australia</option>
                                            <option value="Austria"> Austria</option>
                                            <option value="Azerbaijan"> Azerbaijan</option>
                                            <option value="Bahamas"> Bahamas</option>
                                            <option value="Bahrain"> Bahrain</option>
                                            <option value="Bangladesh"> Bangladesh</option>
                                            <option value="Barbados"> Barbados</option>
                                            <option value="Belarus"> Belarus</option>
                                            <option value="Belgium"> Belgium</option>
                                            <option value="Belize"> Belize</option>
                                            <option value="Benin"> Benin</option>
                                            <option value="Bermuda"> Bermuda</option>
                                            <option value="Bhutan"> Bhutan</option>
                                            <option value="Bolivia"> Bolivia</option>
                                            <option value="Bosnia and Herzegovina"> Bosnia And Herzegovina</option>
                                            <option value="Botswana"> Botswana</option>
                                            <option value="Bouvet Island"> Bouvet Island</option>
                                            <option value="Brazil"> Brazil</option>
                                            <option value="British Indian Ocean Territory"> British Indian Ocean Territory</option>
                                            <option value="Brunei Darussalam"> Brunei Darussalam</option>
                                            <option value="Bulgaria"> Bulgaria</option>
                                            <option value="Burkina Faso"> Burkina Faso</option>
                                            <option value="Burundi"> Burundi</option>
                                            <option value="Cambodia"> Cambodia</option>
                                            <option value="Cameroon"> Cameroon</option>
                                            <option value="Canada"> Canada</option>
                                            <option value="Cape Verde"> Cape Verde</option>
                                            <option value="Cayman Islands"> Cayman Islands</option>
                                            <option value="Central African Republic"> Central African Republic</option>
                                            <option value="Chad"> Chad</option>
                                            <option value="Chile"> Chile</option>
                                            <option value="China"> China</option>
                                            <option value="Christmas Island"> Christmas Island</option>
                                            <option value="Cocos (Keeling) Islands"> Cocos(Keeling) Islands</option>
                                            <option value="Colombia"> Colombia</option>
                                            <option value="Comoros"> Comoros</option>
                                            <option value="Congo"> Congo</option>
                                            <option value="Congo, The Democratic Republic of The"> Congo, The Democratic Republic Of The</option>
                                            <option value="Cook Islands"> Cook Islands</option>
                                            <option value="Costa Rica"> Costa Rica</option>
                                            <option value="Cote D'ivoire"> Cote D'ivoire</option>
                                            <option value="Croatia"> Croatia</option>
                                            <option value="Cuba"> Cuba</option>
                                            <option value="Cyprus"> Cyprus</option>
                                            <option value="Czech Republic"> Czech Republic</option>
                                            <option value="Denmark"> Denmark</option>
                                            <option value="Djibouti"> Djibouti</option>
                                            <option value="Dominica"> Dominica</option>
                                            <option value="Dominican Republic"> Dominican Republic</option>
                                            <option value="Ecuador"> Ecuador</option>
                                            <option value="Egypt"> Egypt</option>
                                            <option value="El Salvador"> El Salvador</option>
                                            <option value="Equatorial Guinea"> Equatorial Guinea</option>
                                            <option value="Eritrea"> Eritrea</option>
                                            <option value="Estonia"> Estonia</option>
                                            <option value="Ethiopia"> Ethiopia</option>
                                            <option value="Falkland Islands (Malvinas)"> Falkland Islands (Malvinas)</option>
                                            <option value="Faroe Islands"> Faroe Islands</option>
                                            <option value="Fiji"> Fiji</option>
                                            <option value="Finland"> Finland</option>
                                            <option value="France"> France</option>
                                            <option value="French Guiana"> French Guiana</option>
                                            <option value="French Polynesia"> French Polynesia</option>
                                            <option value="French Southern Territories"> French Southern Territories</option>
                                            <option value="Gabon"> Gabon</option>
                                            <option value="Gambia"> Gambia</option>
                                            <option value="Georgia"> Georgia</option>
                                            <option value="Germany"> Germany</option>
                                            <option value="Ghana"> Ghana</option>
                                            <option value="Gibraltar"> Gibraltar</option>
                                            <option value="Greece"> Greece</option>
                                            <option value="Greenland"> Greenland</option>
                                            <option value="Grenada"> Grenada</option>
                                            <option value="Guadeloupe"> Guadeloupe</option>
                                            <option value="Guam"> Guam</option>
                                            <option value="Guatemala"> Guatemala</option>
                                            <option value="Guernsey"> Guernsey</option>
                                            <option value="Guinea"> Guinea</option>
                                            <option value="Guinea-bissau"> Guinea - bissau</option>
                                            <option value="Guyana"> Guyana</option>
                                            <option value="Haiti"> Haiti</option>
                                            <option value="Heard Island and Mcdonald Islands"> Heard Island And Mcdonald Islands</option>
                                            <option value="Holy See (Vatican City State)"> Holy See (Vatican City State)</option>
                                            <option value="Honduras"> Honduras</option>
                                            <option value="Hong Kong"> Hong Kong</option>
                                            <option value="Hungary"> Hungary</option>
                                            <option value="Iceland"> Iceland</option>
                                            <option value="India"> India</option>
                                            <option value="Indonesia"> Indonesia</option>
                                            <option value="Iran, Islamic Republic of"> Iran, Islamic Republic Of</option>
                                            <option value="Iraq"> Iraq</option>
                                            <option value="Ireland"> Ireland</option>
                                            <option value="Isle of Man"> Isle Of Man</option>
                                            <option value="Israel"> Israel</option>
                                            <option value="Italy"> Italy</option>
                                            <option value="Jamaica"> Jamaica</option>
                                            <option value="Japan"> Japan</option>
                                            <option value="Jersey"> Jersey</option>
                                            <option value="Jordan"> Jordan</option>
                                            <option value="Kazakhstan"> Kazakhstan</option>
                                            <option value="Kenya"> Kenya</option>
                                            <option value="Kiribati"> Kiribati</option>
                                            <option value="Korea, Democratic People's Republic of"> Korea, Democratic People's Republic of</option>
                                            <option value="Korea, Republic of"> Korea, Republic Of</option>
                                            <option value="Kuwait"> Kuwait</option>
                                            <option value="Kyrgyzstan"> Kyrgyzstan</option>
                                            <option value="Lao People's Democratic Republic"> Lao People's Democratic Republic</option>
                                            <option value="Latvia"> Latvia</option>
                                            <option value="Lebanon"> Lebanon</option>
                                            <option value="Lesotho"> Lesotho</option>
                                            <option value="Liberia"> Liberia</option>
                                            <option value="Libyan Arab Jamahiriya"> Libyan Arab Jamahiriya</option>
                                            <option value="Liechtenstein"> Liechtenstein</option>
                                            <option value="Lithuania"> Lithuania</option>
                                            <option value="Luxembourg"> Luxembourg</option>
                                            <option value="Macao"> Macao</option>
                                            <option value="Macedonia, The Former Yugoslav Republic of"> Macedonia, The Former Yugoslav Republic Of</option>
                                            <option value="Madagascar"> Madagascar</option>
                                            <option value="Malawi"> Malawi</option>
                                            <option value="Malaysia"> Malaysia</option>
                                            <option value="Maldives"> Maldives</option>
                                            <option value="Mali"> Mali</option>
                                            <option value="Malta"> Malta</option>
                                            <option value="Marshall Islands"> Marshall Islands</option>
                                            <option value="Martinique"> Martinique</option>
                                            <option value="Mauritania"> Mauritania</option>
                                            <option value="Mauritius"> Mauritius</option>
                                            <option value="Mayotte"> Mayotte</option>
                                            <option value="Mexico"> Mexico</option>
                                            <option value="Micronesia, Federated States of"> Micronesia, Federated States Of</option>
                                            <option value="Moldova, Republic of"> Moldova, Republic Of</option>
                                            <option value="Monaco"> Monaco</option>
                                            <option value="Mongolia"> Mongolia</option>
                                            <option value="Montenegro"> Montenegro</option>
                                            <option value="Montserrat"> Montserrat</option>
                                            <option value="Morocco"> Morocco</option>
                                            <option value="Mozambique"> Mozambique</option>
                                            <option value="Myanmar"> Myanmar</option>
                                            <option value="Namibia"> Namibia</option>
                                            <option value="Nauru"> Nauru</option>
                                            <option value="Nepal"> Nepal</option>
                                            <option value="Netherlands"> Netherlands</option>
                                            <option value="Netherlands Antilles"> Netherlands Antilles</option>
                                            <option value="New Caledonia"> New Caledonia</option>
                                            <option value="New Zealand"> New Zealand</option>
                                            <option value="Nicaragua"> Nicaragua</option>
                                            <option value="Niger"> Niger</option>
                                            <option value="Nigeria"> Nigeria</option>
                                            <option value="Niue"> Niue</option>
                                            <option value="Norfolk Island"> Norfolk Island</option>
                                            <option value="Northern Mariana Islands"> Northern Mariana Islands</option>
                                            <option value="Norway"> Norway</option>
                                            <option value="Oman"> Oman</option>
                                            <option value="Pakistan"> Pakistan</option>
                                            <option value="Palau"> Palau</option>
                                            <option value="Palestinian Territory, Occupied"> Palestinian Territory, Occupied</option>
                                            <option value="Panama"> Panama</option>
                                            <option value="Papua New Guinea"> Papua New Guinea</option>
                                            <option value="Paraguay"> Paraguay</option>
                                            <option value="Peru"> Peru</option>
                                            <option value="Philippines"> Philippines</option>
                                            <option value="Pitcairn"> Pitcairn</option>
                                            <option value="Poland"> Poland</option>
                                            <option value="Portugal"> Portugal</option>
                                            <option value="Puerto Rico"> Puerto Rico</option>
                                            <option value="Qatar"> Qatar</option>
                                            <option value="Reunion"> Reunion</option>
                                            <option value="Romania"> Romania</option>
                                            <option value="Russian Federation"> Russian Federation</option>
                                            <option value="Rwanda"> Rwanda</option>
                                            <option value="Saint Helena"> Saint Helena</option>
                                            <option value="Saint Kitts and Nevis"> Saint Kitts And Nevis</option>
                                            <option value="Saint Lucia"> Saint Lucia</option>
                                            <option value="Saint Pierre and Miquelon"> Saint Pierre And Miquelon</option>
                                            <option value="Saint Vincent and The Grenadines"> Saint Vincent And The Grenadines</option>
                                            <option value="Samoa"> Samoa</option>
                                            <option value="San Marino"> San Marino</option>
                                            <option value="Sao Tome and Principe"> Sao Tome And Principe</option>
                                            <option value="Saudi Arabia"> Saudi Arabia</option>
                                            <option value="Senegal"> Senegal</option>
                                            <option value="Serbia"> Serbia</option>
                                            <option value="Seychelles"> Seychelles</option>
                                            <option value="Sierra Leone"> Sierra Leone</option>
                                            <option value="Singapore"> Singapore</option>
                                            <option value="Slovakia"> Slovakia</option>
                                            <option value="Slovenia"> Slovenia</option>
                                            <option value="Solomon Islands"> Solomon Islands</option>
                                            <option value="Somalia"> Somalia</option>
                                            <option value="South Africa"> South Africa</option>
                                            <option value="South Georgia and The South Sandwich Islands"> South Georgia And The South Sandwich Islands</option>
                                            <option value="Spain"> Spain</option>
                                            <option value="Sri Lanka"> Sri Lanka</option>
                                            <option value="Sudan"> Sudan</option>
                                            <option value="Suriname"> Suriname</option>
                                            <option value="Svalbard and Jan Mayen"> Svalbard And Jan Mayen</option>
                                            <option value="Swaziland"> Swaziland</option>
                                            <option value="Sweden"> Sweden</option>
                                            <option value="Switzerland"> Switzerland</option>
                                            <option value="Syrian Arab Republic"> Syrian Arab Republic</option>
                                            <option value="Taiwan"> Taiwan</option>
                                            <option value="Tajikistan"> Tajikistan</option>
                                            <option value="Tanzania, United Republic of"> Tanzania, United Republic Of</option>
                                            <option value="Thailand"> Thailand</option>
                                            <option value="Timor-leste"> Timor - leste</option>
                                            <option value="Togo"> Togo</option>
                                            <option value="Tokelau"> Tokelau</option>
                                            <option value="Tonga"> Tonga</option>
                                            <option value="Trinidad and Tobago"> Trinidad And Tobago</option>
                                            <option value="Tunisia"> Tunisia</option>
                                            <option value="Turkey"> Turkey</option>
                                            <option value="Turkmenistan"> Turkmenistan</option>
                                            <option value="Turks and Caicos Islands"> Turks And Caicos Islands</option>
                                            <option value="Tuvalu"> Tuvalu</option>
                                            <option value="Uganda"> Uganda</option>
                                            <option value="Ukraine"> Ukraine</option>
                                            <option value="United Arab Emirates"> United Arab Emirates</option>
                                            <option value="United Kingdom"> United Kingdom</option>
                                            <option value="United States"> United States</option>
                                            <option value="United States Minor Outlying Islands"> United States Minor Outlying Islands</option>
                                            <option value="Uruguay"> Uruguay</option>
                                            <option value="Uzbekistan"> Uzbekistan</option>
                                            <option value="Vanuatu"> Vanuatu</option>
                                            <option value="Venezuela"> Venezuela</option>
                                            <option value="Viet Nam"> Viet Nam</option>
                                            <option value="Virgin Islands, British"> Virgin Islands, British</option>
                                            <option value="Virgin Islands, U.S."> Virgin Islands, U.S.</option>
                                            <option value="Wallis and Futuna"> Wallis And Futuna</option>
                                            <option value="Western Sahara"> Western Sahara</option>
                                            <option value="Yemen"> Yemen</option>
                                            <option value="Zambia"> Zambia</option>
                                            <option value="Zimbabwe"> Zimbabwe</option>
                                        </select>
                                    </div>
                                </div>
                            </div>

                        </div>
                        <!-- End SmartWizard Content -->
                    </div>
                </div>
            </div>
        </div>
    </div>  End Using


@*<div>
        @Html.ActionLink("Back to List", "Index")
    </div>*@
