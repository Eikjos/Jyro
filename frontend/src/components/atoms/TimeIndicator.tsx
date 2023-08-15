import { Box, Text } from "@chakra-ui/react";

type TimeIndicatorProps = {
  number: number;
};

function TimeIndicator({ number }: TimeIndicatorProps) {
  return (
    <Box
      backgroundColor={"white"}
      width="20px"
      height="20px"
      borderRadius={"full"}
      display={"flex"}
      justifyContent={"center"}
      alignItems="center"
    >
      <Text variant={"xs"} textAlign={"center"} margin={0}>
        {number}
      </Text>
    </Box>
  );
}

export { TimeIndicator };
