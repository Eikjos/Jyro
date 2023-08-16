import { Box, Flex, Heading, Text } from '@chakra-ui/react';
import { Avatar, TimeIndicator } from '@components';
import { User } from '@type/User';
import { match } from 'ts-pattern';

type TaskItemProps = {
  name: string;
  projectName: string;
  consumed: number;
  remaining: number;
  original: number;
  priority: 'hight' | 'medium' | 'low';
  user: User;
};

function TaskItem({ name, projectName, consumed, remaining, original, priority, user }: TaskItemProps) {
  return (
    <Box backgroundColor="#EEEEEE" width={'100%'} padding={'10px'} borderRadius={'10px'}>
      <Heading as="h6" variant="xs">
        {projectName}
      </Heading>
      <Text variant={'xs'} height={'40px'}>
        {name}
      </Text>
      <Flex direction={'row'} alignItems={'center'} width={'100%'} justifyContent="space-between">
        <Flex direction="row">
          <Flex direction={'row'} alignItems={'center'} marginRight={'8px'}>
            <Text variant={'xs'} color="gray" marginRight={'8px'}>
              Consommé
            </Text>
            <TimeIndicator number={consumed} />
          </Flex>
          <Flex direction={'row'} alignItems={'center'} marginRight={'8px'}>
            <Text variant={'xs'} color="gray" marginRight={'8px'}>
              Restant
            </Text>
            <TimeIndicator number={remaining} />
          </Flex>
          <Flex direction={'row'} alignItems={'center'}>
            <Text variant={'xs'} color="gray" marginRight={'8px'}>
              Originel
            </Text>
            <TimeIndicator number={original} />
          </Flex>
        </Flex>
        <Flex direction={'row'} alignItems={'center'}>
          <Text variant={'xs'} color="red" marginRight={'5px'}>
            {match(priority)
              .with('hight', () => (
                <Text variant={'xs'} color="red" marginRight={'5px'}>
                  Haute
                </Text>
              ))
              .with('medium', () => (
                <Text variant={'xs'} color="#FFB648" marginRight={'5px'}>
                  Moyenne
                </Text>
              ))
              .otherwise(() => (
                <Text variant={'xs'} color="#1C495C" marginRight={'5px'}>
                  Faible
                </Text>
              ))}
          </Text>
          <Text variant={'xs'} color="red" marginRight={'5px'}></Text>
          <Avatar
            title={(user.firstname[0] + user.lastname[0]).toUpperCase()}
            variant="sm"
            width={'25px'}
            height={'25px'}
          />
        </Flex>
      </Flex>
    </Box>
  );
}

export { TaskItem };
