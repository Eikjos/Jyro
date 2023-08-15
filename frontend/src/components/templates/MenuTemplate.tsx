import { Box, Flex } from "@chakra-ui/react";
import { ReactNode } from "react";
import { Menu } from "..";
import { UserInformation } from "../molecules/UserInformation";

type MenuTemplateProps = {
  title: string;
  name: string;
  children?: ReactNode;
};

function MenuTemplate({ title, name, children }: MenuTemplateProps) {
  return (
    <Box backgroundColor={"#EEEEEE"} height="100vh" width="100%">
      <Box
        backgroundColor={"#1C495CE5"}
        width={"100%"}
        display={"flex"}
        flexDirection={"row"}
        alignItems={"center"}
        justifyContent={"flex-end"}
        height={"75px"}
      >
        <UserInformation title={title} name={name} />
      </Box>
      <Flex direction={"row"} height={"calc(100vh - 75px)"}>
        <Menu
          zIndex={5}
          width={"15%"}
          backgroundColor={"white"}
          marginTop={"-75px"}
        />
        <Box>{children}</Box>
      </Flex>
    </Box>
  );
}

export { MenuTemplate };
