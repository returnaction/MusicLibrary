const SongItem = ({ song }) => {
  console.log(song);
  return (
    <tr>
      <td>{song.id}</td>
      <td>{song.title}</td>
      <td>{song.artist}</td>
      <td>{song.album}</td>
      <td>{song.releaseDate}</td>
      <td>{song.gender}</td>
      <td>{song.likes}</td>
    </tr>
  );
};

export default SongItem;
