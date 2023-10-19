const SearchBar = ({ filterSongs }) => {
  return (
    <div>
      <h4>Search Bar</h4>
      <input
        onChange={(e) => filterSongs(e)}
        placeholder="Enter song you' are looking for"
      />
    </div>
  );
};

export default SearchBar;
