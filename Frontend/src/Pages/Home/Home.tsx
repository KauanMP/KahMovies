import { Box } from "@mui/joy";
import Search from "../../components/Search/Search";
import Carousel from "../../components/Carousel/Carousel";
import { useFetch } from "../../Helpers/config";
import Categories from "./Categories";
import { ICategory } from "../../Models/ICategory";
import { IMovie } from "../../Models/IMovie";

const Home = () => {
  const { data: movie, isLoading: isLoadingMovie } = useFetch<IMovie[]>(
    "movie",
    "/Movie"
  );
  const { data: categories, isLoading: isLoadingCategories } = useFetch<
    ICategory[]
  >("Categories", "/Category");

  if (isLoadingMovie && isLoadingCategories) {
    return <p>Carregando...</p>;
  }

  // const movieAuthorsMap = movie?.map((p) => p.authors);
  // const movieCategoriesMap = movie?.map((p) => p.categories);

  return (
    <div style={{ paddingBottom: "2rem", paddingTop: "2rem" }}>
      <Search />
      <Categories />
      {categories?.map((gender) => {
      const filteredMovies = movie?.filter(
        (movieMap) => {
          const movieCategories = movieMap.categories.map(category => category.categoryName);
          return movieCategories.includes(gender.categoryName);
        }
      );
        if (filteredMovies!.length > 0) {
          return (
            <Carousel gender={gender.categoryName} key={gender.id}>
            {filteredMovies?.map((movieMap) => (
              <Box padding={"6px"} key={movieMap.id}>
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
              </Box>
            ))}
            {filteredMovies?.map((movieMap) => (
              <Box padding={"6px"} key={movieMap.id}>
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
              </Box>
            ))}
          </Carousel>
          );
        }
      })}
    </div>
  );
};

export default Home;

{/* {categories?.map((gender) => (
  <Carousel gender={gender.categoryName} key={gender.id}>
    {movie?.map((movieMap) => (
      <Box padding={"6px"} key={movieMap.id}>
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
      </Box>
    ))}
  </Carousel>
))} */}