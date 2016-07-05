$(document).ajaxComplete(function (response,re) {
            if (re.responseJSON.unAuthorized) {
                location.href = "/login";
            } else {
                alert("Authorized");
            }
        });
        (function () {
            $(function() {
                $.ajax({
                    url: 'sample/req1',
                    type: 'post',
                    dataType: 'json'
                }).done(function (response) {
                });
            });
        }());