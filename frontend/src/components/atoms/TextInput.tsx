import { Button, Input, InputGroup, InputRightElement } from "@chakra-ui/react";
import React, { useState } from "react";
import { ViewIcon, ViewOffIcon } from "@chakra-ui/icons";

type TextInputProps = React.AllHTMLAttributes<HTMLInputElement> & {};

function TextInput({ ...props }: TextInputProps) {
  const [showPassword, setShowPassword] = useState<boolean>(false);

  return (
    <InputGroup style={props.style}>
      <Input
        type={props.type}
        value={props.value}
        onChange={props.onChange}
        name={props.name}
        placeholder={props.placeholder}
      />
      {props.type === "password" && (
        <InputRightElement>
          <Button
            h="1.75rem"
            onClick={() => setShowPassword(!showPassword)}
            backgroundColor={"#09489f"}
          >
            {showPassword && <ViewOffIcon color="white" />}
            {!showPassword && <ViewIcon color="white" />}
          </Button>
        </InputRightElement>
      )}
    </InputGroup>
  );
}

export { TextInput };
