import {
  Button,
  Input,
  InputGroup,
  InputRightElement,
  InputProps,
  Box,
} from "@chakra-ui/react";
import React, { useReducer, useState } from "react";
import { ViewIcon, ViewOffIcon } from "@chakra-ui/icons";

type TextInputProps = InputProps;

function TextInput({ ...props }: TextInputProps) {
  const [showPassword, setShowPassword] = useState<boolean>(false);

  return (
    <InputGroup style={props.style}>
      <Input
        type={!showPassword ? props.type : "text"}
        value={props.value}
        onChange={props.onChange}
        name={props.name}
        placeholder={props.placeholder}
        backgroundColor="white"
        borderRadius={5}
        padding={2}
        variant={"outline"}
        borderColor={"gray.300"}
        borderWidth={1}
        {...props}
      />
      {props.type === "password" && (
        <InputRightElement
          onClick={() => setShowPassword(!showPassword)}
          backgroundColor={"#315A6B"}
          borderTopRightRadius={5}
          _hover={{ backgroundColor: "#15ABB9" }}
          borderBottomRightRadius={5}
        >
          {showPassword && (
            <ViewOffIcon color="white" width={"24px"} height={"24px"} />
          )}
          {!showPassword && (
            <ViewIcon color="white" width={"24px"} height={"24px"} />
          )}
        </InputRightElement>
      )}
    </InputGroup>
  );
}

export { TextInput };
