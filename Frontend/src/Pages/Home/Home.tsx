import { useEffect, useState } from "react";
import { useFetch } from "../../Helpers/config";

// Interfaces
import { IMovie } from "../../Interface/IMovie";

import { Box } from "@mui/joy";
import { Link } from "react-router-dom";
import { SwiperSlide } from "swiper/react";
import Search from "../../components/Search/Search";
import Categories from "./Categories";
import Slide from "../../components/Carousel/Slide";

const Home = () => {
  const [isLoading, setIsLoading] = useState<boolean>(true);
  const { data: movie, isLoading: isLoadingMovie } = useFetch<IMovie[]>(
    "movie",
    "/Movie"
  );

  useEffect(() => {
    if (!isLoadingMovie) {
      setIsLoading(false);
    }
  }, [isLoadingMovie, isLoading]);

  return (
    <Box>
      {!isLoading ? (
        <>
          <Search />
          <Categories />
          <Slide genre={"Teste"}>
            {movie?.map((movieMap) => (
              <SwiperSlide className="card">
                <div className="card-content">
                  <div className="image">
                    <Link to={`/movie/${movieMap.id}`}>
                      <Box
                        className="image"
                        component="img"
                        src={movieMap.poster}
                        alt={movieMap.title}
                      />
                    </Link>
                  </div>
                </div>
              </SwiperSlide>
            ))}
          </Slide>
        </>
      ) : (
        <h1>Carregando...</h1>
      )}
    </Box>
  );
};

export default Home;
