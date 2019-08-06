$(document).ready(function () {
    console.log("called");
    $('#categoryDiv').hide();
    $('#divBanner').hide();
    $('#SubmitID').hide();

    $('#BannerTypeID').change(function () {
        var URL = 'home/CategoryList/' + $('#BannerTypeID').val();
        $.getJSON(URL, function (data) {
            var items = '<option value="">Select Category</option>';
            $.each(data, function (i, category) {
                items += "<option value='" + category.Value + "'>" + category.Text + "</option>";
            });
            $('#CategoryID').html(items);
            $('#categoryDiv').show();
        });
    });

    $('#CategoryID').change(function () {
        console.log("calledcategory");
        var category = $('#CategoryID option:selected').text();
        var URL = 'home/GetBanner?category=' + category;

        $.ajax({
            url: URL,
            contentType: 'application/html; charset=utf-8',
            type: 'GET',
            dataType: 'html',
            success: function (result) {
                //console.log(result);

                $('#divBanner').html(result);
                $('#divBanner').show();
            }
        //.error(function (xhr, status) {
        //    alert(status);
        //})
        })
    $('#SubmitID').show();
    });
});