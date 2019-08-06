$(document).ready(function () {
    var URL = 'Home/BannerTypeList/';
    $.getJSON(URL, function (data) {
        var items = '<option value="">Select Banner</option>';
        $.each(data, function (i, bannerType) {
            items += "<option value='" + bannerType.Value + "'>" + bannerType.Text
                + "</option>";
        });
        $('#BannerTypeID').html(items);
    });
});