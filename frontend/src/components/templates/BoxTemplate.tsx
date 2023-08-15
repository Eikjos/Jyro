import { Box, Heading, Flex } from "@chakra-ui/react";
import { ReactNode } from "react";

type BoxTemplateProps = {
  title: string;
  height: number | string;
  width: number | string;
  children?: ReactNode;
};

function BoxTemplate({ title, height, width, children }: BoxTemplateProps) {
  return (
    <Box
      width={width}
      height={height}
      borderRadius={30}
      paddingTop="28px"
      paddingLeft="30px"
      paddingRight="30px"
      backgroundColor={"white"}
    >
      <Heading
        as="h2"
        variant={"lg"}
        color="#1C495C"
        textAlign={"center"}
        marginBottom={"35px"}
      >
        {title}
      </Heading>
      <Flex direction={"column"} alignItems={"center"}>
        {children}
      </Flex>
    </Box>
  );
}

export { BoxTemplate };
