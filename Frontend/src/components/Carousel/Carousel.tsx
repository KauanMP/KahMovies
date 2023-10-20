import "./Carousel.css";
import { MdArrowForwardIos, MdArrowBackIos } from "react-icons/md";
import { Box } from "@mui/joy";
import { Typography } from "@mui/joy";
import axios from "axios";
import { useQuery } from "react-query";

const Carousel = () => {
  const { data, isLoading } = useQuery("movies", () => {
    return axios
      .get("https://localhost:7120/api/Movie")
      .then((res) => res.data);
  });

  if (isLoading) {
    return <div>Carregando...</div>;
  }
  



  return (
    <Box>
      <Box
        display={"flex"}
        justifyContent={"space-between"}
        alignItems={"center"}
      >
        <Typography level="h1" textColor="common.white">
          Terror
        </Typography>
        <Box>
          <Box
            component="button"
            fontSize={"30px"}
            sx={{ backgroundColor: "transparent", border: "none" }}
          >
            <MdArrowBackIos />
          </Box>
          <Box
            component="button"
            fontSize={"30px"}
            sx={{ backgroundColor: "transparent", border: "none" }}
          >
            <MdArrowForwardIos />
          </Box>
        </Box>
      </Box>
      <Box display={"flex"} overflow={"auto"} gap={1}>
        {data.map((movie: { image: string | undefined; title: string | undefined; }) => (
          <Box flex={"none"}>
            <Box>
              <Box
                component="img"
                borderRadius={10}
                sx={{
                  width: "150px",
                  height: "260px",
                }}
                src={movie.image}
                alt={movie.title}
              />
            </Box>
          </Box>
        ))}
        {data.map((movie: { image: string | undefined; title: string | undefined; }) => (
          <Box flex={"none"}>
            <Box>
              <Box
                component="img"
                borderRadius={10}
                sx={{
                  width: "150px",
                  height: "260px",
                }}
                src={movie.image}
                alt={movie.title}
              />
            </Box>
          </Box>
        ))}
      </Box>
    </Box>
  );
};

export default Carousel;
