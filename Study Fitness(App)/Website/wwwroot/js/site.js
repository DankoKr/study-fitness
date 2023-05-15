document.getElementById("closePopup").addEventListener("click", function () {
    document.getElementById("popup").classList.remove("show");
});

function sortByWeight() {
    window.location.href = "?sort=weight";
}

function sortByName() {
    window.location.href = "?sort=name";
}

function sortByReps() {
    window.location.href = "?sort=reps";
}

