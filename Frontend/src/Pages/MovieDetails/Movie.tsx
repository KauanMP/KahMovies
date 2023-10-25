import { useParams } from "react-router-dom";
import Search from "../../components/Search/Search";
import { Box } from "@mui/joy";

import { useRef, useState } from "react";
import { useFetch } from "../../Helpers/config";
import { IMovie } from "../../Models/IMovie";

const Movie = () => {
  const { id } = useParams();

  const { data: movie, isLoading } = useFetch<IMovie>("movie", `/Movie/${id}`);

  if (isLoading) {
    return <h1>Carregando...</h1>;
  }

  console.log(movie?.image);
  return (
    <Box>
      <Search />
      <Box sx={{}}>
        <Box
          sx={{
            backgroundImage:
              "Url(https://media.filmelier.com/tit/V1orQJ/cover/saw-x_5FPT8zs.jpeg)",
            minHeight: "calc(90vh - 136px)",
            // maxHeight: "900px",
            padding: "25px 0",
            backgroundPosition: "center",
            // position: "relative",
            // order: 0,
            backgroundSize: "cover",
          }}
        ></Box>
      </Box>
    </Box>
  );
};

export default Movie;
