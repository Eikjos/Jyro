import { Box, Flex, Text } from "@chakra-ui/react";
import { Avatar, BoxTemplate, MenuTemplate, TimeIndicator } from "..";

function HomePage() {
  return (
    <MenuTemplate title="TH" name="Hamelin">
      <BoxTemplate title="Tâches en cours" width={"450px"} height={"95%"}>
        <Box
          backgroundColor="#EEEEEE"
          width={"100%"}
          padding={"10px"}
          borderRadius={"10px"}
        >
          <Text variant={"sm"}>Nom Projet</Text>
          <Text variant={"xs"} height={"40px"}>
            Nom de la tâches
          </Text>
          <Flex
            direction={"row"}
            alignItems={"center"}
            width={"100%"}
            justifyContent="space-between"
          >
            <Flex direction="row">
              <Flex direction={"row"} alignItems={"center"} marginRight={"8px"}>
                <Text variant={"xs"} color="gray" marginRight={"8px"}>
                  Consommé
                </Text>
                <TimeIndicator number={12} />
              </Flex>
              <Flex direction={"row"} alignItems={"center"} marginRight={"8px"}>
                <Text variant={"xs"} color="gray" marginRight={"8px"}>
                  Restant
                </Text>
                <TimeIndicator number={12} />
              </Flex>
              <Flex direction={"row"} alignItems={"center"}>
                <Text variant={"xs"} color="gray" marginRight={"8px"}>
                  Originel
                </Text>
                <TimeIndicator number={12} />
              </Flex>
            </Flex>
            <Flex direction={"row"} alignItems={"center"}>
              <Text variant={"xs"} color="red" marginRight={"5px"}>
                Haute
              </Text>
              <Avatar title="TH" variant="sm" width={"25px"} height={"25px"} />
            </Flex>
          </Flex>
        </Box>
      </BoxTemplate>
    </MenuTemplate>
  );
}

export { HomePage };
