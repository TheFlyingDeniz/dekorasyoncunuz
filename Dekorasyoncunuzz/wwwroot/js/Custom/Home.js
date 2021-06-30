$(document).ready(function () {

    $("#Hepsi").click(function () {
        $('input:checkbox').not(this).prop('checked', this.checked);
    });

    $(".nav-link").removeClass("active");
    $("#home_tab").addClass("active");

    $("form").submit(function () {
        if ($("input:checkbox[class='checkcins']").filter(':checked').length < 1) {
            Swal.fire("Eksik dekorasyon!", "Lütfen en az bir tane dekorasyon türü giriniz!", "error");
            return false;
        }
        else if ($("input:checkbox[class='checkmarka']").filter(':checked').length < 1) {
            Swal.fire("Eksik marka!", "Lütfen en az bir tane marka giriniz!", "error");
            return false;
        }
    });

});

var HomePage = (function ()  {

    function priceLabelText(param) {
        $("#price_text").text(param + "₺");
    }

    return {
        priceLabelText: priceLabelText
    };

})();