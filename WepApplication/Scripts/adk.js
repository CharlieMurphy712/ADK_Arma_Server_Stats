$(document).ready(function () {

    $('.datatable').dataTable({ responsive: true, order: [1, "desc"] });
    //$('.datatable').dataTable({ responsive: true });

});

$(document).ready(function () {
    $('[data-toggle="popover"]').popover();
});