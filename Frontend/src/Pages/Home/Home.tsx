import { Box, Button, Typography } from "@mui/joy";
import Search from "../../components/Search/Search";
import Carousel from "../../components/Carousel/Carousel";


const Home = () => {
  return (
    <div style={{ paddingBottom: "2rem" }}>
      <Box>
        <Typography level="h2" textColor="common.white">home</Typography>
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
      <Carousel />
    </div>
  );
};

export default Home;
