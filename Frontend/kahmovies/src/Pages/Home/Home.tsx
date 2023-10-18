import Search from "../../components/Search/Search";
import { Box, Button, Grid, Typography } from "@mui/joy";
// import { MdArrowForwardIos, MdArrowBackIos } from "react-icons/md";

const Home = () => {
  return (
    <div>
      <Box>
        <Typography level="h2">
          home
        </Typography>
      </Box>
      <Search />
      <Box
        display={"flex"}
        justifyContent={"center"}
        alignItems={"center"}
        margin={"0 auto"}
        width={"500px"}
        flexWrap={"wrap"}
        py={3}
        gap={2}
      >
        <Button sx={{ backgroundColor: "#2A3D52" }}>Terror</Button>
        <Button sx={{ backgroundColor: "#2A3D52" }}>Terror</Button>
        <Button sx={{ backgroundColor: "#2A3D52" }}>Terror</Button>
        <Button sx={{ backgroundColor: "#2A3D52" }}>Terror</Button>
        <Button sx={{ backgroundColor: "#2A3D52" }}>Terror</Button>
        <Button sx={{ backgroundColor: "#2A3D52" }}>Terror</Button>
        <Button sx={{ backgroundColor: "#2A3D52" }}>Terror</Button>
        <Button sx={{ backgroundColor: "#2A3D52" }}>Terror</Button>
        <Button sx={{ backgroundColor: "#2A3D52" }}>Terror</Button>
      </Box>
      <Grid
        container
        spacing={2}
        pb={5}
        justifyContent={"start"}
        pl={17.9}
        pr={17.9}
      >
        <Grid xs={12}>
          <Typography color="success" level="h3">
            Terror
          </Typography>
        </Grid>
        <Grid width={"180px"} height={"250px"}>
          <img
            style={{ width: "100%", height: "100%", borderRadius: "10px" }}
            src="https://media.filmelier.com/tit/pij3wm/poster/jogos-mortais-x_2at19uA.jpeg"
            alt=""
          />
        </Grid>
        <Grid width={"180px"} height={"250px"}>
          <img
            style={{ width: "100%", height: "100%", borderRadius: "10px" }}
            src="https://media.filmelier.com/tit/pij3wm/poster/jogos-mortais-x_2at19uA.jpeg"
            alt=""
          />
        </Grid>
      </Grid>
    </div>
  );
};

export default Home;
