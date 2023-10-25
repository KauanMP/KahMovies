import { Box } from "@mui/joy";
import "./Navbar.css";
import { NavLink } from "react-router-dom";

const Navbar = () => {
  return (
    <Box
      component="nav"
      height={"70px"}
      display={"flex"}
      justifyContent={"space-between"}
      alignItems={"center"}
      sx={{ backgroundColor: "#2a3d52" }}
    >
      <Box textAlign={"center"}>
        <NavLink to="/" style={{ color: "white", textDecoration: "none", fontWeight: "700", fontSize: "1.4em" }}>
          KahMovies
        </NavLink>
      </Box>
      <Box
        component="button"
        mr={"50px"}
        sx={{
          backgroundColor: "#B79C09",
          color: "white",
          padding: "5px 7px",
          border: "none",
          borderRadius: "5px",
          textTransform: "uppercase",
          fontWeight: "700",
          cursor: "pointer",
        }}
      >
        Entrar
      </Box>
    </Box>
  );
};

export default Navbar;
