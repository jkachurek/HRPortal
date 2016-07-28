$(document).ready(function() {
    $('#applicationForm')
        .validate({
            rules: {
                'Application.Applicant.FirstName': {
                    required: '#newRadio:checked'
                },
                'Application.Applicant.LastName': {
                    required: '#newRadio:checked'
                },
                'Application.Applicant.Address.StreetAddress': {
                    required: '#newRadio:checked'
                },
                'Application.Applicant.Address.City': {
                    required: '#newRadio:checked'
                },
                'Application.Applicant.Address.State': {
                    required: '#newRadio:checked'
                },
                'Application.Applicant.Address.ZipCode': {
                    required: '#newRadio:checked',
                    digits: true,
                    minlength: 5,
                    maxlength: 5
                },
                'Application.Applicant.Phone': {
                    required: '#newRadio:checked',
                    phoneUS: true
                },
                'Application.Applicant.Email': {
                    required: '#newRadio:checked',
                    email: true
                },
                'Application.Applicant': {
                    required: '#existingRadio:checked'
                },
                'Application.Job': {
                    required: true
                },
                'Application.CoverLetter': {
                    required: true // TODO: add length requirements for cover letter
                },
                'Application.Resume': {
                    required: true
                }
            },
            messages: {
                'Application.Applicant.FirstName': "Enter your First Name",
                'Application.Applicant.LastName': "Enter your Last Name",
                'Application.Applicant.Address.StreetAddress': "Enter your Street Address",
                'Application.Applicant.Address.City': "Enter your City",
                'Application.Applicant.Address.State': "Enter your State",
                'Application.Applicant.Address.ZipCode': {
                    required: "Enter your Zip Code",
                    digits: "Please enter a valid number",
                    minlength: "Please enter a 5-digit Zip Code",
                    maxlength: "Please enter a 5-digit Zip Code"
                },
                'Application.Applicant.Phone': {
                    required: "Enter your phone number",
                    phoneUS: "Please enter a valid phone number"
                },
                'Application.Applicant.Email': {
                    required: "Enter your Email Address",
                    email: "Please enter a valid email address"
                },
                'Application.Applicant': "Please choose a user from the menu, or select \"New User\" above.",
                'Application.Job': "Choose a job from the menu",
                'Application.CoverLetter': "Enter a cover letter",
                'Application.Resume': "Enter the details of your resume"
            }
        });
})