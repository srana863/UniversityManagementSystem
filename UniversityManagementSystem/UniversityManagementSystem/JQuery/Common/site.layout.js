$(document)
    .ajaxStart(function () { showGlobalLoader(); })
    .ajaxStop(function () { hideGlobalLoader(); });

$('.decimal').on('keyup', function (e) {
    var ex = /^[0-9]+\.?[0-9]*$/;
    if (ex.test(this.value) == false) {
        this.value = this.value.substring(0, this.value.length - 1);
    }

});
$('.number').on('keyup', function (e) {
    var ex = /^[0-9]*$/;
    if (ex.test(this.value) == false) {
        this.value = this.value.substring(0, this.value.length - 1);
    }
});

$('.datepicker-not-allow-futuredate').prop('readonly', true);
$('.datepicker-not-allow-futuredate').datepicker({
    format: 'mm/dd/yyyy',
    autoclose: true,
    todayBtn: 'linked',
    todayHightlight: true,
    endDate: "current"
});

$('.datepicker-allow-futuredate').prop('readonly', true);
$('.datepicker-allow-futuredate').datepicker({
    format: 'mm/dd/yyyy',
    autoclose: true,
    todayBtn: 'linked',
    todayHightlight: true
});


$('.readonly-input').prop('readonly', true);
$('.disabled-input').prop('disabled', true);

$(function () {
    $(".select2").select2();
     $("[data-mask]").inputmask();
    //$('.datepicker').prop('readonly', true);
    $('.datepicker').datepicker({
        format: 'mm/dd/yyyy',
        autoclose: true,
        todayBtn: 'linked',
        todayHightlight: true
    });
    var today = new Date();
    today.setDate(today.getDate());

    $(".timepicker").timepicker({
        showInputs: true
    });

    //iCheck for checkbox and radio inputs
    $('input[type="checkbox"].minimal, input[type="radio"].minimal').iCheck({
        checkboxClass: 'icheckbox_minimal-blue',
        radioClass: 'iradio_minimal-blue'
    });
    //Red color scheme for iCheck
    $('input[type="checkbox"].minimal-red, input[type="radio"].minimal-red').iCheck({
        checkboxClass: 'icheckbox_minimal-red',
        radioClass: 'iradio_minimal-red'
    });
    //Flat red color scheme for iCheck
    $('input[type="checkbox"].flat-red, input[type="radio"].flat-red').iCheck({
        checkboxClass: 'icheckbox_flat-green',
        radioClass: 'iradio_flat-green'
    });
});


function searchEmployee(controlId,nextCallFunction) {
    $('#SearchEmployeeName').modal("show");
    loadSearchEmployee(controlId, nextCallFunction);
}

function loadSearchEmployee(controlId, nextCallFunction) {
    var url = '/Common/EmployeeSearch';
    $('#Div-EmployeeList').empty().load(url);
    $('#SearchEmployeeName #nextId').val(controlId);
    $('#SearchEmployeeName #nextMethod').val(nextCallFunction);
}
