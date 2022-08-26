var modal = document.getElementById('fullscreen-menu-modal');
var lin = document.getElementById('fullscreen-menu-link');
var close = document.getElementsByClassName('close-fullscreen-menu')[0];

lin.onclick = function () {
    modal.style.display = "block";
};
close.onclick = function () {
    modal.style.display = "none";
};
window.onclick = function (event) {
    if (event.target == modal) {
        modal.style.display = "none";
    }
}