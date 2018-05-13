function () {
    var preload = document.getElementById('my_preloader');
    var loading = 0;
    var id = setInterval(frame, 64);

    function frame() {
        if (loading == 100) {
            clearInterval(id);
            preload.hidden = true;
        }
    }
}