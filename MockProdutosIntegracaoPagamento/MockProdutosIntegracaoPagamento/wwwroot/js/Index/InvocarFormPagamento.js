
$(document).ready(function () {

    CarregarViewComprador = function () {

        $.ajax({
            url: "/Home/CarregarFormularioCompra",
            type: 'GET',
            dataType: 'HTML',
            success: function (result) {

                setTimeout(function () {

                    $('#modal-comprar').html(result);


                },
                    0);
            },
            error: function (error) {

                //waitingDialog.hide();
                //Swal.fire({
                //    title: "Falha na Requisi&ccedil&atildeo",
                //    buttonsStyling: false,
                //    confirmButtonClass: "btn",
                //    type: "error",
                //    //html: "<b class='text-danger'>" + error.responseText + "</b>"
                //    html:
                //        "<b class='text-danger'>Erro ao obter informações do Credenciado, solicite suporte para analise da ocorrência!</b>"
                //});

            }
        });

    };


});