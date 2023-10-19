// components
import Header from "./Components/Header/Header";
import Footer from "./Components/Footer/Footer";
import SearchBar from "./Components/SearchBar/SearchBar";
import MusicTable from "./Components/MusicTable/MusicTable";

// styles
import "./App.css";

//utils
import React, { useState, useEffect } from "react";
import axios from "axios";
import NewSongForm from "./Components/NewSongForm/NewSongForm";

function App() {
  const [songs, setSongs] = useState([]);

  // get all songs from DB
  const fetchSongs = async () => {
    try {
      const response = await axios.get(`https://localhost:7065/api/song/`);
      setSongs(response.data);
    } catch (error) {
      console.warn("Error in fetchSongs: ", error);
    }
  };

  useEffect(() => {
    fetchSongs();
  }, []);

  //filter songs
  const filterSongs = (event) => {
    let filterValue = event.target.value;
    if (filterValue === "") {
      fetchSongs();
    }

    let filterSongs = songs.filter(
      (song) =>
        song.title.toLowerCase().includes(filterValue.toLowerCase()) ||
        song.artist.toLowerCase().includes(filterValue.toLowerCase()) ||
        song.album.toLowerCase().includes(filterValue.toLowerCase()) ||
        song.releaseDate.toLowerCase().includes(filterValue.toLowerCase())
    );

    setSongs(filterSongs);
  };

  return (
    <div className="App">
      <Header />
      <div>
        <SearchBar filterSongs={filterSongs} />
        <MusicTable songs={songs} />
        <NewSongForm />
      </div>
      <Footer />
    </div>
  );
}

export default App;
