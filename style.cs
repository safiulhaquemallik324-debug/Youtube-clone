.header-container {
  width: 100%;
  height: 60px;
  background-color: #000000;
  justify-content: center;
  position: fixed;
  top: 0;
  left: 0;
  z-index: 10000;
}

.header {
  display: flex;
  width: 100%;
}

.navbar-toggle {
  border: none;
  cursor: pointer;
  background: transparent;
  transition: 0.3s ease;
  height: 50px;
  width: 50px;
  margin-top: 5px;
  margin-left: 10px;
}

.navbar-toggle .bar {
  width: 22px;
  height: 2px;
  margin: 5px auto;
  background-color: #ffffff;
  display: block;
}

.navbar-toggle:hover {
  background-color: rgba(75, 75, 75, 0.2);
  border-radius: 40px;
}

.youtube-logo img {
  width: 120px;
  height: 60px;
  object-fit: contain;
}

.yt-search {
  display: flex;
  width: 600px;
  /* desktop width */
  height: 40px;
  border: 1px solid #2c2c2c;
  border-radius: 50px;
  overflow: hidden;
  background: #1a1919;
  margin-top: 10px;
}

.yt-search input {
  flex: 1;
  border: none;
  outline: none;
  padding: 0 15px;
  font-size: 16px;
  background: #1a1919;
  color: white;
  display: block;
}

.ri-search-line {
  color: #ffffff;
  font-size: 20px;
  align-items: center;
  text-align: center;
}

.search-btn {
  width: 60px;
  border: none;
  background: #1a1919;
  cursor: pointer;
  font-size: 18px;
  border-left: 1px solid #ccc;
}

.search-btn:hover {
  background: #242323;
}

.search-container {
  display: flex;
  align-items: center;
  gap: 10px;
}

.mic-btn {
  border: none;
  margin-top: 10px;
  background-color: rgba(216, 216, 216, 0.123);
  width: 40px;
  height: 40px;
  border-radius: 60px;
  transition: 0.3s ease;
}

.ri-mic-line {
  color: #ffffff;
  font-size: 20px;
  align-items: center;
  text-align: center;
}

.mic-btn:hover {
  background-color: #414141;
}

.setting {
  display: flex;
}

.profiles {
  display: flex;
  align-items: center;
  gap: 20px;
}

.yt-header-right {
  display: flex;
  align-items: center;
  gap: 15px;
  margin-top: 10px;
  margin-left: 500px;
}

/* Create Button */
.create-btn {
  display: flex;
  align-items: center;
  gap: 10px;
  padding: 6px 14px;
  background: #161616;
  color: white;
  border-radius: 50px;
  cursor: pointer;
  font-size: 20px;
  border: none;
  transition: 0.3s ease;
}

.create-btn:hover {
  background: #3f3f3f;
}

.create-btn .icon {
  font-size: 20px;
}

.notification {
  width: 40px;
  height: 40px;
  margin-top: 10px;
  border-radius: 50%;
  display: flex;
  align-items: center;
  justify-content: center;
  cursor: pointer;
  transition: 0.3s ease;
}

.notification:hover {
  background: #272727;
}

.notification i {
  color: white;
  font-size: 22px;
}

.account {
  position: relative;
  width: 40px;
  height: 40px;
  border-radius: 50%;
  display: flex;
  align-items: center;
  justify-content: center;
  cursor: pointer;
  transition: 0.3s ease;
  background-color: rgb(0, 44, 27);
  margin-top: 10px;
}

.account h1 {
  color: white;
  font-size: 25px;
  padding-top: 2px;
}

.body-container {
  width: 100%;
  max-height: 100%;
  background-color: rgb(0, 0, 0);
  display: inline-block;
  gap: 6vh;
}

.content-container {
  transition: 0.3s;
  margin-left: 120px;
  margin-top: 60px;
  height: calc(100vh - 60px);
  display: flex;
  flex-direction: column;
  overflow: hidden;
  gap: 30px;
}

.content-container.shift {
  margin-left: 150px;
}

.home {
  display: flex;
  flex-direction: column;
  width: 120px;
  gap: 20px;
  position: fixed;
  top: 60px;
  left: 0;
  height: calc(100vh - 60px);
  z-index: 5;
  background-color: #000000;
}

.sidebar-icons {
  width: 60px;
  height: 60px;
  justify-content: center;
  margin-left: 12px;
  align-items: center;
  cursor: pointer;
  display: flex;
  flex-direction: column;
}

.sidebar-icons:hover {
  background-color: #202020;
  border-radius: 5px;
  transition: 0.3s ease;
}

.sidebar-icons h1 {
  font-size: 10px;
  color: #fff;
}

.sidebar-icons i {
  color: #fff;
  font-size: 30px;
}

.sidebar-icons img {
  width: 28px;
  height: 28px;
}

.category-wrapper {
  display: flex;
  align-items: center;
  padding: 10px 10px;
  background: #0f0f0f;
  max-width: 1690px;
  height: 70px;
  overflow-x: hidden;
  z-index: 10;
  top: 0;
  position: sticky;
}

.category-scroll {
  display: flex;
  gap: 10px;
  overflow-x: auto;
  scroll-behavior: smooth;
  scrollbar-width: none;
  flex: 1;
}

.category-scroll::-webkit-scrollbar {
  display: none;
}

.category {
  white-space: nowrap;
  padding: 8px 16px;
  border-radius: 20px;
  border: none;
  background: #272727;
  color: white;
  cursor: pointer;
}

.category:hover {
  background: #3f3f3f;
}

.category.active {
  background: white;
  color: black;
}

.scroll-btn {
  background: #000000;
  border: none;
  color: white;
  padding: 8px 12px;
  cursor: pointer;
  top: 0px;
  height: 70px;
  width: 40px;
  z-index: 10;
}

.left {
  left: 0;
}

.right {
  right: 0;
}

.content {
  width: 100%;
  height: 80px;
  display: flex;
}

.video-container {
  background: rgb(0, 0, 0);
  width: 95%;
  display: grid;
  z-index: 4;
  left: 140px;
  top: 110px;
  grid-auto-rows: 500px;
  grid-template-columns: repeat(4, 1fr);
  grid-gap: 20px;
  height: 400px;
}

.video-box {
  width: 100%;
  height: auto;
  display: block;
  border-radius: 12px;
  overflow: hidden;
}

.video-container-page {
  position: relative;
  transition: 0.5s;
  transition-delay: 0.05s;
  padding: 1rem 8px;
  height: 400px;
}

.video-content {
  transition: 0.5s;
  width: 100%;
}

.video-one {
  width: 100%;
  height: auto;
}

.thumb img {
  width: 100%;
}

.video-details {
  margin-top: 5px;
}

.ri-more-2-line {
  color: aliceblue;
}

.section {
  display: flex;
  gap: 10px;
}

.video-container-page:hover {
  background: rgba(201, 121, 69, 0.17);
  border-radius: 20px;
}

.title {
  color: aliceblue;
  font-size: 18px;
  font-weight: 700;
  padding-top: 10px;
}

.channel-name {
  color: rgb(48, 48, 48);
  font-weight: 500;
}

.views {
  color: rgb(48, 48, 48);
  font-weight: 500;
}

.upload {
  color: rgb(48, 48, 48);
  font-weight: 500;
}

.ri-circle-fill {
  font-size: 6px;
  padding-top: 10px;
}

.shorts {
  display: inline-block;
  z-index: 3;
  width: 100%;
  height: auto;
}

.shorts-txt {
  display: flex;
  gap: 10px;
}

.shorts-txt img {
  width: 30px;
  height: 30px;
}

.shorts-txt h1 {
  color: aliceblue;
  font-size: 25px;
}

.shorts-column {
  width: 95%;
  display: grid;
  grid-auto-rows: 500px;
  grid-template-columns: repeat(6, 1fr);
  grid-gap: 10px;
  height: 400px;
  margin-top: 10px;
}

.card {
  height: 400px;
}

.card img {
  height: 400px;
  object-fit: cover;
  border-radius: 6px;
  width: 100%;
}

.sidebar {
  width: 220px;
  background: #0f0f0f;
  color: white;
  padding: 15px;
  position: fixed;
  left: -220px;
  height: calc(100vh - 60px);
  top: 60px;
  transition: 0.3s;
  display: flex;
  flex-direction: column;
  gap: 15px;
  z-index: 12;
}

.sidebar a {
  color: white;
  text-decoration: none;
  font-size: 14px;
}

/* Sidebar active */
.sidebar.active {
  left: 0;
}

.videosection {
  width: 100%;
  overflow-y: scroll;
  height: calc(100vh - 60px);
  display: flex;
  flex-direction: column;
  gap: 30px;
  top: 90px;
}

@media (max-width: 768px) {
  .navbar-toggle .bar {
    width: 18px;
    height: 2px;
    margin: 5px auto;
    background-color: #ffffff;
    display: block;
  }
  .youtube-logo img {
    width: 80px;
    height: 40px;
    object-fit: contain;
    margin-top: 10px;
  }
  .search-container {
    display: flex;
    align-items: center;
    gap: 7px;
  }
  .yt-search input {
    display: none;
  }
  .yt-search {
    background: transparent;
    border: none;
    width: 40px;
    margin-left: 30px;
  }
  .ri-search-line {
    font-size: 25px;
  }
  .search-btn {
    width: 60px;
    border: none;
    background: transparent;
    cursor: pointer;
    font-size: 18px;
    border-left: none;
  }
  .yt-header-right {
    margin-left: 10px;
  }
  .profiles {
    display: flex;
    align-items: center;
    gap: 12px;
  }
  .create-btn {
    padding: 6px 10px;
    font-size: 18px;
  }
  .create-btn .icon {
    font-size: 14px;
  }
  .create-btn .text {
    font-size: 15px;
  }
  .ri-mic-line {
    font-size: 24px;
  }
  .mic-btn {
    border: none;
    margin-top: 10px;
    background: transparent;
    height: 40px;
    border-radius: 60px;
  }
  .notification {
    width: 40px;
    height: 40px;
  }
  .notification i {
    color: white;
    font-size: 23px;
  }
  .home {
    display: none;
  }
  .body-container {
    background-color: rgb(0, 0, 0);
    height: 100%;
    width: 100%;
  }
  .content {
    margin-left: 0px;
    width: 100%;
  }
  .content-container {
    display: inline-block;
    z-index: 3;
    top: 0;
    left: 0;
    align-items: center;
    justify-content: center;
    margin-left: 0px;
  }
  .category-wrapper {
    display: flex;
    align-items: center;
    padding: 10px 10px;
    background: #0f0f0f;
    width: 400px;
    height: 70px;
    overflow-x: hidden;
  }
  .video-container {
    background: rgb(0, 0, 0);
    width: 100%;
    display: grid;
    grid-auto-rows: 400px;
    grid-template-columns: 1fr;
    grid-gap: 10px;
    padding: 5px 15px;
    height: auto;
  }
  .ri-more-2-line {
    font-size: 20px;
  }
  .shorts {
    display: inline-block;
    width: 100%;
    height: auto;
  }
  .shorts-txt {
    margin-left: 20px;
  }
  .shorts-column {
    width: 90%;
    display: grid;
    grid-template-rows: 1fr 1fr;
    grid-template-columns: repeat(2, 1fr);
    grid-gap: 10px;
    height: 620px;
    margin-top: 20px;
    margin-left: 20px;
    overflow: hidden;
    margin-block: 2rem;
  }
  .card {
    height: 300px;
  }
  .card img {
    height: 300px;
    object-fit: cover;
    border-radius: 6px;
    width: 100%;
  }
  .content-container.shift {
    margin-left: 0px;
  }
  .videosection {
    width: 100%;
    overflow-y: scroll;
    margin-left: 0px;
    margin-top: 0px;
  }
}

/*# sourceMappingURL=style.cs.map */
