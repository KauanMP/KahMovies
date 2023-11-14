import { useEffect, useState } from "react";
import { useFetch } from "../../Helpers/config";

// Interfaces
import { IMovie } from "../../Interface/IMovie";

import { Box } from "@mui/joy";
import Search from "../../components/Search/Search";
import Categories from "./Categories";
import Slide from "../../components/Swiper/Slide";
import { IGenre } from "../../Interface/IGenre";

const Home = () => {
  const [isLoading, setIsLoading] = useState<boolean>(true);
  const { isLoading: isLoadingGenre } = useFetch<IGenre[]>("genre", "/Genre");
  const { isLoading: isLoadingMovie } = useFetch<IMovie[]>("movie", "/Movie");

  useEffect(() => {
    if (!isLoadingMovie && !isLoadingGenre) {
      setIsLoading(false);
    }
  }, [isLoadingMovie, isLoadingGenre, isLoading]);

  return (
    <Box>
      {!isLoading ? (
        <>
          <Search />
          <Categories />
          <Slide />
        </>
      ) : (
        <h1>Carregando...</h1>
      )}
    </Box>
  );
};

export default Home;
