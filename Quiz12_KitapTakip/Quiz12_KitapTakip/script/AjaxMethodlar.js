
function UyeKayit() {

    var ad = document.getElementById('k_txtAd').value;
    var soyad = document.getElementById('k_txtSoyad').value;
    var mail = document.getElementById('k_txtMail').value;
    var user = document.getElementById('k_txtKulAd').value;
    var pass = document.getElementById('k_txtParola').value;
    var pass2 = document.getElementById('k_txtParola2').value;
    if (ad!=""||soyad!=""||mail!=""|user!=""||pass!=""||pass2!="") {
        $.ajax({
            url: 'kayit.aspx/Kayit',
            type: 'POST',
            data: "{ ad: '" + ad + "',soyad: '" + soyad + "',mail:'" + mail + "',user:'" + user + "',pass:'" + pass + "' }",
            success: function (resul) {
                alert("Kayıt Eklendi");

            },
            error: function (error) {

                alert("HATA");
            }
        })
    }
    else {
        alert("Alanlar Boş Geçilemez");
    }

   


}
