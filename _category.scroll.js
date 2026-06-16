const scrollContainer = document.querySelector(".category-scroll");
const leftBtn = document.querySelector(".scroll-btn-left");
const rightBtn = document.querySelector(".scroll-btn-right");

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