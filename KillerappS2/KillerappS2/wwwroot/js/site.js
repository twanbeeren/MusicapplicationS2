$(function SearchWiki() {
    $("#search").on("click", function () {
        var searchinput = $("#searchinput").val();
        var url = "https://en.wikipedia.org/w/api.php?action=opensearch&search=" + searchinput + "&format=json&callback=?";
        $.ajax({
            url: url,
            type: 'GET',
            contentType: "application/json; charset=utf-8",
            async: false,
            dataType: "json",
            success: function (data, status, jqXHR) {
                alert("<p>" + data[2][0] + "</p>");
            }
        })
            .done(function () {
                console.log("success");
            })
            .fail(function () {
                console.log("error");
            })
            .always(function () {
                console.log("complete");
            });
    });
});
