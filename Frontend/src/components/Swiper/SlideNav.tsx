import { Box, Typography } from "@mui/joy";
import { MdArrowBackIos, MdArrowForwardIos } from "react-icons/md";

type Props = {
  genre: string;
};
const SlideNav = ({ genre }: Props) => {
  return (
    <Box className="swiper-header">
      <Box display="flex" justifyContent="space-between" alignItems="center">
        <Typography level="h1" pb={2} textColor="common.white">
          {genre}
        </Typography>
        <Box>
          <Box component={"button"} className="slidePrev slideButtonDisable">
            <MdArrowBackIos />
          </Box>
          <Box component={"button"} className="slideNext slideButtonDisable">
            <MdArrowForwardIos />
          </Box>
        </Box>
      </Box>
    </Box>
  );
};

export default SlideNav;
