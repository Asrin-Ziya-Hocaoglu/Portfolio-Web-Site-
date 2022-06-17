$(document).ready(function() {
        $("#btnSend").click(function () {
            SaveinDatabase("Default/SendMessage/");
        });

        function SaveinDatabase(path) {
            var Name = $("#name").val();
            var Email = $("#email").val();
            var Subject = $("#subject").val();
            var Message = $("#message").val();
            var parameters = {Name: Name, Mail: Email, Subject: Subject, Content: Message };
            $.ajax({
                type: 'POST',
                dataType: 'JSON',
                contentType: 'application/json',
                data: JSON.stringify(parameters),
                url: "",
                success: function(response) {
                    if (response.success == true) {
                        toastr.success(response.message, 'Your message has been sent succesfully', { timeOut: 300 });
                    } else {
                        toastr.info(response.message, 'Information', { timeOut: 300 });

                    }

                },
                error: function() {
                    toastr.error("You have a big mistake", 'Warning', { timeOut: 300 });
                }
            });
        }


    })