import dayjs from "dayjs";
import axios from "axios";
import React, { useState, useEffect } from "react";

//css
import "./SongItem.css";

const SongItem = ({ song }) => {
  const shortDateFormat = dayjs(song.releaseDate).format("YYYY/MM/DD");

  //delete song
  const handleDelteSong = async (e) => {
    try {
      const response = await axios.delete(
        `https://localhost:7065/api/song/${song.id}`
      );
    } catch (error) {
      console.warn("Error in DeleteSong button, SongItem", error);
    }
  };

  //update song
  const [isEditing, setIsEditing] = useState(false);
  const [title, setTitle] = useState("");
  const [artist, setArtist] = useState("");
  const [album, setAlbum] = useState("");
  const [releaseDate, setReleaseDate] = useState("");
  const [genre, setGenre] = useState("");

  const handleUpdateButton = async (e) => {
    e.preventDefault();
    setIsEditing(!isEditing);

    setTitle(song.title);
    setArtist(song.artist);
    setAlbum(song.album);
    setGenre(song.genre);
    setReleaseDate(song.releaseDate);
  };

  const updatedSong = {
    title,
    artist,
    album,
    releaseDate,
    genre,
  };

  const handleSongData = async (e) => {
    try {
      e.preventDefault();
      console.log(updatedSong);
      const response = await axios.put(
        `https://localhost:7065/api/song/${song.id}`,
        updatedSong
      );
      setIsEditing(!isEditing);
    } catch (error) {
      console.warn("Error in handleSongData, SongItem ", error);
    }
  };

  // like song button
  const handleSongLikeButton = async (e) => {
    try {
      const response = await axios.put(
        `https://localhost:7065/api/song/like/${song.id}`,
        {}
      );
    } catch (error) {
      console.warn("Error in handleSongLikeButton, SongItem ", error);
    }
  };

  return !isEditing ? (
    <tr>
      <td>{song.id}</td>
      <td>{song.title}</td>
      <td>{song.artist}</td>
      <td>{song.album}</td>
      <td>{shortDateFormat}</td>
      <td>{song.genre}</td>
      <td>
        <button onClick={handleSongLikeButton}>{song.likes}</button>
      </td>
      <td>
        <button onClick={handleDelteSong} type="button">
          Delete
        </button>
      </td>
      <td>
        <button onClick={handleUpdateButton} type="button">
          Update
        </button>
      </td>
    </tr>
  ) : (
    <tr>
      <td>
        <input
          type="text"
          value={title}
          onChange={(e) => setTitle(e.target.value)}
        />
      </td>
      <td>
        <input
          type="text"
          value={artist}
          onChange={(e) => setArtist(e.target.value)}
        />
      </td>
      <td>
        <input
          type="text"
          value={album}
          onChange={(e) => setAlbum(e.target.value)}
        />
      </td>
      <td>{shortDateFormat}</td>
      <td>
        <input
          type="text"
          value={genre}
          onChange={(e) => setGenre(e.target.value)}
        />
      </td>
      <td>
        <button onClick={handleSongData}>Save</button>
      </td>
    </tr>
  );
};

export default SongItem;
