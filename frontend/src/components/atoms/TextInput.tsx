import { ViewIcon, ViewOffIcon } from '@chakra-ui/icons';
import { Input, InputGroup, InputProps, InputRightElement } from '@chakra-ui/react';
import { useState } from 'react';
import React from 'react';

const TextInput = React.forwardRef<HTMLInputElement, InputProps>(function TextInputComponent({ type, ...props }, ref) {
  const [showPassword, setShowPassword] = useState<boolean>(false);

  return (
    <InputGroup style={props.style}>
      <Input
        backgroundColor="white"
        borderRadius={5}
        padding={2}
        variant={'outline'}
        borderColor={'gray.300'}
        borderWidth={1}
        ref={ref}
        type={showPassword ? 'text' : type}
        {...props}
      />
      {type === 'password' && (
        <InputRightElement
          onClick={() => setShowPassword(!showPassword)}
          backgroundColor={'#315A6B'}
          borderTopRightRadius={5}
          _hover={{ backgroundColor: '#15ABB9' }}
          borderBottomRightRadius={5}
        >
          {showPassword && <ViewOffIcon color="white" width={'24px'} height={'24px'} />}
          {!showPassword && <ViewIcon color="white" width={'24px'} height={'24px'} />}
        </InputRightElement>
      )}
    </InputGroup>
  );
});

export { TextInput };
