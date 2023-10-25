import { Box, Button } from "@mui/joy";
import { useFetch } from "../../Helpers/config";
import { ICategory } from "../../Models/ICategory";

const Categories = () => {
  const { data: categories, isLoading } = useFetch<ICategory[]>(
    "Categories",
    "/Category"
  );

  if (isLoading) {
    return <p>Carregando...</p>;
  }

  return (
    <Box
      display={"flex"}
      justifyContent={"center"}
      margin={"0 auto"}
      width={"500px"}
      flexWrap={"wrap"}
      py={1}
      gap={2}
    >
      {categories?.map((gender) => (
        <Button sx={{ backgroundColor: "#2A3D52" }} key={gender.id}>
          {gender.categoryName}
        </Button>
      ))}
    </Box>
  );
};

export default Categories;
