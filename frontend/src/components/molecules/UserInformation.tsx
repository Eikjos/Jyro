import { Box, BoxProps, Flex, Icon, Text } from '@chakra-ui/react';
import { Avatar } from '@components';
import { MdOutlineArrowDropDown } from 'react-icons/md';

type UserInformationProps = {
  title: string;
  name: string;
} & BoxProps;

function UserInformation({ title, name, ...props }: UserInformationProps) {
  return (
    <Box {...props}>
      <Flex flexDirection={'row'} alignItems={'center'} width="150px">
        <Text variant="lg" color={'white'}>
          {name}
        </Text>
        <Avatar variant="xl" title={title} marginLeft={'11px'} />
        <Icon as={MdOutlineArrowDropDown} boxSize={'24px'} color={'white'} />
      </Flex>
    </Box>
  );
}

export { UserInformation };
