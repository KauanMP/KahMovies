import { useParams } from "react-router-dom";
import Search from "../../components/Search/Search";
import { Box, Button, Typography } from "@mui/joy";

import { useFetch } from "../../Helpers/config";
import { IMovie } from "../../Interface/IMovie";

const MovieDetails = () => {
  const { id } = useParams();

  const { data: movie, isLoading } = useFetch<IMovie>("movie", `/Movie/${id}`);

  if (isLoading) {
    return <h1>Carregando...</h1>;
  }

  console.log();

  return (
    <Box>
      <Search />
      <Box
        sx={{
          backgroundImage: `Url(${movie?.stillImage})`,
          minHeight: "calc(90vh - 136px)",
          maxHeight: "900px",
          padding: "50px",
          backgroundPosition: "center",
          position: "relative",
          order: 0,
          backgroundSize: "cover",
          mb: 5,
        }}
      >
        <Box
          sx={{
            width: "1000px",
            height: "500px",
            padding: "50px",
          }}
        >
          <Box display={"grid"} gridTemplateColumns={"2"}>
            <Box gridColumn={1} width={"0px"}>
              <Box
                sx={{
                  borderRadius: "10px",
                  maxWidth: "140px",
                  height: "209px",
                  objectFit: "cover",
                }}
                component="img"
                src={movie?.poster}
                alt={movie?.title}
              />
              <Box sx={{ width: "820px" }}>
                <Typography py={1} level="h1" textColor={"#C4C4C4"}>
                  Sinopse
                </Typography>
                <Box>
                  <Typography
                    level="h4"
                    textColor={"#C4C4C4"}
                    sx={{
                      backgroundColor: "rgba(0, 0, 0, 0.5)",
                      borderRadius: "8px",
                      padding: "10px",
                    }}
                  >
                    {movie?.sinopse}
                  </Typography>
                </Box>
              </Box>
            </Box>

            <Box gridColumn={2} maxWidth={"500px"}>
              <Box>
                <Typography
                  level="h1"
                  textColor={"#C4C4C4"}
                  sx={{
                    WebkitTextStrokeColor: "#999999",
                    WebkitTextStrokeWidth: "0.6px",
                  }}
                  pb={2}
                >
                  {movie?.title}
                </Typography>
              </Box>
              <Box width={"600px"}>
                <Box pb={1}>
                  {movie?.directors.map((directorsMap) => (
                    <Button
                      key={directorsMap.id}
                      size="sm"
                      color="neutral"
                      sx={{ mr: "8px" }}
                    >
                      {directorsMap.directorName}
                    </Button>
                  ))}
                  {movie?.genres.map((genreMap) => (
                    <Button
                      key={genreMap.id}
                      size="sm"
                      color="neutral"
                      sx={{ mr: "8px" }}
                    >
                      {genreMap.genreName}
                    </Button>
                  ))}
                  <Button size="sm" color="neutral">
                    {movie?.duration} min
                  </Button>
                </Box>
              </Box>
            </Box>
          </Box>
        </Box>
      </Box>
      <Box display={"grid"} gridTemplateColumns={"2"} pb={2} px={"80px"}>
        <Box gridColumn={1} width={"50vw"}>
          <Typography pb={2} level="h1" textColor={"#C4C4C4"}>
            Ficha Tecnica
          </Typography>
          <hr style={{ width: "80%" }} />
          <Box>
            {/* <Typography>{movie?.id}</Typography>
            <Typography>{movie?.title}</Typography>
            <Typography>{movie?.releaseYear}</Typography>
            <Typography>{movie?.duration}</Typography>
            <Typography>{movie?.classification}</Typography> */}
            {/* <Typography>{movie?.producers}</Typography> */}
            {/* <Typography>{movie?.directors}</Typography>
            <Typography>{movie?.genres}</Typography>
            <Typography>{movie?.screenwriter}</Typography> */}
          </Box>
        </Box>
        <Box gridColumn={2} width={"50vw"}>
          <Typography pb={2} level="h1" textColor={"#C4C4C4"}>
            Trailer
          </Typography>
          <hr style={{ width: "80%" }} />
          <Box pt={2} ml={10}>
            <iframe
              width="560"
              height="315"
              src="https://www.youtube.com/embed/h2lVX71L_3A?si=qmaN81yV80Pfv-aj"
              title={(movie?.title, "video player")}
              allow="accelerometer; autoplay; clipboard-write; encrypted-media; gyroscope; picture-in-picture; web-share"
            ></iframe>
          </Box>
        </Box>
      </Box>
    </Box>
  );
};

export default MovieDetails;
