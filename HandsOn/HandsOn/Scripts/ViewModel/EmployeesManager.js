var Module = (function () {

    var getEmployees = function () {

        $.ajax({
            URL: "/api/EmployeeAPI/GetEmployees",
            type: "GET",
            dataType: "json",
            contentType: "application/json; charset=utf-8",
            success: function(data) {
                
            }
        });
    };


    $("#getEmployees").click(function() {
        getEmployees();
    });


})();