let toggle = document.getElementById("toggle")
let sidebar = document.getElementById("sidebar")
let content = document.getElementById("content")

toggle.onclick = function () {

    sidebar.classList.toggle("active")
    content.classList.toggle("shift")

}