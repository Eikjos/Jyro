import { Link as ReactRouterLink } from "react-router-dom";
import { Icon, Link, Text, textDecoration } from "@chakra-ui/react";
import { match } from "ts-pattern";
import { MdDashboard } from "react-icons/md";
import {
  AiFillBulb,
  AiFillWechat,
  AiOutlineRise,
  AiTwotoneSetting,
} from "react-icons/ai";

interface MenuItemProps {
  title: string;
  path: string;
  icon: "board" | "projects" | "talks" | "stats" | "settings";
  isActif?: boolean;
}

function MenuItem({ title, path, icon, isActif }: MenuItemProps) {
  return (
    <Link
      display={"flex"}
      paddingTop={"13px"}
      paddingBottom={"13px"}
      alignItems={"center"}
      backgroundColor={isActif ? "#EEEEEE" : "#FFFFFF"}
      borderColor={isActif ? "#315A6B" : "#EEEEEE"}
      borderWidth={1}
      _hover={{ textDecoration: "none" }}
      as={ReactRouterLink}
      to={path}
    >
      {match(icon)
        .with("board", () => (
          <Icon
            as={MdDashboard}
            color={"#1C495C"}
            boxSize={"30px"}
            marginRight="30px"
            marginLeft="50px"
          />
        ))
        .with("projects", () => (
          <Icon
            as={AiFillBulb}
            color={"#1C495C"}
            boxSize={"30px"}
            marginRight="30px"
            marginLeft="50px"
          />
        ))
        .with("talks", () => (
          <Icon
            as={AiFillWechat}
            color={"#1C495C"}
            boxSize={"30px"}
            marginRight="30px"
            marginLeft="50px"
          />
        ))
        .with("stats", () => (
          <Icon
            as={AiOutlineRise}
            color={"#1C495C"}
            boxSize={"30px"}
            marginRight="30px"
            marginLeft="50px"
          />
        ))
        .with("settings", () => (
          <Icon
            as={AiTwotoneSetting}
            color={"#1C495C"}
            boxSize={"30px"}
            marginRight="30px"
            marginLeft="50px"
          />
        ))
        .otherwise(() => null)}
      <Text fontSize={"md"}>{title}</Text>
    </Link>
  );
}

export { MenuItem };
