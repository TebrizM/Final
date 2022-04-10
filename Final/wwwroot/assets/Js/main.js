$(".one-time").slick({
    dots: false,
    infinite: true,
    speed: 300,
    slidesToShow: 1,
    adaptiveHeight: true,
    arrows: true,
    autoplay: true,
    autoplaySpeed: 1500,
    pauseOnHover: true,
    prevArrow: $(".prev-arrow"),
    nextArrow: $(".next-arrow"),
});

//Accordion
$(function () {
    let x = true;
    $(document).on("click", ".accordion-header", function () {
        if (x) {
            x = false;
            if ($(".actives")[0] != $(this).next()[0]) {
                $(".actives").slideUp(300, function () {
                    $(this).removeClass("actives");
                });
                $(this)
                    .next()
                    .slideDown(300, function () {
                        $(this).addClass("actives");
                        x = true;
                    });
            } else {
                $(".actives").slideUp(300, function () {
                    $(this).removeClass("actives");
                    x = true;
                });
            }
        }
    });
});

//My PlaylisT

const music = new Audio("./assets/media/music/Gojira - Global Warming.mp3");


let masterPlay = document.getElementById("masterPlay");
let wave = document.getElementsByClassName("wave")[0];

masterPlay.addEventListener("click", () => {
    console.log(music.paused);

    console.log("test");
    if (music.paused) {
        music.play();
        masterPlay.classList.remove("bi-play-fill");
        masterPlay.classList.add("bi-pause-fill");
        wave.classList.add("active2");
    } else {
        music.pause();
        masterPlay.classList.add("bi-play-fill");
        masterPlay.classList.remove("bi-pause-fill");
        wave.classList.remove("active2");
    }
});

const makeAllPlays = () => {
    Array.from(document.getElementsByClassName("playListPlay")).forEach(
        (element) => {
            element.classList.add("bi-play-circle-fill");
            element.classList.remove("bi-pause-circle-fill");
        }
    );
};

const makebg = () => {
    Array.from(document.getElementsByClassName("songItem")).forEach((element) => {
        element.style.background = "rgba(98, 98, 160, 0.158);";
    });
};

let index = 0;
let posterPlay = document.getElementById("track-img");
let titlePlay = document.getElementById("titles");

Array.from(document.getElementsByClassName("playListPlay")).forEach(
    (element) => {
        element.addEventListener("click", (e) => {
            index = e.target.dataset.index
            let source = e.target.dataset.src;
            makeAllPlays();
            AllPlayIcon(document.getElementsByClassName('playListPlay'));
            PauseIcon(Array.from(document.getElementsByClassName('playListPlay'))[index]);
            music.src = `./uploads/tracks/${source}`;

            music.play();

            music.play();
            masterPlay.classList.remove("bi-play-fill");
            masterPlay.classList.add("bi-pause-fill");
            wave.classList.add("active2");
            music.addEventListener("ended", () => {
                AllPlayIcon(document.getElementsByClassName('playListPlay'));
                PauseIcon(Array.from(document.getElementsByClassName('playListPlay'))[index]);
                wave.classList.remove("active2");
            });
        });
    }
);

let currentStart = document.getElementById('currentStart');
let currentEnd = document.getElementById('currentEnd');
let seek = document.getElementById('seek');
let bar2 = document.getElementById('bar2');




music.addEventListener('timeupdate', () => {
    let currMusic = music.currentTime;
    let durMusic = music.duration;

    let min = Math.floor(durMusic / 60);
    let sec = Math.floor(durMusic % 60);
    if (sec < 10) {
        sec = `0${sec}`
    }
    currentEnd.innerHTML = `${min}:${sec}`;


    let min1 = Math.floor(currMusic / 60);
    let sec1 = Math.floor(currMusic % 60);
    if (sec1 < 10) {
        sec1 = `0${sec1}`
    }
    currentStart.innerHTML = `${min1}:${sec1}`;


    let progressBar = parseInt((music.currentTime / music.duration) * 100);
    seek.value = progressBar;
    let seekBar = seek.value;
    bar2.style.width = `${seekBar}%`



})

seek.addEventListener('change', () => {
    music.currentTime = seek.value * music.duration / 100;
})

music.addEventListener('ended', () => {
    masterPlay.classList.add('bi-pause-fill')
    wave.classList.add("active2");
})

let volIcon = document.getElementById('vol-Icon');
let vol = document.getElementById('vol');
let volBar = document.getElementsByClassName('vol_bar');

//vol.addEventListener('change', () => {
//    if (vol.value == 0) {
//        volIcon.classList.remove('bi-volume-up-fill')
//        volIcon.classList.add('bi-volume-mute-fill')
//        volIcon.classList.remove('bi-volume-down-fill')

//    }
//    if (vol.value > 0) {
//        volIcon.classList.remove('bi-volume-up-fill')
//        volIcon.classList.remove('bi-volume-mute-fill')
//        volIcon.classList.add('bi-volume-down-fill')

//    }
//    if (vol.value > 50) {
//        volIcon.classList.add('bi-volume-up-fill')
//        volIcon.classList.remove('bi-volume-mute-fill')
//        volIcon.classList.remove('bi-volume-down-fill')

//    }
//    let volVal = vol.value;
//    volBar.style.width = `${volVal}%`;

//    music.volume = volVal / 100;
//})

let back = document.getElementById('back')
let next = document.getElementById('next')

back.addEventListener('click', () => {
    index -= 1;

    if (index < 0) {
        index = Array.from(document.getElementsByClassName('playListPlay')).length - 1;
    }
    music.src = `./uploads/tracks/${Array.from(document.getElementsByClassName('playListPlay'))[index].dataset.src}`;

    music.play();
 
    makeAllPlays();
    AllPlayIcon(document.getElementsByClassName('playListPlay'));
    PauseIcon(Array.from(document.getElementsByClassName('playListPlay'))[index]);

})

next.addEventListener('click', () => {
    index++;

    if (index > Array.from(document.getElementsByClassName('playListPlay')).length - 1) {
        index = 0;
    }
    music.src = `./uploads/tracks/${Array.from(document.getElementsByClassName('playListPlay'))[index].dataset.src}`;

    music.play();

    makeAllPlays();
    AllPlayIcon(document.getElementsByClassName('playListPlay'));
    PauseIcon(Array.from(document.getElementsByClassName('playListPlay'))[index]);


})
function PauseIcon(element) {
    element.classList.remove("bi-play-circle-fill");
    element.classList.add("bi-pause-circle-fill");
}
function AllPlayIcon(elements) {

    Array.from(elements).forEach(element => {
        element.classList.add("bi-play-circle-fill");
        element.classList.remove("bi-pause-circle-fill");

    })

}