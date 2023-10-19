import SongItem from "./SongItem";

const MusicTable = ({ songs }) => {
  const songItem = songs.map((song) => <SongItem key={song.id} song={song} />);
  return (
    <table>
      <thead>
        <tr>
          <th>Id</th>
          <th>Title</th>
          <th>Artist</th>
          <th>Album</th>
          <th>Published</th>
          <th>Ganre</th>
          <th>Likes</th>
        </tr>
      </thead>
      <tbody>{songItem}</tbody>
    </table>
  );
};

export default MusicTable;
