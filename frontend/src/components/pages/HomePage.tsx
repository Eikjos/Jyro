import { Flex } from "@chakra-ui/react";
import { BoxTemplate, MenuTemplate, TaskItem } from "..";

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
          </BoxTemplate>
          <BoxTemplate title="Actualités" width="100%" height="48%">
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
          </BoxTemplate>
        </Flex>
      </Flex>
    </MenuTemplate>
  );
}

export { HomePage };
