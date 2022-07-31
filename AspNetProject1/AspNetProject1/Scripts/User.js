
$(document).ready(function () {
    // call for customers on page load
    $.ajax({

        url: "Admin.aspx/GetAllCustomers",
        method: "post",
        dataType: "json",
        contentType: "application/json",
        async: true,
        success: function (data) {
            data = JSON.parse(data.d)
            console.log(data)
            populateCustomerTable(data)
        }
    });
    // call for products on page load

    $.ajax({

        url: "Admin.aspx/GetAllProducts",
        method: "post",
        dataType: "json",
        contentType: "application/json",
        async: true,
        success: function (data) {
            data = JSON.parse(data.d)
            console.log(data)
            populateProductTable(data)
        }
    })

});




function populateCustomerTable(data) {

    $("#customerTable").dataTable({
        data: data,
        "paging": true,
        "lengthChange": false,
        "searching": true,
        "ordering": true,
        "info": true,
        "autoWidth": true,
        "bDestroy": true,
        columns: [
            { "data": "id" },
            { "data": "fname" },
            { "data": "lname" },
            { "data": "email" },
            
            {'data': null,

                 'defaultContent': '<button id="editBtn" onclick="editCustomerClick()">Edit</button>'
            },
            {
                'data': null,
                'defaultContent': '<button id="deleteBtn" onclick="deleteCustomerClick()">Delete</button>'
            }
        ]
    })
}

function addCustomer() {

    var fname = $("#customerFName").val();
    var lname = $("#customerLName").val();
    var email = $("#customerEmail").val();

    $.ajax({

        url: "Admin.aspx/AddCustomerWeb",
        method: "post",
        dataType: "json",
        contentType: "application/json",
        data:JSON.stringify( { "fname": fname, "lname": lname, "email": email }),
        async: true,
        success: function (data) {
            data = JSON.parse(data.d)
            console.log(data)
          
            populateCustomerTable(data)
        }

    });
    
    alert("Customer Added Successfully")
    return false

}


function populateProductTable(data) {

    $("#productTable").dataTable({
        data: data,
        "bDestroy": true,
        columns: [
            { "data": "id" },
            { "data": "name" },
            { "data": "price" }

        ]
    })
}
function editCustomerClick() {

}