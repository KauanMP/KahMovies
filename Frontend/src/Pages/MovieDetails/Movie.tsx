import { useParams } from "react-router-dom";
import Search from "../../components/Search/Search";
import { Box } from "@mui/joy";

import { useFetch } from "../../Helpers/config";
import { IMovie } from "../../Interface/IMovie";

const Movie = () => {
  const { id } = useParams();

  const { data: movie, isLoading } = useFetch<IMovie>("movie", `/Movie/${id}`);

  if (isLoading) {
    return <h1>Carregando...</h1>;
  }

  return (
    <Box>
      <Search />
      <Box
        sx={{
          backgroundImage: `Url(${movie?.stillImage})`,
          minHeight: "calc(90vh - 136px)",
          maxHeight: "900px",
          padding: "25px 0",
          backgroundPosition: "center",
          position: "relative",
          order: 0,
          backgroundSize: "cover",
        }}
      ></Box>
    </Box>
  );
};

export default Movie;
