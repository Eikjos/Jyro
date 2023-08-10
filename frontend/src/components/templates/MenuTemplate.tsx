import { Box } from "@chakra-ui/react";
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
      <Menu
        zIndex={5}
        width={"15%"}
        height={"100%"}
        backgroundColor={"white"}
        marginTop={"-75px"}
      />
      {children}
    </Box>
  );
}

export { MenuTemplate };
