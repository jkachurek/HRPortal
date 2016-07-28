$(document).ready(function() {
    $('#policyForm')
        .validate({
            rules: {
                'Policy.Name': { required: true },
                'Policy.Category.Name': { required: '#newRadio:checked' },
                'Policy.Category.CategoryId': { required: '#existingRadio:checked' },
                'Policy.Content': { required: true }
            },
            messages: {
                'Policy.Name': "Enter a name for your new policy",
                'Policy.Category.Name': "Enter a name for the new category",
                'Policy.Category.CategoryId': "Choose a category from the menu, or select \"New Category\" above",
                'Policy.Content': "Enter the details of your new policy"
            }
        });
})