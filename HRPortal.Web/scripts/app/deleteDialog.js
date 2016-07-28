$(document).ready(function() {
    $('#deleteDialog')
        .dialog({
            //autoopen: false,
            draggable: false,
            resizable: false,
            modal: true
        });
    $('#deleteButton')
        .click(function() {
            $('#deleteDialog').dialog('open');
            $('#deleteDialog').dialog({
                
            })
        });
})