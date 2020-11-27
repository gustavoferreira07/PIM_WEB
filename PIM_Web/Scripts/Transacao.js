window.onload = function () {
    var todaydate = new Date();
    var day = todaydate.getDate();
    var month = todaydate.getMonth() + 1;
    var year = todaydate.getFullYear();
    var datestring = day + "/" + month + "/" + year;
    document.getElementById("DataTransacao").value = datestring;
}