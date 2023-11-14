import { Box } from "@mui/joy";

// Swiper
import Swiper from "swiper/bundle";

// CSS
import "swiper/css/bundle";
import "./Slide.css";
import { useFetch } from "../../Helpers/config";

// Interfaces
import { IGenre } from "../../Interface/IGenre";
import { IMovie } from "../../Interface/IMovie";

import { SwiperSlide } from "swiper/react";
import { Link } from "react-router-dom";
import SlideNav from "./SlideNav";
import { useEffect } from "react";

const Slide = () => {
  const { data: movie } = useFetch<IMovie[]>("movie", "/Movie");
  const { data: genre } = useFetch<IGenre[]>("genre", "/Genre");

  useEffect(() => {
    new Swiper(".mySwiper", {
      autoHeight: true,
      slidesPerView: 6,
      cssMode: true,
      spaceBetween: 15,
      navigation: {
        prevEl: ".slidePrev",
        nextEl: ".slideNext",
      },
    });
  });

  return (
    <>
      {genre?.map((genreMap) => {
        const filteredMovies = movie?.filter((movieMap) => {
          const movieCategories = movieMap.genres.map(
            (genre) => genre.genreName
          );
          return movieCategories.includes(genreMap.genreName);
        });

        if (filteredMovies && filteredMovies.length > 0) {
          return (
            <Box component={"section"} margin="0 auto" key={genreMap.genreName}>
              <Box className="swiper mySwiper">
                <SlideNav genre={genreMap.genreName} />
                <div className="swiper-wrapper">
                  {filteredMovies.map((movieMap) => (
                    <SwiperSlide className="card" key={movieMap.id}>
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
                  {filteredMovies.map((movieMap) => (
                    <SwiperSlide className="card" key={movieMap.id}>
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
                </div>
              </Box>
            </Box>
          );
        }
      })}
    </>
  );
};

export default Slide;
