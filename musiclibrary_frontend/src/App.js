// components
import Header from "./Components/Header/Header";
import SearchBar from "./Components/SearchBar/SearchBar";
import MusicTable from "./Components/MusicTable/MusicTable";

// styles
import "./App.css";

//utils
import React, { useState, useEffect } from "react";
import axios from "axios";

function App() {
  const [songs, setSongs] = useState([]);

  useEffect(() => {
    fetchSongs();
  }, []);

  const fetchSongs = async () => {
    try {
      const response = await axios.get(`https://localhost:7065/api/song/`);
      setSongs(response.data);
    } catch (error) {
      console.warn("Error in fetchSongs: ", error);
    }
  };

  return (
    <div className="App">
      <div>
        <MusicTable songs={songs} />
      </div>
    </div>
  );
}

export default App;
