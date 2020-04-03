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

partial = false;
idproducto = "";
function CoinChange() {
    if (!partial) {
        document.location = "/Home/Index?page=" + getCookie("page") + "&currency=" + $("#currencySelec").val() + '&name=' + $("#query").val();
        partial = false;
    }
    else {
        Buy(idproducto);
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

function SearchProd(page) {
    if (page == null) {
        page = 1;
    }
    $.ajax(
        {
            url: "/Home/SearchByName?name=" + $('#query').val() + "&currency=" + $("#currencySelec").val() + "&page=" + page,
            type: 'GET',
            success: function (result) {
                $('#contenedor').html(result);
            }
        });
}
