import axios from "axios";
import React, { useState } from "react";

// components
import TextField from "./TextField";

const NewSongForm = ({ onNewSong }) => {
  const [title, setTitle] = useState("");
  const [artist, setArtist] = useState("");
  const [album, setAlbum] = useState("");
  const [releaseDate, setReleaseDate] = useState("");
  const [genre, setGenre] = useState("");

  const handleSubmit = async (e) => {
    e.preventDefault();

    const formData = {
      title,
      artist,
      album,
      releaseDate,
      genre,
    };

    try {
      const response = await axios.post(
        `https://localhost:7065/api/song/`,
        formData
      );

      if (response.status === 201) {
        onNewSong();
      }
    } catch (error) {
      console.warn("Error submitting newNong form: ", error);
    }
  };

  return (
    <form onSubmit={handleSubmit}>
      <h4>Add New Song</h4>
      <div>
        <TextField label={"Title"} value={title} onChange={setTitle} />
        <TextField label={"Artist"} value={artist} onChange={setArtist} />
        <TextField label={"Album"} value={album} onChange={setAlbum} />
        <TextField
          label={"Release Data"}
          value={releaseDate}
          onChange={setReleaseDate}
          type="date"
        />
        <TextField label={"Genre"} value={genre} onChange={setGenre} />
      </div>
      <button type="Submit">Add Song</button>
    </form>
  );
};

export default NewSongForm;
