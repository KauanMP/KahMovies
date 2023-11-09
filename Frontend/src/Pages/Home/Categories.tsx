import { Box, Button } from "@mui/joy";
import { useFetch } from "../../Helpers/config";
import { IGenre } from "../../Interface/IGenre";

const Categories = () => {
  const { data: genre, isLoading } = useFetch<IGenre[]>("Genres", "/Genre");

  if (isLoading) {
    return <p>Carregando...</p>;
  }

  return (
    <Box
      display={"flex"}
      justifyContent={"center"}
      margin={"0 auto"}
      width={"500px"}
      flexWrap={"wrap"}
      py={1}
      gap={2}
    >
      {genre?.map((genreMap) => (
        <Button sx={{ backgroundColor: "#2A3D52" }} key={genreMap.id}>
          {genreMap.genreName}
        </Button>
      ))}
    </Box>
  );
};

export default Categories;
