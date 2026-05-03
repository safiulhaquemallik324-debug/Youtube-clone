const scrollContainer = document.querySelector(".category-scroll");
const leftBtn = document.querySelector(".left");
const rightBtn = document.querySelector(".right");

rightBtn.addEventListener("click", () => {
    scrollContainer.scrollBy({
        left: 200,
        behavior: "smooth"
    });
});

leftBtn.addEventListener("click", () => {
    scrollContainer.scrollBy({
        left: -200,
        behavior: "smooth"
    });
});