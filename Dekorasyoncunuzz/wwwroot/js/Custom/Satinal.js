$(document).ready(function () {
    $(".nav-link").removeClass("active");
    $("#decoration_tab").addClass("active");
});

function validateForm() {
    let x = document.forms["myForm"]["hesapno"].value;
    if (x.length != 16) {
        Swal.fire("Üzgünüz!", "Lütfen geçerli bir hesap numarası giriniz!", "error");
        return false;
    }
    else {
        Swal.fire("Tebrikler!", "Satın alımınız gerçekleşti!", "success");
    }
}