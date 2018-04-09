//Get all Contacts
function GetAllContacts() {
    jQuery.support.cors = true;
    $.ajax({
        url: 'http://localhost:41207/api/Contact',
        type: 'GET',
        dataType: 'json',
        success: function (data) {
            WriteResponsesForAllContacts(data);
        },
        error: function (x, y, z) {
            alert(x + '\n' + y + '\n' + z);
        }
    });

    //Displays in a Table
    function WriteResponsesForAllContacts(Contacts) {
        var strResult = "<table><th>Id</th><th>Name</th><th>Gender</th><th>Age</th><th>Salary</th>";
        $.each(Contacts, function (index, Contact) {
            strResult += "<tr><td>" + Contact.id + "</td><td> " + Contact.FirstName + "</td><td>" + Contact.LastName + "</td><td>" + Contact.Email + "</td><td>" + Contact.PhoneNumber + "</td><td>" + Contact.Status + "</td></tr>";
        });
        strResult += "</table>";
        $("#divDisplayAllContacts").html(strResult);
    }
}



//Adds an Contact to the List
function AddContact() {
    var Contact = {        
        id: $('#txtContactId').val(),
        FirstName: $('#txtFirstName').val(),
        LastName: $('#txtLastName').val(),
        Email: $('#txtEmail').val(),
        PhoneNumber: $('#txtPhoneNumber').val(),
        Status: $('#txtStatus').val()
    };

    $.ajax({
        url: 'http://localhost:41207/api/Contact/',
        type: 'POST',
        data: JSON.stringify(Contact),
        contentType: "application/json;charset=utf-8",
        success: function (data) {
            alert('Contact added Successfully');
            GetAllContacts();
        },
        error: function () {
            alert('Contact not Added');
        }
    });
}


//Updates an Contact to the List
function UpdateContact() {
    var Contact = {
        id: $('#txtContactId').val(),
        FirstName: $('#txtFirstName').val(),
        LastName: $('#txtLastName').val(),
        Email: $('#txtEmail').val(),
        PhoneNumber: $('#txtPhoneNumber').val(),
        Status: $('#txtStatus').val()
    };

    $.ajax({
        url: 'http://localhost:41207/api/Contact/' + $('#txtContactId').val(),
        type: 'PUT',
        data: JSON.stringify(Contact),
        contentType: "application/json;charset=utf-8",
        success: function (data) {
            alert('Contact updated Successfully');
            GetAllContacts();
        },
        error: function () {
            alert('Contact could not be updated');
        }
    });
}


//Delete an Contact from the List
function DeleteContact() {

    jQuery.support.cors = true;
    var id = $('#txtDelContactId').val()

    $.ajax({
        url: 'http://localhost:41207/api/Contact/' + id,
        type: 'DELETE',
        contentType: "application/json;charset=utf-8",
        success: function (data) {
            WriteResponse(data);
        },
        error: function (x, y, z) {
            alert(x + '\n' + y + '\n' + z);
        }
    });
}

function WriteResponse(Contacts) {
    var strResult = "<table><th>Id</th><th>Name</th><th>Gender</th><th>Age</th><th>Salary</th>";
    $.each(Contacts, function (index, Contact) {
        strResult += "<tr><td>" + Contact.id + "</td><td> " + Contact.FirstName + "</td><td>" + Contact.LastName + "</td><td>" + Contact.Email + "</td><td>" + Contact.PhoneNumber + "</td><td>" + Contact.Status + "</td></tr>";
    });
    strResult += "</table>";
    $("#divDisplayAllContacts").html(strResult);
}