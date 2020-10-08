$("#olustur").click(function () {
    var productnamedata = $("#productname").val() // inputların idsini veriable'a atıyoruz.
    var data = {
        "productname": productnamedata, // ajax ile göndereceğimiz datayı tanımlıyoruz ve inputlardan gelen veriye eşitliyoruz.
    }
    //var postData = JSON.stringify({
    //    updatedItems
    //});
    //var valdata = $("#makaleolustur").serialize();
    $.ajax({
        contentType: 'application/json',
        dataType: 'json',
        traditional: true,
        type: "POST",
        url: "/Kategori/KategoriOlustur",
        data: JSON.stringify(data), // veri
        success: function (response) {
            alert('Kategori başarıyla oluşturuldu')
            //setTimeout(function () { location.reload(); }, 2000);
        },
        error: function () {
            alert('Kategori oluşturulamadı')
        }
    });
})