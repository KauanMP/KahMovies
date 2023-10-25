import { Box } from "@mui/joy";
import Search from "../../components/Search/Search";
import Carousel from "../../components/Carousel/Carousel";
import { useFetch } from "../../Helpers/config";
import Categories from "./Categories";
import { ICategory } from "../../Models/ICategory";
import { IMovie } from "../../Models/IMovie";
import { Link } from "react-router-dom";
import { useEffect, useState } from "react";

const Home = () => {
  const { data: movie, isLoading: isLoadingMovie } = useFetch<IMovie[]>(
    "movie",
    "/Movie"
  );
  const { data: categories, isLoading: isLoadingCategories } = useFetch<
    ICategory[]
  >("Categories", "/Category");

  const [isLoading, setIsLoading] = useState<boolean>(true);

  useEffect(() => {
    if (!isLoadingMovie && !isLoadingCategories) {
      setIsLoading(false);
    }
  }, [isLoadingMovie, isLoadingCategories, isLoading]);

  console.log(isLoading);

  return (
    <div
      style={{
        padding: "0 10rem 2rem 10rem",
        margin: "0 auto",
      }}
    >
      {!isLoading ? (
        <>
          <Search />
          <Categories />
          {categories?.map((gender) => {
            const filteredMovies = movie?.filter((movieMap) => {
              const movieCategories = movieMap.categories.map(
                (category) => category.categoryName
              );
              return movieCategories.includes(gender.categoryName);
            });

            {
              if (filteredMovies!.length > 0) {
                return (
                  <Carousel gender={gender.categoryName} key={gender.id}>
                    {filteredMovies?.map((movieMap) => (
                      <Box padding={"6px"} key={movieMap.id}>
                        <Link to={`/movie/${movieMap.id}`}>
                          <Box
                            component="img"
                            borderRadius={10}
                            sx={{
                              width: "150px",
                              height: "260px",
                            }}
                            src={movieMap.image}
                            alt={movieMap.title}
                          />
                        </Link>
                      </Box>
                    ))}
                  </Carousel>
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
