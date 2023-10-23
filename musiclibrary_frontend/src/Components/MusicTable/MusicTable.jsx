import SongItem from "./SongItem";

const MusicTable = ({ songs, onSongLikeSuccess }) => {
  const songItem = songs.map((song) => (
    <SongItem key={song.id} song={song} onSongLikeSuccess={onSongLikeSuccess} />
  ));
  return (
    <table>
      <thead>
        <tr>
          <th>Id</th>
          <th>Title</th>
          <th>Artist</th>
          <th>Album</th>
          <th>Published</th>
          <th>Genre</th>
          <th>Likes</th>
        </tr>
      </thead>
      <tbody>{songItem}</tbody>
    </table>
  );
};

export default MusicTable;
