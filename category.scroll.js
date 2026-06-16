const scrollContainer = document.querySelector(".category-scroll");
const leftBtn = document.querySelector(".scroll-btn-left");
const rightBtn = document.querySelector(".scroll-btn-right");

// Button scroll
if (rightBtn) {
    rightBtn.addEventListener("click", () => {
        scrollContainer.scrollBy({ left: 220, behavior: "smooth" });
    });
}

if (leftBtn) {
    leftBtn.addEventListener("click", () => {
        scrollContainer.scrollBy({ left: -220, behavior: "smooth" });
    });
}

// 👉 Mouse drag scroll (desktop)
let isDown = false;
let startX;
let scrollLeft;

scrollContainer.addEventListener("mousedown", (e) => {
    isDown = true;
    scrollContainer.classList.add("active");
    startX = e.pageX - scrollContainer.offsetLeft;
    scrollLeft = scrollContainer.scrollLeft;
});

scrollContainer.addEventListener("mouseleave", () => {
    isDown = false;
});

scrollContainer.addEventListener("mouseup", () => {
    isDown = false;
});

scrollContainer.addEventListener("mousemove", (e) => {
    if (!isDown) return;
    e.preventDefault();
    const x = e.pageX - scrollContainer.offsetLeft;
    const walk = (x - startX) * 2;
    scrollContainer.scrollLeft = scrollLeft - walk;
});