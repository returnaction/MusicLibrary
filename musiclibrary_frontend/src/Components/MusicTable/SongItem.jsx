import dayjs from "dayjs";

const SongItem = ({ song }) => {
  const shortDateFormat = dayjs(song.releaseDate).format("YYYY/MM/DD");
  console.log(song);
  return (
    <tr>
      <td>{song.id}</td>
      <td>{song.title}</td>
      <td>{song.artist}</td>
      <td>{song.album}</td>
      <td>{shortDateFormat}</td>
      <td>{song.genre}</td>
      <td>{song.likes}</td>
    </tr>
  );
};

export default SongItem;
