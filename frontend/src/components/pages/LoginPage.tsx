import { Box, Heading, Flex, Text, Button } from "@chakra-ui/react";
import background from "../../assets/png/background-login.png";
import { Icon, TextInput } from "..";
import { Link } from "react-router-dom";

function LoginPage() {
  return (
    <Box
      backgroundImage={`url(${background})`}
      height="100vh"
      width="100%"
      backgroundSize="cover"
      backgroundRepeat="no-repeat"
    >
      <Box
        width="25%"
        height="100vh"
        backgroundColor="rgba(238, 238, 238, 0.93)"
        position="absolute"
        right={0}
        display={"flex"}
        flexDirection={"column"}
        alignItems={"center"}
      >
        <Icon />
        <Heading
          as="h2"
          textAlign={"center"}
          width={"100%"}
          color="#444444"
          marginTop={"5%"}
        >
          Connexion
        </Heading>
        <Flex direction={"column"} width="75%" height="200px" marginTop="25%">
          <TextInput type="email" placeholder="Email" marginBottom={10} />
          <TextInput type="password" placeholder="Mot de passe" />
          <Text as="span" textAlign={"center"} marginTop={5}>
            Pas encore de compte ?{" "}
            <Link to="/register" style={{ color: "#315A6B", fontWeight: 600 }}>
              Inscrivez-vous
            </Link>
          </Text>
          <Button
            backgroundColor={"#315A6B"}
            width={"50%"}
            _hover={{ backgroundColor: "#15ABB9" }}
            padding={"10px"}
            height={"50px"}
            marginTop={10}
            marginLeft={"auto"}
            marginRight={"auto"}
          >
            <Text as="span" fontSize={"22px"} color={"white"}>
              Se connecter
            </Text>
          </Button>
        </Flex>
      </Box>
    </Box>
  );
}

export { LoginPage };
