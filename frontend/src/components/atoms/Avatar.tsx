import { Box, BoxProps, Text } from "@chakra-ui/react";

type AvatarProps = {
  title: string;
  variant: "xl" | "sm";
} & BoxProps;

function Avatar({ title, variant, ...props }: AvatarProps) {
  return (
    <Box
      borderRadius={"full"}
      width={9}
      height={9}
      backgroundColor={"#D9D9D9"}
      display={"flex"}
      justifyContent={"center"}
      alignItems={"center"}
      {...props}
    >
      <Text variant={variant} color="black" fontWeight={700}>
        {title}
      </Text>
    </Box>
  );
}

export { Avatar };
