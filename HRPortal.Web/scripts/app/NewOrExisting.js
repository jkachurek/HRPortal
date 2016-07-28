$(document)
    .ready(
    function () {
        $('#newItem').hide();
        $('#existingItem').hide();
        $('#newRadio')
            .click(function () {
                $('#newItem').show();
                $('#existingItem').hide();
            });
        $('#existingRadio')
            .click(function () {
                $('#existingItem').show();
                $('#newItem').hide();
            });
    })