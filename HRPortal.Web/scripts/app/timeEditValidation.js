$(document).ready(function () {
    $('#timeEntryForm')
        .validate({
            rules: {
                'Date': {
                    required: true,
                    date: true
                },
                'HoursWorked': {
                    required: true,
                    number: true,
                    min: 0,
                    max: 16
                }
            },
            messages: {
                'Date': {
                    required: "Enter a date",
                    date: "You must enter a valid date"
                },
                'HoursWorked': {
                    required: "Enter the number of hours worked",
                    number: "You must enter a decimal number",
                    min: "You cannot enter a negative number",
                    max: "You cannot submit more than 16 hours"
                }
            }
        });
})