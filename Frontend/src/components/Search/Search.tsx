import { Box, Input } from "@mui/joy";

const Search = () => {
  return (
    <Box display={"flex"} justifyContent={"center"} >
      <Input
        disabled={false}
        placeholder="Pesquise um filme"
        size="md"
        variant="outlined"
        sx={{ width: "300px"}}
      />
    </Box>
  );
};

export default Search;