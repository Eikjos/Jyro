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
import { RegisterRequestType } from "../../types/User";
import { useMutation } from "react-query";
import { register as registerReq } from "../../api/user";

function RegisterPage() {
  const navigation = useNavigate();

  const schema = z
    .object({
      firstname: z.string(),
      lastname: z.string(),
      email: z.string().email(),
      password: z
        .string()
        .regex(/.*[A-Z].*/, "Le mot de passe doit contenir une majuscule.")
        .regex(/.*[a-z].*/, "Le mot de passe doit contenir une minuscule.")
        .regex(/.*\d.*/, "Le mot de passe doit contenir un nombre.")
        .regex(
          /.*[`~<>?,./!@#$%^&*()\-_+="'|{}[\];:].*/,
          "Le mot de passe doit un caractère spécial."
        )
        .min(8, "Le mot de passe doit contenir au moins 8 caractères."),
      confirmPassword: z.string(),
    })
    .refine((data) => data.password === data.confirmPassword, {
      message: "Les mots de passse doivent être identiques.",
      path: ["confirmPassword"],
    });

  const {
    handleSubmit,
    register,
    formState: { errors },
  } = useForm<RegisterRequestType & { confirmPassword: string }>({
    resolver: zodResolver(schema),
  });

  const registerRequest = useMutation({
    mutationFn: registerReq,
  });

  const onSubmit = (values: RegisterRequestType) => {
    registerRequest.mutate(
      {
        firstname: values.firstname,
        lastname: values.lastname,
        password: values.password,
        email: values.email,
      },
      {
        onSuccess: () => navigation("/login"),
      }
    );
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
          Inscription
        </Heading>
        <form onSubmit={handleSubmit(onSubmit)} style={{ width: "75%" }}>
          <Flex direction={"column"} width="100%" marginTop="25%">
            <Flex marginBottom={5}>
              <FormControl
                isInvalid={errors.firstname !== undefined}
                width={"100%"}
              >
                <FormLabel htmlFor="firstname">Prénom</FormLabel>
                <TextInput
                  id="firstname"
                  type="text"
                  placeholder="Prénom"
                  {...register("firstname")}
                />
                <FormErrorMessage>
                  {errors.firstname && errors.firstname.message}
                </FormErrorMessage>
              </FormControl>
              <FormControl
                isInvalid={errors.lastname !== undefined}
                width={"100%"}
                marginLeft={5}
              >
                <FormLabel htmlFor="lastname">Nom</FormLabel>
                <TextInput
                  id="lastname"
                  type="text"
                  placeholder="Nom"
                  {...register("lastname")}
                />
                <FormErrorMessage>
                  {errors.lastname && errors.lastname.message}
                </FormErrorMessage>
              </FormControl>
            </Flex>
            <FormControl
              isInvalid={errors.email !== undefined}
              width={"100%"}
              marginBottom={5}
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
              marginBottom={5}
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
            <FormControl
              isInvalid={errors.confirmPassword !== undefined}
              width={"100%"}
              marginBottom={5}
            >
              <FormLabel htmlFor="confirmPassword">
                Confirmation mot de passe
              </FormLabel>
              <TextInput
                id="confirmPassword"
                type="password"
                placeholder="Confirmation mot de passe"
                {...register("confirmPassword")}
              />
              <FormErrorMessage>
                {errors.confirmPassword && errors.confirmPassword.message}
              </FormErrorMessage>
            </FormControl>
            <Text as="span" textAlign={"center"} marginTop={5}>
              Vous avez déjà un compte ?{" "}
              <Link
                to="/register"
                style={{ color: "#315A6B", fontWeight: 600 }}
              >
                Connectez-vous
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
                S'enregistrer
              </Text>
            </Button>
          </Flex>
        </form>
      </Box>
    </Box>
  );
}

export { RegisterPage };
