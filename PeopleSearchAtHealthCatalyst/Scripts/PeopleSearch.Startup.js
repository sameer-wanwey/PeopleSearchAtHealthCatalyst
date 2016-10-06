$(document).ready(function () {

    $("#txtSearchPerson").attr('maxlength', '25')
    $("#btnSearch").click(function(event){
        Search($("#txtSearchPerson").val().trim(), false);
        return false;
    });

    $("#btnDelayInSearch").click(function (event) {
        Search($("#txtSearchPerson").val().trim(), true);
        return false;
    });
    ShowPeople();
});

function ShowPeople()
{
    AjaxCall('', "/DataService/GetPeople/");
}

function Search(criteria, IsDelay)
{
    if (criteria) {
        if(!IsDelay)
            AjaxCall(criteria, "/DataService/SearchPerson/");
        else
            AjaxCall(criteria, "/DataService/DelayInSearchPerson/");
    }
    else {
        alert("Please enter search criteria.");
    }
    
}

function AjaxCall(searchString, url) {
    $("#imgLoading").removeClass("hidden");
    $.ajax(url,
        {
            type: "POST",
            data: JSON.stringify(
                {
                    name: searchString
                }),
            contentType: "application/json; charset=utf-8",
            dataType: "json",
            success: $.proxy(ProcessResult, this),
            error: $.proxy(HandleError, this)
        });
}

function ProcessResult(data, successCode, request)
{
    ClearResult();
    if (data) {
        if (data.length > 0) {
            for (var i = 0; i < data.length ; i++) {
                InsertRow(data[i]);
            }
        }
        else
            alert("No data found!");
    }
    else {
        alert("No data found!");
    }
    $("#imgLoading").addClass("hidden");
    $('.table > tbody tr:nth-child(even)').addClass('alt');
}

function InsertRow(row)
{
    $("#resultSet").append("<tr><td>" + row["FirstName"] + " " + row["LastName"] + "</td><td>" + row["Age"] + "</td><td>" + row["Address1"] + " " + row["Address2"] + + " " + row["City"] + " " + row["State"] + " " + row["PostalCode"] + "</td><td>" + row["Interests"] + "</td><td><img src='/Content/Images/" + row["Id"]  + ".jpg' /></td></tr>");
}

function ClearResult(){
    $("#resultSet").empty();
}

function HandleError() {
    alert("An error occured.");
    $("#imgLoading").addClass("hidden");
}

jQuery.fn.center = function () {
    this.css("position", "fixed");
    this.css("top", ($(window).height() / 2) - (this.outerHeight() / 2));
    this.css("left", ($(window).width() / 2) - (this.outerWidth() / 2));
    return this;
}

$('#imgLoading').center();
$(window).resize(function () {
    $('#imgLoading').center();
});