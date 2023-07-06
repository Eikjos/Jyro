import { Button, Input, InputGroup, InputRightElement } from "@chakra-ui/react";
import { useState } from "react";
import { TextInput } from "..";

function LoginPage() {
  const [email, setEmail] = useState("");
  const [password, setPassword] = useState("");
  const [showPassword, setShowPassword] = useState<boolean>(false);

  return (
    <div>
      <div className=""></div>
      <div className="">
        <h1>Connexion</h1>
        <form>
          <TextInput
            name="email"
            type="text"
            placeholder="Email"
            value={email}
            onChange={(evt) => setEmail(evt.currentTarget.value)}
          />
          <TextInput
            name="password"
            type="password"
            placeholder="Mot de passe"
            value={password}
            onChange={(evt) => setPassword(evt.currentTarget.value)}
          />
          <Button>Se connecter</Button>
        </form>
      </div>
    </div>
  );
}

export { LoginPage };
