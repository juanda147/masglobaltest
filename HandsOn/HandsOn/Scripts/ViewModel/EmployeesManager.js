var Module = (function () {

    var result = ko.observableArray([]);

    var getEmployees = function () {

        var employeeId = $("#employeeID").val() === "" ? 0 : $("#employeeID").val();

        if (isNaN(employeeId) || employeeId < 0) {
            result([]);
            return false;
        }

        $.ajax({
            url: "/api/EmployeeAPI/GetAllEmployee?employeeId=" + employeeId,
            type: "GET",
            dataType: "json",
            contentType: "application/json; charset=utf-8",
            success: function (data) {
                result(data);
            }
        });
    };


    $("#getEmployees").click(function () {
        getEmployees();
    });

    ko.applyBindings({ gridEmployeesData: result });

})();