import { Box, BoxProps, Text } from "@chakra-ui/react";

type AvatarProps = {
  title: string;
} & BoxProps;

function Avatar({ title, ...props }: AvatarProps) {
  return (
    <Box
      {...props}
      borderRadius={"full"}
      width={9}
      height={9}
      backgroundColor={"#D9D9D9"}
      display={"flex"}
      justifyContent={"center"}
      alignItems={"center"}
    >
      <Text variant={"2xl"} color="black" fontWeight={700}>
        {title}
      </Text>
    </Box>
  );
}

export { Avatar };
