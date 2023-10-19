import "./Carousel.css";
import { MdArrowForwardIos, MdArrowBackIos } from "react-icons/md";
import { Box } from "@mui/joy";
import { Typography } from "@mui/joy";

const Carousel = () => {
  return (
    <Box>
      <Box
        display={"flex"}
        justifyContent={"space-between"}
        alignItems={"center"}
      >
        <Typography level="h1">Terror</Typography>
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
      <Box display={"flex"} overflow={"auto"} gap={2}>
        <Box width={"200px"} height={"320px"} flex={"none"}>
          <Box>
            <Box
              component="img"
              borderRadius={10}
              sx={{ width: "100%", height: "100%", objectFit: "cover" }}
              src="https://media.filmelier.com/tit/reYscQ/poster/fale-comigo_NOki3T8.jpeg"
              alt="#"
            />
          </Box>
        </Box>
        <Box width={"200px"} height={"320px"} flex={"none"}>
          <Box>
            <Box
              component="img"
              borderRadius={10}
              sx={{ width: "100%", height: "100%", objectFit: "cover" }}
              src="https://media.filmelier.com/tit/reYscQ/poster/fale-comigo_NOki3T8.jpeg"
              alt="#"
            />
          </Box>
        </Box>
        <Box width={"200px"} height={"320px"} flex={"none"}>
          <Box>
            <Box
              component="img"
              borderRadius={10}
              sx={{ width: "100%", height: "100%", objectFit: "cover" }}
              src="https://media.filmelier.com/tit/reYscQ/poster/fale-comigo_NOki3T8.jpeg"
              alt="#"
            />
          </Box>
        </Box>
        <Box width={"200px"} height={"320px"} flex={"none"}>
          <Box>
            <Box
              component="img"
              borderRadius={10}
              sx={{ width: "100%", height: "100%", objectFit: "cover" }}
              src="https://media.filmelier.com/tit/reYscQ/poster/fale-comigo_NOki3T8.jpeg"
              alt="#"
            />
          </Box>
        </Box>
        <Box width={"200px"} height={"320px"} flex={"none"}>
          <Box>
            <Box
              component="img"
              borderRadius={10}
              sx={{ width: "100%", height: "100%", objectFit: "cover" }}
              src="https://media.filmelier.com/tit/reYscQ/poster/fale-comigo_NOki3T8.jpeg"
              alt="#"
            />
          </Box>
        </Box>
        <Box width={"200px"} height={"320px"} flex={"none"}>
          <Box>
            <Box
              component="img"
              borderRadius={10}
              sx={{ width: "100%", height: "100%", objectFit: "cover" }}
              src="https://media.filmelier.com/tit/reYscQ/poster/fale-comigo_NOki3T8.jpeg"
              alt="#"
            />
          </Box>
        </Box>
        <Box width={"200px"} height={"320px"} flex={"none"}>
          <Box>
            <Box
              component="img"
              borderRadius={10}
              sx={{ width: "100%", height: "100%", objectFit: "cover" }}
              src="https://media.filmelier.com/tit/reYscQ/poster/fale-comigo_NOki3T8.jpeg"
              alt="#"
            />
          </Box>
        </Box>
        <Box width={"200px"} height={"320px"} flex={"none"}>
          <Box>
            <Box
              component="img"
              borderRadius={10}
              sx={{ width: "100%", height: "100%", objectFit: "cover" }}
              src="https://media.filmelier.com/tit/reYscQ/poster/fale-comigo_NOki3T8.jpeg"
              alt="#"
            />
          </Box>
        </Box>
      </Box>
    </Box>
  );
};

export default Carousel;
