import { extendTheme, defineStyleConfig } from "@chakra-ui/react";

const theme = extendTheme({
  fonts: {
    body: `'Roboto'`,
    mono: `'Roboto'`,
    heading: `'Roboto'`,
  },
  size: {
    sizes: {},
  },
  components: {
    Text: defineStyleConfig({
      variants: {
        "4xl": {
          fontSize: "36px",
        },
        "3xl": {
          fontSize: "30px",
        },
        "2xl": {
          fontSize: "24px",
        },
        xl: {
          fontSize: "20px",
        },
        lg: {
          fontSize: "18px",
        },
        md: {
          fontSize: "16px",
        },
        sm: {
          fontSize: "14px",
        },
        xs: {
          fontSize: "12px",
        },
      },
    }),
    Heading: defineStyleConfig({
      variants: {
        "4xl": {
          fontSize: "60px",
        },
        "3xl": {
          fontSize: "48px",
        },
        "2xl": {
          fontSize: "36px",
        },
        xl: {
          fontSize: "30px",
        },
        lg: {
          fontSize: "24px",
        },
        md: {
          fontSize: "20px",
        },
        sm: {
          fontSize: "16px",
        },
        xs: {
          fontSize: "14px",
        },
      },
    }),
  },
});

export default theme;
