import "./Carousel.css";
import "slick-carousel/slick/slick.css";
import "slick-carousel/slick/slick-theme.css";

import { MdArrowForwardIos, MdArrowBackIos } from "react-icons/md";
import { Box } from "@mui/joy";
import { Typography } from "@mui/joy";

import React, { ReactNode, useState } from "react";
import Slider from "react-slick";

type Props = {
  children: ReactNode;
  gender: string;
}
const Carousel = ({ children, gender } : Props) => {
  const [activeArrowBack, setActiveArrowBack] = useState<boolean>(false);
  const [activeArrowForward, setActiveArrowForward] = useState<boolean>(true);

  const settings = {
    dots: false,
    centerMode: false,
    arrows: false,
    infinite: true,

    adaptiveHeight: true,
    variableWidth: true,
    slidesToShow: 7,
    slidesToScroll: 1,
    speed: 200,
  };

  const sliderRef = React.createRef<Slider>();

  const nextSlide = () => {
    if (sliderRef.current) {
      sliderRef.current.slickNext();
      setActiveArrowForward(true);
      setActiveArrowBack(false);
    }
  };

  const prevSlide = () => {
    if (sliderRef.current) {
      sliderRef.current.slickPrev();
      setActiveArrowBack(true);
      setActiveArrowForward(false);
    }
  };

  return (
    <Box margin={"0 auto"}>
      <Box
        display={"flex"}
        justifyContent={"space-between"}
        alignItems={"center"}
      >
        <Typography level="h1" textColor="common.white">
          {gender}
        </Typography>
        <Box>
          {activeArrowBack ? (
            <Box
              component="button"
              fontSize={"30px"}
              sx={{
                backgroundColor: "transparent",
                cursor: "pointer",
                border: "none",
                color: "#B79C09",
              }}
              onClick={prevSlide}
            >
              <MdArrowBackIos />
            </Box>
          ) : (
            <Box
              component="button"
              fontSize={"30px"}
              sx={{
                backgroundColor: "transparent",
                cursor: "pointer",
                border: "none",
                color: "#4e440a",
              }}
              onClick={prevSlide}
            >
              <MdArrowBackIos />
            </Box>
          )}
          {activeArrowForward ? (
            <Box
              component="button"
              fontSize={"30px"}
              sx={{
                backgroundColor: "transparent",
                cursor: "pointer",
                border: "none",
                color: "#B79C09",
              }}
              onClick={nextSlide}
            >
              <MdArrowForwardIos />
            </Box>
          ) : (
            <Box
              component="button"
              fontSize={"30px"}
              sx={{
                backgroundColor: "transparent",
                cursor: "pointer",
                border: "none",
                color: "#4e440a",
              }}
              onClick={nextSlide}
            >
              <MdArrowForwardIos />
            </Box>
          )}
        </Box>
      </Box>
      <Box>
        <Slider ref={sliderRef} {...settings}>
          {children}
        </Slider>
      </Box>
    </Box>
  );
};

export default Carousel;
