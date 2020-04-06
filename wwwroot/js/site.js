// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.
function GoHome() {
    document.location = "/Home?currency=" + $("#currencySelec").val();
}

function curmenu() {
    $("#currencySelec").val(getCookie('currency'));
}

function OnloadCarro()
{
    $("#currencySelec").hide();
}

function getCookie(name) {
    var value = "; " + document.cookie;
    var parts = value.split("; " + name + "=");
    if (parts.length == 2) return parts.pop().split(";").shift();
}

pageFound = 1;
partial = false;
idproducto = "";
vistapartial = 1;
function CoinChange() {
    if (!partial) {
        if ($("#query").val() == "") {
            document.location = "/Home/Index?page=" + getCookie("page") + "&currency=" + $("#currencySelec").val();
        }
        else
        {
            document.location = "/Home/Index?page=" + getCookie("page") + "&currency=" + $("#currencySelec").val() + '&name=' + $("#query").val();
        }
        partial = false;
        pageFound = 1;
    }
    else {
        if (vistapartial == 1) {
            SearchProd(pageFound);
        }
        else
        {
            Buy(idproducto);
            pageFound = 1;
        }      
    }
}

function Buy(id) {
    cur = $("#currencySelec").val();
    $.ajax(
        {
            url: '/Home/BuyProducts?id=' + id + '&currency=' + cur + '&name=' + $("#query").val(),
            type: 'GET',
            success: function (result) {
                $('#contenedor').html(result);
            }
        });
    idproducto = id;
    partial = true;
    vistapartial = 2;
    $("#currencySelec").val(cur);
}

function Carro() {
    cur = $("#currencySelec").val();
    $.ajax(
        {
            url: '/api/cart',
            type: 'POST',
            data:
            {
                idProduct: $("#prodId").val(),
                quantity: $("#quantity").val(),
                currency: cur
            },
            success: function () {
                document.location = "/Cart";
            }
        });
}

function DeleteCart() {
    $.ajax(
        {
            url: "/api/cart/delete",
            type: "DELETE",
            success: function () {
                location.reload();
            }
        });
}

//tot = 1;
function SearchProd(page, totalPages) {
    if (page == null) {
        page = 1;
    }
    $.ajax(
        {
            url: "/Home/SearchByName?name=" + $('#query').val() + "&currency=" + $("#currencySelec").val() + "&page=" + page,
            type: 'GET',
            success: function (result) {
                $('#contenedor').html(result);
                Controles(page, totalPages);               
            }
        });
    partial = true;
    vistapartial = 1;
    pageFound = page;
}

function Controles(page, totalPages) {
    SetPageToActive(page)
    if (page > 1) {
        $("#prevv").show();
    }
    console.log(totalPages)
    console.log(page)
    if (page == totalPages) {
        $("#nextt").hide();
        console.log(page)
    }
}


function SetPageToActive(id) {
    $('#' + id).addClass("active");
}