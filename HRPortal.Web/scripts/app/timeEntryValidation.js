$(document).ready(function() {
    $('#timeEntryForm')
        .validate({
            rules: {
                'TimeEntry.Employee.UserId': { required: true },
                'TimeEntry.Date': {
                    required: true,
                    date: true
                },
                'TimeEntry.HoursWorked': {
                    required: true,
                    number: true,
                    min: 0,
                    max: 16
                }
            },
            messages: {
                'TimeEntry.Employee': "Pick an employee",
                'TimeEntry.Date': {
                    required: "Enter a date",
                    date: "You must enter a valid date"
                },
                'TimeEntry.HoursWorked': {
                    required: "Enter the number of hours worked",
                    number: "You must enter a decimal number",
                    min: "You cannot enter a negative number",
                    max: "You cannot submit more than 16 hours"
                }
            }
        });
})