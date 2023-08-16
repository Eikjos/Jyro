import { Box, Flex, Heading, Text } from '@chakra-ui/react';

type NewsItemProps = {
  title: string;
  content: string;
};

function NewsItem({ title, content }: NewsItemProps) {
  return (
    <Box
      paddingY={'8px'}
      paddingX={'13px'}
      borderRadius={'10px'}
      backgroundColor={'#EEEEEE'}
      width={'100%'}
      height={'90px'}
    >
      <Flex direction={'column'} alignItems={'flex-start'}>
        <Heading as="h6" variant={'xs'} marginBottom={'15px'}>
          {title}
        </Heading>
        <Text variant="xs">{content}</Text>
      </Flex>
    </Box>
  );
}

export { NewsItem };
