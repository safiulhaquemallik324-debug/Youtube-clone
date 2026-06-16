let toggle = document.getElementById("toggle");
let sidebar = document.getElementById("sidebar");
let content = document.getElementById("content");

toggle.onclick = function () {
    sidebar.classList.toggle("active");
    content.classList.toggle("shift");
};

// Close sidebar when clicking outside
document.addEventListener("click", function (e) {
    if (
        sidebar.classList.contains("active") &&
        !sidebar.contains(e.target) &&
        !toggle.contains(e.target)
    ) {
        sidebar.classList.remove("active");
        content.classList.remove("shift");
    }
});