import { Box, Flex, Icon, Heading, Text } from "@chakra-ui/react";
import { MdCircleNotifications } from "react-icons/md";

type NotificationItempProps = {
  name: string;
  content1: string;
  content2: string;
};

function NotificationItem({
  name,
  content1,
  content2,
}: NotificationItempProps) {
  return (
    <Box
      paddingY={"8px"}
      paddingX={"13px"}
      borderRadius={"10px"}
      backgroundColor={"#EEEEEE"}
      width={"100%"}
      height={"90px"}
    >
      <Flex
        direction="row"
        alignItems={"center"}
        justifyContent={"space-between"}
        height={"100%"}
      >
        <Flex
          direction="column"
          alignItems={"flex-start"}
          justifyContent={"space-between"}
          height={"100%"}
        >
          <Heading as="h6" variant="xs">
            {name}
          </Heading>
          <Text variant="xs">
            {content1}
            <Text>{content2}</Text>
          </Text>
        </Flex>
        <Icon as={MdCircleNotifications} color="#FB6A6A" boxSize={"30px"} />
      </Flex>
    </Box>
  );
}

export { NotificationItem };
