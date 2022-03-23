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

//My Playlisy Page

// const music = new Audio("./assets/media/music/Gojira - Global Warming.mp3");

// const songs = [
//   {
//     id: "1",
//     songName: `Inferno <br>
//       <div class="subtitle">Gojira</div>`,
//     poster: "./assets/media/albums/1.jpg",
//   },
//   {
//     id: "2",
//     songName: `Global Warming <br>
//       <div class="subtitle">Gojira</div>`,
//     poster: "./assets/media/albums/2.jpg",
//   },
//   {
//     id: "3",
//     songName: `Norupo <br>
//       <div class="subtitle">Heilung</div>`,
//     poster: "./assets/media/albums/3.jpg",
//   },
//   {
//     id: "4",
//     songName: `Lullaby<br>
//       <div class="subtitle">Low</div>`,
//     poster: "./assets/media/albums/4.jpg",
//   },
//   {
//     id: "5",
//     songName: `Over <br>
//       <div class="subtitle">Postishead</div>`,
//     poster: "./assets/media/albums/5.jpg",
//   },
//   {
//     id: "6",
//     songName: `Morgenstern <br>
//       <div class="subtitle">Rammstein</div>`,
//     poster: "./assets/media/albums/6.jpg",
//   },
//   {
//     id: "7",
//     songName: `Moskau <br>
//       <div class="subtitle">Rammstein</div>`,
//     poster: "./assets/media/albums/7.jpg",
//   },
// ];

// Array.from(document.getElementsByClassName("songItem")).forEach(
//   (element, i) => {
//     if (!element || !songs[i]) return;

//     console.log(element);
//     element.getElementsByTagName("img")[0].src = songs[i].poster;
//     element.getElementsByTagName("h5")[0].innerHTML = songs[i].songName;
//   }
// );

// let masterPlay = document.getElementById("masterPlay");
// let wave = document.getElementsByClassName("wave")[0];

// masterPlay.addEventListener("click", () => {
//   console.log(music.paused);
//   if (music.paused) {
//     music.play();
//     masterPlay.classList.remove("bi-play-fill");
//     masterPlay.classList.add("bi-pause-fill");
//     wave.classList.add("active2");
//   } else {
//     music.pause();
//     masterPlay.classList.add("bi-play-fill");
//     masterPlay.classList.remove("bi-pause-fill");
//     wave.classList.remove("active2");
//   }
// });

// const makeAllPlays = () => {
//   Array.from(document.getElementsByClassName("playListPlay")).forEach(
//     (element) => {
//       element.classList.add("bi-play-circle-fill");
//       element.classList.remove("bi-pause-circle-fill");
//     }
//   );
// };

// const makebg = () => {
//   Array.from(document.getElementsByClassName("songItem")).forEach((element) => {
//     element.style.background = "rgba(98, 98, 160, 0.158);";
//   });
// };

// let index = 0;
// let posterPlay = document.getElementById("poster_master_play");
// let titlePlay = document.getElementById("titles");

// Array.from(document.getElementsByClassName("playListPlay")).forEach(
//   (element) => {
//     element.addEventListener("click", (e) => {
//       index = e.target.id;
//       makeAllPlays();
//       e.target.classList.remove("bi-play-circle-fill");
//       e.target.classList.add("bi-pause-circle-fill");
//       music.src = `./assets/media/music/${index}.mp3`;
//       posterPlay.src = `assets/media/albums/${index}.jpg`;
//       music.play();
//       let songtitle = songs.filter((el) => {
//         return el.id == index;
//       });
//       songtitle.forEach((el) => {
//         let { songName } = el;
//         titlePlay.innerHTML = songName;
//       });
//       music.play();
//       masterPlay.classList.remove("bi-play-fill");
//       masterPlay.classList.add("bi-pause-fill");
//       wave.classList.add("active2");
//       music.addEventListener("ended", () => {
//         masterPlay.classList.add("bi-play-fill");
//         masterPlay.classList.remove("bi-pause-fill");
//         wave.classList.remove("active2");
//       });
//     });
//   }
// );

// let currentStart = document.getElementById('currentStart');
// let currentEnd = document.getElementById('currentEnd');
// let seek = document.getElementById('seek');
// let bar2 = document.getElementById('bar2');




// music.addEventListener('timeupdate', ()=>{
//   let currMusic = music.currentTime;
//   let durMusic = music.duration;

//   let min = Math.floor(durMusic/60);
//   let sec = Math.floor(durMusic%60);
//   if(sec<10){
//       sec = `0${sec}`
//   }
//   currentEnd.innerHTML = `${min}:${sec}`;


//   let min1 = Math.floor(currMusic/60);
//   let sec1 = Math.floor(currMusic%60);
//   if(sec1<10){
//       sec1 = `0${sec1}`
//   }
//   currentStart.innerHTML = `${min1}:${sec1}`;


//   let progressBar = parseInt((music.currentTime/ music.duration)*100);
//   seek.value = progressBar;
//   let seekBar = seek.value;
//   bar2.style.width = `${seekBar}%`
//   dots.style.width = `${seekBar}%`


// })

// seek.addEventListener('change', ()=>{
//   music.currentTime = seek.value*music.duration/100;
// })

// music.addEventListener('ended', ()=>{
//   masterPlay.classList.add("bi-play-fill");
//   masterPlay.classList.remove("bi-pause-fill");
//   wave.classList.remove("active2");
// })

// let volIcon = document.getElementById('vol-Icon');
// let vol = document.getElementById('vol');
// let volBar = document.getElementsByClassName('vol_bar');

// vol.addEventListener('change', ()=>{
//   if(vol.value == 0){
//     volIcon.classList.remove('bi-volume-up-fill')
//     volIcon.classList.add('bi-volume-mute-fill')
//     volIcon.classList.remove('bi-volume-down-fill')

//   }
//   if(vol.value > 0){
//     volIcon.classList.remove('bi-volume-up-fill')
//     volIcon.classList.remove('bi-volume-mute-fill')
//     volIcon.classList.add('bi-volume-down-fill')

//   }
//   if(vol.value >50){
//     volIcon.classList.add('bi-volume-up-fill')
//     volIcon.classList.remove('bi-volume-mute-fill')
//     volIcon.classList.remove('bi-volume-down-fill')

//   }
//   let volVal = vol.value;
//   volBar.style.width = `${volVal}%`;

//   music.volume = volVal/100;
// })

// let back = document.getElementById('back')
// let next = document.getElementById('next')

// back.addEventListener('click', ()=>{
//   index-=1;

//   if(index <1){
//     index = Array.from(document.getElementsByClassName('songItem')).length;
//   }
//   music.src = `./assets/media/music/${index}.mp3`;
//   posterPlay.src = `assets/media/albums/${index}.jpg`;
//   music.play();
//   let songtitle = songs.filter((el) => {
//     return el.id == index;
//   });
//   songtitle.forEach((el) => {
//     let { songName } = el;
//     titlePlay.innerHTML = songName;
//   });
//   makeAllPlays();
//   document.getElementById(`${index}`).classList.remove("bi-play-fill");
//   document.getElementById(`${index}`).classList.add("bi-pause-fill");

// })

// next.addEventListener('click', ()=>{
//   index-=0;
//   index +=1;

//   if(index > Array.from(document.getElementsByClassName('songItem')).length){
//     index = 1;
//   }
//   music.src = `./assets/media/music/${index}.mp3`;
//   posterPlay.src = `assets/media/albums/${index}.jpg`;
//   music.play();
//   let songtitle = songs.filter((el) => {
//     return el.id == index;
//   });
//   songtitle.forEach((el) => {
//     let { songName } = el;
//     titlePlay.innerHTML = songName;
//   });
//   makeAllPlays();
//   document.getElementById(`${index}`).classList.remove("bi-play-fill");
//   document.getElementById(`${index}`).classList.add("bi-pause-fill");

// })

const musicContainer = document.querySelector('.music-container');
const playBtn = document.querySelector('#play');
const prevBtn = document.querySelector('#prev');
const nextBtn = document.querySelector('#next');
const audio = document.querySelector('#audio');
const progress = document.querySelector('.progress');
const progressContainer = document.querySelector('.track-range');
const title = document.querySelector('#title');
const cover = document.querySelector('#cover')



const songs = ['1', '2', '3' , '4', '5' , '6', '7'];

// Keep track of song
let songIndex = 2;

// Initially load song details into DOM
loadSong(songs[songIndex]);

// Update song details
function loadSong(song) {
  title.innerText = song;
  audio.src = `./assets/media/music/${song}.mp3`;
  cover.src = `./assets/media/albums/${song}.jpg`;
}
function playSong() {
  musicContainer.classList.add('play');
  playBtn.querySelector('i.fas').classList.remove('fa-play');
  playBtn.querySelector('i.fas').classList.add('fa-pause');

  audio.play();
}
function pauseSong() {
  musicContainer.classList.remove('play');
  playBtn.querySelector('i.fas').classList.add('fa-play');
  playBtn.querySelector('i.fas').classList.remove('fa-pause');

  audio.pause();
}

// Previous song
function prevSong() {
  songIndex--;

  if (songIndex < 0) {
    songIndex = songs.length - 1;
  }

  loadSong(songs[songIndex]);

  playSong();
}

// Next song
function nextSong() {
  songIndex++;

  if (songIndex > songs.length - 1) {
    songIndex = 0;
  }

  loadSong(songs[songIndex]);

  playSong();
}

// Update progress bar
function updateProgress(e) {
  const { duration, currentTime } = e.srcElement;
  const progressPercent = (currentTime / duration) * 100;
  progress.style.width = `${progressPercent}%`;
}

// Set progress bar
function setProgress(e) {
  const width = this.clientWidth;
  const clickX = e.offsetX;
  const duration = audio.duration;

  audio.currentTime = (clickX / width) * duration;
}

//get duration & currentTime for Time of song
function DurTime (e) {
	const {duration,currentTime} = e.srcElement;
	var sec;
	var sec_d;

	// define minutes currentTime
	let min = (currentTime==null)? 0:
	 Math.floor(currentTime/60);
	 min = min <10 ? '0'+min:min;

	// define seconds currentTime
	function get_sec (x) {
		if(Math.floor(x) >= 60){
			
			for (var i = 1; i<=60; i++){
				if(Math.floor(x)>=(60*i) && Math.floor(x)<(60*(i+1))) {
					sec = Math.floor(x) - (60*i);
					sec = sec <10 ? '0'+sec:sec;
				}
			}
		}else{
		 	sec = Math.floor(x);
		 	sec = sec <10 ? '0'+sec:sec;
		 }
	} 

	get_sec (currentTime,sec);

	// change currentTime DOM
	currTime.innerHTML = min +':'+ sec;

	// define minutes duration
	let min_d = (isNaN(duration) === true)? '0':
		Math.floor(duration/60);
	 min_d = min_d <10 ? '0'+min_d:min_d;


	 function get_sec_d (x) {
		if(Math.floor(x) >= 60){
			
			for (var i = 1; i<=60; i++){
				if(Math.floor(x)>=(60*i) && Math.floor(x)<(60*(i+1))) {
					sec_d = Math.floor(x) - (60*i);
					sec_d = sec_d <10 ? '0'+sec_d:sec_d;
				}
			}
		}else{
		 	sec_d = (isNaN(duration) === true)? '0':
		 	Math.floor(x);
		 	sec_d = sec_d <10 ? '0'+sec_d:sec_d;
		 }
	} 

	// define seconds duration
	
	get_sec_d (duration);

	// change duration DOM
	durTime.innerHTML = min_d +':'+ sec_d;
		
};

// Event listeners
playBtn.addEventListener('click', () => {
  const isPlaying = musicContainer.classList.contains('play');

  if (isPlaying) {
    pauseSong();
  } else {
    playSong();
  }
});

// Change song
prevBtn.addEventListener('click', prevSong);
nextBtn.addEventListener('click', nextSong);

// Time/song update
audio.addEventListener('timeupdate', updateProgress);

// Click on progress bar
progressContainer.addEventListener('click', setProgress);

// Song ends
audio.addEventListener('ended', nextSong);

// Time of song
audio.addEventListener('timeupdate',DurTime);