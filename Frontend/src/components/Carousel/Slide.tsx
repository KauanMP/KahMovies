import { Box, Typography } from "@mui/joy";
import { ReactNode } from "react";

// Swiper
import Swiper from "swiper/bundle";

// CSS
import "swiper/css/bundle";

type Props = {
  children: ReactNode;
  genre: string;
};

const Slide = ({ children, genre }: Props) => {
  new Swiper(".mySwiper", {
    slidesPerView: 5,
    spaceBetween: 30,
    loop: false,
    cssMode: true,
    navigation: {
      prevEl: ".slidePrev",
      nextEl: ".slideNext",
    },
  });

  return (
    <Box component={"section"} margin={"0 auto"}>
      <Box className="swiper mySwiper">
        <Box className="swiper-header">
          <Box
            display={"flex"}
            justifyContent={"space-between"}
            alignItems={"center"}
          >
            <Typography level="h1" pb={2} textColor="common.white">
              {genre}
            </Typography>
            <Box>
              <button className="slidePrev">Prev</button>
              <button className="slideNext">Next</button>
            </Box>
          </Box>
        </Box>
        <div className="swiper-wrapper">{children}</div>
      </Box>
    </Box>
  );
};

export default Slide;
