import { Box, BoxProps, Flex } from '@chakra-ui/react';
import { Icon, MenuItem } from '@components';

type MenuProps = {
  route: 'default' | 'projects' | 'stats' | 'talks' | 'settings';
} & BoxProps;

function Menu({ route, ...props }: MenuProps) {
  return (
    <Box display={'flex'} flexDirection={'column'} alignItems={'center'} {...props}>
      <Icon />
      <Flex direction={'column'} height={'60%'} justifyContent={'space-between'} width={'100%'} marginTop={70}>
        <Flex direction={'column'} height={'60%'} justifyContent={'space-between'} width={'100%'}>
          <MenuItem path="/" icon="board" title="Tableau de bord" isActif={route == 'default'} />
          <MenuItem path="/projects" icon="projects" title="Mes projets" isActif={route == 'projects'} />
          <MenuItem path="/" icon="talks" title="Mes discussions" isActif={route == 'talks'} />
          <MenuItem path="/" icon="stats" title="Mes statistiques" isActif={route == 'stats'} />
        </Flex>
        <MenuItem path="/" icon="settings" title="Mes paramètres" isActif={route == 'settings'} />
      </Flex>
    </Box>
  );
}

export { Menu };
