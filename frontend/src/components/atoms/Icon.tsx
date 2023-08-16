import icon from '@assets/png/icon.png';
import { Box, Heading, Image } from '@chakra-ui/react';

function Icon() {
  return (
    <Box display="flex" alignItems="center">
      <Image src={icon} height="8.1875rem" width="10.08931rem" />
      <Heading as={'h1'} marginLeft={-30} marginBottom={5} color="#444444">
        Jyro
      </Heading>
    </Box>
  );
}

export { Icon };
