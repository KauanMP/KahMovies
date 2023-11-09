import Search from "../../components/Search/Search";
import Categories from "./Categories";

import { Box, Typography } from "@mui/joy";
import { Link } from "react-router-dom";
import { useEffect, useState } from "react";

// Interfaces
import { useFetch } from "../../Helpers/config";
import { IMovie } from "../../Interface/IMovie";
import { IGenre } from "../../Interface/IGenre";

// Swiper
import { Navigation } from "swiper/modules";
import { Swiper, SwiperSlide } from "swiper/react";
import { SwiperNavButtons } from "../../components/Carousel/SwiperNavButtons";

// CSS
import "swiper/css";
import "swiper/css/pagination";
import "./home.css";

const Home = () => {
  const { data: movie, isLoading: isLoadingMovie } = useFetch<IMovie[]>(
    "movie",
    "/Movie"
  );

  const { data: Genre, isLoading: isLoadingGenre } = useFetch<IGenre[]>(
    "Genres",
    "/Genre"
  );

  const [isLoading, setIsLoading] = useState<boolean>(true);

  useEffect(() => {
    if (!isLoadingMovie && !isLoadingGenre) {
      setIsLoading(false);
    }
  }, [isLoadingMovie, isLoadingGenre, isLoading]);

  return (
    <div
      style={{
        padding: "0 15rem 2rem 15rem",
        margin: "0 auto",
      }}
    >
      {!isLoading ? (
        <>
          <Search />
          <Categories />
          {Genre?.map((genreMap) => {
            const filteredMovies = movie?.filter((movieMap) => {
              const movieCategories = movieMap.genres.map(
                (genre) => genre.genreName
              );
              return movieCategories.includes(genreMap.genreName);
            });

            {
              if (filteredMovies!.length > 0) {
                return (
                  <>
                    <Box
                      display={"flex"}
                      justifyContent={"space-between"}
                      alignItems={"center"}
                    >
                      <Typography level="h1" pb={2} textColor="common.white">
                        {genreMap.genreName}
                      </Typography>
                      <SwiperNavButtons />
                    </Box>
                    <Swiper
                      key={genreMap.id}
                      modules={[Navigation]}
                      spaceBetween={10}
                      slidesPerView="auto"
                    >
                      {filteredMovies?.map((movieMap) => (
                        <SwiperSlide className="res-slide" key={movieMap.id}>
                          <Link to={`/movie/${movieMap.id}`}>
                            <Box
                              component="img"
                              borderRadius={10}
                              src={movieMap.poster}
                              alt={movieMap.title}
                            />
                          </Link>
                        </SwiperSlide>
                      ))}
                    </Swiper>
                  </>
                );
              }
            }
          })}
        </>
      ) : (
        <h1>Carregando...</h1>
      )}
    </div>
  );
};

export default Home;
