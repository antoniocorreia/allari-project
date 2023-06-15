
function showClock() {
    var date = new Date();
    var h = date.getHours(); 
    var m = date.getMinutes(); 
    var s = date.getSeconds(); 
    
    if (h == 0) {
        h = 12;
    }

    h = (h < 10) ? "0" + h : h;
    m = (m < 10) ? "0" + m : m;
    s = (s < 10) ? "0" + s : s;

    var time = h + ":" + m + ":" + s;
    document.getElementById("digital-clock").innerText = time;
    document.getElementById("digital-clock").textContent = time;

    setTimeout(showClock, 1000);
}

showClock();


onmousemove = function(e) {
    var posX = e.clientX;
    var posY = e.clientY;

    document.getElementById("mouse-x").innerText = posX;
    document.getElementById("mouse-x").textContent = posX;

    document.getElementById("mouse-y").innerText = posY;
    document.getElementById("mouse-y").textContent = posY;

}
