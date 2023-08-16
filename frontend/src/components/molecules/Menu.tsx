import { Box, BoxProps, Flex } from "@chakra-ui/react";
import { Icon, MenuItem } from "..";

function Menu({ ...props }: BoxProps) {
  return (
    <Box
      display={"flex"}
      flexDirection={"column"}
      alignItems={"center"}
      {...props}
    >
      <Icon />
      <Flex
        direction={"column"}
        height={"60%"}
        justifyContent={"space-between"}
        width={"100%"}
        marginTop={70}
      >
        <Flex
          direction={"column"}
          height={"60%"}
          justifyContent={"space-between"}
          width={"100%"}
        >
          <MenuItem path="/" icon="board" title="Tableau de bord" isActif />
          <MenuItem path="/" icon="projects" title="Mes projets" />
          <MenuItem path="/" icon="talks" title="Mes discussions" />
          <MenuItem path="/" icon="stats" title="Mes statistiques" />
        </Flex>
        <MenuItem path="/" icon="settings" title="Mes paramètres" />
      </Flex>
    </Box>
  );
}

export { Menu };
