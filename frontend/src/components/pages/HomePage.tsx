import { Flex } from "@chakra-ui/react";
import {
  BoxTemplate,
  MenuTemplate,
  NewsItem,
  NotificationItem,
  TaskItem,
} from "~/components/index";

function HomePage() {
  return (
    <MenuTemplate title="TH" name="Hamelin">
      <Flex
        direction={"row"}
        width={"100%"}
        height="100%"
        padding={"35px"}
        alignItems={"center"}
        gap="35px"
      >
        <BoxTemplate title="Tâches en cours" width={"650px"} height={"95%"}>
          <TaskItem
            name="Nom de la tâche"
            projectName="Nom du projet"
            remaining={12}
            original={12}
            consumed={12}
            priority="hight"
            user={{ id: "", firstname: "Thomas", lastname: "Hamelin" }}
          />
          <TaskItem
            name="Nom de la tâche"
            projectName="Nom du projet"
            remaining={12}
            original={12}
            consumed={12}
            priority="hight"
            user={{ id: "", firstname: "Thomas", lastname: "Hamelin" }}
          />
          <TaskItem
            name="Nom de la tâche"
            projectName="Nom du projet"
            remaining={12}
            original={12}
            consumed={12}
            priority="medium"
            user={{ id: "", firstname: "Thomas", lastname: "Hamelin" }}
          />
          <TaskItem
            name="Nom de la tâche"
            projectName="Nom du projet"
            remaining={12}
            original={12}
            consumed={12}
            priority="low"
            user={{ id: "", firstname: "Thomas", lastname: "Hamelin" }}
          />
          <TaskItem
            name="Nom de la tâche"
            projectName="Nom du projet"
            remaining={12}
            original={12}
            consumed={12}
            priority="medium"
            user={{ id: "", firstname: "Thomas", lastname: "Hamelin" }}
          />
          <TaskItem
            name="Nom de la tâche"
            projectName="Nom du projet"
            remaining={12}
            original={12}
            consumed={12}
            priority="low"
            user={{ id: "", firstname: "Thomas", lastname: "Hamelin" }}
          />
        </BoxTemplate>
        <Flex direction="column" gap="4%" width="100%" height="95%">
          <BoxTemplate title="Notifications" width="100%" height="48%">
            <NotificationItem
              name="Nom Projet"
              content1="Vous avez rejoint le projet NOM DU PROJET."
              content2="Bonne réussite dans ce projet !"
            />
            <NotificationItem
              name="Nom Projet"
              content1="Le sprint se termine dans 2 jours."
              content2="Regarde les tâches qui te reste à faire."
            />
            <NotificationItem
              name="Succès"
              content1="Un nouveau succès a été atteint. Vous avez terminé 10 tâches."
              content2="Prochain objectif : 15 tâches."
            />
          </BoxTemplate>
          <BoxTemplate title="Actualités" width="100%" height="48%">
            <NewsItem
              title="Nouveau projet"
              content="Le projet NOM DU PROJET viens d'êtres créer, pour le client NOM DU CLIENT. Pris en charge par NOM DU CDP."
            />
            <NewsItem
              title="Nom projet"
              content="Le projet est achevé. Bravo à toute l'équipe de développement pour ce travail."
            />
          </BoxTemplate>
        </Flex>
      </Flex>
    </MenuTemplate>
  );
}

export { HomePage };
