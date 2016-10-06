angularApp.factory('PSAservice',
    function () {
        return {
            Person: {
                Id:1,
                FirstName: "Sameer",
                LastName: "Wanwey",
                Age: 32,
                Interest: "Cricket, Football",
                Address1: "2240 west 3800 south",
                Address2: "Crossword apartments",
                City: "West Valle City",
                State:"Utah",
                PostalCode:"44119"
            }
        }
    });
$(document).ready(function () {

    //$("#txtSearchPerson").attr('maxlength', '25')

    //$("#btnSearch").click(function(event){
    //    //Search($("#txtSearchPerson").val().trim(), false);
    //    return false;
    //});

    //$("#btnDelayInSearch").click(function (event) {
    //    //Search($("#txtSearchPerson").val().trim(), true);
    //    return false;
    //});
    //ShowPeople();
});
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