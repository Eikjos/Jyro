import {
  Box,
  Heading,
  Flex,
  Text,
  Button,
  FormControl,
  FormLabel,
  FormErrorMessage,
} from "@chakra-ui/react";
import background from "../../assets/png/background-login.png";
import { Icon, TextInput } from "..";
import { Link, useNavigate } from "react-router-dom";
import { z } from "zod";
import { useForm } from "react-hook-form";
import { zodResolver } from "@hookform/resolvers/zod";
import { LoginRequestType } from "../../types/Auth";
import { useUserContext } from "../../context/UserContext";

function LoginPage() {
  const { login } = useUserContext();
  const navigation = useNavigate();

  const schema = z.object({
    email: z.string().email(),
    password: z.string(),
  });

  const {
    handleSubmit,
    register,
    formState: { errors },
  } = useForm<LoginRequestType>({
    resolver: zodResolver(schema),
  });

  const onSubmit = (values: LoginRequestType) => {
    login(values.email, values.password, () => {
      navigation("/");
    });
  };

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
        <form onSubmit={handleSubmit(onSubmit)} style={{ width: "75%" }}>
          <Flex
            direction={"column"}
            width="100%"
            height="200px"
            marginTop="25%"
          >
            <FormControl
              isInvalid={errors.email !== undefined}
              width={"100%"}
              marginBottom={10}
            >
              <FormLabel htmlFor="email">Email</FormLabel>
              <TextInput
                id="email"
                type="email"
                placeholder="Email"
                {...register("email")}
              />
              <FormErrorMessage>
                {errors.email && errors.email.message}
              </FormErrorMessage>
            </FormControl>
            <FormControl
              isInvalid={errors.password !== undefined}
              width={"100%"}
            >
              <FormLabel htmlFor="password">Mot de passe</FormLabel>
              <TextInput
                id="password"
                type="password"
                placeholder="Mot de passe"
                {...register("password")}
              />
              <FormErrorMessage>
                {errors.password && errors.password.message}
              </FormErrorMessage>
            </FormControl>
            <Text as="span" textAlign={"center"} marginTop={5}>
              Pas encore de compte ?{" "}
              <Link
                to="/register"
                style={{ color: "#315A6B", fontWeight: 600 }}
              >
                Inscrivez-vous
              </Link>
            </Text>
            <Button
              type="submit"
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
        </form>
      </Box>
    </Box>
  );
}

export { LoginPage };
